/// <summary>
/// Data Models for M3UFromXtream application.
/// </summary>
/// 
using Newtonsoft.Json;

namespace M3UFromXtream
{
    /// <summary>
    /// Represents a category with an identifier, name, and optional parent category.
    /// </summary>
    public class Category
    {
        [JsonProperty("category_id")]
        public string CategoryId { get; set; } = "";

        [JsonProperty("category_name")]
        public string CategoryName { get; set; } = "";

        [JsonProperty("parent_id")]
        public int ParentId { get; set; } = 0;
    }

    /// <summary>
    /// Represents a media stream with associated metadata.
    /// </summary>
    /// <remarks>This class provides properties to access various attributes of a media stream, such as its
    /// type, identifier, and associated category.</remarks>
    public class Stream
    {
        [JsonProperty("num")]
        public int Num { get; set; } = 0;

        [JsonProperty("name")]
        public string Name { get; set; } = "";

        [JsonProperty("stream_type")]
        public string StreamType { get; set; } = "";

        [JsonProperty("stream_id")]
        public int StreamId { get; set; } = 0;

        [JsonProperty("stream_icon")]
        public string StreamIcon { get; set; } = "";

        [JsonProperty("epg_channel_id")]
        public string EpgChannelId { get; set; } = "";

        [JsonProperty("category_id")]
        public string CategoryId { get; set; } = "";
    }
}
