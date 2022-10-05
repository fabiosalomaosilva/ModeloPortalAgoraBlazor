using System.Text.Json.Serialization;

namespace ModeloPortalAgoraBlazor.Dtos;

public class SelectDataDto
{
    [JsonPropertyName("value")]
    public string Value { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }
}