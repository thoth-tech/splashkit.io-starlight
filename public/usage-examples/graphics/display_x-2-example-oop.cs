using SplashKitSDK;

namespace DisplayXExample2
{
    public class Program
    {
        public static void Main()
        {
            // Load Font
            Font font = SplashKit.LoadFont("font", "RobotoSlab.ttf");

            // Set number of displays
            int dispCount = SplashKit.NumberOfDisplays();

            // Arrays for storing display details
            int[,] dispStore = new int[dispCount, 4];
            string[] dispNames = new string[dispCount];

            // Create variables for offset
            int minX = 0, minY = 0;

            // Loop through displays collect details
            for (uint i = 0; i < dispCount; i++)
            {
                // Set details for display
                Display dispDetails = SplashKit.DisplayDetails(i);

                // Get coordinate info for display
                int dispX = dispDetails.X;
                int dispY = dispDetails.Y;

                // Get resolution for display
                int dispWidth = dispDetails.Width;
                int dispHeight = dispDetails.Height;

                // Get name for display
                string dispName = dispDetails.Name;

                // Add details to display store
                dispStore[i, 0] = dispX;
                dispStore[i, 1] = dispY;
                dispStore[i, 2] = dispWidth;
                dispStore[i, 3] = dispHeight;
                dispNames[i] = dispName;

                // Set min coordinate offset for drawing
                if (dispX < minX)
                {
                    minX = dispX;
                }
                if (dispY < minY)
                {
                    minY = dispY;
                }
            }

            Window wind = SplashKit.OpenWindow("Display X", 800, 600);

            for (int i = 0; i < dispCount; i++)
            {
                // Set Display Variables
                int originX = dispStore[i, 0];
                int originY = dispStore[i, 1];
                int lenW = dispStore[i, 2];
                int lenH = dispStore[i, 3];

                // Create strings for display
                string displayNameString = $"Name: {dispNames[i]}";
                string displayNumString = $"Display Number: {i + 1}";
                string displayCoordString = $"Display Coordinates: ({originX}, {originY})";

                // Refactor size and normalize for 300,300 origin in window
                originX = (originX - minX + 300) / 8;
                originY = (originY - minY + 500) / 8;
                lenW = lenW / 8;
                lenH = lenH / 8;

                // Draw Display setup to screen and label
                Rectangle disp = SplashKit.RectangleFrom(originX, originY, lenW, lenH);
                wind.DrawRectangle(Color.Black, disp);
                wind.DrawText(displayNameString, Color.Black, font, 10, originX + 5, originY + 5);
                wind.DrawText(displayNumString, Color.Black, font, 10, originX + 5, originY + 20);
                wind.DrawText(displayCoordString, Color.Black, font, 10, originX + 5, originY + 35);
                wind.Refresh();
            }
            wind.DrawText("Display X value represents the horizontal offset of a display,", Color.Black, font, 16, 10, 10);
            wind.DrawText("where 0,0 is the top left corner of the main display.", Color.Black, font, 16, 10, 30);
            wind.Refresh();
            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();
            }
        }
    }
}
