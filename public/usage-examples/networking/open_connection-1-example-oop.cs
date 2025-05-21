using SplashKitSDK;

namespace OpenConnectionExample
{
    public class Program
    {
        public static void Main()
        {
            // Start a simple TCP server on localhost:8080
            SplashKit.CreateServer("127.0.0.1", 8080);

            // Establish a TCP connection to a local server on port 8080
            Connection conn = SplashKit.OpenConnection("local server connection", "127.0.0.1", 8080);

            if (SplashKit.IsConnectionOpen(conn))
            {
                SplashKit.WriteLine("Connection successfully established.");
            }
            else
            {
                SplashKit.WriteLine("Failed to connect.");
            }
        }
    }
}
