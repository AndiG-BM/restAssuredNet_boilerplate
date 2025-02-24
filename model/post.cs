using Newtonsoft.Json;

namespace restAssuredNet_boilerplate.model
{
    public class Post
    {
        [JsonProperty("userId")]
        public int UserId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; } = string.Empty;

        [JsonProperty("body")]
        public string Body { get; set; } = string.Empty;

        public Post()
        {
        }
    }
}