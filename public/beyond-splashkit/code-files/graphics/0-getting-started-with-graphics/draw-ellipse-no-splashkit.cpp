#include <SDL.h>
#include <cstdlib>
#include <ctime>

SDL_Color random_color()
{
    return SDL_Color{ Uint8(rand() % 256), Uint8(rand() % 256), Uint8(rand() % 256), 255 };
}

void draw_ellipse(SDL_Renderer* renderer, int x, int y, int width, int height, SDL_Color color)
{
    SDL_SetRenderDrawColor(renderer, color.r, color.g, color.b, color.a);
    SDL_Rect rect = { x, y, width, height };
    SDL_RenderFillRect(renderer, &rect);
}

int main(int argc, char* argv[])
{
    srand((unsigned)time(0));

    SDL_Init(SDL_INIT_VIDEO);
    SDL_Window* window = SDL_CreateWindow("Draw Ellipse (SDL2)",
        SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED, 800, 600, SDL_WINDOW_SHOWN);
    SDL_Renderer* renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);

    SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
    SDL_RenderClear(renderer);

    for (int i = 0; i < 30; i++)
    {
        int width = 600 - i * 20;
        int height = 400 - i * 10;
        int x = 100 + i * 10;
        int y = 100 + i * 5;
        draw_ellipse(renderer, x, y, width, height, random_color());
    }

    SDL_RenderPresent(renderer);
    SDL_Delay(4000);

    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();

    return 0;
}
