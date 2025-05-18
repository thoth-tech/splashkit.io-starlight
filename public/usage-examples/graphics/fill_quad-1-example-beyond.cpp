#include <iostream>
#include <algorithm>
#ifdef __APPLE__
#include <SDL.h>
#else
#include <SDL2/SDL.h>
#endif

// Fill a triangle by horizontal scanlines
void fill_triangle(SDL_Renderer *renderer, SDL_Point p1, SDL_Point p2, SDL_Point p3)
{
    // Sort the points by y-coordinate
    if (p2.y < p1.y)
        std::swap(p1, p2);
    if (p3.y < p1.y)
        std::swap(p1, p3);
    if (p3.y < p2.y)
        std::swap(p2, p3);

    auto draw_scanline = [&](int y, int xa, int xb)
    {
        if (xa > xb)
            std::swap(xa, xb);
        SDL_RenderDrawLine(renderer, xa, y, xb, y);
    };

    auto edge_interp = [](SDL_Point a, SDL_Point b, int y) -> int
    {
        if (b.y == a.y)
            return a.x;
        return a.x + (b.x - a.x) * (y - a.y) / (b.y - a.y);
    };

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

// Fill a convex quad by splitting into two triangles
void fill_quad(SDL_Renderer *renderer, const SDL_Point q[4])
{
    // Assume points are given in order around the quad
    fill_triangle(renderer, q[0], q[1], q[2]);
    fill_triangle(renderer, q[0], q[2], q[3]);
}

int main(int argc, char **argv)
{
    if (SDL_Init(SDL_INIT_VIDEO) < 0)
    {
        std::cerr << "SDL_Init Error: " << SDL_GetError() << std::endl;
        return 1;
    }

    // Create a window
    SDL_Window *window = SDL_CreateWindow(
        "Coloured Star",
        SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED,
        600, 600,
        SDL_WINDOW_SHOWN);
    if (!window)
    {
        std::cerr << "SDL_CreateWindow Error: " << SDL_GetError() << std::endl;
        SDL_Quit();
        return 1;
    }

    // Create renderer
    SDL_Renderer *renderer = SDL_CreateRenderer(
        window, -1, SDL_RENDERER_ACCELERATED);
    if (!renderer)
    {
        std::cerr << "SDL_CreateRenderer Error: " << SDL_GetError() << std::endl;
        SDL_DestroyWindow(window);
        SDL_Quit();
        return 1;
    }

    // Clear screen to white
    SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
    SDL_RenderClear(renderer);

    // Define four diamond quads
    SDL_Point q1[4] = {{300, 0}, {200, 200}, {300, 300}, {400, 200}};
    SDL_Point q2[4] = {{400, 210}, {310, 300}, {400, 390}, {600, 300}};
    SDL_Point q3[4] = {{200, 400}, {300, 300}, {400, 400}, {300, 600}};
    SDL_Point q4[4] = {{200, 390}, {290, 300}, {200, 210}, {0, 300}};

    // Black quad
    SDL_SetRenderDrawColor(renderer, 0, 0, 0, 255);
    fill_quad(renderer, q1);

    // Green quad
    SDL_SetRenderDrawColor(renderer, 0, 255, 0, 255);
    fill_quad(renderer, q2);

    // Red quad
    SDL_SetRenderDrawColor(renderer, 255, 0, 0, 255);
    fill_quad(renderer, q3);

    // Blue quad
    SDL_SetRenderDrawColor(renderer, 0, 0, 255, 255);
    fill_quad(renderer, q4);

    // Show the result
    SDL_RenderPresent(renderer);

    // Keep window open until closed by user
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

    // Clean up
    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();

    return 0;
}
