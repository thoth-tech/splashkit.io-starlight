#include <SDL2/SDL.h>
#include <SDL2/SDL2_gfxPrimitives.h>
#include <cstdlib>
#include <ctime>

void draw_circle_sdl(SDL_Renderer* renderer, int cx, int cy, int r, SDL_Color color) {
    
    circleRGBA(renderer, cx, cy, r, color.r, color.g, color.b, color.a);
}

int main(int argc, char* argv[]) {
    SDL_Init(SDL_INIT_VIDEO);
    SDL_Window* window = SDL_CreateWindow(
        "Bubbles",
        SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED,
        800, 600,
        SDL_WINDOW_SHOWN
    );
    SDL_Renderer* renderer = SDL_CreateRenderer(
        window, -1, SDL_RENDERER_ACCELERATED
    );

    SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
    SDL_RenderClear(renderer);

    std::srand(static_cast<unsigned int>(std::time(nullptr)));

    for (int i = 0; i < 50; i++) {
        // Set random circle values
        int x      = std::rand() % 800;
        int y      = std::rand() % 600;
        int radius = std::rand() % 50;
        SDL_Color color = {
            static_cast<Uint8>(std::rand() % 256),
            static_cast<Uint8>(std::rand() % 256),
            static_cast<Uint8>(std::rand() % 256),
            255
        };

        // Draw the circle outline on the random data
        draw_circle_sdl(renderer, x, y, radius, color);
    }

    SDL_RenderPresent(renderer);
    SDL_Delay(4000);

    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();
    return 0;
}
