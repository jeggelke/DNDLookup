using Newtonsoft.Json;

namespace DNDLookup.DNDObjects
{
    public class BaseObject : IObjectInterface
    {
        public ulong? Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
