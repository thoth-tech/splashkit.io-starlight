#define SDL_MAIN_HANDLED
#include <iostream>
#include <random>
#include <SDL2/SDL.h>
#include <SDL2/SDL2_gfxPrimitives.h>

SDL_Color random_rgb_color(std::mt19937 &rng) {
    std::uniform_int_distribution<int> dist(0, 255);
    return SDL_Color{Uint8(dist(rng)), Uint8(dist(rng)), Uint8(dist(rng)), 255};
}

int main(int argc, char **argv)
{
    SDL_Init(SDL_INIT_VIDEO);

    SDL_Window* window = SDL_CreateWindow(
        "Draw Ellipse (Beyond SplashKit)",
        SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED,
        800, 600, SDL_WINDOW_SHOWN);

    SDL_Renderer* renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);

    // Clear screen to white
    SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
    SDL_RenderClear(renderer);

    std::random_device rd;
    std::mt19937 rng(rd());

    // Draw 30 ellipses, THIN outline only, not filled
    for (int i = 0; i < 30; i++)
    {
        int width  = 600 - i * 20;
        int height = 400 - i * 10;
        int x      = 100 + i * 10 + width  / 2; // Center X
        int y      = 100 + i * 5  + height / 2; // Center Y

        SDL_Color color = random_rgb_color(rng);

        // Draw *outline only*, not filled!
        ellipseRGBA(renderer, x, y, width / 2, height / 2, color.r, color.g, color.b, color.a);
    }

    SDL_RenderPresent(renderer);

    SDL_Delay(4000);

    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();
    return 0;
}
