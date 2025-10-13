using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        string hexValue = "1F3A";
        string binaryValue = SplashKit.HexToBin(hexValue);  // SplashKit function

        SplashKit.WriteLine("Hex: " + hexValue);
        SplashKit.WriteLine("Binary: " + binaryValue);
    }
}
