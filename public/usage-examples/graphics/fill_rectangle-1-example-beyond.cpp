#include <iostream>
#include <cstdlib>
#include <ctime>
#ifdef __APPLE__
#include <SDL.h>
#else
#include <SDL2/SDL.h>
#endif

int main(int argc, char **argv)
{
    // Seed random number generator
    std::srand(static_cast<unsigned int>(std::time(nullptr)));

    SDL_Window *window = nullptr;

    if (SDL_Init(SDL_INIT_VIDEO) < 0)
    {
        std::cout << "SDL could not be initialized: " << SDL_GetError();
        return 1;
    }

    window = SDL_CreateWindow(
        "Fill Rectangle",
        SDL_WINDOWPOS_CENTERED,
        SDL_WINDOWPOS_CENTERED,
        800,
        600,
        SDL_WINDOW_SHOWN);

    if (window == NULL)
    {
        SDL_LogError(SDL_LOG_CATEGORY_ERROR, "Could not create window: %s\n", SDL_GetError());
        SDL_Quit();
        return 1;
    }

    SDL_Renderer *renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);
    if (renderer == NULL)
    {
        SDL_LogError(SDL_LOG_CATEGORY_ERROR, "Could not create renderer: %s\n", SDL_GetError());
        SDL_DestroyWindow(window);
        SDL_Quit();
        return 1;
    }

    // Clear screen with white
    SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
    SDL_RenderClear(renderer);

    // Set drawing color to blue and draw the rectangle
    SDL_SetRenderDrawColor(renderer, 0, 0, 255, 255);  // Blue
    SDL_Rect rect = {200, 200, 200, 100};
    SDL_RenderFillRect(renderer, &rect);

    // Display drawing
    SDL_RenderPresent(renderer);

    // Hold window 4 seconds
    SDL_Delay(4000);

    // Cleanup and free memory
    SDL_DestroyWindow(window);

    return 0;
}