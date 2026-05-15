using SplashKitSDK;
using static SplashKitSDK.SplashKit;

string headingText = "Interface Labels";
string firstLabel = "Welcome to SplashKit";
string secondLabel = "This is a label element";

OpenWindow("Simple Interface Layout", 800, 600);

SetInterfaceStyle(InterfaceStyle.ShadedLightStyle);

while (!QuitRequested())
{
    ProcessEvents();

    ClearScreen(Color.White);

    // Labels are grouped together to form a simple interface section.
    LabelElement(headingText, RectangleFrom(320, 300, 400, 40));
    LabelElement(firstLabel, RectangleFrom(300, 250, 400, 40));
    LabelElement(secondLabel, RectangleFrom(300, 200, 400, 40));

    DrawInterface();

    RefreshScreen(60);
}

CloseAllWindows();