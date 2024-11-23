using SplashKitSDK;
using static SplashKitSDK.SplashKit;
//Variable Declartions
double bar_x = 100;
Line slider = LineFrom(100,300,500,300);
Line bar = LineFrom(bar_x,310,bar_x,290);
double percent = 0;
string volume = "Volume: ";


// Create window and draw initial Lines
OpenWindow("point on Line",600,600);
ClearScreen(ColorWhite());

DrawLine(ColorBlack(),slider);
DrawLine(ColorBlack(),bar);
DrawText(volume + percent.ToString(),ColorBlack(),200,450);
RefreshScreen();

while (! QuitRequested())
{
    
    ProcessEvents();

    // Check if user is holding click on the bar Line
    while (MouseDown(MouseButton.LeftButton) & PointOnLine(MousePosition(),bar))
    {

        ClearScreen(ColorWhite());
        bar_x = MousePosition().X; // sets bar_x value to mouse x value
        percent = ((bar_x - 100) / (500 - 100)) * 100; // convert bar_x position to percent value
        bar = LineFrom(bar_x,310,bar_x,290);
        
        // redraw Lines and volume text
        DrawLine(ColorBlack(),bar);
        DrawLine(ColorBlack(),slider);
        DrawText(volume + percent.ToString(),ColorBlack(),200,450);
        RefreshScreen();
        ProcessEvents();

    }

    
}