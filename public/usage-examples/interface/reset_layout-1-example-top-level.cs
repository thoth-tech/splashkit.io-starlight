using SplashKitSDK;
using static SplashKitSDK.SplashKit;

OpenWindow("Resetting Interface Layout", 800, 600);

SetInterfaceStyle(InterfaceStyle.ShadedLightStyle);

while (!QuitRequested())
{
    ProcessEvents();

    ClearScreen(Color.White);

    if (StartPanel("Layout Reset Demo", RectangleFrom(40, 40, 500, 400)))
    {
        StartCustomLayout();

        LabelElement("Before reset");

        SplitIntoColumns(3);
        SetLayoutHeight(64);

        Button("One");
        Button("Two");
        Button("Three");

        // Resetting returns the interface to the default single-column layout.
        ResetLayout();

        LabelElement("Default Layout After Reset");

        Button("Default Layout 1");
        Button("Default Layout 2");
        Button("Default Layout 3");

        EndPanel("Layout Reset Demo");
    }

    DrawInterface();

    RefreshScreen(60);
}

CloseAllWindows();