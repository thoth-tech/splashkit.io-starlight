using SplashKitSDK;

namespace MyIpExample
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.WriteLine("Hello! This example shows the IPv4 address of this computer.");

            // Ask SplashKit for the local IPv4 address
            string localAddress = SplashKit.MyIP();

            // Display the address in dotted decimal format
            SplashKit.WriteLine("This computer's IPv4 address is: " + localAddress);

            // The address is also useful as the host a client connects to
            SplashKit.WriteLine("A client on this machine can connect to a server using " + localAddress + ".");
        }
    }
}
