#include <iostream>
#ifdef __APPLE__
#include <SDL.h>
#else
#include <SDL2/SDL.h>
#endif

// Function to create and return a new SDL window
SDL_Window *sdl_open_window(const char *window_title, const int width, const int height)
{
    SDL_Window *window = nullptr;

    // Initialize SDL Video system
    if (SDL_Init(SDL_INIT_VIDEO) < 0)
    {
        std::cout << "SDL could not be initialized: " << SDL_GetError();
        exit(1);
    }

    // Create a window centered on the screen
    window = SDL_CreateWindow(
        window_title,
        SDL_WINDOWPOS_CENTERED,
        SDL_WINDOWPOS_CENTERED,
        width,
        height,
        SDL_WINDOW_OPENGL);

    // Error handling for window creation
    if (window == NULL)
    {
        SDL_LogError(SDL_LOG_CATEGORY_ERROR, "Could not create window: %s\n", SDL_GetError());
        exit(1);
    }

    return window;
}

// Function to draw the outline of a circle using midpoint circle algorithm
void draw_circle(SDL_Renderer *renderer, int cx, int cy, int radius)
{
    int x = radius;
    int y = 0;
    int err = 0;

    // Draw symmetrical points around the center
    while (x >= y)
    {
        SDL_RenderDrawPoint(renderer, cx + x, cy + y);
        SDL_RenderDrawPoint(renderer, cx + y, cy + x);
        SDL_RenderDrawPoint(renderer, cx - y, cy + x);
        SDL_RenderDrawPoint(renderer, cx - x, cy + y);
        SDL_RenderDrawPoint(renderer, cx - x, cy - y);
        SDL_RenderDrawPoint(renderer, cx - y, cy - x);
        SDL_RenderDrawPoint(renderer, cx + y, cy - x);
        SDL_RenderDrawPoint(renderer, cx + x, cy - y);

        y++;

        if (err <= 0)
        {
            err += 2 * y + 1;
        }
        else
        {
            x--;
            err += 2 * (y - x) + 1;
        }
    }
}

int main(int argv, char **args)
{
    // Open an SDL window with a title and dimensions
    SDL_Window *window = sdl_open_window("No SK Window: Draw Circles", 800, 600);

    // Create a renderer for drawing
    SDL_Renderer *renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);
    if (renderer == NULL)
    {
        SDL_LogError(SDL_LOG_CATEGORY_ERROR, "Could not create renderer: %s\n", SDL_GetError());
        exit(1);
    }

    // Set background color to white and clear the screen
    SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
    SDL_RenderClear(renderer);

    // Get the center of the screen
    int center_x = 800 / 2;
    int center_y = 600 / 2;

    // Draw multiple circles with different radii and colors
    SDL_SetRenderDrawColor(renderer, 255, 0, 0, 255);     // Red
    draw_circle(renderer, center_x, center_y, 50);

    SDL_SetRenderDrawColor(renderer, 0, 0, 255, 255);     // Blue
    draw_circle(renderer, center_x, center_y, 100);

    SDL_SetRenderDrawColor(renderer, 255, 165, 0, 255);   // Orange
    draw_circle(renderer, center_x, center_y, 150);

    SDL_SetRenderDrawColor(renderer, 0, 255, 0, 255);     // Green
    draw_circle(renderer, center_x, center_y, 200);

    // Display the drawn circles on the window
    SDL_RenderPresent(renderer);

    // Event handling and delay to keep window open for 4 seconds or until user closes it
    SDL_Event event;
    Uint32 start_time = SDL_GetTicks();
    bool quit = false;

    while (!quit)
    {
        if (SDL_PollEvent(&event))
        {
            if (event.type == SDL_QUIT)
            {
                quit = true;
            }
        }

        // Automatically close the window after 4000 milliseconds (4 seconds)
        if (SDL_GetTicks() - start_time > 4000)
        {
            quit = true;
        }
    }

    // Clean up and free memory
    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();

    return 0;
}