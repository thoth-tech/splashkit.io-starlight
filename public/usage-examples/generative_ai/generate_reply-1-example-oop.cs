using SplashKitSDK;

namespace GenerateReply
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.OpenWindow("Interactive AI Terminal", 900, 600);

            SplashKit.WriteLine("Interactive AI Terminal (Single-Turn)");
            SplashKit.Write("Enter your prompt: ");
            string prompt = SplashKit.ReadLine();

            string reply = SplashKit.GenerateReply(prompt);

            SplashKit.WriteLine("\nAI reply:");
            SplashKit.WriteLine(reply);

            while (!SplashKit.QuitRequested())
            {
                SplashKit.ProcessEvents();

                SplashKit.ClearScreen(SplashKit.ColorWhite());
                SplashKit.DrawText("Interactive AI Terminal", SplashKit.ColorBlack(), 20, 20);
                SplashKit.DrawText("Prompt:", SplashKit.ColorBlack(), 20, 70);
                SplashKit.DrawText(prompt, SplashKit.ColorDarkSlateGray(), 20, 100);
                SplashKit.DrawText("AI Reply:", SplashKit.ColorBlack(), 20, 160);
                SplashKit.DrawText(reply, SplashKit.ColorBlue(), 20, 190);

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}