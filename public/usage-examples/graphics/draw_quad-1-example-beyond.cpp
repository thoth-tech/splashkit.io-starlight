#include <iostream>
#ifdef __APPLE__
#include <SDL.h>
#else
#include <SDL2/SDL.h>
#endif

struct Quad 
{
    SDL_Point points[4];
};

Quad quad_from(int x_top_left, int y_top_left,
    int x_top_right, int y_top_right,
    int x_bottom_left, int y_bottom_left,
    int x_bottom_right, int y_bottom_right)
{
    Quad result;
    result.points[0].x = x_top_left;
    result.points[0].y = y_top_left;
    result.points[1].x = x_top_right;
    result.points[1].y = y_top_right;
    result.points[2].x = x_bottom_left;
    result.points[2].y = y_bottom_left;
    result.points[3].x = x_bottom_right;
    result.points[3].y = y_bottom_right;
    return result;
}

void draw_quad(SDL_Renderer * renderer, SDL_Color clr, Quad q)
{
    // Set the line color
    SDL_SetRenderDrawBlendMode(renderer, SDL_BLENDMODE_NONE);
    SDL_SetRenderDrawColor(renderer, clr.r, clr.g, clr.b, clr.a);

    // Draw the edges of the quad
    SDL_RenderDrawLine(renderer, q.points[0].x, q.points[0].y, q.points[1].x, q.points[1].y);
    SDL_RenderDrawLine(renderer, q.points[0].x, q.points[0].y, q.points[2].x, q.points[2].y);
    SDL_RenderDrawLine(renderer, q.points[3].x, q.points[3].y, q.points[1].x, q.points[1].y);
    SDL_RenderDrawLine(renderer, q.points[3].x, q.points[3].y, q.points[2].x, q.points[2].y);
}

int main(int argv, char **args)
{
    // Declare variables
    Quad q1 = quad_from(400, 200, 300, 300, 300, 0, 200, 200);
    Quad q2 = quad_from(400, 210, 310, 300, 600, 300, 400, 390);
    Quad q3 = quad_from(200, 400, 300, 300, 300, 600, 400, 400);
    Quad q4 = quad_from(200, 390, 290, 300, 0, 300, 200, 210);
    
    SDL_Window *window = nullptr;

    // Check if SDL was successfully initialized
    if (SDL_Init(SDL_INIT_VIDEO) < 0)
    {
        std::cout << "SDL could not be initialized: " << SDL_GetError();
        exit(1);
    }

    // Create window
    window = SDL_CreateWindow(
        "Ninja Star",
        SDL_WINDOWPOS_CENTERED,
        SDL_WINDOWPOS_CENTERED,
        600,
        600,
        SDL_WINDOW_OPENGL
    );

    if (window == NULL)
    {
        SDL_LogError(SDL_LOG_CATEGORY_ERROR, "Could not create window: %s\n", SDL_GetError());
        exit(1);
    }

    // Create renderer
    SDL_Renderer *renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);
    
    if (renderer == NULL)
    {
        SDL_LogError(SDL_LOG_CATEGORY_ERROR, "Could not create rederer: %s\n", SDL_GetError());
        exit(1);
    }

    // Clear screen with white color
    SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
    SDL_RenderClear(renderer);

    // Draw the ninja star
    draw_quad(renderer, {0, 0, 0, 255}, q1);
    draw_quad(renderer, {0, 127, 0, 255}, q2);
    draw_quad(renderer, {255, 0, 0, 255}, q3);
    draw_quad(renderer, {0, 0, 255, 255}, q4);

    // Display the drawing for 5 seconds
    SDL_RenderPresent(renderer);
    SDL_Delay(5000);

    // Clean up
    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();

    return 0;
}