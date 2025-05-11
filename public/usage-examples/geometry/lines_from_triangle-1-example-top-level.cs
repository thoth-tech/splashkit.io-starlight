using SplashKitSDK;

Window newWindow = new Window("Lines From Triangle", 400, 400);
//Triangle from pair cordinates sequentially
Triangle newTriangle = Geometry.TriangleFrom(100, 100, 200, 80, 150, 200);

//Loop through and display each line (edge) of the triangle individually
foreach (Line line in SplashKit.LinesFrom(newTriangle))
{
    ClearScreen(Color.White);
    DrawLine(Color.Red, line);
    RefreshScreen();
    Delay(800);
}

//Pause briefly at the end
Delay(1000);
