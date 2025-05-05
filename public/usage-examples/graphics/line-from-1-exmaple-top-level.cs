using SplashKitSDK;
using System.Collections.Generic;

// Open a window
Window window = new Window("Lines From Rectangle Example", 800, 600);

// Create a centered rectangle
Rectangle my_rect = SplashKit.RectangleFrom(250, 200, 300, 200);
List<Line> rectangle_edges = SplashKit.LinesFrom(my_rect);

// Define normal and hover colors
List<Color> normal_colors = new List<Color> { Color.Red, Color.LimeGreen, Color.Blue, Color.Orange };
List<Color> hover_colors = new List<Color> { Color.White, Color.White, Color.White, Color.White };

// Game loop
while (!window.CloseRequested)
{
    SplashKit.ProcessEvents();
    SplashKit.ClearScreen(Color.DarkSlateGray);

    // Fill the rectangle background
    SplashKit.FillRectangle(Color.Black, my_rect.X, my_rect.Y, my_rect.Width, my_rect.Height);

    Point2D mouse = SplashKit.MousePosition();

    for (int i = 0; i < rectangle_edges.Count; i++)
    {
        Line edge = rectangle_edges[i];

        if (SplashKit.PointOnLine(mouse, edge))
        {
            // Draw with hover color (manual draw for compatibility)
            SplashKit.DrawLine(
                hover_colors[i],
                edge.StartPoint.X, edge.StartPoint.Y,
                edge.EndPoint.X, edge.EndPoint.Y
            );
        }
        else
        {
            // Draw with normal color
            SplashKit.DrawLine(
                normal_colors[i],
                edge.StartPoint.X, edge.StartPoint.Y,
                edge.EndPoint.X, edge.EndPoint.Y
            );
        }
    }

    SplashKit.RefreshScreen(60);
}
