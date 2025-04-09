
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
        "draw_line_on_window",
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

    // Clear screen with black
    SDL_SetRenderDrawColor(renderer, 0, 0, 0, 255);
    SDL_RenderClear(renderer);

    // Starburst pattern (similar to SplashKit)
    SDL_Point line1[] = { {0, 0}, {600, 600} };
        SDL_SetRenderDrawColor(renderer, 255, 255, 0, 255); // COLOR_YELLOW
        SDL_RenderDrawLines(renderer, line1, 2);

        SDL_Point line2[] = { {0, 150}, {600, 450} };
        SDL_SetRenderDrawColor(renderer, 0, 127, 0, 255); // COLOR_GREEN
        SDL_RenderDrawLines(renderer, line2, 2);

        SDL_Point line3[] = { {0, 300}, {600, 300} };
        SDL_SetRenderDrawColor(renderer, 0, 127, 127, 255); // COLOR_TEAL
        SDL_RenderDrawLines(renderer, line3, 2);

        SDL_Point line4[] = { {0, 450}, {600, 150} };
        SDL_SetRenderDrawColor(renderer, 0, 0, 255, 255); // COLOR_BLUE
        SDL_RenderDrawLines(renderer, line4, 2);

        SDL_Point line5[] = { {0, 600}, {600, 0} };
        SDL_SetRenderDrawColor(renderer, 238, 130, 238, 255); // COLOR_VIOLET
        SDL_RenderDrawLines(renderer, line5, 2);

        SDL_Point line6[] = { {150, 0}, {450, 600} };
        SDL_SetRenderDrawColor(renderer, 127, 0, 127, 255); // COLOR_PURPLE
        SDL_RenderDrawLines(renderer, line6, 2);

        SDL_Point line7[] = { {300, 0}, {300, 600} };
        SDL_SetRenderDrawColor(renderer, 255, 192, 203, 255); // COLOR_PINK
        SDL_RenderDrawLines(renderer, line7, 2);

        SDL_Point line8[] = { {450, 0}, {150, 600} };
        SDL_SetRenderDrawColor(renderer, 255, 0, 0, 255); // COLOR_RED
        SDL_RenderDrawLines(renderer, line8, 2);

        SDL_Point line9[] = { {600, 0}, {0, 600} };
        SDL_SetRenderDrawColor(renderer, 255, 165, 0, 255); // COLOR_ORANGE
        SDL_RenderDrawLines(renderer, line9, 2);
        
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

