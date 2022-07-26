namespace Heimdall.Error
{
  internal class UnauthorizedException : System.Exception
  {
    public UnauthorizedException() : base("Unauthorized")
    {
    }
  }
}
