#include <iostream>
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
        "Colourful Starburst",
        SDL_WINDOWPOS_CENTERED,
        SDL_WINDOWPOS_CENTERED,
        600,
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

    // Clear screen with a black color
    SDL_SetRenderDrawColor(renderer, 0, 0, 0, 255);
    SDL_RenderClear(renderer);

    // Draws starburst pattern with changing colours to window
    SDL_SetRenderDrawColor(renderer, 255, 255, 0, 255); // COLOR_YELLOW
    SDL_RenderDrawLine(renderer, 0, 0, 600, 600);
    SDL_SetRenderDrawColor(renderer, 0, 127, 0, 255); // COLOR_GREEN
    SDL_RenderDrawLine(renderer, 0, 150, 600, 450);
    SDL_SetRenderDrawColor(renderer, 0, 127, 127, 255); // COLOR_TEAL
    SDL_RenderDrawLine(renderer, 0, 300, 600, 300);
    SDL_SetRenderDrawColor(renderer, 0, 0, 255, 255); // COLOR_BLUE
    SDL_RenderDrawLine(renderer, 0, 450, 600, 150);
    SDL_SetRenderDrawColor(renderer, 238, 130, 238, 255); // COLOR_VIOLET
    SDL_RenderDrawLine(renderer, 0, 600, 600, 0);
    SDL_SetRenderDrawColor(renderer, 127, 0, 127, 255); // COLOR_PURPLE
    SDL_RenderDrawLine(renderer, 150, 0, 450, 600);
    SDL_SetRenderDrawColor(renderer, 255, 192, 203, 255); // COLOR_PINK
    SDL_RenderDrawLine(renderer, 300, 0, 300, 600);
    SDL_SetRenderDrawColor(renderer, 255, 0, 0, 255); // COLOR_RED
    SDL_RenderDrawLine(renderer, 450, 0, 150, 600);
    SDL_SetRenderDrawColor(renderer, 255, 165, 0, 255); // COLOR_ORANGE
    SDL_RenderDrawLine(renderer, 600, 0, 0, 600);

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