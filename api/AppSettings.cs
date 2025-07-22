namespace api
{
    public class AppSettings
    {
        public string JwtSecret { get; set; } = string.Empty;
        public string JwtExpiryMinutes { get; set; } = string.Empty;
    }
}