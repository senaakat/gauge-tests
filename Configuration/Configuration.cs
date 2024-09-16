using System;

public static class Configuration
{
    public static string browser = "Chrome";
    // Gets the base URL from an environment variable or uses a default value if not found
    public static string BaseUrl => Environment.GetEnvironmentVariable("BASE_URL") ?? "https://test1.optimumcozum.com";
    
    // Constructs the login page URL using the BaseUrl
    public static string LoginPageUrl => $"{BaseUrl}/login";
    public static string AuthorityUrl =>$"{BaseUrl}/auth/select-role?first=1";
    
    // Constructs the dashboard URL using the BaseUrl
    public static string DashboardUrl => $"{BaseUrl}/bakdat/fleet/dashboard/index";
    public static string CarsUrl => $"{BaseUrl}/bakdat/fleet/cars";


    // Test user email and password
    public static string TestName => "ferhatkotan";
    public static string TestPassword => "Ferhat326.";
}
