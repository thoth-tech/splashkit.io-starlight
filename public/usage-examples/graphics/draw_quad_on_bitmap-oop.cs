using System;
using System.Drawing;
using System.Windows.Forms;

public class DartQuadForm : Form
{
    public DartQuadForm()
    {
        this.Text = "Dart-Shaped Quad";
        this.ClientSize = new Size(800, 600);
        this.BackColor = Color.White;
        this.Paint += OnPaint;
    }

    private void OnPaint(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        Point[] dart = {
            new Point(400, 100),
            new Point(500, 300),
            new Point(400, 500),
            new Point(300, 300)
        };

        Brush fillBrush = new SolidBrush(Color.SkyBlue);
        Pen outlinePen = new Pen(Color.Blue, 2);

        // Fill with two triangles
        g.FillPolygon(fillBrush, new[] { dart[0], dart[1], dart[2] });
        g.FillPolygon(fillBrush, new[] { dart[2], dart[3], dart[0] });

        g.DrawPolygon(outlinePen, dart);
    }

    [STAThread]
    public static void Main()
    {
        Application.Run(new DartQuadForm());
    }
}
