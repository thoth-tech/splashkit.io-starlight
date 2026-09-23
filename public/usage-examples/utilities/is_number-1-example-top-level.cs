using static SplashKitSDK.SplashKit;

// Check if "42" is a number
bool result1 = IsNumber("42");
WriteLine("Is '42' a number? " + result1);

// Check if "3.14" is a number
bool result2 = IsNumber("3.14");
WriteLine("Is '3.14' a number? " + result2);

// Check if "hello" is a number
bool result3 = IsNumber("hello");
WriteLine("Is 'hello' a number? " + result3);

// Check if "12abc" is a number
bool result4 = IsNumber("12abc");
WriteLine("Is '12abc' a number? " + result4);
