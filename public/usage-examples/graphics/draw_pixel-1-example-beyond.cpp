#include <iostream>
#include <SDL2/SDL.h>
#include <array>

const int WINDOW_WIDTH = 600;
const int WINDOW_HEIGHT = 600;
const int TRAIL_LENGTH = 50;

// Define some colors
SDL_Color color_list[5] = {
    {0, 0, 255, 255},    // Blue
    {255, 0, 0, 255},    // Red
    {0, 255, 0, 255},    // Green
    {255, 255, 0, 255},  // Yellow
    {255, 105, 180, 255} // Pink
};

int main(int argc, char *argv[])
{
    if (SDL_Init(SDL_INIT_VIDEO) < 0)
    {
        std::cerr << "Failed to initialize SDL: " << SDL_GetError() << "\n";
        return -1;
    }

    SDL_Window *window = SDL_CreateWindow("Cursor Trail",
                                          SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED,
                                          WINDOW_WIDTH, WINDOW_HEIGHT,
                                          SDL_WINDOW_SHOWN);

    if (!window)
    {
        std::cerr << "Failed to create window: " << SDL_GetError() << "\n";
        SDL_Quit();
        return -1;
    }

    SDL_Renderer *renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);

    if (!renderer)
    {
        std::cerr << "Failed to create renderer: " << SDL_GetError() << "\n";
        SDL_DestroyWindow(window);
        SDL_Quit();
        return -1;
    }

    std::array<SDL_Point, TRAIL_LENGTH> mouse_history = {};
    bool running = true;
    SDL_Event event;

    while (running)
    {
        while (SDL_PollEvent(&event))
        {
            if (event.type == SDL_QUIT)
            {
                running = false;
            }
        }

        // Shift old points
        for (int i = 0; i < TRAIL_LENGTH - 1; ++i)
        {
            mouse_history[i] = mouse_history[i + 1];
        }

        // Get current mouse position
        int mouse_x, mouse_y;
        SDL_GetMouseState(&mouse_x, &mouse_y);
        mouse_history[TRAIL_LENGTH - 1] = {mouse_x, mouse_y};

        // Clear screen
        SDL_SetRenderDrawColor(renderer, 0, 0, 0, 255); // Black
        SDL_RenderClear(renderer);

        // Draw trail
        for (int i = 0; i < TRAIL_LENGTH; ++i)
        {
            SDL_Color color = color_list[i % 5];
            SDL_SetRenderDrawColor(renderer, color.r, color.g, color.b, color.a);
            SDL_RenderDrawPoint(renderer, mouse_history[i].x, mouse_history[i].y);
        }

        SDL_RenderPresent(renderer);
        SDL_Delay(16); // ~60 FPS
    }

    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();
    return 0;
}
