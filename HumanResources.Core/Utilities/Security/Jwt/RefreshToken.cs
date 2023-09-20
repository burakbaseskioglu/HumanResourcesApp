namespace HumanResources.Core.Utilities.Security.Jwt
{
    public class RefreshToken
    {
        public string refresh_token { get; set; }
        public DateTime expire_time { get; set; }
    }
}
