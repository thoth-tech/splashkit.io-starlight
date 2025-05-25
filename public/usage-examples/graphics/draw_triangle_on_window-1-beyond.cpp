#define SDL_MAIN_HANDLED
#include <iostream>
#ifdef __APPLE__
#include <SDL.h>
#else
#include <SDL2/SDL.h>
#endif


SDL_Color random_rgb_color(Uint8 max_val = 255) {
    return SDL_Color{
        static_cast<Uint8>(rand() % (max_val + 1)),
        static_cast<Uint8>(rand() % (max_val + 1)),
        static_cast<Uint8>(rand() % (max_val + 1)),
        255
    };
}

void draw_triangle(SDL_Renderer* renderer, SDL_Color color, int x_offset) {
    SDL_SetRenderDrawColor(renderer, color.r, color.g, color.b, color.a);
    SDL_Point points[4] = {
        {0 + x_offset, 0},
        {20 + x_offset, 40},
        {40 + x_offset, 0},
        {0 + x_offset, 0} // Close triangle
    };
    SDL_RenderDrawLines(renderer, points, 4);
}

int main(int argc, char* argv[]) {
    if (SDL_Init(SDL_INIT_VIDEO) != 0) {
        std::cerr << "SDL_Init Error: " << SDL_GetError() << std::endl;
        return 1;
    }

    SDL_Window* window = SDL_CreateWindow("Draw Triangle on Window (Beyond SplashKit)",
                                          SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED,
                                          800, 600, SDL_WINDOW_SHOWN);
    if (!window) {
        std::cerr << "Window creation failed: " << SDL_GetError() << std::endl;
        SDL_Quit();
        return 1;
    }

    SDL_Renderer* renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);
    if (!renderer) {
        std::cerr << "Renderer creation failed: " << SDL_GetError() << std::endl;
        SDL_DestroyWindow(window);
        SDL_Quit();
        return 1;
    }

    // Clear background to white
    SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
    SDL_RenderClear(renderer);

    // Draw 20 triangles with random color and increasing x
    for (int i = 0; i < 20; ++i) {
        int x_offset = 40 * i;
        SDL_Color color = random_rgb_color(255);
        draw_triangle(renderer, color, x_offset);
    }

    SDL_RenderPresent(renderer);

    // Wait 4000ms or until window closed
    Uint32 start = SDL_GetTicks();
    SDL_Event e;
    bool running = true;
    while (running && SDL_GetTicks() - start < 4000) {
        while (SDL_PollEvent(&e)) {
            if (e.type == SDL_QUIT) running = false;
        }
        SDL_Delay(16);
    }

    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();
    return 0;
}
