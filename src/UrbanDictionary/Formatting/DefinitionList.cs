using System.Collections.Generic;
using Newtonsoft.Json;

namespace UrbanDictionary
{
    public class DefinitionList
    {
        [JsonProperty("list")]
        public List<Definition> definitions;
    }
}
