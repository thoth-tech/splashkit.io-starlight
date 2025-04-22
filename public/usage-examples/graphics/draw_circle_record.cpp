#include <SDL2/SDL.h>
#include <cmath>

// Function to draw a circle using SDL_RenderDrawPoint
void draw_circle(SDL_Renderer* renderer, int center_x, int center_y, int radius, SDL_Color color)
{
    SDL_SetRenderDrawColor(renderer, color.r, color.g, color.b, color.a);
    for (int w = 0; w < radius * 2; w++)
    {
        for (int h = 0; h < radius * 2; h++)
        {
            int dx = radius - w; // horizontal offset
            int dy = radius - h; // vertical offset
            if ((dx*dx + dy*dy) <= (radius * radius))
            {
                SDL_RenderDrawPoint(renderer, center_x + dx, center_y + dy);
            }
        }
    }
}

int main(int argc, char* argv[])
{
    SDL_Init(SDL_INIT_VIDEO);

    SDL_Window* window = SDL_CreateWindow("Draw Circles",
                                          SDL_WINDOWPOS_CENTERED,
                                          SDL_WINDOWPOS_CENTERED,
                                          800, 600,
                                          SDL_WINDOW_SHOWN);

    SDL_Renderer* renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);

    // Define center point
    int center_x = 400;
    int center_y = 300;

    // Define colors
    SDL_Color red = {255, 0, 0, 255};
    SDL_Color blue = {0, 0, 255, 255};
    SDL_Color orange = {255, 165, 0, 255};
    SDL_Color green = {0, 255, 0, 255};

    // Clear screen with white background
    SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
    SDL_RenderClear(renderer);

    // Draw circles with different radii and colors
    draw_circle(renderer, center_x, center_y, 50, red);
    draw_circle(renderer, center_x, center_y, 100, blue);
    draw_circle(renderer, center_x, center_y, 150, orange);
    draw_circle(renderer, center_x, center_y, 200, green);

    // Present the renderer
    SDL_RenderPresent(renderer);

    // Wait for 4 seconds
    SDL_Delay(4000);

    // Clean up
    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();

    return 0;
}
