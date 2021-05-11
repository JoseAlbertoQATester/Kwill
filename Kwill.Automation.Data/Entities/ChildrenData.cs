using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kwill.Automation.Data.Entities
{
    public class ChildrenData
    {

        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        [JsonProperty("LastName")]
        public string LastName { get; set; }

        [JsonProperty("Relation")]
        public string Relation { get; set; }

        [JsonProperty("Day")]
        public string Day { get; set; }

        [JsonProperty("Month")]
        public string Month { get; set; }

        [JsonProperty("Year")]
        public string Year { get; set; }

        [JsonProperty("Number")]
        public string Number { get; set; }

        [JsonProperty("PostCode")]
        public string PostCode { get; set; }

        [JsonProperty("Street")]
        public string Street { get; set; }

        [JsonProperty("Town")]
        public string Town { get; set; }

        [JsonProperty("City")]
        public string City { get; set; }
    }
}
