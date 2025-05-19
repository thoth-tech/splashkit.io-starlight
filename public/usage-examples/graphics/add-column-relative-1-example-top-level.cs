using SplashKitSDK;

void AddColumnRelative(double width, ref float x, float containerWidth, float height, Color col)
{
    float colWidth = (float)(containerWidth * width);
    SplashKit.FillRectangle(col, x, 0, colWidth, height);
    x += colWidth;
}

SplashKit.OpenWindow("Columns with Increasing Percentage Width", 600, 200);

while (!SplashKit.QuitRequested())
{
    SplashKit.ProcessEvents();
    SplashKit.ClearScreen(Color.White);

    float x = 0;
    float winWidth = 600, winHeight = 200;

    AddColumnRelative(0.10, ref x, winWidth, winHeight, Color.LightBlue);
    AddColumnRelative(0.20, ref x, winWidth, winHeight, Color.LightGreen);
    AddColumnRelative(0.30, ref x, winWidth, winHeight, Color.Yellow);
    AddColumnRelative(0.40, ref x, winWidth, winHeight, Color.Pink);

    SplashKit.DrawText("Columns: 10% | 20% | 30% | 40%", Color.Black, 10, winHeight - 30);

    SplashKit.RefreshScreen();
}
