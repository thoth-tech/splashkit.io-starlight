using static SplashKitSDK.SplashKit;

OpenWindow("Lines From Triangle", 400, 400);

//Build the triangle and get its edges
var p1    = PointAt(100, 100);
var p2    = PointAt(200,  80);
var p3    = PointAt(150, 200);
var tri   = TriangleFrom(p1, p2, p3);
var lines = LinesFrom(tri);

const float R = 10f;  //Circle Radius

while (!QuitRequested())
{
    ProcessEvents();
    ClearScreen(SplashKitSDK.Color.White);

    //Mouse position x and y
    float mx = MouseX();
    float my = MouseY();

    //Draw each edge and its index, highlighting if touched
    int i = 0;
    foreach (var ln in lines)
    {
        //A simple “touch zone” around the line
        float x1 = (float)ln.StartPoint.X;
        float y1 = (float)ln.StartPoint.Y;
        float x2 = (float)ln.EndPoint.X;
        float y2 = (float)ln.EndPoint.Y;

        //If overlap
        float left   = x1 < x2 ? x1 - R : x2 - R;
        float right  = x1 > x2 ? x1 + R : x2 + R;
        float top    = y1 < y2 ? y1 - R : y2 - R;
        float bottom = y1 > y2 ? y1 + R : y2 + R;
        bool overlap =
            mx >= left && mx <= right &&
            my >= top  && my <= bottom;

        //highlight colour blue if overlap or not in red
        var col = overlap ? SplashKitSDK.Color.Blue : SplashKitSDK.Color.Red;
        DrawLine(col, ln);

        //Draw the index at the midpoint
        float midX = (x1 + x2) * 0.5f;
        float midY = (y1 + y2) * 0.5f;
        DrawText(i.ToString(), SplashKitSDK.Color.Black, midX, midY);

        i++;
    }

    //Draw a little circle around the mouse
    DrawCircle(SplashKitSDK.Color.Green, MouseX(), MouseY(), R);

    RefreshScreen();
}
