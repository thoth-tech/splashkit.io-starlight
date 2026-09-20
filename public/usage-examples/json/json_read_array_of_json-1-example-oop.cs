using SplashKitSDK;

namespace JsonReadArrayOfJsonExample
{
    public class Program
    {
        public static void Main()
        {
            // Build the Json from text, so the example needs no resource files
            Json scores = SplashKit.JsonFromString("{\"players\": [{\"name\": \"Ada\", \"score\": 120}, {\"name\": \"Grace\", \"score\": 95}, {\"name\": \"Linus\", \"score\": 140}]}");

            // Each entry in this list is a Json object of its own
            List<Json> players = new List<Json>();
            SplashKit.JsonReadArray(scores, "players", ref players);

            int playerCount = players.Count;

            SplashKit.OpenWindow("Score Board", 520, 360);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen(Color.White);

                SplashKit.DrawText("Score board", Color.Black, "arial", 30, 30, 25);

                for (int index = 0; index < playerCount; index++)
                {
                    // Read the fields from each player like from any other Json object
                    string playerName = players[index].ReadString("name");
                    int playerScore = players[index].ReadInteger("score");

                    SplashKit.DrawText($"{playerName}: {playerScore}", Color.Black, "arial", 24, 30, 85 + index * 40);
                }

                SplashKit.RefreshScreen(60);
            }

            // Frees the scores and the player objects that were read from it
            Json.FreeAll();
            SplashKit.CloseAllWindows();
        }
    }
}
