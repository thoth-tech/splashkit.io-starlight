using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Open a window with the specified title and dimensions
OpenWindow("Fill Triangle", 800, 600);

// Draw 50 random filled triangles on the window
Random random = new Random();
for (int i = 0; i < 50; i++)
    {
    // Generate random coordinates for the three vertices of the triangle
    int x1 = random.Next(800);
    int y1 = random.Next(600);
    int x2 = random.Next(800);
    int y2 = random.Next(600);
    int x3 = random.Next(800);
    int y3 = random.Next(600);

    // Generate a random color for the triangle
    Color randomColor = RGBColor(
        random.Next(255), random.Next(255), random.Next(255)  
    );
    // Draw a filled triangle with the random color and vertices
    FillTriangle(randomColor, x1, y1, x2, y2, x3, y3);
    }

// Refresh the screen to display the drawn triangles
RefreshScreen();

// Delay to keep the window open for 4 seconds
Delay(4000);

// Close all open windows
CloseAllWindows();

    

