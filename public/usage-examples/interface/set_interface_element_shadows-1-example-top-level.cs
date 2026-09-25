using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Interface Element Shadows", 700, 420);

int shadowRadius = 3;
Point2D shadowOffset = PointAt(3, 3);
Color shadowColor = RGBAColor(0, 0, 0, 140);
string shadowStyle = "Small shadow";

while (!QuitRequested())
{
    ProcessEvents();

    // Change the interface shadow using number keys
    if (KeyTyped(KeyCode.Num1Key))
    {
        shadowRadius = 3;
        shadowOffset = PointAt(3, 3);
        shadowStyle = "Small shadow";
    }

    if (KeyTyped(KeyCode.Num2Key))
    {
        shadowRadius = 15;
        shadowOffset = PointAt(15, 15);
        shadowStyle = "Large shadow";
    }

    // Apply the selected shadow style to interface elements
    SetInterfaceElementShadows(
        shadowRadius,
        shadowColor,
        shadowOffset
    );

    ClearScreen(ColorWhite());

    DrawText(
        "Press 1 for small shadow or 2 for large shadow",
        ColorBlack(),
        130,
        80
    );

    DrawText(
        "Current style: " + shadowStyle,
        ColorBlack(),
        240,
        130
    );

    Button(
        "Interface Button",
        RectangleFrom(230, 200, 240, 60)
    );

    DrawInterface();
    RefreshScreen(60);
}

CloseAllWindows();