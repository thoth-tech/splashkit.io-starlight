#define SDL_MAIN_HANDLED
#include <SDL2/SDL.h>
#include <chrono>
#include <thread>

// Simple delay function
void delay_ms(int milliseconds) {
    std::this_thread::sleep_for(std::chrono::milliseconds(milliseconds));
}

// Function to draw a filled triangle using lines
void draw_triangle(SDL_Renderer* renderer) {
    // Define the triangle points (roof)
    SDL_Point top = {400, 150};     // Top point
    SDL_Point left = {250, 300};    // Left bottom
    SDL_Point right = {550, 300};   // Right bottom

    // Draw lines to fill the triangle row by row
    for (int y = top.y; y <= left.y; y++) {
        float ratio = (float)(y - top.y) / (left.y - top.y);
        int startX = top.x + (left.x - top.x) * ratio;
        int endX = top.x + (right.x - top.x) * ratio;
        SDL_RenderDrawLine(renderer, startX, y, endX, y);
    }
}

int main() {
    SDL_Init(SDL_INIT_VIDEO); // Start SDL

    // Create a window
    SDL_Window* window = SDL_CreateWindow("Simple House Drawing",
                                          SDL_WINDOWPOS_CENTERED,
                                          SDL_WINDOWPOS_CENTERED,
                                          800, 600, 0);

    // Create a renderer to draw on the window
    SDL_Renderer* renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);

    // Clear the screen with white
    SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255); // White
    SDL_RenderClear(renderer);
    SDL_RenderPresent(renderer);
    delay_ms(1000);

    // Draw green ground (rectangle)
    SDL_SetRenderDrawColor(renderer, 0, 255, 0, 255); // Green
    SDL_Rect ground = {0, 400, 800, 200};
    SDL_RenderFillRect(renderer, &ground);
    SDL_RenderPresent(renderer);
    delay_ms(1000);

    // Draw gray house (rectangle)
    SDL_SetRenderDrawColor(renderer, 150, 150, 150, 255); // Gray
    SDL_Rect house = {300, 300, 200, 200};
    SDL_RenderFillRect(renderer, &house);
    SDL_RenderPresent(renderer);
    delay_ms(1000);

    // Draw red roof (triangle)
    SDL_SetRenderDrawColor(renderer, 255, 0, 0, 255); // Red
    draw_triangle(renderer);
    SDL_RenderPresent(renderer);
    delay_ms(5000);

    // Clean up
    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();

    return 0;
}
