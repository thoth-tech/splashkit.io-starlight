#include <SDL2/SDL.h>
#include <SDL2/SDL_image.h>
#include <iostream>

// helper to draw a filled rectangle with given color and position
void draw_rect(SDL_Renderer* renderer, SDL_Color color, int x, int y, int w, int h)
{
    SDL_SetRenderDrawColor(renderer, color.r, color.g, color.b, color.a);
    SDL_Rect rect = { x, y, w, h };
    SDL_RenderFillRect(renderer, &rect);
}

int main(int argc, char* argv[])
{
    if (SDL_Init(SDL_INIT_VIDEO) != 0)
    {
        std::cerr << "SDL Init Error: " << SDL_GetError() << std::endl;
        return 1;
    }

    if (!(IMG_Init(IMG_INIT_JPG) & IMG_INIT_JPG))
    {
        std::cerr << "IMG Init Error: " << IMG_GetError() << std::endl;
        SDL_Quit();
        return 1;
    }

    SDL_Window* window = SDL_CreateWindow("Night Sky",
                                          SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED,
                                          500, 533, 0);
    SDL_Renderer* renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);

    // loads background image used in the original example (provided in the resources zip)
    SDL_Surface* backgroundSurface = IMG_Load("sky.jpg");
    if (!backgroundSurface)
    {
        std::cerr << "Image Load Error: " << IMG_GetError() << std::endl;
        SDL_DestroyRenderer(renderer);
        SDL_DestroyWindow(window);
        IMG_Quit();
        SDL_Quit();
        return 1;
    }

    SDL_Texture* background = SDL_CreateTextureFromSurface(renderer, backgroundSurface);
    SDL_FreeSurface(backgroundSurface);

    // render background image
    SDL_RenderCopy(renderer, background, NULL, NULL);

    SDL_Color black  = { 0, 0, 0, 255 };
    SDL_Color orange = { 255, 165, 0, 255 };
    SDL_Color yellow = { 255, 255, 0, 255 };

    // draw buildings
    draw_rect(renderer, black, 40, 200, 100, 400);   // Building 1
    draw_rect(renderer, black, 200, 400, 100, 400);  // Building 2
    draw_rect(renderer, black, 350, 300, 100, 300);  // Building 3

    // draw windows for building 1
    for (int j = 220; j < 700; j += 50)
    {
        for (int i = 55; i < 135; i += 20)
        {
            draw_rect(renderer, orange, i, j, 10, 20);
        }
    }

    // draw windows for building 2
    for (int j = 420; j < 570; j += 50)
    {
        for (int i = 215; i < 295; i += 20)
        {
            draw_rect(renderer, yellow, i, j, 10, 20);
        }
    }

    // draw windows for building 3
    for (int j = 320; j < 700; j += 50)
    {
        for (int i = 365; i < 440; i += 20)
        {
            draw_rect(renderer, orange, i, j, 10, 20);
        }
    }

    SDL_RenderPresent(renderer);

    // event loop - keep window open for 5 seconds
    Uint32 start_time = SDL_GetTicks();
    const int frame_delay = 16;
    SDL_Event event;
    while (SDL_GetTicks() - start_time < 5000)
    {
        while (SDL_PollEvent(&event))
        {
            if (event.type == SDL_QUIT)
            {
                start_time = SDL_GetTicks() + 5000;
            }
        }
        SDL_Delay(frame_delay);
    }

    // cleanup
    SDL_DestroyTexture(background);
    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    IMG_Quit();
    SDL_Quit();
    return 0;
}
