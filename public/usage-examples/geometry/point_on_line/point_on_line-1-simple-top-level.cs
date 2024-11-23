using SplashKitSDK;
using static SplashKitSDK.SplashKit;

//Variable Declartions

Line ln = LineFrom(100,300,500,300);


// Create window
OpenWindow("point on line",600,600);

while (! QuitRequested())
{
    //Display line
    ClearScreen(ColorWhite());
    DrawLine(ColorBlack(),ln);
    
    //Draw text if curser is on line
    if( PointOnLine(MousePosition(),ln))
    {
        DrawText("Point on line" + PointToString(MousePosition()),ColorBlack(),200,450);
    }
    
    
    RefreshScreen();
    ProcessEvents();

    
}   
