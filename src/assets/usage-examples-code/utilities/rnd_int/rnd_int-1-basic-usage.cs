using System;
using SplashKitSDK;

int upperBound = 10;
int randomNumber = SplashKitSDK.SplashKit.Rnd(upperBound);

Console.WriteLine("Random number between 0 and " + upperBound + ": " + randomNumber);
