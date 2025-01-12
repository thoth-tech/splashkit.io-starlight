using SplashKitSDK;

namespace CircleRadiusExample
{
    public class Program
    {
        public static void Main()
        {   
            // Let user enter the radius
            SplashKit.WriteLine("Enter Radius for circle: ");
            double Radius = SplashKit.ConvertToDouble(SplashKit.ReadLine());

            Window window = new Window("Circle Radius", 800, 600);
            window.Clear(Color.White);
            
            // Create a circle at the position (400, 300)
            Circle circle = SplashKit.CircleAt(400, 300, Radius);

            // Find the radius of the circle
            double radius = circle.Radius;

            // Fill the Circle
            SplashKit.FillCircle(Color.Red, 400, 300, radius);

            // Create a rectangle to show the radius
            SplashKit.DrawRectangle(Color.White, 400, 300, radius, radius);

            string text = "Radius: " + radius.ToString();

            // Print result on window
            SplashKit.DrawText(text, Color.Black, "NORMAL_FONT", 20, 100, 100);

            window.Refresh();
            SplashKit.Delay(4000);
            window.Close();
        }
    }
}