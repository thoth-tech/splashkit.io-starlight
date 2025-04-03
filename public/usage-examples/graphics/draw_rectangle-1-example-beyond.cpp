#include <iostream>
#include <cstdlib>
#include <ctime>
#ifdef __APPLE__
#include <SDL.h>
#else
#include <SDL2/SDL.h>
#endif

int main(int argv, char **args)
{
    // Declare Variables
    SDL_Window *window = nullptr;

    // Check for successful initialisation
    if (SDL_Init(SDL_INIT_VIDEO) < 0)
    {
        std::cout << "SDL could not be initialized: " << SDL_GetError();
        exit(1);
    }

    // Create Window
    window = SDL_CreateWindow(
        "Draw Rectangle",
        SDL_WINDOWPOS_CENTERED,
        SDL_WINDOWPOS_CENTERED,
        800,
        600,
        SDL_WINDOW_OPENGL);

    // Error handling for window
    if (window == NULL)
    {
        SDL_LogError(SDL_LOG_CATEGORY_ERROR, "Could not create window: %s\n", SDL_GetError());
        exit(1);
    }

    // Create renderer
    SDL_Renderer *renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);
    if (renderer == NULL)
    {
        SDL_LogError(SDL_LOG_CATEGORY_ERROR, "Could not create rederer: %s\n", SDL_GetError());
        exit(1);
    }

    // Clear screen with a white color
    SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
    SDL_RenderClear(renderer);

    for (int i = 0; i < 21; i++)
    {
        int x = i * 40 - 40;
        int y = 600 - i * 30;
        // Draw rectangle using x and y above with width 40 and height 30
        SDL_Rect rect = {x, y, 40, 30};
        SDL_SetRenderDrawColor(renderer, std::rand() % 256, std::rand() % 256, std::rand() % 256, 255);
        SDL_RenderDrawRect(renderer, &rect);
    }
    // Display drawing
    SDL_RenderPresent(renderer);

    // Hold window 5 seconds
    SDL_Delay(5000);

    // Cleanup and free memory
    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();

    // Cleanup and free memory
    SDL_DestroyWindow(window);

    return 0;
}