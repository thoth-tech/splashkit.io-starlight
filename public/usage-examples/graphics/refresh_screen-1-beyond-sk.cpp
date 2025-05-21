// refresh_screen-1-example-beyond.cpp

#define SDL_MAIN_HANDLED
#include <SDL2/SDL.h>
#include <SDL2/SDL2_gfxPrimitives.h>
#include <chrono>
#include <thread>

void delay_ms(int ms) {
    std::this_thread::sleep_for(std::chrono::milliseconds(ms));
}

void draw_triangle(SDL_Renderer* renderer) {
    SDL_Point top   = {400,150};
    SDL_Point left  = {250,300};
    SDL_Point right = {550,300};
    for (int y = top.y; y <= left.y; ++y) {
        float ratio = float(y - top.y) / float(left.y - top.y);
        int startX = top.x + (left.x - top.x) * ratio;
        int endX   = top.x + (right.x - top.x) * ratio;
        SDL_RenderDrawLine(renderer, startX, y, endX, y);
    }
}

int main() {
    auto wait = [&](int ms) {
        Uint32 start = SDL_GetTicks();
        SDL_Event evt;
        while (SDL_GetTicks() - start < ms) {
            while (SDL_PollEvent(&evt)) {
                if (evt.type == SDL_QUIT) return false;
            }
            SDL_Delay(16);
        }
        return true;
    };

    if (SDL_Init(SDL_INIT_VIDEO) != 0) return 1;
    SDL_Window*   window   = SDL_CreateWindow(
        "Simple House Drawing",
        SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED,
        800, 600, 0
    );
    SDL_Renderer* renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);

    SDL_Rect ground, house;

    if (!window || !renderer) goto cleanup;

    // clear to white
    SDL_SetRenderDrawColor(renderer, 255,255,255,255);
    SDL_RenderClear(renderer);
    SDL_RenderPresent(renderer);
    if (!wait(1000)) goto cleanup;

    // draw ground
    ground = {  0, 400, 800, 200 };
    SDL_SetRenderDrawColor(renderer,   0,255,   0,255);
    SDL_RenderFillRect(renderer, &ground);
    SDL_RenderPresent(renderer);
    if (!wait(1000)) goto cleanup;

    // draw house body
    house  = {300, 300, 200, 200};
    SDL_SetRenderDrawColor(renderer, 150,150,150,255);
    SDL_RenderFillRect(renderer, &house);
    SDL_RenderPresent(renderer);
    if (!wait(1000)) goto cleanup;

    // draw roof
    SDL_SetRenderDrawColor(renderer, 255,   0,   0,255);
    draw_triangle(renderer);
    SDL_RenderPresent(renderer);
    if (!wait(5000)) goto cleanup;

cleanup:
    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();
    return 0;
}
