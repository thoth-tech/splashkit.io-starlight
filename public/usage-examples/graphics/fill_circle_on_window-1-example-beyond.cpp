#include <SDL.h>
#include <iostream>

// Function to create and open an SDL window
SDL_Window* open_window(const char* title, int width, int height)
{
    // Initialize SDL
    if (SDL_Init(SDL_INIT_VIDEO) < 0)
    {
        std::cerr << "SDL could not be initialized: " << SDL_GetError() << std::endl;
        exit(1);
    }

    // Create SDL window
    SDL_Window* window = SDL_CreateWindow(title, SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED, width, height, SDL_WINDOW_SHOWN);
    if (!window)
    {
        std::cerr << "Window could not be created: " << SDL_GetError() << std::endl;
        SDL_Quit();
        exit(1);
    }

    return window;
}

// Function to create a renderer
SDL_Renderer* create_renderer(SDL_Window* window)
{
    SDL_Renderer* renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);
    if (!renderer)
    {
        std::cerr << "Renderer could not be created: " << SDL_GetError() << std::endl;
        SDL_DestroyWindow(window);
        SDL_Quit();
        exit(1);
    }
    return renderer;
}

// Function to draw a filled circle
void draw_filled_circle(SDL_Renderer* renderer, int x, int y, int radius, SDL_Color color)
{
    SDL_SetRenderDrawColor(renderer, color.r, color.g, color.b, color.a);
    for (int w = 0; w < radius * 2; w++)
    {
        for (int h = 0; h < radius * 2; h++)
        {
            int dx = radius - w;
            int dy = radius - h;
            if ((dx * dx + dy * dy) <= (radius * radius))
            {
                SDL_RenderDrawPoint(renderer, x + dx, y + dy);
            }
        }
    }
}

int main(int argc, char** argv)
{
    // Create and open a new window
    SDL_Window* window = open_window("Traffic Lights", 800, 600);
    SDL_Renderer* renderer = create_renderer(window);

    // Clear the screen to white
    SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
    SDL_RenderClear(renderer);

    // Define traffic light colors
    SDL_Color red = {255, 0, 0, 255};
    SDL_Color yellow = {255, 255, 0, 255};
    SDL_Color green = {0, 255, 0, 255};

    // Draw traffic lights
    draw_filled_circle(renderer, 400, 100, 50, red);
    draw_filled_circle(renderer, 400, 250, 50, yellow);
    draw_filled_circle(renderer, 400, 400, 50, green);

    // Present the updated frame
    SDL_RenderPresent(renderer);

    // Keep the window open for 5 seconds
    SDL_Delay(5000);

    // Clean up and close everything
    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();

    return 0;
}
