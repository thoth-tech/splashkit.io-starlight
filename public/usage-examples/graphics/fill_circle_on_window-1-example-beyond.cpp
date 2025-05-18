#include <SDL2/SDL.h>
#include <SDL2/SDL2_gfxPrimitives.h>
#include <iostream>

void fill_circle_on_window(SDL_Renderer* ren, SDL_Color c, int x, int y, int r)
{
    filledCircleRGBA(ren, x, y, r, c.r, c.g, c.b, c.a);
}


int SDL_main(int argc, char* argv[])
{
     // Open a new window 
    SDL_Init(SDL_INIT_VIDEO);
    SDL_Window*   window   = SDL_CreateWindow(
        "Traffic Lights",
        SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED,
        800, 600, 0
    );
    SDL_Renderer* renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);
    SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
    SDL_RenderClear(renderer);

    // Use function to place 3 circles in destination window as traffic lights
    fill_circle_on_window(renderer, SDL_Color{255,0,0,255}, 400, 100, 50);
    fill_circle_on_window(renderer, SDL_Color{255,255,0,255}, 400, 250, 50);
    fill_circle_on_window(renderer, SDL_Color{0,255,0,255}, 400, 400, 50);


    SDL_RenderPresent(renderer);

    
    Uint32 start = SDL_GetTicks();
    SDL_Event evt;
    bool waiting = true;
    while (waiting)
    {
       
        while (SDL_PollEvent(&evt))
        {
            if (evt.type == SDL_QUIT)
                waiting = false;
        }
        if (SDL_GetTicks() - start >= 5000)
            waiting = false;

        SDL_Delay(16); 
    }

    // close_all_windows()
    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();
    return 0;
}
