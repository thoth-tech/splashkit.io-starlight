using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Build the Json from text, so the example needs no resource files
Json progress = JsonFromString("{\"badges\": [true, false, true, true, false]}");

// The function fills a list that we create empty first
List<bool> badges = new List<bool>();
JsonReadArray(progress, "badges", ref badges);

// Count the unlocked badges once, because the list never changes
int badgeCount = badges.Count;
int unlockedCount = 0;

for (int index = 0; index < badgeCount; index++)
{
    if (badges[index])
    {
        unlockedCount++;
    }
}

OpenWindow("Badge Board", 520, 360);

while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(ColorWhite());

    DrawText("Your badges", ColorBlack(), "arial", 30, 30, 25);

    for (int index = 0; index < badgeCount; index++)
    {
        if (badges[index])
        {
            DrawText($"Badge {index + 1}: unlocked", ColorDarkGreen(), "arial", 24, 30, 85 + index * 40);
        }
        else
        {
            DrawText($"Badge {index + 1}: locked", ColorGray(), "arial", 24, 30, 85 + index * 40);
        }
    }

    DrawText($"Unlocked: {unlockedCount} of {badgeCount}", ColorBlack(), "arial", 26, 30, 310);

    RefreshScreen(60);
}

FreeJson(progress);
CloseAllWindows();
