using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Json exampleJson = CreateJson();

JsonSetString(exampleJson, "name", "SplashKit");

bool hasName = JsonHasKey(exampleJson, "name");
bool hasAge = JsonHasKey(exampleJson, "age");

WriteLine("JSON Has Key Example");
WriteLine("--------------------");

if (hasName)
{
    WriteLine("Has key 'name': true");
}
else
{
    WriteLine("Has key 'name': false");
}

if (hasAge)
{
    WriteLine("Has key 'age': true");
}
else
{
    WriteLine("Has key 'age': false");
}

FreeJson(exampleJson);