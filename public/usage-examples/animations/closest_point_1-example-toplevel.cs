using SplashKitSDK;
using System;  // Add this line for Math class

class Program
{
    static void Main(string[] args)
    {
        // Initialize circle and line
        var circle = new Circle
        {
            Radius = 50,
            Center = new Point2D() { X = 400, Y = 300 }
        };

        var line = new Line
        {
            StartPoint = new Point2D() { X = 200, Y = 100 },
            EndPoint = new Point2D() { X = 600, Y = 500 }
        };

        // Open the window
        SplashKit.OpenWindow("Closest Point on Line", 800, 600);

        while (!SplashKit.WindowCloseRequested("Closest Point on Line"))
        {
            SplashKit.ProcessEvents();

            // Update circle center with mouse position
            circle.Center = SplashKit.MousePosition();

            // Find the closest point on the line
            var closestPoint = GetClosestPointOnLine(circle, line);

            // Clear screen and draw objects
            SplashKit.ClearScreen(Color.White);
            SplashKit.DrawLine(Color.Red, line.StartPoint.X, line.StartPoint.Y, line.EndPoint.X, line.EndPoint.Y);
            SplashKit.DrawCircle(Color.Blue, circle.Center.X, circle.Center.Y, circle.Radius);
            SplashKit.FillCircle(Color.Green, closestPoint.X, closestPoint.Y, 5);

            SplashKit.RefreshScreen();
        }
    }

    // Method to calculate the closest point on the line from the circle
    static Point2D GetClosestPointOnLine(Circle circle, Line line)
    {
        double dx = line.EndPoint.X - line.StartPoint.X;
        double dy = line.EndPoint.Y - line.StartPoint.Y;

        double t = ((circle.Center.X - line.StartPoint.X) * dx + (circle.Center.Y - line.StartPoint.Y) * dy) / (dx * dx + dy * dy);
        t = Math.Max(0, Math.Min(1, t));  // Math is now available

        return new Point2D
        {
            X = line.StartPoint.X + t * dx,
            Y = line.StartPoint.Y + t * dy
        };
    }

    // Manually defining Circle and Line structures if SplashKit does not have them
    struct Circle
    {
        public double Radius;
        public Point2D Center;
    }

    struct Line
    {
        public Point2D StartPoint;
        public Point2D EndPoint;
    }
}
