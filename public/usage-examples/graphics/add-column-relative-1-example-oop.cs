using SplashKitSDK;

class Column
{
    public double WidthPercent { get; }
    public Color FillColor { get; }

    public Column(double widthPercent, Color color)
    {
        WidthPercent = widthPercent;
        FillColor = color;
    }

    public void Draw(ref float x, float containerWidth, float height)
    {
        float colWidth = (float)(containerWidth * WidthPercent);
        SplashKit.FillRectangle(FillColor, x, 0, colWidth, height);
        x += colWidth;
    }
}

class Program
{
    static void Main()
    {
        SplashKit.OpenWindow("Columns with Increasing Percentage Width", 600, 200);

        Column[] columns = {
            new Column(0.10, Color.LightBlue),
            new Column(0.20, Color.LightGreen),
            new Column(0.30, Color.Yellow),
            new Column(0.40, Color.Pink),
        };

        float winWidth = 600, winHeight = 200;

        while (!SplashKit.QuitRequested())
        {
            SplashKit.ProcessEvents();
            SplashKit.ClearScreen(Color.White);

            float x = 0;
            foreach (var col in columns)
                col.Draw(ref x, winWidth, winHeight);

            SplashKit.DrawText("Columns: 10% | 20% | 30% | 40%", Color.Black, 10, winHeight - 30);

            SplashKit.RefreshScreen();
        }
    }
}
