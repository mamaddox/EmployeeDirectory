using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace EmployeeDirectory.Entities
{
    public class AttributeGetter<TEntity>
        where TEntity : IEntity
    {
        public string[] Fields { get; private set; }

        public AttributeGetter()
        {
            var properties = typeof(TEntity).GetProperties();
            Fields = properties
                .Select(prop => prop.GetCustomAttribute<JsonPropertyAttribute>())
                .Select(jsonProp => jsonProp.PropertyName)
                .ToArray();
        }
    }
}