// #include <iostream>
// #include <string>
// #include <SDL.h>
// #include <SDL_ttf.h>

// void draw_point_label(SDL_Renderer *renderer, TTF_Font *font, int x, int y, const std::string &text, SDL_Color color)
// {
//     SDL_Surface *surface = TTF_RenderText_Solid(font, text.c_str(), color);
//     SDL_Texture *texture = SDL_CreateTextureFromSurface(renderer, surface);
//     SDL_Rect dst = { x, y, surface->w, surface->h };
//     SDL_FreeSurface(surface);
//     SDL_RenderCopy(renderer, texture, NULL, &dst);
//     SDL_DestroyTexture(texture);
// }

// int main(int argc, char* argv[])
// {
//     SDL_Init(SDL_INIT_VIDEO);
//     TTF_Init();

//     SDL_Window* window = SDL_CreateWindow("Triangle Coordinates",
//         SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED, 800, 400, SDL_WINDOW_SHOWN);
//     SDL_Renderer* renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);

//     // Load font
//     TTF_Font *font = TTF_OpenFont("arial.ttf", 14);
//     if (!font)
//     {
//         std::cerr << "Font load error: " << TTF_GetError() << std::endl;
//         return 1;
//     }

//     // Triangle points
//     SDL_Point p1 = { 400, 100 };
//     SDL_Point p2 = { 200, 300 };
//     SDL_Point p3 = { 600, 300 };

//     SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255); // white background
//     SDL_RenderClear(renderer);

//     // Draw triangle
//     SDL_SetRenderDrawColor(renderer, 255, 0, 0, 255); // red
//     SDL_RenderDrawLine(renderer, p1.x, p1.y, p2.x, p2.y);
//     SDL_RenderDrawLine(renderer, p2.x, p2.y, p3.x, p3.y);
//     SDL_RenderDrawLine(renderer, p3.x, p3.y, p1.x, p1.y);

//     // Draw corner dots
//     SDL_SetRenderDrawColor(renderer, 0, 0, 255, 255); // blue
//     SDL_RenderDrawPoint(renderer, p1.x, p1.y);
//     SDL_RenderDrawPoint(renderer, p2.x, p2.y);
//     SDL_RenderDrawPoint(renderer, p3.x, p3.y);

//     // Draw coordinate labels
//     SDL_Color blue = { 0, 0, 255 };
//     draw_point_label(renderer, font, p1.x - 50, p1.y - 20, "(x=400, y=100)", blue);
//     draw_point_label(renderer, font, p2.x - 120, p2.y, "(x=200, y=300)", blue);
//     draw_point_label(renderer, font, p3.x + 10, p3.y, "(x=600, y=300)", blue);

//     SDL_RenderPresent(renderer);

//     SDL_Delay(10000); // Show for 10 seconds

//     // Cleanup
//     TTF_CloseFont(font);
//     SDL_DestroyRenderer(renderer);
//     SDL_DestroyWindow(window);
//     TTF_Quit();
//     SDL_Quit();

//     return 0;
// }


#include <SDL2/SDL.h>
#include <SDL2/SDL2_gfxPrimitives.h>
#include <iostream>
#include <cstdlib>
#include <ctime>

const int WINDOW_WIDTH = 400;
const int WINDOW_HEIGHT = 400;

int main(int argc, char* argv[])
{
    // Initialize SDL
    if (SDL_Init(SDL_INIT_VIDEO) < 0)
    {
        std::cerr << "Failed to initialize SDL: " << SDL_GetError() << "\n";
        return 1;
    }

    // Create SDL Window
    SDL_Window* window = SDL_CreateWindow(
        "Draw Circle on Bitmap",
        SDL_WINDOWPOS_CENTERED,
        SDL_WINDOWPOS_CENTERED,
        WINDOW_WIDTH,
        WINDOW_HEIGHT,
        SDL_WINDOW_SHOWN
    );

    if (!window)
    {
        std::cerr << "Failed to create window: " << SDL_GetError() << "\n";
        SDL_Quit();
        return 1;
    }

    // Create SDL Renderer
    SDL_Renderer* renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);
    if (!renderer)
    {
        std::cerr << "Failed to create renderer: " << SDL_GetError() << "\n";
        SDL_DestroyWindow(window);
        SDL_Quit();
        return 1;
    }

    // Set up random number generator
    std::srand(std::time(0));

    // Draw the main circle
    filledCircleRGBA(renderer, 200, 200, 150, 180, 0, 0, 255);  // Dark red planet
    circleRGBA(renderer, 200, 200, 150, 255, 0, 0, 255);        // Red outline

    // Add surface details
    for (int i = 0; i < 15; ++i)
    {
        int x = std::rand() % 200 + 100;
        int y = std::rand() % 200 + 100;
        int size = std::rand() % 20 + 10;
        circleRGBA(renderer, x, y, size, 255, 0, 0, 255);
    }

    // Display the scene
    SDL_RenderPresent(renderer);

    // Main loop
    bool running = true;
    SDL_Event event;
    while (running)
    {
        while (SDL_PollEvent(&event))
        {
            if (event.type == SDL_QUIT)
            {
                running = false;
            }
        }

        SDL_Delay(10); // Reduce CPU usage
    }

    // Cleanup
    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();

    return 0;
}
