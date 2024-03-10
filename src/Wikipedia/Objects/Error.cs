using System.Text.Json.Serialization;

namespace Wikipedia.Objects;

public class Error
{
    public string? Code { get; set; }

    public string? Info { get; set; }

    [JsonPropertyName("docref")] 
    public string? DocumentReference { get; set; }
}