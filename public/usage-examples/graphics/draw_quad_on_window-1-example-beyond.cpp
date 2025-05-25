#define SDL_MAIN_HANDLED  // Prevent SDL from redefining main

#include <SDL2/SDL.h>
#include <SDL2/SDL_render.h>

// Helper: Draw a quad (polygon with 4 points)
void draw_quad(SDL_Renderer* renderer, SDL_Color color, const SDL_Point* points) {
    SDL_SetRenderDrawColor(renderer, color.r, color.g, color.b, color.a);
    SDL_RenderDrawLines(renderer, points, 5); // 4 points + closing line
}

int main() {
    // Define quad points (diamonds) as arrays of SDL_Point
    SDL_Point q1[5] = {{400, 200}, {300, 300}, {300, 0}, {200, 200}, {400, 200}};
    SDL_Point q2[5] = {{400, 210}, {310, 300}, {600, 300}, {400, 390}, {400, 210}};
    SDL_Point q3[5] = {{200, 400}, {300, 300}, {300, 600}, {400, 400}, {200, 400}};
    SDL_Point q4[5] = {{200, 390}, {290, 300}, {0, 300}, {200, 210}, {200, 390}};

    // Initialize SDL
    if (SDL_Init(SDL_INIT_VIDEO) != 0) {
        SDL_Log("Unable to initialize SDL: %s", SDL_GetError());
        return 1;
    }

    // Create two windows side by side
    SDL_Window* window_1 = SDL_CreateWindow(
        "Diamonds On Window 1",
        SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED,
        600, 600, SDL_WINDOW_SHOWN
    );
    SDL_Window* window_2 = SDL_CreateWindow(
        "Diamonds On Window 2",
        SDL_WINDOWPOS_CENTERED + 600, SDL_WINDOWPOS_CENTERED, // Offset position
        600, 600, SDL_WINDOW_SHOWN
    );
    if (!window_1 || !window_2) {
        SDL_Log("Unable to create windows: %s", SDL_GetError());
        if (window_1) SDL_DestroyWindow(window_1);
        if (window_2) SDL_DestroyWindow(window_2);
        SDL_Quit();
        return 1;
    }

    // Create renderers for both windows
    SDL_Renderer* renderer_1 = SDL_CreateRenderer(window_1, -1, SDL_RENDERER_ACCELERATED);
    SDL_Renderer* renderer_2 = SDL_CreateRenderer(window_2, -1, SDL_RENDERER_ACCELERATED);
    if (!renderer_1 || !renderer_2) {
        SDL_Log("Unable to create renderers: %s", SDL_GetError());
        if (renderer_1) SDL_DestroyRenderer(renderer_1);
        if (renderer_2) SDL_DestroyRenderer(renderer_2);
        SDL_DestroyWindow(window_1);
        SDL_DestroyWindow(window_2);
        SDL_Quit();
        return 1;
    }

    // Clear both screens to white
    SDL_SetRenderDrawColor(renderer_1, 255, 255, 255, 255);
    SDL_RenderClear(renderer_1);
    SDL_SetRenderDrawColor(renderer_2, 255, 255, 255, 255);
    SDL_RenderClear(renderer_2);

    // Draw quads on window 1
    draw_quad(renderer_1, SDL_Color{0, 0, 0, 255}, q1);      // Black
    draw_quad(renderer_1, SDL_Color{0, 255, 0, 255}, q2);     // Green

    // Draw quads on window 2
    draw_quad(renderer_2, SDL_Color{255, 0, 0, 255}, q3);     // Red
    draw_quad(renderer_2, SDL_Color{0, 0, 255, 255}, q4);     // Blue

    SDL_RenderPresent(renderer_1);
    SDL_RenderPresent(renderer_2);

    // Wait for 5 seconds, respond to quit events for both windows
    Uint32 start = SDL_GetTicks();
    SDL_Event event;
    bool running = true;
    while (running && SDL_GetTicks() - start < 5000) {
        while (SDL_PollEvent(&event)) {
            if (event.type == SDL_QUIT)
                running = false;
        }
        SDL_Delay(16);
    }

    // Cleanup
    SDL_DestroyRenderer(renderer_1);
    SDL_DestroyRenderer(renderer_2);
    SDL_DestroyWindow(window_1);
    SDL_DestroyWindow(window_2);
    SDL_Quit();

    return 0;
}
