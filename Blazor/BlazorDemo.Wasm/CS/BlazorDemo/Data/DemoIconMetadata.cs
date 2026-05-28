using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BlazorDemo.Data;

public sealed class DemoIconMetadataDocument {
    [JsonPropertyName("icons")] public Dictionary<string, DemoIconMetadata> Icons { get; set; } = [];
}

public sealed class DemoIconMetadata {
    [JsonPropertyName("category")] public string Category { get; set; }
    [JsonPropertyName("tags")] public string[] Tags { get; set; } = [];
}
