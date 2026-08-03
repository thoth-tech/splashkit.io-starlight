using static SplashKitSDK.SplashKit;

// Find the GCD of 12 and 8
int result1 = GreatestCommonDivisor(12, 8);
WriteLine("GCD of 12 and 8 is: " + result1);

// Find the GCD of 100 and 75
int result2 = GreatestCommonDivisor(100, 75);
WriteLine("GCD of 100 and 75 is: " + result2);

// Find the GCD of 7 and 13 (both prime, so GCD is 1)
int result3 = GreatestCommonDivisor(7, 13);
WriteLine("GCD of 7 and 13 is: " + result3);

// Find the GCD of 36 and 60
int result4 = GreatestCommonDivisor(36, 60);
WriteLine("GCD of 36 and 60 is: " + result4);
