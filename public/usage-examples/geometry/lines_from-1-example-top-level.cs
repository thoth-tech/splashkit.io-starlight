using static SplashKitSDK.SplashKit;

OpenWindow("Interactive Rectangle Edges", 800, 600);

SplashKitSDK.Rectangle myRectangle = RectangleFrom(250, 200, 300, 200);
// Get the four edges of the rectangle using the LinesFrom function
List<SplashKitSDK.Line> rectangleEdges = LinesFrom(myRectangle);

List<SplashKitSDK.Color> normalColors = new List<SplashKitSDK.Color>
{
    ColorRed(),
    ColorLimeGreen(),
    ColorBlue(),
    ColorOrange()
};

List<SplashKitSDK.Color> hoverColors = new List<SplashKitSDK.Color>
{
    ColorWhite(),
    ColorWhite(),
    ColorWhite(),
    ColorWhite()
};

SplashKitSDK.Point2D mousePosition;
SplashKitSDK.Line edge;

while (!WindowCloseRequested("Interactive Rectangle Edges"))
{
    ProcessEvents();
    ClearScreen(ColorDarkSlateGray());

    FillRectangle(ColorBlack(), myRectangle.X, myRectangle.Y, myRectangle.Width, myRectangle.Height);

    mousePosition = MousePosition();

    for (int i = 0; i < rectangleEdges.Count; i++)
    {
        edge = rectangleEdges[i];

        // Detects if the mouse is over the edge using SplashKit's geometry function
        if (PointOnLine(mousePosition, edge))
        {
            DrawLine(hoverColors[i], edge.StartPoint.X, edge.StartPoint.Y, edge.EndPoint.X, edge.EndPoint.Y);
        }
        else
        {
            DrawLine(normalColors[i], edge.StartPoint.X, edge.StartPoint.Y, edge.EndPoint.X, edge.EndPoint.Y);
        }
    }

    RefreshScreen(60);
}