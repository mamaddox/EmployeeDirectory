using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace EmployeeDirectory.Entities.Attributes
{
    public class AttributeGetter<TEntity>
        where TEntity : IEntity
    {
        public string[] Fields { get; private set; }
        public string[] HiddenFields { get; private set; }
        public string[] PictureFields { get; set; }

        public AttributeGetter()
        {
            var properties = typeof(TEntity).GetProperties();

            Fields = properties
                .Select(prop => prop.GetCustomAttribute<JsonPropertyAttribute>())
                .Select(jsonProp => jsonProp.PropertyName)
                .ToArray();

            HiddenFields = (from prop in properties
                            let jsonProp = prop.GetCustomAttribute<JsonPropertyAttribute>()
                            let fieldType = prop.GetCustomAttribute<FieldTypeAttribute>()
                            where fieldType != null && fieldType.IsHidden
                            select jsonProp.PropertyName)
                            .ToArray();

            PictureFields = (from prop in properties
                            let jsonProp = prop.GetCustomAttribute<JsonPropertyAttribute>()
                            let fieldType = prop.GetCustomAttribute<FieldTypeAttribute>()
                            where fieldType != null && fieldType.IsPicture
                            select jsonProp.PropertyName)
                            .ToArray();
        }
    }
}