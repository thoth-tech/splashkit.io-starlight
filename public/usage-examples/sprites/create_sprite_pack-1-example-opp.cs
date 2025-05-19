using SplashKitSDK;

namespace SpritePackSimulation
{
    public class Program
    {
        public static void Main()
        {
            Window window = SplashKit.OpenWindow("Sprite Pack Simulation", 800, 600);

            // Load bitmaps
            Bitmap glieseBitmap = SplashKit.LoadBitmap("gliese", "Gliese.png");
            Bitmap aquariiBitmap = SplashKit.LoadBitmap("aquarii", "Aquarii.png");

            // Create sprites
            Sprite glieseSprite = SplashKit.CreateSprite(glieseBitmap);
            Sprite aquariiSprite = SplashKit.CreateSprite(aquariiBitmap);

            // Start both at the center
            glieseSprite.X = 400;
            glieseSprite.Y = 300;
            aquariiSprite.X = 400;
            aquariiSprite.Y = 300;

            // Active sprite flag (true = Gliese, false = Aquarii)
            bool useGliese = true;

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                // Switch control with keys
                if (SplashKit.KeyTyped(KeyCode.Num1Key)) useGliese = true;
                if (SplashKit.KeyTyped(KeyCode.Num2Key)) useGliese = false;

                // Move the active sprite (left/right arrows)
                if (useGliese)
                {
                    if (SplashKit.KeyDown(KeyCode.LeftKey)) glieseSprite.X -= 5;
                    if (SplashKit.KeyDown(KeyCode.RightKey)) glieseSprite.X += 5;
                }
                else
                {
                    if (SplashKit.KeyDown(KeyCode.LeftKey)) aquariiSprite.X -= 5;
                    if (SplashKit.KeyDown(KeyCode.RightKey)) aquariiSprite.X += 5;
                }

                // Draw everything
                SplashKit.ClearScreen(Color.Black);
                if (useGliese)
                {
                    SplashKit.DrawSprite(glieseSprite);
                    SplashKit.DrawText("Active: Gliese (Press 2 for Aquarii)", Color.White, 10, 10);
                }
                else
                {
                    SplashKit.DrawSprite(aquariiSprite);
                    SplashKit.DrawText("Active: Aquarii (Press 1 for Gliese)", Color.White, 10, 10);
                }
                SplashKit.DrawText("Use LEFT/RIGHT arrows to move", Color.White, 10, 40);

                SplashKit.RefreshScreen();
            }

            SplashKit.CloseAllWindows();
        }
    }
}
