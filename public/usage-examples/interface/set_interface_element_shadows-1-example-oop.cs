using SplashKitSDK;

namespace SetInterfaceElementShadowsExample
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window(
                "Interface Element Shadows",
                700,
                420
            );

            int shadowRadius = 3;
            Point2D shadowOffset = SplashKit.PointAt(3, 3);
            Color shadowColor = Color.RGBAColor(0, 0, 0, 140);
            string shadowStyle = "Small shadow";

            while (!window.CloseRequested)
            {
                SplashKit.ProcessEvents();

                // Change the interface shadow using number keys
                if (SplashKit.KeyTyped(KeyCode.Num1Key))
                {
                    shadowRadius = 3;
                    shadowOffset = SplashKit.PointAt(3, 3);
                    shadowStyle = "Small shadow";
                }

                if (SplashKit.KeyTyped(KeyCode.Num2Key))
                {
                    shadowRadius = 15;
                    shadowOffset = SplashKit.PointAt(15, 15);
                    shadowStyle = "Large shadow";
                }

                // Apply the selected shadow style to interface elements
                SplashKit.SetInterfaceElementShadows(
                    shadowRadius,
                    shadowColor,
                    shadowOffset
                );

                window.Clear(Color.White);

                window.DrawText(
                    "Press 1 for small shadow or 2 for large shadow",
                    Color.Black,
                    130,
                    80
                );

                window.DrawText(
                    "Current style: " + shadowStyle,
                    Color.Black,
                    240,
                    130
                );

                SplashKit.Button(
                    "Interface Button",
                    SplashKit.RectangleFrom(
                        230,
                        200,
                        240,
                        60
                    )
                );

                SplashKit.DrawInterface();
                window.Refresh(60);
            }

            window.Close();
        }
    }
}