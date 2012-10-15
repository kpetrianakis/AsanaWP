// JSON C# Class Generator
// http://at-my-window.blogspot.com/?page=json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NAsanaLibrary.Entities
{

    internal class Task
    {

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("modified_at")]
        public string ModifiedAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("assignee_status")]
        public string AssigneeStatus { get; set; }

        [JsonProperty("due_on")]
        public string DueOn { get; set; }

        [JsonProperty("workspace")]
        public Workspace Workspace { get; set; }

        [JsonProperty("completed_at")]
        public object CompletedAt { get; set; }

        [JsonProperty("followers")]
        public IList<User> Followers { get; set; }

        [JsonProperty("assignee")]
        public User Assignee { get; set; }

        [JsonProperty("parent")]
        public object Parent { get; set; }

        [JsonProperty("tags")]
        public IList<Tag> Tags { get; set; }

        [JsonProperty("projects")]
        public IList<Project> Projects { get; set; }
    }
}
