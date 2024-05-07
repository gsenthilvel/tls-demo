using System.Net;

class Program
{
    static async Task TLS2DemoMethod(int version=2)
    {
        // default optional TLS version is 2
        switch (version)
        {
            case 1:
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11;
                break;
            case 2:
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                break;
            case 3:
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13;
                break;
            default:
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
                break;
        }

        // Create an HttpClient instance
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Send a GET request to the specified URI
                HttpResponseMessage response = await client.GetAsync("https://www.google.com/");
                response.EnsureSuccessStatusCode();

                // Read the response content as a string
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
    static async Task TLS3DemoMethod(int version = 3)
    {
        // default optional TLS version is 3
        switch (version)
        {
            case 1:
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11;
                break;
            case 2:
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                break;
            case 3:
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13;
                break;
            default:
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
                break;
        }

        // Create an HttpClient instance
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Send a GET request to the specified URI
                HttpResponseMessage response = await client.GetAsync("https://www.google.com/");
                response.EnsureSuccessStatusCode();

                // Read the response content as a string
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
    static void Main(string[] args)
    {
        // Invoke the methods to demonstrate TLS 1.2 and 1.3
        TLS2DemoMethod().Wait();
        TLS3DemoMethod().Wait();
    }
}
