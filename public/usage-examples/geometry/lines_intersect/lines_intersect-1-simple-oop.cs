using SplashKitSDK;

namespace LinesIntersect
{
  public class Program
  {
    public static void Main()
    {
      SplashKit.OpenWindow("Lines Intersect", 800, 600);

      // Define points for the lines
      Point2D startPoint1 = new Point2D() { X = 100, Y = 150 };
      Point2D endPoint1 = new Point2D() { X = 500, Y = 550 };

      Point2D startPoint2 = new Point2D() { X = 100, Y = 550 };
      Point2D endPoint2 = new Point2D() { X = 500, Y = 150 };

      Point2D startPoint3 = new Point2D() { X = 550, Y = 150 };
      Point2D endPoint3 = new Point2D() { X = 550, Y = 500 };

      // Draw the lines
      Line demoLine1 = SplashKit.LineFrom(startPoint1, endPoint1);
      SplashKit.DrawLine(SplashKit.ColorRed(), demoLine1);
      SplashKit.DrawText("A", SplashKit.ColorBlack(), startPoint1.X - 20, startPoint1.Y - 10);

      Line demoLine2 = SplashKit.LineFrom(startPoint2, endPoint2);
      SplashKit.DrawLine(SplashKit.ColorBlue(), demoLine2);
      SplashKit.DrawText("B", SplashKit.ColorBlack(), startPoint2.X - 20, startPoint2.Y - 10);

      Line demoLine3 = SplashKit.LineFrom(startPoint3, endPoint3);
      SplashKit.DrawLine(SplashKit.ColorGreen(), demoLine3);
      SplashKit.DrawText("C", SplashKit.ColorBlack(), startPoint3.X - 20, startPoint3.Y - 10);

      // Check intersections
      bool intersect1And2 = SplashKit.LinesIntersect(demoLine1, demoLine2);
      bool intersect1And3 = SplashKit.LinesIntersect(demoLine1, demoLine3);

      // Display intersection results
      SplashKit.DrawText("A and B intersect: " + (intersect1And2 ? "Yes" : "No"), SplashKit.ColorBlack(), 150, 130);
      SplashKit.DrawText("A and C intersect: " + (intersect1And3 ? "Yes" : "No"), SplashKit.ColorBlack(), 150, 150);

      SplashKit.RefreshScreen();
      SplashKit.Delay(5000);

      SplashKit.CloseAllWindows();
    }
  }
}