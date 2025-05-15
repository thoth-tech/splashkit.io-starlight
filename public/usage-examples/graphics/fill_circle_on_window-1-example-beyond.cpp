#include <iostream>
#include <cstdlib>
#include <ctime>
#ifdef __APPLE__
#include <SDL.h>
#else
#include <SDL2/SDL.h>
#endif

void draw_traffic_lights(SDL_Renderer *renderer)
{
    // Clear screen with white color
    SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
    SDL_RenderClear(renderer);

    // Colors for the traffic lights
    SDL_Color colors[3] = {{255, 0, 0, 255}, {255, 255, 0, 255}, {0, 255, 0, 255}};
    int y_positions[3] = {100, 250, 400};

    for (int i = 0; i < 3; i++)
    {
        // Set color
        SDL_SetRenderDrawColor(renderer, colors[i].r, colors[i].g, colors[i].b, colors[i].a);

        // Draw filled circle
        for (int w = 0; w < 50 * 2; w++)
        {
            for (int h = 0; h < 50 * 2; h++)
            {
                int dx = 50 - w; // Horizontal offset
                int dy = 50 - h; // Vertical offset
                if ((dx * dx + dy * dy) <= (50 * 50))
                {
                    SDL_RenderDrawPoint(renderer, 400 + dx, y_positions[i] + dy);
                }
            }
        }
    }

    SDL_RenderPresent(renderer);
}

int main(int argc, char **argv)
{
    if (SDL_Init(SDL_INIT_VIDEO) < 0)
    {
        std::cout << "SDL could not be initialized: " << SDL_GetError();
        exit(1);
    }

    SDL_Window *window = SDL_CreateWindow(
        "Traffic Lights - Beyond SDL",
        SDL_WINDOWPOS_CENTERED,
        SDL_WINDOWPOS_CENTERED,
        800,
        600,
        SDL_WINDOW_SHOWN);

    if (window == NULL)
    {
        SDL_LogError(SDL_LOG_CATEGORY_ERROR, "Could not create window: %s\n", SDL_GetError());
        SDL_Quit();
        exit(1);
    }

    SDL_Renderer *renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);
    if (renderer == NULL)
    {
        SDL_LogError(SDL_LOG_CATEGORY_ERROR, "Could not create renderer: %s\n", SDL_GetError());
        SDL_DestroyWindow(window);
        SDL_Quit();
        exit(1);
    }

    draw_traffic_lights(renderer);
    SDL_Delay(5000);

    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();

    return 0;
}
