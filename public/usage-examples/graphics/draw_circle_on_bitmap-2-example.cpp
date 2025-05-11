#include <SDL2/SDL.h>
#include <SDL2/SDL2_gfxPrimitives.h>
#include <iostream>

const int WIDTH = 800;
const int HEIGHT = 600;

int main(int argc, char* argv[])
{
    if (SDL_Init(SDL_INIT_VIDEO) != 0)
    {
        std::cout << "SDL Init failed: " << SDL_GetError() << std::endl;
        return 1;
    }

    SDL_Window* window = SDL_CreateWindow("Nested Circles Bitmap",
                                          SDL_WINDOWPOS_CENTERED,
                                          SDL_WINDOWPOS_CENTERED,
                                          WIDTH,
                                          HEIGHT,
                                          SDL_WINDOW_SHOWN);

    if (!window)
    {
        std::cout << "Window creation failed: " << SDL_GetError() << std::endl;
        SDL_Quit();
        return 1;
    }

    SDL_Renderer* renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);
    if (!renderer)
    {
        std::cout << "Renderer creation failed: " << SDL_GetError() << std::endl;
        SDL_DestroyWindow(window);
        SDL_Quit();
        return 1;
    }

    // Create a texture (simulate a bitmap area)
    SDL_Texture* canvas = SDL_CreateTexture(renderer,
                                            SDL_PIXELFORMAT_RGBA8888,
                                            SDL_TEXTUREACCESS_TARGET,
                                            300,
                                            300);

    if (!canvas)
    {
        std::cout << "Texture creation failed: " << SDL_GetError() << std::endl;
        SDL_DestroyRenderer(renderer);
        SDL_DestroyWindow(window);
        SDL_Quit();
        return 1;
    }

    // Draw into the texture
    SDL_SetRenderTarget(renderer, canvas);
    SDL_SetRenderDrawColor(renderer, 128, 128, 128, 255); // grey bg
    SDL_RenderClear(renderer);

    // Coordinates for center
    int centerX = 150;
    int centerY = 150;

    // Define circle thickness
    int circleThickness = 20;

    // Draw circles with specific colors and same thickness
    filledCircleRGBA(renderer, centerX, centerY, 100, 255, 0, 0, 255);  // Red circle
    filledCircleRGBA(renderer, centerX, centerY, 100 - circleThickness, 0, 255, 0, 255);  // Green circle
    filledCircleRGBA(renderer, centerX, centerY, 100 - 2 * circleThickness, 128, 128, 128, 255);  // Yellow circle

    SDL_SetRenderTarget(renderer, nullptr);

    bool running = true;
    SDL_Event evt;

    while (running)
    {
        while (SDL_PollEvent(&evt))
        {
            if (evt.type == SDL_QUIT)
                running = false;
        }

        SDL_SetRenderDrawColor(renderer, 0, 0, 0, 255); // screen bg black
        SDL_RenderClear(renderer);

        SDL_Rect dest = {250, 150, 300, 300};
        SDL_RenderCopy(renderer, canvas, nullptr, &dest);

        SDL_RenderPresent(renderer);
    }

    SDL_DestroyTexture(canvas);
    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();

    return 0;
}
