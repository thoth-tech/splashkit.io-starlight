#include <SDL2/SDL.h>
#include <cmath>
#include <cstdlib>
#include <ctime>

// Function to draw a circle using SDL2 (no SplashKit)
void draw_circle_sdl(SDL_Renderer* renderer, int centerX, int centerY, int radius, SDL_Color color)
{
    SDL_SetRenderDrawColor(renderer, color.r, color.g, color.b, color.a);
    
    // Midpoint circle algorithm
    int x = radius;
    int y = 0;
    int err = 0;

    while (x >= y)
    {
        SDL_RenderDrawPoint(renderer, centerX + x, centerY + y);
        SDL_RenderDrawPoint(renderer, centerX + y, centerY + x);
        SDL_RenderDrawPoint(renderer, centerX - y, centerY + x);
        SDL_RenderDrawPoint(renderer, centerX - x, centerY + y);
        SDL_RenderDrawPoint(renderer, centerX - x, centerY - y);
        SDL_RenderDrawPoint(renderer, centerX - y, centerY - x);
        SDL_RenderDrawPoint(renderer, centerX + y, centerY - x);
        SDL_RenderDrawPoint(renderer, centerX + x, centerY - y);

        if (err <= 0)
        {
            y += 1;
            err += 2*y + 1;
        }
        if (err > 0)
        {
            x -= 1;
            err -= 2*x + 1;
        }
    }
}

int main(int argc, char* argv[])
{
    // Initialize random number generator
    std::srand(std::time(nullptr));

    // Initialize SDL
    if (SDL_Init(SDL_INIT_VIDEO) < 0) {
        SDL_Log("SDL initialization failed: %s", SDL_GetError());
        return 1;
    }

    // Create window
    SDL_Window* window = SDL_CreateWindow(
        "Bubbles (Beyond SplashKit)",
        SDL_WINDOWPOS_CENTERED,
        SDL_WINDOWPOS_CENTERED,
        800, 600,
        SDL_WINDOW_SHOWN);

    if (!window) {
        SDL_Log("Window creation failed: %s", SDL_GetError());
        SDL_Quit();
        return 1;
    }

    // Create renderer
    SDL_Renderer* renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);
    if (!renderer) {
        SDL_Log("Renderer creation failed: %s", SDL_GetError());
        SDL_DestroyWindow(window);
        SDL_Quit();
        return 1;
    }

    // Clear screen to white
    SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
    SDL_RenderClear(renderer);

    // Draw 50 random circles
    for (int i = 0; i < 50; i++)
    {
        // Generate random values
        int x = std::rand() % 800;
        int y = std::rand() % 600;
        int radius = 10 + (std::rand() % 40); // Radius between 10-50
        SDL_Color color = {
            static_cast<Uint8>(std::rand() % 256),
            static_cast<Uint8>(std::rand() % 256),
            static_cast<Uint8>(std::rand() % 256),
            255
        };

        // Draw the circle
        draw_circle_sdl(renderer, x, y, radius, color);
    }

    // Update screen
    SDL_RenderPresent(renderer);

    // Wait 4 seconds
    SDL_Delay(4000);

    // Cleanup
    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();

    return 0;
}