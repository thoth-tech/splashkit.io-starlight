#include <SDL2/SDL.h>
#include <SDL2/SDL2_gfxPrimitives.h>
#include <iostream>

// Mimics SplashKit’s fill_triangle_on_window
void fill_triangle_on_window(SDL_Renderer* ren, SDL_Color c,
                             Sint16 x1, Sint16 y1,
                             Sint16 x2, Sint16 y2,
                             Sint16 x3, Sint16 y3)
{
    filledTrigonRGBA(ren,
                     x1, y1,
                     x2, y2,
                     x3, y3,
                     c.r, c.g, c.b, c.a);
}

int SDL_main(int argc, char* argv[])
{
    SDL_Init(SDL_INIT_VIDEO);

    SDL_Window*   blue_window   = SDL_CreateWindow(
        "Blue Triangle",
        SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED,
        200, 200, 0
    );
    SDL_Renderer* blue_renderer = SDL_CreateRenderer(
        blue_window, -1, SDL_RENDERER_ACCELERATED
    );

    SDL_Window*   red_window   = SDL_CreateWindow(
        "Red Triangle",
        SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED,
        200, 200, 0
    );
    SDL_Renderer* red_renderer = SDL_CreateRenderer(
        red_window, -1, SDL_RENDERER_ACCELERATED
    );

    // Fill a blue triangle on the first window
    SDL_SetRenderDrawColor(blue_renderer, 255,255,255,255);
    SDL_RenderClear(blue_renderer);
    fill_triangle_on_window(blue_renderer,
                            SDL_Color{0,0,255,255},
                            50,100, 100,50, 150,100);
    SDL_RenderPresent(blue_renderer);

    // Fill a red triangle on the second window
    SDL_SetRenderDrawColor(red_renderer, 255,255,255,255);
    SDL_RenderClear(red_renderer);
    fill_triangle_on_window(red_renderer,
                            SDL_Color{255,0,0,255},
                            50,50, 100,100, 150,50);
    SDL_RenderPresent(red_renderer);

    Uint32 start = SDL_GetTicks();
    SDL_Event evt;
    while (SDL_GetTicks() - start < 5000)
    {
        while (SDL_PollEvent(&evt))
        {
            if (evt.type == SDL_QUIT)
                start = SDL_GetTicks() + 5000;
        }
        SDL_Delay(16);
    }

    SDL_DestroyRenderer(blue_renderer);
    SDL_DestroyWindow(   blue_window);
    SDL_DestroyRenderer(red_renderer);
    SDL_DestroyWindow(   red_window);
    SDL_Quit();
    return 0;
}
