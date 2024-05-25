using static SplashKitSDK.SplashKit;  
using System.Threading;              

// Open a few windows
OpenWindow("Window 1", 800, 600);
OpenWindow("Window 2", 800, 600);
OpenWindow("Window 3", 800, 600);

WriteLine("Opened 3 windows. Waiting for 5 seconds...");

// Wait for 5 seconds
Thread.Sleep(5000);

// Close all windows
CloseAllWindows();
WriteLine("All windows have been closed.");
