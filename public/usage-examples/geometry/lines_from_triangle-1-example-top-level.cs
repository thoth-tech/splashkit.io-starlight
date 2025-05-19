using static SplashKitSDK.SplashKit;

OpenWindow("Lines From Triangle", 400, 400);

//Build the triangle and get its edges
var p1    = PointAt(100, 100);
var p2    = PointAt(200,  80);
var p3    = PointAt(150, 200);
var tri   = TriangleFrom(p1, p2, p3);
List<Line> lines = LinesFrom(tri);

float R = 10f;  //Circle Radius

while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(Color.White);

    //Mouse position x and y
    float mx = MouseX();
    float my = MouseY();

    //Draw each edge and its index, highlighting if touched
    for (int i = 0; i < lines.Count; i++)
    {
        var ln = lines[i];

        //A simple “touch zone” around the line
        float x1 = (float)ln.StartPoint.X;
        float y1 = (float)ln.StartPoint.Y;
        float x2 = (float)ln.EndPoint.X;
        float y2 = (float)ln.EndPoint.Y;

        //If overlap
        bool overlap =
            mx >= Math.Min(x1, x2) - R && mx <= Math.Max(x1, x2) + R &&
            my >= Math.Min(y1, y2) - R && my <= Math.Max(y1, y2) + R;

        //highlight colour blue if overlap or not in red
        Color col = overlap ? Color.Blue : Color.Red;
        DrawLine(col, x1, y1, x2, y2);

        //Draw the index at the midpoint
        float midX = (x1 + x2) * 0.5f;
        float midY = (y1 + y2) * 0.5f;
        DrawText(i.ToString(), Color.Black, midX, midY);
    }

    //Draw a little circle around the mouse
    DrawCircle(Color.Green, MouseX(), MouseY(), R);

    RefreshScreen();
}
