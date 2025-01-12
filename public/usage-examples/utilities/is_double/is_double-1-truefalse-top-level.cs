using static SplashKitSDK.SplashKit;

string[] values = { "123", "45.67", "-50", "abc", "789", "0" };

foreach (string value in values)
{
    // Check if string is a valid double
    bool number = IsDouble(value);

    // Print the value along with the result using "true" or "false"
    WriteLine(value + " - " + (number ? "true" : "false"));
}
