﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kwill.Automation.Data.Entities
{
    public class PersonData
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

        [JsonProperty("Address1")]
        public string Address1 { get; set; }

        [JsonProperty("Address2")]
        public string Address2 { get; set; }

        [JsonProperty("PostCode")]
        public string PostCode { get; set; }

        [JsonProperty("Town")]
        public string Town { get; set; }

        [JsonProperty("City")]
        public string City { get; set; }
    }
}
