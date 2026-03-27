using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        string encoded = "SGVsbG8gU3BsYXNoS2l0";

        // Decode a Base64 string back to plain text
        string decoded = SplashKit.Base64Decode(encoded);

        // Print the Base64 input and decoded output
        SplashKit.WriteLine("Base64: " + encoded);
        SplashKit.WriteLine("Decoded: " + decoded);
    }
}
