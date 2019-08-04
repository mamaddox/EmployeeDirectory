using Newtonsoft.Json;

namespace EmployeeDirectory.Entities
{
    public class SearchParameterEntity : ISearchParameterEntity
    {
        public SearchParameterEntity(string field, string value)
        {
            Field = field;
            Value = value;
        }

        [JsonProperty("Field")]
        public string Field { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }
    }
}