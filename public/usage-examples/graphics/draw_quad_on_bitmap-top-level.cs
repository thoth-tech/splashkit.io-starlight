using System.Drawing;
using System.Windows.Forms;

var form = new Form
{
    Text = "Dart-Shaped Quad",
    ClientSize = new Size(800, 600),
    BackColor = Color.White
};

form.Paint += (sender, e) =>
{
    Graphics g = e.Graphics;
    Point[] dart = {
        new Point(400, 100),
        new Point(500, 300),
        new Point(400, 500),
        new Point(300, 300)
    };

    g.FillPolygon(Brushes.SkyBlue, new[] { dart[0], dart[1], dart[2] });
    g.FillPolygon(Brushes.SkyBlue, new[] { dart[2], dart[3], dart[0] });
    g.DrawPolygon(Pens.Blue, dart);
};

Application.Run(form);
