using System;
using SplashKitSDK;
using static SplashKitSDK.SplashKit;

string url = "http://example.com";
ushort port = 80;

Console.WriteLine("HTTP GET Request");
Console.WriteLine();
Console.WriteLine("Requesting: " + url);
Console.WriteLine();

// Make a GET request to the web resource
HttpResponse response = HttpGet(url, port);

// Convert the response into text
string responseText = HttpResponseToString(response);

Console.WriteLine("Response received:");

int displayLength = Math.Min(200, responseText.Length);
Console.WriteLine(responseText.Substring(0, displayLength));

// Release the HTTP response
FreeResponse(response);