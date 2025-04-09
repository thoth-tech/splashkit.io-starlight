// // using System;
// using SplashKitSDK;

// public class Program
// {
//     public static void Main()
//     {
//         Window window = SplashKit.OpenWindow("Line Width Example", 800, 600);

//         // Set line width to 10
//         var opt1 = SplashKit.OptionLineWidth(10);
//         SplashKit.DrawLine(Color.Black, 100, 100, 200, 200, opt1);  // Use DrawLine instead of DrawRectangle

//         // Set line width to 5
//         var opt2 = SplashKit.OptionLineWidth(5);
//         SplashKit.DrawLine(Color.Red, 400, 100, 600, 250, opt2);  // Use DrawLine instead of DrawRectangle

//         SplashKit.RefreshScreen();

//         // Keep the window open until the user closes it
//         while (!SplashKit.WindowCloseRequested(window))
//         {
//             SplashKit.ProcessEvents();
//         }
//     }
// }
