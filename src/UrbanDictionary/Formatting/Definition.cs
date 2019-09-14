using Newtonsoft.Json;

namespace UrbanDictionary
{
    public class Definition
    {
        [JsonProperty("definition")]
        public string definition;

        [JsonProperty("thumbs_up")]
        public int thumbsUp;

        [JsonProperty("thumbs_down")]
        public int thumbsDown;

        [JsonProperty("word")]
        public string word;

        [JsonProperty("example")]
        public string example;

        public override string ToString()
        {
            return word;
        }
    }
}
