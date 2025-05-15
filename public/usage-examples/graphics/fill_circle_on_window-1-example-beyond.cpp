#include <iostream>
#include <cstdlib>
#include <ctime>
#ifdef __APPLE__
#include <SDL.h>
#else
#include <SDL2/SDL.h>
#endif

void draw_filled_circle(SDL_Renderer *renderer, SDL_Color color, int cx, int cy, int radius)
{
    SDL_SetRenderDrawColor(renderer, color.r, color.g, color.b, color.a);

    for (int w = 0; w < radius * 2; w++)
    {
        for (int h = 0; h < radius * 2; h++)
        {
            int dx = radius - w;
            int dy = radius - h;

            if ((dx * dx + dy * dy) <= (radius * radius))
            {
                SDL_RenderDrawPoint(renderer, cx + dx, cy + dy);
            }
        }
    }
}

void draw_traffic_lights(SDL_Renderer *renderer, SDL_Color colors[], int y_positions[], int num_lights)
{
    SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
    SDL_RenderClear(renderer);

    for (int i = 0; i < num_lights; i++)
    {
        draw_filled_circle(renderer, colors[i], 400, y_positions[i], 50);
    }

    SDL_RenderPresent(renderer);
}

int main(int argc, char **argv)
{
    if (SDL_Init(SDL_INIT_VIDEO) < 0) return 1;

    SDL_Window *window = SDL_CreateWindow(
        "Traffic Lights",
        SDL_WINDOWPOS_CENTERED,
        SDL_WINDOWPOS_CENTERED,
        800,
        600,
        SDL_WINDOW_SHOWN
    );

    if (!window)
    {
        SDL_Quit();
        return 1;
    }

    SDL_Renderer *renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED | SDL_RENDERER_PRESENTVSYNC);
    if (!renderer)
    {
        SDL_DestroyWindow(window);
        SDL_Quit();
        return 1;
    }

    SDL_Color colors[3] = {
        {255, 0, 0, 255},   // Red
        {255, 255, 0, 255}, // Yellow
        {0, 129, 0, 255}    // Dark Green
    };

    int y_positions[3] = {100, 250, 400};

    draw_traffic_lights(renderer, colors, y_positions, 3);

    bool running = true;
    SDL_Event event;

    while (running)
    {
        while (SDL_PollEvent(&event))
        {
            if (event.type == SDL_QUIT) running = false;
        }
    }

    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();

    return 0;
}
