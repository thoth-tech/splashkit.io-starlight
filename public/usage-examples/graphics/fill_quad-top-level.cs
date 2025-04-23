using SDL2;
using System;

var points = new (int x, int y)[][]
{
    new[] { (400,200), (300,300), (300,0), (200,200) },
    new[] { (400,210), (310,300), (600,300), (400,390) },
    new[] { (200,400), (300,300), (300,600), (400,400) },
    new[] { (200,390), (290,300), (0,300), (200,210) }
};

var colors = new SDL.SDL_Color[]
{
    new() { r = 0, g = 0, b = 0, a = 255 },
    new() { r = 0, g = 255, b = 0, a = 255 },
    new() { r = 255, g = 0, b = 0, a = 255 },
    new() { r = 0, g = 0, b = 255, a = 255 }
};

SDL.SDL_Init(SDL.SDL_INIT_VIDEO);
var window = SDL.SDL_CreateWindow("Coloured Star", SDL.SDL_WINDOWPOS_CENTERED, SDL.SDL_WINDOWPOS_CENTERED, 600, 600, SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN);
var renderer = SDL.SDL_CreateRenderer(window, -1, 0);
SDL.SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
SDL.SDL_RenderClear(renderer);

for (int i = 0; i < points.Length; i++)
{
    SDL.SDL_SetRenderDrawColor(renderer, colors[i].r, colors[i].g, colors[i].b, colors[i].a);
    for (int j = 0; j < 4; j++)
    {
        var (x1, y1) = points[i][j];
        var (x2, y2) = points[i][(j + 1) % 4];
        SDL.SDL_RenderDrawLine(renderer, x1, y1, x2, y2);
    }
}

SDL.SDL_RenderPresent(renderer);
SDL.SDL_Delay(5000);
SDL.SDL_DestroyRenderer(renderer);
SDL.SDL_DestroyWindow(window);
SDL.SDL_Quit();
