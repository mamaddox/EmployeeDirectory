using Newtonsoft.Json;

namespace EmployeeDirectory.Entities
{
    public class EmployeeEntity : IEmployeeEntity
    {
        [JsonProperty("Id")]
        public int Id { get; set; }

        [JsonProperty("First Name")]
        public string FirstName { get; set; }

        [JsonProperty("Last Name")]
        public string LastName { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("Department")]
        public string Department { get; set; }

        [JsonProperty("Location")]
        public string Location { get; set; }

        [JsonProperty("Picture")]
        public string Picture { get; set; }
    }
}