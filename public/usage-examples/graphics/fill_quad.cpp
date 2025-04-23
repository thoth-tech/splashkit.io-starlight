#include <SDL2/SDL.h>
#include <iostream>
#include <vector>

struct Point
{
    int x, y;
};

void drawFilledQuad(SDL_Renderer* renderer, const std::vector<Point>& points, SDL_Color color)
{
    // Set the drawing color
    SDL_SetRenderDrawColor(renderer, color.r, color.g, color.b, color.a);

    // Create an SDL_Point array from the custom Point vector
    SDL_Point sdlPoints[4];
    for (int i = 0; i < 4; ++i)
    {
        sdlPoints[i].x = points[i].x;
        sdlPoints[i].y = points[i].y;
    }

    // Draw the filled polygon (quadrilateral)
    // Note: SDL2 doesn't have a built-in function to fill polygons.
    // You would need to use an external library like SDL_gfx or implement your own filling algorithm.
    // For demonstration purposes, we'll draw the outline.
    SDL_RenderDrawLines(renderer, sdlPoints, 4);
    // Connect the last point to the first to close the quad
    SDL_RenderDrawLine(renderer, sdlPoints[3].x, sdlPoints[3].y, sdlPoints[0].x, sdlPoints[0].y);
}

int main(int argc, char* argv[])
{
    const int windowWidth = 600;
    const int windowHeight = 600;

    if (SDL_Init(SDL_INIT_VIDEO) < 0)
    {
        std::cerr << "SDL could not initialize! SDL_Error: " << SDL_GetError() << "\n";
        return 1;
    }

    SDL_Window* window = SDL_CreateWindow("Coloured Star",
                                          SDL_WINDOWPOS_CENTERED,
                                          SDL_WINDOWPOS_CENTERED,
                                          windowWidth,
                                          windowHeight,
                                          SDL_WINDOW_SHOWN);

    if (!window)
    {
        std::cerr << "Window could not be created! SDL_Error: " << SDL_GetError() << "\n";
        SDL_Quit();
        return 1;
    }

    SDL_Renderer* renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);

    if (!renderer)
    {
        std::cerr << "Renderer could not be created! SDL_Error: " << SDL_GetError() << "\n";
        SDL_DestroyWindow(window);
        SDL_Quit();
        return 1;
    }

    // Set background color to white and clear the screen
    SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
    SDL_RenderClear(renderer);

    // Define the four quads (as vectors of Points)
    std::vector<Point> quad1 = { {400, 200}, {300, 300}, {300, 0}, {200, 200} };
    std::vector<Point> quad2 = { {400, 210}, {310, 300}, {600, 300}, {400, 390} };
    std::vector<Point> quad3 = { {200, 400}, {300, 300}, {300, 600}, {400, 400} };
    std::vector<Point> quad4 = { {200, 390}, {290, 300}, {0, 300}, {200, 210} };

    // Draw the quads with specified colors
    drawFilledQuad(renderer, quad1, {0, 0, 0, 255});       // Black
    drawFilledQuad(renderer, quad2, {0, 255, 0, 255});     // Green
    drawFilledQuad(renderer, quad3, {255, 0, 0, 255});     // Red
    drawFilledQuad(renderer, quad4, {0, 0, 255, 255});     // Blue

    // Present the renderer
    SDL_RenderPresent(renderer);

    // Wait for 5 seconds
    SDL_Delay(5000);

    // Clean up
    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();

    return 0;
}
