using System;
using System.Drawing;
using System.Windows.Forms;

public class Circle
{
    public int X, Y, Radius;
    public Color Color;

    public Circle(int x, int y, int radius, Color color)
    {
        X = x;
        Y = y;
        Radius = radius;
        Color = color;
    }

    public void Draw(Graphics g)
    {
        using Brush brush = new SolidBrush(Color);
        g.FillEllipse(brush, X - Radius, Y - Radius, Radius * 2, Radius * 2);
    }
}

public class CircleForm : Form
{
    private readonly Circle[] _circles;

    public CircleForm()
    {
        Text = "Draw Circles - OOP";
        ClientSize = new Size(800, 600);
        BackColor = Color.White;

        int cx = 400, cy = 300;
        _circles = new[]
        {
            new Circle(cx, cy, 50, Color.Red),
            new Circle(cx, cy, 100, Color.Blue),
            new Circle(cx, cy, 150, Color.Orange),
            new Circle(cx, cy, 200, Color.Green),
        };

        Paint += (s, e) =>
        {
            foreach (var circle in _circles)
                circle.Draw(e.Graphics);
        };
    }
}

public static class Program
{
    [STAThread]
    static void Main()
    {
        Application.Run(new CircleForm());
    }
}
