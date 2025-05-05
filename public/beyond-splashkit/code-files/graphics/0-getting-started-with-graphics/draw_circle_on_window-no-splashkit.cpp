#include <SDL2/SDL.h>
#include <cstdlib>
#include <ctime>

int main(int argc, char* argv[])
{
    // Create SDL window and renderer
    SDL_Init(SDL_INIT_VIDEO);
    SDL_Window* window = SDL_CreateWindow("Bubbles", SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED, 800, 600, SDL_WINDOW_SHOWN);
    SDL_Renderer* renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);

    // Clear screen to white
    SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255);
    SDL_RenderClear(renderer);

    std::srand(static_cast<unsigned int>(std::time(nullptr)));

    for (int i = 0; i < 50; i++)
    {
        // Set random circle values
        int x = std::rand() % 800;
        int y = std::rand() % 600;
        int radius = std::rand() % 50;
        SDL_Color randomColor = { static_cast<Uint8>(std::rand() % 256), static_cast<Uint8>(std::rand() % 256), static_cast<Uint8>(std::rand() % 256), 255 };

        // Draw the circle base on the random data
        int cx = x, cy = y;
        int r = radius;
        int px = r;
        int py = 0;
        int err = 0;
        SDL_SetRenderDrawColor(renderer, randomColor.r, randomColor.g, randomColor.b, randomColor.a);
        while (px >= py)
        {
            SDL_RenderDrawPoint(renderer, cx + px, cy + py);
            SDL_RenderDrawPoint(renderer, cx + py, cy + px);
            SDL_RenderDrawPoint(renderer, cx - py, cy + px);
            SDL_RenderDrawPoint(renderer, cx - px, cy + py);
            SDL_RenderDrawPoint(renderer, cx - px, cy - py);
            SDL_RenderDrawPoint(renderer, cx - py, cy - px);
            SDL_RenderDrawPoint(renderer, cx + py, cy - px);
            SDL_RenderDrawPoint(renderer, cx + px, cy - py);

            if (err <= 0)
            {
                py++;
                err += 2 * py + 1;
            }
            else
            {
                px--;
                err -= 2 * px + 1;
            }
        }
    }

    // Present rendered content and wait
    SDL_RenderPresent(renderer);
    SDL_Delay(4000);

    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();

    return 0;
}