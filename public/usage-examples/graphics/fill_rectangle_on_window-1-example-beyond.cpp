#include <iostream>
#define SDL_MAIN_HANDLED
#ifdef __APPLE__
#include <SDL.h>
#else
#include <SDL2/SDL.h>
#endif

int main()
{
    // Declare windows and renderers
    SDL_Window *blue_window = nullptr, *red_window = nullptr;
    SDL_Renderer *blue_renderer = nullptr, *red_renderer = nullptr;

    // Initialize SDL
    if (SDL_Init(SDL_INIT_VIDEO) < 0)
    {
        std::cerr << "SDL could not be initialized: " << SDL_GetError() << "\n";
        return 1;
    }

    // Create Blue Window and Renderer
    blue_window = SDL_CreateWindow("Blue Rectangle", SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED, 200, 200, SDL_WINDOW_SHOWN);
    if (!blue_window)
    {
        std::cerr << "Could not create Blue window: " << SDL_GetError() << "\n";
        SDL_Quit();
        return 1;
    }
    blue_renderer = SDL_CreateRenderer(blue_window, -1, SDL_RENDERER_ACCELERATED);

    // Create Red Window and Renderer
    red_window = SDL_CreateWindow("Red Rectangle", SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED, 200, 200, SDL_WINDOW_SHOWN);
    if (!red_window)
    {
        std::cerr << "Could not create Red window: " << SDL_GetError() << "\n";
        SDL_DestroyRenderer(blue_renderer);
        SDL_DestroyWindow(blue_window);
        SDL_Quit();
        return 1;
    }
    red_renderer = SDL_CreateRenderer(red_window, -1, SDL_RENDERER_ACCELERATED);

    // Move Red Window to the right of Blue Window
    int x, y;
    SDL_GetWindowPosition(blue_window, &x, &y);
    SDL_SetWindowPosition(red_window, x + 210, y); // 210 = 200 width + 10px gap

    // Blue window content
    SDL_SetRenderDrawColor(blue_renderer, 255, 255, 255, 255);
    SDL_RenderClear(blue_renderer);
    SDL_SetRenderDrawColor(blue_renderer, 0, 0, 255, 255);
    SDL_Rect rect = {50, 50, 100, 50};
    SDL_RenderFillRect(blue_renderer, &rect);
    SDL_RenderPresent(blue_renderer);

    // Red window content
    SDL_SetRenderDrawColor(red_renderer, 255, 255, 255, 255);
    SDL_RenderClear(red_renderer);
    SDL_SetRenderDrawColor(red_renderer, 255, 0, 0, 255);
    SDL_RenderFillRect(red_renderer, &rect);
    SDL_RenderPresent(red_renderer);

    // Keep windows open for 4 seconds
    Uint32 start_time = SDL_GetTicks();
    SDL_Event event;
    while (SDL_GetTicks() - start_time < 4000)
    {
        if (SDL_PollEvent(&event) && event.type == SDL_QUIT)
            break;
    }

    // Cleanup
    SDL_DestroyRenderer(blue_renderer);
    SDL_DestroyRenderer(red_renderer);
    SDL_DestroyWindow(blue_window);
    SDL_DestroyWindow(red_window);
    SDL_Quit();

    return 0;
}
