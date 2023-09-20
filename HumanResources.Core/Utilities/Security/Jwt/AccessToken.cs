namespace HumanResources.Core.Utilities.Security.Jwt
{
    public class AccessToken
    {
        public string access_token { get; set; }
        public DateTime expire_time { get; set; }
    }
}
