#define SDL_MAIN_HANDLED
#include <SDL2/SDL.h>
#include <SDL2/SDL_ttf.h>
#include <iostream>

int main()
{
    SDL_Init(SDL_INIT_VIDEO);
    TTF_Init();

    SDL_Window *window = SDL_CreateWindow("Font Load Example", SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED, 800, 600, SDL_WINDOW_SHOWN);
    SDL_Renderer *renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);

    // Load the font
    TTF_Font *my_font = TTF_OpenFont("RobotoSlab-VariableFont_wght.ttf", 40);
    if (!my_font)
    {
        std::cerr << "Failed to load font: " << TTF_GetError() << std::endl;
        return 1;
    }

    SDL_Color text_color = {0, 0, 0, 255};

    // Render the text surface
    SDL_Surface *text_surface = TTF_RenderText_Solid(my_font, "Font Loaded Successfully!", text_color);
    if (!text_surface)
    {
        std::cerr << "Failed to render text surface: " << TTF_GetError() << std::endl;
        TTF_CloseFont(my_font);
        return 1;
    }

    SDL_Texture *text_texture = SDL_CreateTextureFromSurface(renderer, text_surface);
    if (!text_texture)
    {
        std::cerr << "Failed to create texture: " << SDL_GetError() << std::endl;
        SDL_FreeSurface(text_surface);
        TTF_CloseFont(my_font);
        return 1;
    }

    SDL_Rect text_rect;
    text_rect.w = text_surface->w;
    text_rect.h = text_surface->h;
    text_rect.x = (800 - text_rect.w) / 2;
    text_rect.y = (600 - text_rect.h) / 2;

    SDL_SetRenderDrawColor(renderer, 220, 220, 220, 255);
    SDL_RenderClear(renderer);
    SDL_RenderCopy(renderer, text_texture, NULL, &text_rect);
    SDL_RenderPresent(renderer);

    SDL_Event event;
    bool running = true;
    while (running)
    {
        while (SDL_PollEvent(&event))
        {
            if (event.type == SDL_QUIT)
            {
                running = false;
            }
        }
    }

    SDL_FreeSurface(text_surface);
    SDL_DestroyTexture(text_texture);
    TTF_CloseFont(my_font);
    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    TTF_Quit();
    SDL_Quit();

    return 0;
}

