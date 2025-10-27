/// <summary>
/// Data Models for M3UFromXtream application.
/// </summary>
/// 
using System.Text.Json.Serialization;

namespace M3UFromXtream
{
    /// <summary>
    /// Represents a category with an identifier, name, and optional parent category.   
    /// </summary>
    public class Category
    {
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; } = "";

        [JsonPropertyName("category_name")]
        public string CategoryName { get; set; } = "";

        [JsonPropertyName("parent_id")]
        public int ParentId { get; set; } = 0;
    }

    /// <summary>
    /// Represents a media stream with associated metadata.
    /// </summary>
    /// <remarks>This class provides properties to access various attributes of a media stream, such as its
    /// type, identifier, and associated category.</remarks>
    public class Stream
    {
        [JsonPropertyName("num")]
        public int Num { get; set; } = 0;

        [JsonPropertyName("name")]
        public string Name { get; set; } = "";

        [JsonPropertyName("stream_type")]
        public string StreamType { get; set; } = "";

        [JsonPropertyName("stream_id")]
        public int StreamId { get; set; } = 0;

        [JsonPropertyName("stream_icon")]
        public string StreamIcon { get; set; } = "";

        [JsonPropertyName("epg_channel_id")]
        public string EpgChannelId { get; set; } = "";

        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; } = "";
    }
}
