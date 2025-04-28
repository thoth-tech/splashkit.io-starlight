#include <iostream>
#ifdef __APPLE__
#include <SDL.h>
#else
#include <SDL2/SDL.h>
#endif

struct Point_2D
{
    unsigned int x;
    unsigned int y;
};

struct Color_RGB
{
    Uint8 red;
    Uint8 green;
    Uint8 blue;
};

void draw_quad_rgb(SDL_Renderer * renderer, Point_2D pt_1, Point_2D pt_2, Point_2D pt_3, Point_2D pt_4, Color_RGB color)
{
    // Set the line color
    SDL_SetRenderDrawBlendMode(renderer, SDL_BLENDMODE_NONE);
    SDL_SetRenderDrawColor(renderer, color.red, color.green, color.blue, 255);

    // Draw quad on the surface attached to renderer
    SDL_RenderDrawLine(renderer, pt_1.x, pt_1.y, pt_2.x, pt_2.y);
    SDL_RenderDrawLine(renderer, pt_1.x, pt_1.y, pt_3.x, pt_3.y);
    SDL_RenderDrawLine(renderer, pt_4.x, pt_4.y, pt_2.x, pt_2.y);
    SDL_RenderDrawLine(renderer, pt_4.x, pt_4.y, pt_3.x, pt_3.y);
}

SDL_Window *sdl_open_window(const char *window_title, const int width, const int height)
{
    // Initialize the window pointer
    SDL_Window *window = nullptr;

    // Initialize the SDL library and check if unsuccessful
    if (SDL_Init(SDL_INIT_VIDEO) < 0)
    {
        std::cout << "SDL could not be initialized: " << SDL_GetError();
        exit(1);
    }

    // Create a window
    window = SDL_CreateWindow(
        window_title,
        SDL_WINDOWPOS_CENTERED,
        SDL_WINDOWPOS_CENTERED,
        width,
        height,
        SDL_WINDOW_OPENGL);

    // Check if window creation was unsuccessful
    if (window == NULL)
    {
        SDL_LogError(SDL_LOG_CATEGORY_ERROR, "Could not create window: %s\n", SDL_GetError());
        exit(1);
    }

    return window;
}

int main(int argv, char **args)
{
    SDL_Window *window = sdl_open_window("Ninja Star", 600, 600);

    // Create a renderer by attaching the window
    SDL_Renderer *renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);
    
    // Check if renderer creation was unsuccessful
    if (renderer == NULL)
    {
        SDL_LogError(SDL_LOG_CATEGORY_ERROR, "Could not create rederer: %s\n", SDL_GetError());
        exit(1);
    }

    // Clear screen with white color
    SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
    SDL_RenderClear(renderer);

    // Draw a ninja star using four quads
    draw_quad_rgb(renderer, {400, 200}, {300, 300}, {300, 0}, {200, 200}, {0, 0, 0});
    draw_quad_rgb(renderer, {400, 210}, {310, 300}, {600, 300}, {400, 390}, {0, 127, 0});
    draw_quad_rgb(renderer, {200, 400}, {300, 300}, {300, 600}, {400, 400}, {255, 0, 0});
    draw_quad_rgb(renderer, {200, 390}, {290, 300}, {0, 300}, {200, 210}, {0, 0, 255});

    // Render the frame onto the window
    SDL_RenderPresent(renderer);

    // Wait for 5 seconds before exiting
    SDL_Delay(5000);

    // Clean up and free memory
    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();

    return 0;
}