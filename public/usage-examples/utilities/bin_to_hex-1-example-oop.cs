using SplashKitSDK;

public
class Program
{
public
    static void Main()
    {
        string binaryValue = "111110011010";
        string hexValue = SplashKit.BinToHex(binaryValue); // SplashKit function

        SplashKit.WriteLine("Binary: " + binaryValue);
        SplashKit.WriteLine("Hex: " + hexValue);
    }
}
