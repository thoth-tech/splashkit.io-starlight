using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Data-Driven dungeon loading logic
Json levelInfo = JsonFromFile("level_data.json");

// Access strings and ints
string levelName = JsonReadString(levelInfo, "level_name");
int difficulty = JsonReadInteger(levelInfo, "difficulty");
string theme = JsonReadString(levelInfo, "theme");

OpenWindow($"Dungeon: {levelName}", 800, 600);

while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(ColorBlack());

    DrawText($"Level Name: {levelName}", ColorWhite(), 20, 20);
    DrawText($"Difficulty: {difficulty}", ColorWhite(), 20, 40);
    DrawText($"Theme: {theme}", ColorWhite(), 20, 60);

    // Reading nested objects from an array
    Json spawnPoints = JsonReadArray(levelInfo, "spawn_points");
    for (int i = 0; i < JsonArraySize(spawnPoints); i++)
    {
        Json entry = JsonReadObjectAtIndex(spawnPoints, i);
        string type = JsonReadString(entry, "type");
        double x = JsonReadNumber(entry, "x");
        double y = JsonReadNumber(entry, "y");

        Color drawColor = (type == "Player") ? ColorGreen() : ColorRed();
        FillRectangle(drawColor, x, y, 32, 32);
        DrawText(type, ColorWhite(), (float)x, (float)y - 15);
    }

    // Reading loot points
    Json lootItems = JsonReadArray(levelInfo, "loot");
    for (int i = 0; i < JsonArraySize(lootItems); i++)
    {
        Json item = JsonReadObjectAtIndex(lootItems, i);
        string itemName = JsonReadString(item, "item");
        double x = JsonReadNumber(item, "x");
        double y = JsonReadNumber(item, "y");

        FillCircle(ColorGold(), (float)x, (float)y, 8);
        DrawText(itemName, ColorGold(), (float)x - 20, (float)y - 20);
    }

    RefreshScreen(60);
}

FreeJson(levelInfo);
CloseAllWindows();
