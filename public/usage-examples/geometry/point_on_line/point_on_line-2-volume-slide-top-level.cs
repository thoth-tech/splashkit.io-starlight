using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Variable Declarations
double BarX = 100;
Line Slider = LineFrom(100, 300, 500, 300);
Line Bar = LineFrom(BarX, 310, BarX, 290);
double Percent = 0;
string Volume = "Volume: ";

// Create window and draw initial Lines
OpenWindow("Volume Slider", 600, 600);
ClearScreen(ColorWhite());

DrawLine(ColorBlack(), Slider);
DrawLine(ColorBlack(), Bar);
DrawText(Volume + Percent.ToString(), ColorBlack(), 200, 450);
RefreshScreen();

while (!QuitRequested())
{
    ProcessEvents();

    // Check if user is holding click on the bar Line
    while (MouseDown(MouseButton.LeftButton) && PointOnLine(MousePosition(), Bar))
    {
        ClearScreen(ColorWhite());
        BarX = MousePosition().X; // sets BarX value to mouse X value
        Percent = ((BarX - 100) / (500 - 100)) * 100; // convert BarX position to Percent value
        Bar = LineFrom(BarX, 310, BarX, 290);
        
        // redraw Lines and Volume text
        DrawLine(ColorBlack(), Bar);
        DrawLine(ColorBlack(), Slider);
        DrawText(Volume + Percent.ToString(), ColorBlack(), 200, 450);
        RefreshScreen();
        ProcessEvents();
    }
}

CloseWindow(Window);
