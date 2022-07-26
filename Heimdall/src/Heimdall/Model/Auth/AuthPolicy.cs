using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Heimdall.Model.Auth
{
  public class AuthPolicy
  {
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
    [JsonPropertyName("policyDocument")]
    public PolicyDocument? PolicyDocument { get; set; }

    [JsonPropertyName("context")]

    public IDictionary<string, object> Context { get; set; } = new Dictionary<string, object>();
  }
}
