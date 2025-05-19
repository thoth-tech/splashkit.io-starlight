#include <SDL2/SDL.h>
#include <SDL2/SDL2_gfxPrimitives.h>
#include <iostream>

// Helper to draw filled circles on a bitmap (SDL_Renderer)
void fill_circle_on_bitmap(SDL_Renderer* ren, int x, int y, int radius, SDL_Color color)
{
    filledCircleRGBA(ren, x, y, radius, color.r, color.g, color.b, color.a);
}

// Helper to draw lines on a bitmap (SDL_Renderer)
void draw_line_on_bitmap(SDL_Renderer* ren, int x1, int y1, int x2, int y2, SDL_Color color)
{
    lineRGBA(ren, x1, y1, x2, y2, color.r, color.g, color.b, color.a);
}


int SDL_main(int argc, char* argv[])
{
    // Create a Window and bitmap for the map
    SDL_Init(SDL_INIT_VIDEO);
    SDL_Window* window = SDL_CreateWindow("Window", SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED, 400, 300, 0);
    SDL_Renderer* renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);

    // Fill background with white
    SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
    SDL_RenderClear(renderer);

    // Draw the route line and points
    draw_line_on_bitmap(renderer, 100, 80, 300, 220, SDL_Color{0, 255, 0, 255});  // Starting point (x1, y1) to End point (x2, y2)
    fill_circle_on_bitmap(renderer, 100, 80, 5, SDL_Color{255, 0, 0, 255});  // Start point
    fill_circle_on_bitmap(renderer, 300, 220, 5, SDL_Color{255, 0, 0, 255}); // End point
    

    SDL_RenderPresent(renderer);

    
    bool running = true;
    SDL_Event evt;
    while (running)
    {
        while (SDL_PollEvent(&evt))
        {
            if (evt.type == SDL_QUIT)
                running = false;
        }
        SDL_Delay(16); 
    }

    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();

    return 0;
}
