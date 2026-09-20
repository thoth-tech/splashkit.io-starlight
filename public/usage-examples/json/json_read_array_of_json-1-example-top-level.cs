using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Build the Json from text, so the example needs no resource files
Json scores = JsonFromString("{\"players\": [{\"name\": \"Ada\", \"score\": 120}, {\"name\": \"Grace\", \"score\": 95}, {\"name\": \"Linus\", \"score\": 140}]}");

// Each entry in this list is a Json object of its own
List<Json> players = new List<Json>();
JsonReadArray(scores, "players", ref players);

int playerCount = players.Count;

OpenWindow("Score Board", 520, 360);

while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(ColorWhite());

    DrawText("Score board", ColorBlack(), "arial", 30, 30, 25);

    for (int index = 0; index < playerCount; index++)
    {
        // Read the fields from each player like from any other Json object
        string playerName = JsonReadString(players[index], "name");
        int playerScore = JsonReadNumberAsInt(players[index], "score");

        DrawText($"{playerName}: {playerScore}", ColorBlack(), "arial", 24, 30, 85 + index * 40);
    }

    RefreshScreen(60);
}

// Frees the scores and the player objects that were read from it
FreeAllJson();
CloseAllWindows();
