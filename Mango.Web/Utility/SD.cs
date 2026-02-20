namespace Mango.Web.Utility
{
    public class SD
    {
        // Make this nullable so assigning a possibly-null configuration value doesn't warn.
        public static string CuoponAPIBase { get; set; } = "https://localhost:7001";
        public static string AuthAPIBase { get; set; } = "https://localhost:7002";
        public static string ProductAPIBase { get; set; } = "https://localhost:7000";

        
        public const string RoleAdmin = "ADMIN";
        public const string RoleCustomer = "CUSTOMER";
        public const string TokenCookie = "JWTTOken";


        public enum ApiType
        {
            GET = 0,
            POST = 1,
            PUT = 2,
            DELETE = 3
        }
    }
}
