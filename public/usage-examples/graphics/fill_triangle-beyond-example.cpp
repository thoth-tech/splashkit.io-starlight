#include <iostream>
#include <cmath>
#ifdef __APPLE__
#include <SDL.h>
#else
#include <SDL2/SDL.h>
#endif

// Helper function to draw a filled triangle using horizontal scanlines
void fill_triangle(SDL_Renderer *renderer, SDL_Point p1, SDL_Point p2, SDL_Point p3)
{
    // Sort the points by y-coordinate
    if (p2.y < p1.y) std::swap(p1, p2);
    if (p3.y < p1.y) std::swap(p1, p3);
    if (p3.y < p2.y) std::swap(p2, p3);

    auto draw_scanline = [&](int y, int xa, int xb)
    {
        if (xa > xb) std::swap(xa, xb);
        SDL_RenderDrawLine(renderer, xa, y, xb, y);
    };

    auto edge_interp = [](SDL_Point a, SDL_Point b, int y) -> int
    {
        if (b.y == a.y) return a.x;
        return a.x + (b.x - a.x) * (y - a.y) / (b.y - a.y);
    };

    // Fill the triangle with horizontal lines
    for (int y = p1.y; y <= p3.y; ++y)
    {
        if (y < p2.y)
        {
            int xa = edge_interp(p1, p2, y);
            int xb = edge_interp(p1, p3, y);
            draw_scanline(y, xa, xb);
        }
        else
        {
            int xa = edge_interp(p2, p3, y);
            int xb = edge_interp(p1, p3, y);
            draw_scanline(y, xa, xb);
        }
    }
}

int main(int argc, char **argv)
{
    // Initialize SDL2
    if (SDL_Init(SDL_INIT_VIDEO) < 0)
    {
        std::cerr << "SDL could not initialize: " << SDL_GetError() << std::endl;
        return 1;
    }

    // Create window
    SDL_Window *window = SDL_CreateWindow("Fill Triangle Example",
                                          SDL_WINDOWPOS_CENTERED,
                                          SDL_WINDOWPOS_CENTERED,
                                          800, 600,
                                          SDL_WINDOW_SHOWN);
    if (!window)
    {
        std::cerr << "Window could not be created: " << SDL_GetError() << std::endl;
        return 1;
    }

    // Create renderer
    SDL_Renderer *renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);
    if (!renderer)
    {
        std::cerr << "Renderer could not be created: " << SDL_GetError() << std::endl;
        SDL_DestroyWindow(window);
        return 1;
    }

    // Clear screen to white
    SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
    SDL_RenderClear(renderer);

    // Set color to red and draw filled triangle
    SDL_SetRenderDrawColor(renderer, 255, 0, 0, 255);
    SDL_Point p1 = {100, 100};
    SDL_Point p2 = {200, 200};
    SDL_Point p3 = {300, 100};
    fill_triangle(renderer, p1, p2, p3);

    // Show rendered content
    SDL_RenderPresent(renderer);

    // Keep window open until user closes it
    SDL_Event event;
    bool running = true;
    while (running)
    {
        while (SDL_PollEvent(&event))
        {
            if (event.type == SDL_QUIT)
                running = false;
        }

        SDL_Delay(10); // Limit CPU usage
    }

    // Cleanup
    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();

    return 0;
}
