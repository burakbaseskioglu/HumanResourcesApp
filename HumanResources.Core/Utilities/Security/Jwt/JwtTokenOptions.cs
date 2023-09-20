namespace HumanResources.Core.Utilities.Security.Jwt
{
    public class JwtTokenOptions
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public string SecretKey { get; set; }
    }
}
