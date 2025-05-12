#define SDL_MAIN_HANDLED  // Prevent SDL from redefining main

#include <SDL2/SDL.h>
#include <SDL2/SDL_render.h>

int main() {
    // Initialize SDL
    if (SDL_Init(SDL_INIT_VIDEO) != 0) {
        SDL_Log("Unable to initialize SDL: %s", SDL_GetError());
        return 1;
    }

    // Create the main window
    SDL_Window *window = SDL_CreateWindow("Draw Quad on Bitmap (Beyond SplashKit)",
                                           SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED,
                                           800, 600, SDL_WINDOW_SHOWN);
    if (!window) {
        SDL_Log("Unable to create window: %s", SDL_GetError());
        SDL_Quit();
        return 1;
    }

    // Create a renderer
    SDL_Renderer *renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);
    if (!renderer) {
        SDL_Log("Unable to create renderer: %s", SDL_GetError());
        SDL_DestroyWindow(window);
        SDL_Quit();
        return 1;
    }

    // Main loop flag
    bool running = true;
    SDL_Event event;

    while (running) {
        while (SDL_PollEvent(&event)) {
            if (event.type == SDL_QUIT) running = false;
        }

        // Clear screen with white color
        SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
        SDL_RenderClear(renderer);

        // Set drawing color to blue
        SDL_SetRenderDrawColor(renderer, 0, 0, 255, 255);

        // Define the front and back faces of the cube
        SDL_Point frontFace[5] = {{300, 200}, {500, 200}, {500, 400}, {300, 400}, {300, 200}};
        SDL_Point backFace[5] = {{350, 150}, {550, 150}, {550, 350}, {350, 350}, {350, 150}};

        // Draw faces
        SDL_RenderDrawLines(renderer, frontFace, 5);
        SDL_RenderDrawLines(renderer, backFace, 5);

        // Connect edges between faces
        SDL_RenderDrawLine(renderer, 300, 200, 350, 150);
        SDL_RenderDrawLine(renderer, 500, 200, 550, 150);
        SDL_RenderDrawLine(renderer, 300, 400, 350, 350);
        SDL_RenderDrawLine(renderer, 500, 400, 550, 350);

        // Present the frame
        SDL_RenderPresent(renderer);

        SDL_Delay(16);  // ~60 FPS
    }

    // Cleanup
    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();

    return 0;
}