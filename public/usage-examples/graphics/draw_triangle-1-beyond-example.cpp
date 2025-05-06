#include <iostream>
#include <string>
#include <SDL.h>
#include <SDL_ttf.h>

void draw_point_label(SDL_Renderer *renderer, TTF_Font *font, int x, int y, const std::string &text, SDL_Color color)
{
    SDL_Surface *surface = TTF_RenderText_Solid(font, text.c_str(), color);
    SDL_Texture *texture = SDL_CreateTextureFromSurface(renderer, surface);
    SDL_Rect dst = { x, y, surface->w, surface->h };
    SDL_FreeSurface(surface);
    SDL_RenderCopy(renderer, texture, NULL, &dst);
    SDL_DestroyTexture(texture);
}

int main(int argc, char* argv[])
{
    SDL_Init(SDL_INIT_VIDEO);
    TTF_Init();

    SDL_Window* window = SDL_CreateWindow("Triangle Coordinates",
        SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED, 800, 400, SDL_WINDOW_SHOWN);
    SDL_Renderer* renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);

    // Load font
    TTF_Font *font = TTF_OpenFont("arial.ttf", 14);
    if (!font)
    {
        std::cerr << "Font load error: " << TTF_GetError() << std::endl;
        return 1;
    }

    // Triangle points
    SDL_Point p1 = { 400, 100 };
    SDL_Point p2 = { 200, 300 };
    SDL_Point p3 = { 600, 300 };

    SDL_SetRenderDrawColor(renderer, 255, 255, 255, 255); // white background
    SDL_RenderClear(renderer);

    // Draw triangle
    SDL_SetRenderDrawColor(renderer, 255, 0, 0, 255); // red
    SDL_RenderDrawLine(renderer, p1.x, p1.y, p2.x, p2.y);
    SDL_RenderDrawLine(renderer, p2.x, p2.y, p3.x, p3.y);
    SDL_RenderDrawLine(renderer, p3.x, p3.y, p1.x, p1.y);

    // Draw corner dots
    SDL_SetRenderDrawColor(renderer, 0, 0, 255, 255); // blue
    SDL_RenderDrawPoint(renderer, p1.x, p1.y);
    SDL_RenderDrawPoint(renderer, p2.x, p2.y);
    SDL_RenderDrawPoint(renderer, p3.x, p3.y);

    // Draw coordinate labels
    SDL_Color blue = { 0, 0, 255 };
    draw_point_label(renderer, font, p1.x - 50, p1.y - 20, "(x=400, y=100)", blue);
    draw_point_label(renderer, font, p2.x - 120, p2.y, "(x=200, y=300)", blue);
    draw_point_label(renderer, font, p3.x + 10, p3.y, "(x=600, y=300)", blue);

    SDL_RenderPresent(renderer);

    SDL_Delay(10000); // Show for 10 seconds

    // Cleanup
    TTF_CloseFont(font);
    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    TTF_Quit();
    SDL_Quit();

    return 0;
}
