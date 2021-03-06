﻿using Newtonsoft.Json;

namespace Kwill.Automation.Data.Entities
{
    public class CustomerData
    {
        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        [JsonProperty("MiddleName")]
        public string MiddleName { get; set; }

        [JsonProperty("LastName")]
        public string LastName { get; set; }

        [JsonProperty("Day")]
        public string Day { get; set; }

        [JsonProperty("Month")]
        public string Month { get; set; }

        [JsonProperty("Year")]
        public string Year { get; set; }

        [JsonProperty("MaritalStatus")]
        public string MaritalStatus { get; set; }

        [JsonProperty("PostCode")]
        public string PostCode { get; set; }

        [JsonProperty("Address1")]
        public string Address1 { get; set; }

        [JsonProperty("Address2")]
        public string Address2 { get; set; }

        [JsonProperty("Town")]
        public string Town { get; set; }

        [JsonProperty("City")]
        public string City { get; set; }

        [JsonProperty("Telephone")]
        public string Telephone { get; set; }


    }
}
