// JSON C# Class Generator
// http://at-my-window.blogspot.com/?page=json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NAsanaLibrary.Entities
{

    internal class User
    {

        [JsonProperty("id")]
        public object Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("workspaces")]
        public IList<Workspace> Workspaces { get; set; }
    }
}
