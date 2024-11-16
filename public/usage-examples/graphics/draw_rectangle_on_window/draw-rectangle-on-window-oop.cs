using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        int windowWidth = 800, windowHeight = 600, rows = 8, cols = 8, rectSize = 60;
        float offsetX = (windowWidth - cols * rectSize) / 2f, offsetY = (windowHeight - rows * rectSize) / 2f;
        Window myWindow = new Window("Checkerboard", windowWidth, windowHeight);

        while (!myWindow.CloseRequested)
        {
            myWindow.Clear(Color.White);
            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                {
                    float x = offsetX + c * rectSize, y = offsetY + r * rectSize;
                    Color fill = ((r + c) % 2 == 0) ? Color.Black : Color.LightGray;
                    myWindow.FillRectangle(fill, x, y, rectSize, rectSize);
                    myWindow.DrawRectangle(Color.Blue, x, y, rectSize, rectSize);
                }
            myWindow.Refresh();
        }

        myWindow.Close();
    }
}
