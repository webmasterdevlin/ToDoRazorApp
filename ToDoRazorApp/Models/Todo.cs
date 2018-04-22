using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ToDoRazorApp.Models
{
    public class Todo
    {
        [JsonProperty("_id")]
        public string Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("isDone")]
        public bool IsDone { get; set; }
        [JsonProperty("deadLine")]
        public DateTime DeadLine { get; set; }
    }
}
