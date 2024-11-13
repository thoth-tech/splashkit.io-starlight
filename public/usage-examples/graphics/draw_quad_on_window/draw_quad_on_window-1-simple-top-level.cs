using SplashKitSDK;
using static SplashKitSDK.SplashKit;


//Initialise quad coords
Quad q1 = new Quad();
Quad q2 = new Quad();
Quad q3 = new Quad();
Quad q4 = new Quad();
q1.Points = new Point2D[4];
q2.Points = new Point2D[4];
q3.Points = new Point2D[4];
q4.Points = new Point2D[4];

double[,] q1_corners = new double[,]{{400,200},{300, 300},{300,0},{200,200}}; 
double[,] q2_corners = new double[,]{{400,210},{310, 300},{600,300},{400,390}}; 
double[,] q3_corners = new double[,]{{200,400},{300, 300},{300,600},{400,400}}; 
double[,] q4_corners = new double[,]{{200,390},{290, 300},{0,300},{200,210}}; 



// set coords
for (int i = 0; i < 4; i++) {
    q1.Points[i] = PointAt(q1_corners[i,0],q1_corners[i,1]);
    q2.Points[i] = PointAt(q2_corners[i,0],q2_corners[i,1]);
    q3.Points[i] = PointAt(q3_corners[i,0],q3_corners[i,1]);
    q4.Points[i] = PointAt(q4_corners[i,0],q4_corners[i,1]);
}

// Create Window
Window window1 = OpenWindow("Draw Quad On Window 1", 600, 600);
Window window2 = OpenWindow("Draw Quad On Window 2", 600, 600);
ClearScreen(ColorWhite());


DrawQuadOnWindow(window1, ColorBlack(), q1);
DrawQuadOnWindow(window1, ColorGreen(), q2);
DrawQuadOnWindow(window2, ColorRed(), q3);
DrawQuadOnWindow(window2, ColorBlue(), q4);

RefreshScreen();
Delay(5000);
CloseAllWindows();
