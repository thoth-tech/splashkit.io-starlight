using SplashKitSDK;
using static SplashKitSDK.SplashKit;

Window window = OpenWindow("HSB Color", 800, 600);

double hue = 1;
double saturation = 1;
double brightness = 1;

while (!WindowCloseRequested(window))
    {
        ProcessEvents();

        Vector2D scroll = MouseWheelScroll();
        Vector2D movement = MouseMovement();

        // Adjust hue by dragging with right mouse button
        if (MouseDown(MouseButton.LeftButton))
            {
                hue += movement.X / ScreenWidth();
                    
            }

                saturation += scroll.Y / 10.0;
                    

        // Clear and draw
                
        Color color = HSBColor(hue, saturation, brightness);
        FillCircle(color, 400, 300, 300);

        RefreshScreen(60);
        }

CloseAllWindows();
