using SplashKitSDK;

namespace JsonReadArrayOfBoolExample
{
    public class Program
    {
        public static void Main()
        {
            // Build the Json from text, so the example needs no resource files
            Json progress = SplashKit.JsonFromString("{\"badges\": [true, false, true, true, false]}");

            // The function fills a list that we create empty first
            List<bool> badges = new List<bool>();
            SplashKit.JsonReadArray(progress, "badges", ref badges);

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

            SplashKit.OpenWindow("Badge Board", 520, 360);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen(Color.White);

                SplashKit.DrawText("Your badges", Color.Black, "arial", 30, 30, 25);

                for (int index = 0; index < badgeCount; index++)
                {
                    if (badges[index])
                    {
                        SplashKit.DrawText($"Badge {index + 1}: unlocked", Color.DarkGreen, "arial", 24, 30, 85 + index * 40);
                    }
                    else
                    {
                        SplashKit.DrawText($"Badge {index + 1}: locked", Color.Gray, "arial", 24, 30, 85 + index * 40);
                    }
                }

                SplashKit.DrawText($"Unlocked: {unlockedCount} of {badgeCount}", Color.Black, "arial", 26, 30, 310);

                SplashKit.RefreshScreen(60);
            }

            progress.Free();
            SplashKit.CloseAllWindows();
        }
    }
}
