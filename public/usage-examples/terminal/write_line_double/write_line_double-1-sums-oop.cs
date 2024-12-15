using SplashKitSDK;

namespace WriteLineDouble
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.WriteLine("Demonstrating SplashKit.WriteLine(double):");

            // Perform some calculations
            double value1 = 3.14159;  // Example value: pi
            double value2 = 2.71828;  // Example value: e
            double sum = value1 + value2;
            double product = value1 * value2;
            double difference = value1 - value2;
            double quotient = value1 / value2;

            SplashKit.WriteLine("The values used are:");
            SplashKit.WriteLine(value1); // Writing the first double value
            SplashKit.WriteLine(value2); // Writing the second double value

            SplashKit.WriteLine("Their sum is:");
            SplashKit.WriteLine(sum); // Writing the sum

            SplashKit.WriteLine("Their product is:");
            SplashKit.WriteLine(product); // Writing the product

            SplashKit.WriteLine("Their difference is:");
            SplashKit.WriteLine(difference); // Writing the difference

            SplashKit.WriteLine("Their quotient is:");
            SplashKit.WriteLine(quotient); // Writing the quotient

            SplashKit.WriteLine("End of demonstration.");
        }
    }
}