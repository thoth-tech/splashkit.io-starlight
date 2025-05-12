using SplashKitSDK;

namespace AddColumnExample
{
    /// <summary>
    /// Represents a visual column with a label, size, and position.
    /// </summary>
    public class Column
    {
        public string Label { get; }
        public int Width { get; }
        public int X { get; }
        public int Y { get; }
        public int Height { get; }

        public Column(string label, int x, int y, int width, int height)
        {
            Label = label;
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Draws the column as a filled rectangle with a border and label.
        /// </summary>
        public void Draw()
        {
            SplashKit.FillRectangle(Color.LightGray, X, Y, Width, Height);
            SplashKit.DrawRectangle(Color.Black, X, Y, Width, Height);
            SplashKit.DrawText(Label, Color.Black, "Arial", 20, X + 10, Y + 10);
        }
    }

    /// <summary>
    /// Manages the window and handles rendering of columns.
    /// </summary>
    public class ColumnDemo
    {
        private Window _window;
        private Column[] _columns;

        public ColumnDemo()
        {
            _window = SplashKit.OpenWindow("Add Column Example", 600, 400);

            // Create columns with varying widths
            _columns = new Column[]
            {
                new Column("Small", 50, 50, 100, 300),
                new Column("Medium", 150, 50, 200, 300),
                new Column("Large", 350, 50, 300, 300)
            };
        }

        /// <summary>
        /// Runs the main event loop and draws all columns.
        /// </summary>
        public void Run()
        {
            while (!_window.CloseRequested)
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen(Color.White);

                foreach (var column in _columns)
                {
                    column.Draw();
                }

                SplashKit.RefreshScreen(60);
            }
        }

        /// <summary>
        /// Application entry point.
        /// </summary>
        public static void Main()
        {
            ColumnDemo demo = new ColumnDemo();
            demo.Run();
        }
    }
}