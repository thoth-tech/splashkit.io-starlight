using System;
using System.Drawing;
using System.Windows.Forms;

int centerX = 400;
int centerY = 300;

var circles = new (int radius, Color color)[]
{
    (50, Color.Red),
    (100, Color.Blue),
    (150, Color.Orange),
    (200, Color.Green)
};

Form form = new()
{
    Text = "Draw Circles - Top Level",
    ClientSize = new Size(800, 600),
    BackColor = Color.White
};

form.Paint += (s, e) =>
{
    foreach (var (radius, color) in circles)
    {
        using Brush brush = new SolidBrush(color);
        e.Graphics.FillEllipse(brush, centerX - radius, centerY - radius, radius * 2, radius * 2);
    }
};

Application.Run(form);
