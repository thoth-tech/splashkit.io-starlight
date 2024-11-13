using static SplashKitSDK.SplashKit;

//Open new window with title and dimensions
OpenWindow("Blue Background", 800, 600);

//Use Clear Screen to change the background color to blue 
ClearScreen(ColorBlue());
RefreshScreen(60);
Delay(4000);

//Close loaded windows   
CloseAllWindows();