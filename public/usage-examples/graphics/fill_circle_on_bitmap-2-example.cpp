// fill_circle_on_bitmap-1-example-beyond.cpp
// Beyond SplashKit version using SDL2
// Draws a rainbow caterpillar onto an off-screen bitmap

#include <SDL2/SDL.h>
#include <cmath>

// Function to draw a filled circle using midpoint algorithm
void draw_filled_circle(SDL_Renderer* renderer, int cx, int cy, int radius, SDL_Color color)
{
    SDL_SetRenderDrawColor(renderer, color.r, color.g, color.b, color.a);
    for (int w = 0; w < radius * 2; w++)
    {
        for (int h = 0; h < radius * 2; h++)
        {
            int dx = radius - w; // horizontal offset
            int dy = radius - h; // vertical offset
            if (dx * dx + dy * dy <= radius * radius)
            {
                SDL_RenderDrawPoint(renderer, cx + dx, cy + dy);
            }
        }
    }
}

int main(int argc, char* argv[])
{
    SDL_Init(SDL_INIT_VIDEO);
    SDL_Window* window = SDL_CreateWindow("Beyond SplashKit - Caterpillar",
                                          SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED,
                                          400, 200, SDL_WINDOW_SHOWN);
    SDL_Renderer* renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);

    // Rainbow colors
    SDL_Color colors[6] = {
        {255, 0, 0, 255},     // Red
        {255, 165, 0, 255},   // Orange
        {255, 255, 0, 255},   // Yellow
        {0, 255, 0, 255},     // Green
        {0, 0, 255, 255},     // Blue
        {128, 0, 128, 255}    // Violet
    };

    // Clear background
    SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
    SDL_RenderClear(renderer);

    // Draw caterpillar circles
    int x = 50;
    int y;
    for (int i = 0; i < 6; i++)
    {
        y = (i % 2 == 0) ? 120 : 80;
        draw_filled_circle(renderer, x, y, 40, colors[i]);
        x += 60;
    }

    // Draw caterpillar eyes (black)
    SDL_Color black = {0, 0, 0, 255};
    draw_filled_circle(renderer, 60, 100, 8, black);
    draw_filled_circle(renderer, 60, 130, 8, black);

    SDL_RenderPresent(renderer);

    // Main loop
    bool running = true;
    SDL_Event event;
    while (running)
    {
        while (SDL_PollEvent(&event))
        {
            if (event.type == SDL_QUIT)
                running = false;
        }
        SDL_Delay(16);
    }

    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();

    return 0;
}