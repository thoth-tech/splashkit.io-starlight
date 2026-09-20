using SplashKitSDK;

namespace OctToBinExample
{
    public static class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("File Permission Bits", 640, 400);

            // Each octal digit of a Unix permission code is three bits: read, write and execute
            string permissionCode = "754";
            string bits = SplashKit.OctToBin(permissionCode);

            string[] whoNames = { "Owner", "Group", "Others" };
            string[] permissionNames = { "Read", "Write", "Execute" };

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                SplashKit.ClearScreen(Color.White);

                SplashKit.DrawText("Permission code: " + permissionCode, Color.Black, 40, 30);
                SplashKit.DrawText("As bits: " + bits, Color.Black, 40, 60);

                for (int column = 0; column < 3; column++)
                {
                    SplashKit.DrawText(permissionNames[column], Color.Black, 230 + column * 130, 115);
                }

                for (int row = 0; row < 3; row++)
                {
                    SplashKit.DrawText(whoNames[row], Color.Black, 60, 165 + row * 70);
                }

                // 754 has no leading zero digit, so all nine bits come back
                for (int position = 0; position < 9; position++)
                {
                    double boxX = 200 + (position % 3) * 130;
                    double boxY = 140 + (position / 3) * 70;

                    if (bits[position] == '1')
                    {
                        SplashKit.FillRectangle(Color.Green, boxX, boxY, 100, 50);
                    }
                    else
                    {
                        SplashKit.FillRectangle(Color.LightGray, boxX, boxY, 100, 50);
                    }

                    SplashKit.DrawRectangle(Color.Black, boxX, boxY, 100, 50);
                }

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}
