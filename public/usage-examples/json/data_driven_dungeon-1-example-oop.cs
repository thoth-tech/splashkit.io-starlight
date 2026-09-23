using System;
using SplashKitSDK;
using static SplashKitSDK.SplashKit;

namespace DataDrivenDungeon
{
    public class DungeonManager
    {
        private Json _levelData;

        public DungeonManager(string fileName)
        {
            _levelData = JsonFromFile(fileName);
        }

        public string LevelName => JsonReadString(_levelData, "level_name");
        public int Difficulty => JsonReadInteger(_levelData, "difficulty");
        public string Theme => JsonReadString(_levelData, "theme");

        public void Draw()
        {
            ClearScreen(ColorBlack());
            DrawText($"Level: {LevelName}", ColorWhite(), 20, 20);
            DrawText($"Difficulty: {Difficulty}", ColorWhite(), 20, 40);
            DrawText($"Theme: {Theme}", ColorWhite(), 20, 60);

            // Accessing the 'spawn_points' array and looping through objects
            Json spawnPoints = JsonReadArray(_levelData, "spawn_points");
            for (int i = 0; i < JsonArraySize(spawnPoints); i++)
            {
                Json entry = JsonReadObjectAtIndex(spawnPoints, i);
                string entryType = JsonReadString(entry, "type");
                double x = JsonReadNumber(entry, "x");
                double y = JsonReadNumber(entry, "y");

                Color drawColor = (entryType == "Player") ? ColorGreen() : ColorRed();
                FillRectangle(drawColor, x, y, 32, 32);
                DrawText(entryType, ColorWhite(), (float)x, (float)y - 15);
            }

            // Accessing the 'loot' array
            Json lootPoints = JsonReadArray(_levelData, "loot");
            for (int i = 0; i < JsonArraySize(lootPoints); i++)
            {
                Json item = JsonReadObjectAtIndex(lootPoints, i);
                string lootName = JsonReadString(item, "item");
                double x = JsonReadNumber(item, "x");
                double y = JsonReadNumber(item, "y");

                FillCircle(ColorGold(), (float)x, (float)y, 8);
                DrawText(lootName, ColorGold(), (float)x - 20, (float)y - 20);
            }
        }

        public void Cleanup()
        {
            FreeJson(_levelData);
        }
    }

    public class Program
    {
        public static void Main()
        {
            DungeonManager dungeon = new DungeonManager("level_data.json");
            OpenWindow($"Dungeon Navigator: {dungeon.LevelName}", 800, 600);

            while (!QuitRequested())
            {
                ProcessEvents();
                dungeon.Draw();
                RefreshScreen(60);
            }

            dungeon.Cleanup();
            CloseAllWindows();
        }
    }
}
