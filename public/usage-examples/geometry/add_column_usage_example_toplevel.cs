using SplashKitSDK;

Window window = SplashKit.OpenWindow("Add Column Example", 600, 400);

// Create column objects
Column[] columns = new Column[]
{
    new Column("Small", 50, 50, 100, 300),
    new Column("Medium", 150, 50, 200, 300),
    new Column("Large", 350, 50, 300, 300)
};

// Main Event Loop
while (!window.CloseRequested)
{
    SplashKit.ProcessEvents();
    SplashKit.ClearScreen(Color.White);

    foreach (var column in columns)
    {
        column.Draw();
    }

    SplashKit.RefreshScreen(60);
}

/// <summary>
/// Represents a visual column with a label and size.
/// </summary>
public class Column
{
    public string Label { get; }
    public int Width { get; }
    public int X { get; }
    public int Y { get; }
    public int Height { get; }

    public Column(string label, int x, int y, int width, int height)
    {
        Label = label;
        X = x;
        Y = y;
        Width = width;
        Height = height;
    }

    /// <summary>
    /// Draws the column with its label.
    /// </summary>
    public void Draw()
    {
        SplashKit.FillRectangle(Color.LightGray, X, Y, Width, Height);
        SplashKit.DrawRectangle(Color.Black, X, Y, Width, Height);
        SplashKit.DrawText(Label, Color.Black, "Arial", 20, X + 10, Y + 10);
    }
}