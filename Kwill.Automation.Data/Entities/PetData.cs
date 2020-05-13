using Newtonsoft.Json;

namespace Kwill.Automation.Data.Entities
{
    public class PetData
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }
    }
}
