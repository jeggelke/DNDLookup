using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DNDLookup.DNDObjects.DNDObjects
{
    public class ChoiceObjectBase
    {
        [JsonProperty("choose")]
        public int NumberOfItemsToChoose { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("from")]
        public List<BaseObject> Items;
    }
}
