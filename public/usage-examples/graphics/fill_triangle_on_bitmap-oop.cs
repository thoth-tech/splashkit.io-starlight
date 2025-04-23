using SplashKitSDK;

public class TriangleDrawer
{
    private Bitmap _bitmap;

    public TriangleDrawer()
    {
        _bitmap = new Bitmap("triangle", 618, 618);
        _bitmap.Clear(Color.White);
    }

    public void DrawFilledTriangle()
    {
        float x1 = 100, y1 = 200;
        float x2 = 309, y2 = 20;
        float x3 = 520, y3 = 200;

        _bitmap.FillTriangle(Color.Red, x1, y1, x2, y2, x3, y3);
    }

    public void Show()
    {
        Window window = new Window("Fill Triangle on Bitmap", 618, 618);
        window.DrawBitmap(_bitmap, 0, 0);
        window.Refresh();
        SplashKit.Delay(5000);
    }
}

public class Program
{
    public static void Main()
    {
        TriangleDrawer drawer = new TriangleDrawer();
        drawer.DrawFilledTriangle();
        drawer.Show();
    }
}
