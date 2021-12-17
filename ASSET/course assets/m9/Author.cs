﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m9_01_json_schema_demo
{
    public class Author
    {
        [JsonProperty("name", Required = Required.Always)]
        public string name { get; set; }

        [JsonProperty("courses", Required = Required.Default)]
        public string[] courses { get; set; }

        public DateTime since { get; set; }

        [JsonProperty("happy", Required = Required.Always)]
        public bool happy { get; set; }

        [JsonProperty("issues", Required = Required.AllowNull)]
        public object issues { get; set; }

        public Car car { get; set; }
        public int authorRelationship { get; set; }
    }
}
