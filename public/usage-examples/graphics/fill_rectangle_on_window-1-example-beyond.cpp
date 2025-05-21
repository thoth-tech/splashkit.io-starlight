#include <iostream>
#ifdef __APPLE__
#  include <SDL.h>
#else
#  include <SDL2/SDL.h>
#endif

SDL_Window* sdl_open_window(const char* title, int w, int h)
{
    if (SDL_Init(SDL_INIT_VIDEO) < 0)
    {
        std::cerr << "SDL_Init failed: " << SDL_GetError() << "\n";
        exit(1);
    }
    SDL_Window* win = SDL_CreateWindow(
        title,
        SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED,
        w, h, SDL_WINDOW_SHOWN
    );
    if (!win)
    {
        SDL_LogError(SDL_LOG_CATEGORY_ERROR, "SDL_CreateWindow: %s", SDL_GetError());
        SDL_Quit();
        exit(1);
    }
    return win;
}

int main()
{
    SDL_Window* blue_window = sdl_open_window("Blue Rectangle", 200, 200);
    SDL_Renderer* blue_renderer = SDL_CreateReblue_window, -1, SDL_RENDERER_ACCELERATED);
    SDL_Window* red_window  = sdl_open_window("Red Rectangle",  200, 200);
    SDL_Renderer* red_renderer  = SDL_CreateRenderer(red_window,  -1, SDL_RENDERER_ACCELERATED);

    int x, y;
    SDL_GetWindowPosition(blue_window, &x, &y);
    SDL_SetWindowPosition(red_window, x + 200, y);

    // Fill a blue rectangle on the first window
    SDL_SetRenderDrawColor(blue_renderer, 255, 255, 255, 255);
    SDL_RenderClear(blue_renderer);
    SDL_SetRenderDrawColor(blue_renderer,   0,   0, 255, 255);

    // Rendering a blue rectangle
    SDL_Rect rect = { 50, 50, 100, 50 };
    SDL_RenderFillRect(blue_renderer, &rect);
    SDL_RenderPresent(blue_renderer);

    // Fill a red rectangle on the second window
    SDL_SetRenderDrawColor(red_renderer, 255, 255, 255, 255);
    SDL_RenderClear(red_renderer);
    SDL_SetRenderDrawColor(red_renderer, 255,   0,   0, 255);
    SDL_RenderFillRect(red_renderer, &rect);
    SDL_RenderPresent(red_renderer);

    // Keep windows open and responsive for 5 seconds
    Uint32 start = SDL_GetTicks();
    SDL_Event ev;
    while (SDL_GetTicks() - start < 5000)
    {
        while (SDL_PollEvent(&ev)) {}
        SDL_Delay(16);
    }

    SDL_DestroyRenderer(blue_renderer);
    SDL_Destroy(blue_window);
    SDL_DestroyRenderer(red_renderer);
    SDL_DestroyWindow(red_window);
    SDL_Quit();
    return 0;
}
