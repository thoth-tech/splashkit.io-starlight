#include <iostream>
#include <cstdlib>
#include <ctime>
#ifdef __APPLE__
#include <SDL.h>
#else
#include <SDL2/SDL.h>
#endif

// Helper function to draw a filled ellipse
void fill_ellipse(SDL_Renderer *renderer, int cx, int cy, int rx, int ry)
{
    for (int y = -ry; y <= ry; ++y)
    {
        // Calculate the corresponding x radius using the ellipse equation
        int dx = static_cast<int>(rx * std::sqrt(1.0 - (y * y) / static_cast<double>(ry * ry)));
        SDL_RenderDrawLine(renderer, cx - dx, cy + y, cx + dx, cy + y);
    }
}

int main(int argc, char **argv)
{
    SDL_Window *window = nullptr;

    if (SDL_Init(SDL_INIT_VIDEO) < 0)
    {
        std::cout << "SDL could not be initialized: " << SDL_GetError();
        return 1;
    }

    window = SDL_CreateWindow(
        "Fill Ellipse",
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

    SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
    SDL_RenderClear(renderer);

    // SplashKit uses top-left x, y and width/height; SDL version uses center and radius, so values of the ellipse and the rectangle differ
    SDL_SetRenderDrawColor(renderer, 0, 0, 255, 255); // Blue
    int centerX = 400;
    int centerY = 300;
    int radiusX = 200;
    int radiusY = 100;
    fill_ellipse(renderer, centerX, centerY, radiusX, radiusY);

    // Set drawing color to red and draw the rectangle around ellipse
    SDL_SetRenderDrawColor(renderer, 255, 0, 0, 255); // Red
    SDL_Rect rect = {200, 200, 400, 200};
    SDL_RenderDrawRect(renderer, &rect);

    SDL_RenderPresent(renderer);
    SDL_Delay(5000);
    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);

    return 0;
}
