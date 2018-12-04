using Newtonsoft.Json;

namespace webapi.Model
{
    public class Person
    {
        [JsonProperty(PropertyName = "PersonID")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "Firstname")]
        public string Firstname { get; set; }
        [JsonProperty(PropertyName = "Lastname")]
        public string LastName { get; set; }
    }
}