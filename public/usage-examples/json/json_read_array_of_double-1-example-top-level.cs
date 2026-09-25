using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Build the Json from text, so the example needs no resource files
Json weather = JsonFromString("{\"temperatures\": [18.5, 21.5, 19.5, 22.5]}");

// The function fills a list that we create empty first
List<double> temperatures = new List<double>();
JsonReadArray(weather, "temperatures", ref temperatures);

// The readings never change, so add them up once instead of every frame
int temperatureCount = temperatures.Count;
double total = 0;

for (int index = 0; index < temperatureCount; index++)
{
    total += temperatures[index];
}

double average = total / temperatureCount;

OpenWindow("Temperature Log", 520, 360);

while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(ColorWhite());

    DrawText("Recent temperatures", ColorBlack(), "arial", 30, 30, 25);

    for (int index = 0; index < temperatureCount; index++)
    {
        DrawText($"Day {index + 1}: {temperatures[index]} C", ColorBlack(), "arial", 24, 30, 85 + index * 40);
    }

    DrawText($"Average: {average} C", ColorBlack(), "arial", 26, 30, 270);

    RefreshScreen(60);
}

FreeJson(weather);
CloseAllWindows();
