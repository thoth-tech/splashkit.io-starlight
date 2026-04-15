using System;
using SplashKitSDK;
using static SplashKitSDK.SplashKit;

namespace RectangleToStringExample
{
    public class Program
    {
        public static void Main()
        {
            Rectangle rect = RectangleFrom(10, 20, 100, 50);
            string result = RectangleToString(rect);

            Console.WriteLine(result);
        }
    }
}