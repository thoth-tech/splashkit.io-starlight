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
    SDL_Window* blue_win = sdl_open_window("Blue Rectangle", 200, 200);
    SDL_Renderer* blue_r = SDL_CreateRenderer(blue_win, -1, SDL_RENDERER_ACCELERATED);
    SDL_Window* red_win  = sdl_open_window("Red Rectangle",  200, 200);
    SDL_Renderer* red_r  = SDL_CreateRenderer(red_win,  -1, SDL_RENDERER_ACCELERATED);

    int x, y;
    SDL_GetWindowPosition(blue_win, &x, &y);
    SDL_SetWindowPosition(red_win, x + 200, y);

    // Fill a blue rectangle on the first window
    SDL_SetRenderDrawColor(blue_r, 255, 255, 255, 255);
    SDL_RenderClear(blue_r);
    SDL_SetRenderDrawColor(blue_r,   0,   0, 255, 255);
    SDL_Rect rect = { 50, 50, 100, 50 };
    SDL_RenderFillRect(blue_r, &rect);
    SDL_RenderPresent(blue_r);

    // Fill a red rectangle on the second window
    SDL_SetRenderDrawColor(red_r, 255, 255, 255, 255);
    SDL_RenderClear(red_r);
    SDL_SetRenderDrawColor(red_r, 255,   0,   0, 255);
    SDL_RenderFillRect(red_r, &rect);
    SDL_RenderPresent(red_r);

    // Keep windows open and responsive for 5 seconds
    Uint32 start = SDL_GetTicks();
    SDL_Event ev;
    while (SDL_GetTicks() - start < 5000)
    {
        while (SDL_PollEvent(&ev)) {}
        SDL_Delay(16);
    }

    SDL_DestroyRenderer(blue_r);
    SDL_DestroyWindow(blue_win);
    SDL_DestroyRenderer(red_r);
    SDL_DestroyWindow(red_win);
    SDL_Quit();
    return 0;
}
