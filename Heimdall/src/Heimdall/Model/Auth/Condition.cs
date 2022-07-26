using System.Collections.Generic;

namespace Heimdall.Model.Auth
{
  public class Condition
  {
    public ConditionOperator Operator { get; set; }
    public IDictionary<ConditionKey, string> KeyPairs { get; set; }
  }
}
