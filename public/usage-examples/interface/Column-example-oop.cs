using System;

class ColumnDisplay
{
    private const int ContainerWidth = 50;

    // Display columns with increasing percentage width
    public void AddColumnRelative(double width)
    {
        int pixels = (int)(ContainerWidth * width);
        string bar = new string('=', pixels);
        Console.WriteLine($"[{bar}] {(int)(width * 100)}%");
    }
}

class Program
{
    static void Main()
    {
        var display = new ColumnDisplay();
        for (int i = 1; i <= 5; i++)
            display.AddColumnRelative(i * 0.2);
    }
}
