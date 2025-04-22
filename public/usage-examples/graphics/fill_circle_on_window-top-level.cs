using SplashKitSDK;

Window win = new Window("Traffic Lights - Top Level", 800, 600);

win.Clear(Color.White);

win.FillCircle(Color.Red, 400, 100, 50);
win.FillCircle(Color.Yellow, 400, 250, 50);
win.FillCircle(Color.Green, 400, 400, 50);

win.Refresh();

SplashKit.Delay(5000);
win.Close();
