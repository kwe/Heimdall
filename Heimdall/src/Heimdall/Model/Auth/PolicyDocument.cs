using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Heimdall.Model.Auth
{
  public class PolicyDocument
  {
    [JsonPropertyName("Version")]
    public string? Version { get; set; }
    [JsonPropertyName("Statement")]
    public IEnumerable<Statement>? Statement { get; set; }
  }
}
