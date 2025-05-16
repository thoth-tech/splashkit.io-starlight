#include <iostream>
#ifdef __APPLE__
#include <SDL.h>
#else
#include <SDL2/SDL.h>
#endif

SDL_Window* sdl_open_window(const char* window_title, int width, int height)
{
    // Initialize SDL video subsystem
    if (SDL_Init(SDL_INIT_VIDEO) < 0)
    {
        std::cout << "SDL could not initialize: " << SDL_GetError() << std::endl;
        exit(1);
    }

    // Create the application window
    SDL_Window* window = SDL_CreateWindow(
        window_title,
        SDL_WINDOWPOS_CENTERED,
        SDL_WINDOWPOS_CENTERED,
        width,
        height,
        SDL_WINDOW_SHOWN
    );

    // Check for window creation error
    if (window == nullptr)
    {
        SDL_LogError(SDL_LOG_CATEGORY_ERROR, "Could not create window: %s", SDL_GetError());
        SDL_Quit();
        exit(1);
    }

    return window;
}

int main(int argc, char* argv[])
{
    const int trail_length = 50;
    SDL_Point mouse_history[trail_length] = {};

    // Colors for the trail (blue, red, green, yellow, pink)
    SDL_Color color_list[5] = {
        {   0,   0, 255, 255 },
        { 255,   0,   0, 255 },
        {   0, 255,   0, 255 },
        { 255, 255,   0, 255 },
        { 255, 105, 180, 255 }
    };

    // Open window and create renderer
    SDL_Window* window = sdl_open_window("Cursor Trail", 600, 600);
    SDL_Renderer* renderer = SDL_CreateRenderer(
        window, -1, SDL_RENDERER_ACCELERATED | SDL_RENDERER_PRESENTVSYNC
    );
    if (renderer == nullptr)
    {
        SDL_LogError(SDL_LOG_CATEGORY_ERROR, "Could not create renderer: %s", SDL_GetError());
        SDL_DestroyWindow(window);
        SDL_Quit();
        return 1;
    }

    bool running = true;
    SDL_Event event;

    while (running)
    {
        // Handle window events (e.g. close button)
        while (SDL_PollEvent(&event))
        {
            if (event.type == SDL_QUIT)
            {
                running = false;
            }
        }

        // Get current mouse position
        int mouse_x, mouse_y;
        SDL_GetMouseState(&mouse_x, &mouse_y);

        // Shift mouse history forward
        for (int i = 0; i < trail_length - 1; i++)
        {
            mouse_history[i] = mouse_history[i + 1];
        }
        SDL_Point pt;
        pt.x = mouse_x;
        pt.y = mouse_y;
        mouse_history[trail_length - 1] = pt;

        // Clear screen to black
        SDL_SetRenderDrawColor(renderer, 0, 0, 0, 255);
        SDL_RenderClear(renderer);

        // Draw the mouse trail
        for (int i = 0; i < trail_length; i++)
        {
            SDL_Color col = color_list[i % 5];
            SDL_SetRenderDrawColor(renderer, col.r, col.g, col.b, col.a);
            SDL_RenderDrawPoint(renderer, mouse_history[i].x, mouse_history[i].y);
        }

        // Present the updated frame
        SDL_RenderPresent(renderer);

        // Delay to cap at ~60 FPS
        SDL_Delay(16);
    }

    // Clean up
    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();
    return 0;
}
