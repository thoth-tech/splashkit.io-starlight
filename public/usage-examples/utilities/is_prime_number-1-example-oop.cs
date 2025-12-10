using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        int[] numbers = { 17, 18 };

        foreach (int num in numbers)
        {
            if (SplashKit.IsPrimeNumber(num))  // SplashKit function
                SplashKit.WriteLine(num + " is prime");
            else
                SplashKit.WriteLine(num + " is not prime");
        }
    }
}
