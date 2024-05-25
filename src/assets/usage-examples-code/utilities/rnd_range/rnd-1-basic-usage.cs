using System;
using SplashKitSDK;

int min = 1;
int max = 10;
int randomNumber = SplashKitSDK.SplashKit.Rnd(min, max);

Console.WriteLine("Random number between " + min + " and " + max + ": " + randomNumber);
