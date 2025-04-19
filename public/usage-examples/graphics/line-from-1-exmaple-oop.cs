using SplashKitSDK;
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        new RectangleLinesApp().Run();
    }
}

public class RectangleLinesApp
{
    private Window window;
    private Rectangle myRect;
    private List<Line> rectangleEdges;
    private List<Color> normalColors;
    private List<Color> hoverColors;

    public void Run()
    {
        window = new Window("Lines From Rectangle Example", 800, 600);
        myRect = SplashKit.RectangleFrom(250, 200, 300, 200);
        rectangleEdges = SplashKit.LinesFrom(myRect);

        normalColors = new List<Color> { Color.Red, Color.LimeGreen, Color.Blue, Color.Orange };
        hoverColors = new List<Color> { Color.White, Color.White, Color.White, Color.White };

        while (!window.CloseRequested)
        {
            SplashKit.ProcessEvents();
            SplashKit.ClearScreen(Color.DarkSlateGray);
            SplashKit.FillRectangle(Color.Black, myRect.X, myRect.Y, myRect.Width, myRect.Height);

            Point2D mouse = SplashKit.MousePosition();

            for (int i = 0; i < rectangleEdges.Count; i++)
            {
                Line edge = rectangleEdges[i];

                if (SplashKit.PointOnLine(mouse, edge))
                {
                    DrawLineManually(hoverColors[i], edge); // simulate "hover" with color only
                }
                else
                {
                    SplashKit.DrawLine(normalColors[i], edge);
                }
            }

            SplashKit.RefreshScreen(60);
        }
    }

    // Draw manually using start and end points — avoids unsupported overloads
    private void DrawLineManually(Color color, Line edge)
    {
        SplashKit.DrawLine(
            color,
            edge.StartPoint.X, edge.StartPoint.Y,
            edge.EndPoint.X, edge.EndPoint.Y
        );
    }
}