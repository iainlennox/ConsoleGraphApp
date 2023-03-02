using Azure.Identity;
using Microsoft.Graph;

var scopes = new[] { "User.Read" };
var interactiveBrowserCredentialOptions = new InteractiveBrowserCredentialOptions
{
  ClientId = "800cee12-232c-4771-b66b-b68eaae3705b"
};
var tokenCredential = new InteractiveBrowserCredential(interactiveBrowserCredentialOptions);

var graphClient = new GraphServiceClient(tokenCredential, scopes);

var me = await graphClient.Me.GetAsync();
Console.WriteLine($"Hello {me?.DisplayName}!");
