using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Three Column Layout", 800, 600);

SetInterfaceStyle(InterfaceStyle.ShadedLightStyle);

while (!QuitRequested())
{
    ProcessEvents();

    ClearScreen(ColorWhite());

    if (StartPanel("Split Into Columns Demo", RectangleFrom(40, 40, 600, 180)))
    {
        StartCustomLayout();

        SplitIntoColumns(3);
        SetLayoutHeight(64);

        Button("Column 1");
        Button("Column 2");
        Button("Column 3");

        EndPanel("Split Into Columns Demo");
    }

    DrawInterface();

    RefreshScreen(60);
}

CloseAllWindows();