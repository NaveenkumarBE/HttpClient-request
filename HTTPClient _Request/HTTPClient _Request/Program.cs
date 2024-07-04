using System.Text;

class Program
{
    static async Task Main()
    {
        //Define the URL
        string url = "https://example.com";

        //Define the bearer token
        string accessToken = "YOUR ACCESS TOKEN";

        //Define the request body(If needed)
        var data = new
        {
            key = "value"
        };

        //Serialize the data to JSON
        var json = Newtonsoft.Json.JsonConvert.SerializeObject(data);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        //Create an HTTPClient Instance
        var client = new HttpClient();

        //Add the bearer token to the request header
        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");

        //Make the HTTP request
        var response = await client.PostAsync(url,content);

        //print the response status code and content
        Console.WriteLine($"Response Status Code :{response.StatusCode}");
        Console.WriteLine($"Response Content :{await response.Content.ReadAsStringAsync()}");

    }
}