using Azure.Core;
using Azure.Identity;
using System;
using System.Threading.Tasks;

public class TokenService
{
    
    // Add MAin method
    public static async Task Main(string[] args)
    {
        TokenService tokenService = new TokenService();
        string token = await tokenService.GetAuthorizationTokenAsync();
        Console.WriteLine(token);
    }
    public async Task<string> GetAuthorizationTokenAsync()
    {
        var credential = new DefaultAzureCredential();
        var tokenRequestContext = new TokenRequestContext(new[] { "https://cognitiveservices.azure.com/.default" });
        AccessToken token = await credential.GetTokenAsync(tokenRequestContext);
        return token.Token;
    }
}