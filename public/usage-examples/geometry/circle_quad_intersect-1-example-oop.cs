using System;
using SplashKitSDK;

namespace CircleQuadOOPExample
{
    class CircleQuadIntersectExample
    {
        private Window _window;
        private Point2D _p1, _p2, _p3, _p4;
        private Quad _fixedQuad;
        private float _radius = 30;

        public CircleQuadIntersectExample()
        {
            _window = new Window("Circle Quad Intersect Example", 800, 600);
            SetupQuad();
        }

        private void SetupQuad()
        {
            _p1 = SplashKit.PointAt(300, 200);
            _p2 = SplashKit.PointAt(500, 200);
            _p3 = SplashKit.PointAt(500, 400);
            _p4 = SplashKit.PointAt(300, 400);
            _fixedQuad = SplashKit.QuadFrom(_p1, _p2, _p3, _p4);
        }

        public void Run()
        {
            while (!_window.CloseRequested)
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen(Color.DarkSlateGray);

                Point2D pos = SplashKit.MousePosition();
                Circle mouseCircle = SplashKit.CircleAt(pos.X, pos.Y, _radius);

                bool isIntersecting = SplashKit.CircleQuadIntersect(mouseCircle, _fixedQuad);

                Color fillColor = isIntersecting ? Color.Red : Color.Green;

                SplashKit.FillTriangle(fillColor, _p1.X, _p1.Y, _p2.X, _p2.Y, _p3.X, _p3.Y);
                SplashKit.FillTriangle(fillColor, _p1.X, _p1.Y, _p4.X, _p4.Y, _p3.X, _p3.Y);

                SplashKit.DrawCircle(Color.White, mouseCircle);

                SplashKit.RefreshScreen(60);
            }
        }

        static void Main(string[] args)
        {
            new CircleQuadIntersectExample().Run();
        }
    }
}