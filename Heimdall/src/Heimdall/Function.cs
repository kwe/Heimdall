using Amazon.Lambda.Core;
using Heimdall.Error;
using Heimdall.Model;
using Heimdall.Model.Auth;


// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace Heimdall;

public class Function
{

  public AuthPolicy FunctionHandler(TokenAuthorizerContext input, ILambdaContext context)
  {
    // here we go
    try
    {
      context.Logger.LogLine($"{nameof(input.AuthorizationToken)}: {input.AuthorizationToken}");
      context.Logger.LogLine($"{nameof(input.MethodArn)}: {input.MethodArn}");

      var principalId = "kwe";

      var methodArn = ApiGatewayArn.Parse(input.MethodArn);
      var apiOptions = new ApiOptions(methodArn.Region, methodArn.RestApiId, methodArn.Stage);

      var policyBuilder = new AuthPolicyBuilder(principalId, methodArn.AwsAccountId, apiOptions);
      policyBuilder.AllowAllMethods();

      var authResponse = policyBuilder.Build();

      return authResponse;

    }
    catch (Exception ex)
    {
      if (ex is UnauthorizedException)
        throw;

      context.Logger.LogLine($"Error: {ex.ToString()}");

      throw new UnauthorizedException();
    }

  }
}

