// JSON C# Class Generator
// http://at-my-window.blogspot.com/?page=json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NAsanaLibrary.Entities
{

    internal class Story
    {

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("target")]
        public Target Target { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("created_by")]
        public User CreatedBy { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
