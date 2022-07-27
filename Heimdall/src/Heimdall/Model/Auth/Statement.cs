using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Heimdall.Model.Auth
{
  public class Statement
  {
    [JsonPropertyName("Action")]
    public string? Action { get; set; }
    [JsonPropertyName("Effect")]
    public string? Effect { get; set; } = "Deny"; // Default to Deny to ensure Allows are explicitly set
    [JsonPropertyName("Resource")]
    public string? Resource { get; set; }
    public IDictionary<ConditionOperator, IDictionary<ConditionKey, string>> Condition { get; set; }
  }
}
