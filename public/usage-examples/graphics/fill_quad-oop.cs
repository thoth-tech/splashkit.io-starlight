using SDL2;
using System;
using System.Runtime.InteropServices;

class Point
{
    public int X, Y;
    public Point(int x, int y) { X = x; Y = y; }
}

class Quad
{
    public Point[] Points;
    public SDL.SDL_Color Color;

    public Quad(Point[] points, SDL.SDL_Color color)
    {
        Points = points;
        Color = color;
    }

    public void Draw(IntPtr renderer)
    {
        SDL.SDL_SetRenderDrawColor(renderer, Color.r, Color.g, Color.b, Color.a);
        for (int i = 0; i < Points.Length; i++)
        {
            var p1 = Points[i];
            var p2 = Points[(i + 1) % Points.Length];
            SDL.SDL_RenderDrawLine(renderer, p1.X, p1.Y, p2.X, p2.Y);
        }
    }
}

class Program
{
    const int Width = 600, Height = 600;

    static void Main()
    {
        SDL.SDL_Init(SDL.SDL_INIT_VIDEO);
        SDL.SDL_Window window = SDL.SDL_CreateWindow("Coloured Star", SDL.SDL_WINDOWPOS_CENTERED, SDL.SDL_WINDOWPOS_CENTERED, Width, Height, SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN);
        IntPtr renderer = SDL.SDL_CreateRenderer(window, -1, 0);

        SDL.SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
        SDL.SDL_RenderClear(renderer);

        var quads = new Quad[]
        {
            new Quad(new Point[] { new(400,200), new(300,300), new(300,0), new(200,200) }, new SDL.SDL_Color{ r=0, g=0, b=0, a=255 }),
            new Quad(new Point[] { new(400,210), new(310,300), new(600,300), new(400,390) }, new SDL.SDL_Color{ r=0, g=255, b=0, a=255 }),
            new Quad(new Point[] { new(200,400), new(300,300), new(300,600), new(400,400) }, new SDL.SDL_Color{ r=255, g=0, b=0, a=255 }),
            new Quad(new Point[] { new(200,390), new(290,300), new(0,300), new(200,210) }, new SDL.SDL_Color{ r=0, g=0, b=255, a=255 }),
        };

        foreach (var quad in quads)
            quad.Draw(renderer);

        SDL.SDL_RenderPresent(renderer);
        SDL.SDL_Delay(5000);

        SDL.SDL_DestroyRenderer(renderer);
        SDL.SDL_DestroyWindow(window);
        SDL.SDL_Quit();
    }
}
