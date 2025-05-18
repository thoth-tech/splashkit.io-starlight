
#define SDL_MAIN_HANDLED
#include <SDL2/SDL.h>
#include <SDL2/SDL_ttf.h>
#include <iostream>
#include <string>


void draw_text(SDL_Renderer *ren, TTF_Font *font,
               const std::string &text,
               SDL_Color color, int x, int y)
{
    SDL_Surface *surf = TTF_RenderUTF8_Blended(font, text.c_str(), color);
    SDL_Texture *tex  = SDL_CreateTextureFromSurface(ren, surf);
    SDL_FreeSurface(surf);

    int w, h;
    SDL_QueryTexture(tex, nullptr, nullptr, &w, &h);
    SDL_Rect dst{x, y, w, h};
    SDL_RenderCopy(ren, tex, nullptr, &dst);
    SDL_DestroyTexture(tex);
}

int main()
{
    
    SDL_Init(SDL_INIT_VIDEO);
    TTF_Init();
    SDL_Window   *window   = SDL_CreateWindow(
        "Freeing Fonts",
        SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED,
        800, 200, 0
    );
    SDL_Renderer *renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);

    
    TTF_Font *bebas = TTF_OpenFont("BebasNeue.ttf", 30);
    
    TTF_Font *sysf  = TTF_OpenFont("BebasNeue.ttf", 30);

    bool running = true;
    SDL_Event e;
    SDL_Color black{0,0,0,255};

    while (running)
    {
        // process_events()
        while (SDL_PollEvent(&e))
        {
            if (e.type == SDL_QUIT)
                running = false;
            else if (e.type == SDL_KEYDOWN && e.key.keysym.sym == SDLK_SPACE)
            {
                // If the font is loaded, it is freed
                // If the font has been free, it is loaded again
                if (bebas)
                {
                    TTF_CloseFont(bebas);
                    bebas = nullptr;
                }
                else
                {
                    bebas = TTF_OpenFont("BebasNeue.ttf", 30);
                }
            }
        }

       
        SDL_SetRenderDrawColor(renderer, 255,255,255,255);
        SDL_RenderClear(renderer);

        
        if (bebas)
        {
            draw_text(renderer, bebas,
                      "Using BebasNeue Font: Press Space bar to free font",
                      black, 30, 50);
        }
        else
        {
            draw_text(renderer, sysf,  
                      "Using System Font: BebasNeue font has been freed",
                      black, 30, 50);
            draw_text(renderer, sysf,
                      "Press Space bar to load BebasNeue font again",
                      black, 30,100);
        }

        
        SDL_RenderPresent(renderer);
        SDL_Delay(16);
    }

    // Clean up
    if (bebas)
        TTF_CloseFont(bebas);
    TTF_CloseFont(sysf);
    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    TTF_Quit();
    SDL_Quit();
    return 0;
}
