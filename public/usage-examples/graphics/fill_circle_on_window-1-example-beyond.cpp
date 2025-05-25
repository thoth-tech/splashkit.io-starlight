#define SDL_MAIN_HANDLED
#include <SDL2/SDL.h>
#include <SDL2/SDL2_gfxPrimitives.h>
#include <iostream>

// Draws a filled circle at (x, y) with a given radius and color
void fill_circle_on_window(SDL_Renderer* renderer, const SDL_Color& color, int x, int y, int radius) {
    filledCircleRGBA(renderer, x, y, radius, color.r, color.g, color.b, color.a);
}

int main(int argc, char* argv[]) {
    // Initialize SDL
    if (SDL_Init(SDL_INIT_VIDEO) < 0) {
        std::cerr << "SDL_Init Error: " << SDL_GetError() << std::endl;
        return 1;
    }

    // Create window
    SDL_Window* window = SDL_CreateWindow(
        "Traffic Lights",
        SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED,
        800, 600, 0
    );
    if (!window) {
        std::cerr << "SDL_CreateWindow Error: " << SDL_GetError() << std::endl;
        SDL_Quit();
        return 1;
    }

    // Create renderer
    SDL_Renderer* renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);
    if (!renderer) {
        std::cerr << "SDL_CreateRenderer Error: " << SDL_GetError() << std::endl;
        SDL_DestroyWindow(window);
        SDL_Quit();
        return 1;
    }

    // Enable alpha blending (optional, for future transparency use)
    SDL_SetRenderDrawBlendMode(renderer, SDL_BLENDMODE_BLEND);

    // Define traffic light colors
    const SDL_Color RED    = {255,   0,   0, 255};
    const SDL_Color YELLOW = {255, 255,   0, 255};
    const SDL_Color GREEN  = {  0, 255,   0, 255};

    // Clear window to white
    SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
    SDL_RenderClear(renderer);

    // Draw traffic light circles
    fill_circle_on_window(renderer, RED,    400, 100, 50);
    fill_circle_on_window(renderer, YELLOW, 400, 250, 50);
    fill_circle_on_window(renderer, GREEN,  400, 400, 50);

    SDL_RenderPresent(renderer);

    // Keep the window open for 5 seconds or until closed
    const int FRAME_DELAY = 16; // milliseconds
    Uint32 start_time = SDL_GetTicks();
    SDL_Event event;
    bool running = true;

    while (running) {
        while (SDL_PollEvent(&event)) {
            if (event.type == SDL_QUIT)
                running = false;
        }
        if (SDL_GetTicks() - start_time >= 5000)
            running = false;
        SDL_Delay(FRAME_DELAY);
    }

    // Cleanup resources
    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();
    return 0;
}
