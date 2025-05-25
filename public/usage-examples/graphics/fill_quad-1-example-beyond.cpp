#define SDL_MAIN_HANDLED
#include <SDL2/SDL.h>
#include <SDL2/SDL2_gfxPrimitives.h>
#include <iostream>

// Helper to fill a quad (polygon with 4 points) with color
void fill_quad_on_window(SDL_Renderer* renderer, const SDL_Color& color, const Sint16* vx, const Sint16* vy)
{
    filledPolygonRGBA(renderer, vx, vy, 4, color.r, color.g, color.b, color.a);
}

int main()
{
    // Define color variables
    const SDL_Color BLACK = {0, 0, 0, 255};
    const SDL_Color GREEN = {0, 255, 0, 255};
    const SDL_Color RED   = {255, 0, 0, 255};
    const SDL_Color BLUE  = {0, 0, 255, 255};
    const SDL_Color WHITE = {255, 255, 255, 255};

    // Create two windows and their renderers
    SDL_Init(SDL_INIT_VIDEO);
    SDL_Window* window1 = SDL_CreateWindow("Filled Diamond On Window 1", SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED, 600, 600, SDL_WINDOW_SHOWN);
    SDL_Window* window2 = SDL_CreateWindow("Filled Diamond On Window 2", SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED, 600, 600, SDL_WINDOW_SHOWN);
    SDL_Renderer* renderer1 = SDL_CreateRenderer(window1, -1, SDL_RENDERER_ACCELERATED);
    SDL_Renderer* renderer2 = SDL_CreateRenderer(window2, -1, SDL_RENDERER_ACCELERATED);

    // Position windows side by side
    int x, y;
    SDL_GetWindowPosition(window1, &x, &y);
    SDL_SetWindowPosition(window2, x + 600, y);

    // Quads defined by their x and y coordinates
    Sint16 q1_x[4] = {400, 300, 300, 200};
    Sint16 q1_y[4] = {200, 300,   0, 200};
    Sint16 q2_x[4] = {400, 310, 600, 400};
    Sint16 q2_y[4] = {210, 300, 300, 390};
    Sint16 q3_x[4] = {200, 300, 300, 400};
    Sint16 q3_y[4] = {400, 300, 600, 400};
    Sint16 q4_x[4] = {200, 290,   0, 200};
    Sint16 q4_y[4] = {390, 300, 300, 210};

    // Fill background to white
    SDL_SetRenderDrawColor(renderer1, WHITE.r, WHITE.g, WHITE.b, WHITE.a);
    SDL_RenderClear(renderer1);
    SDL_SetRenderDrawColor(renderer2, WHITE.r, WHITE.g, WHITE.b, WHITE.a);
    SDL_RenderClear(renderer2);

    // Draw the first and second quad on the first window
    fill_quad_on_window(renderer1, BLACK, q1_x, q1_y);
    fill_quad_on_window(renderer1, GREEN, q2_x, q2_y);

    // Draw the third and fourth quad on the second window
    fill_quad_on_window(renderer2, RED, q3_x, q3_y);
    fill_quad_on_window(renderer2, BLUE, q4_x, q4_y);

    SDL_RenderPresent(renderer1);
    SDL_RenderPresent(renderer2);

    // Keep windows open for 5 seconds
    Uint32 start_time = SDL_GetTicks();
    bool running = true;
    SDL_Event event;
    while (running && SDL_GetTicks() - start_time < 5000) {
        while (SDL_PollEvent(&event)) {
            if (event.type == SDL_QUIT) running = false;
        }
        SDL_Delay(16);
    }

    SDL_DestroyRenderer(renderer1);
    SDL_DestroyWindow(window1);
    SDL_DestroyRenderer(renderer2);
    SDL_DestroyWindow(window2);
    SDL_Quit();
    return 0;
}
