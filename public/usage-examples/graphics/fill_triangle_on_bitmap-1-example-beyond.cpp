#include <SDL2/SDL.h>
#include <SDL2/SDL_image.h>
#include <SDL2/SDL2_gfxPrimitives.h>
#include <iostream>

const int WINDOW_W = 618;
const int WINDOW_H = 618;

// Loads a PNG file into an SDL_Texture
SDL_Texture* load_texture(SDL_Renderer* renderer, const char* file) {
    SDL_Surface* surf = IMG_Load(file);
    if (!surf) {
        std::cerr << "IMG_Load error: " << IMG_GetError() << std::endl;
        return nullptr;
    }
    SDL_Texture* tex = SDL_CreateTextureFromSurface(renderer, surf);
    SDL_FreeSurface(surf);
    return tex;
}

// Draws a filled red triangle (the hat) onto the current render-target
void draw_hat(SDL_Renderer* renderer) {
    filledTrigonRGBA(renderer,
        100, 200,   // left point
        309,  20,   // top point
        520, 200,   // right point
        255, 0, 0, 255 // red color
    );
}

int main(int argc, char* argv[]) {
    // Initialize SDL2 and SDL2_image
    SDL_Init(SDL_INIT_VIDEO);
    IMG_Init(IMG_INIT_PNG);

    // Create window and renderer
    SDL_Window*   window = SDL_CreateWindow("Happy Hat",
                        SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED,
                        WINDOW_W, WINDOW_H, 0);
    SDL_Renderer* renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);

    // Load both emojis as textures
    SDL_Texture* sad_emoji     = load_texture(renderer, "sad_emoji.png");
    SDL_Texture* smiling_emoji = load_texture(renderer, "smiling_emoji.png");
    if (!sad_emoji || !smiling_emoji) return 1;

    // Create a target texture for the smiling emoji with the hat
    SDL_Texture* smiling_emoji_hat = SDL_CreateTexture(
        renderer,
        SDL_PIXELFORMAT_RGBA8888,
        SDL_TEXTUREACCESS_TARGET,
        WINDOW_W, WINDOW_H
    );

    // Show sad emoji on black background for 1 second
    SDL_SetRenderDrawColor(renderer, 0,0,0,255);
    SDL_RenderClear(renderer);
    SDL_RenderCopy(renderer, sad_emoji, nullptr, nullptr);
    SDL_RenderPresent(renderer);
    SDL_Delay(1000);

    // Draw smiling emoji and the red triangle hat onto the target texture
    SDL_SetRenderTarget(renderer, smiling_emoji_hat);
      SDL_SetRenderDrawColor(renderer, 0,0,0,0);   // clear to transparent
      SDL_RenderClear(renderer);
      SDL_RenderCopy(renderer, smiling_emoji, nullptr, nullptr);
      draw_hat(renderer);
    SDL_SetRenderTarget(renderer, nullptr);

    // Show smiling emoji with hat on black for 1 second
    SDL_SetRenderDrawColor(renderer, 0,0,0,255);
    SDL_RenderClear(renderer);
    SDL_RenderCopy(renderer, smiling_emoji_hat, nullptr, nullptr);
    SDL_RenderPresent(renderer);
    SDL_Delay(1000);

    // Spin the smiling emoji with the hat for 360 degrees
    for (int ang = 0; ang < 360; ++ang) {
        SDL_SetRenderDrawColor(renderer, 0,0,0,255);
        SDL_RenderClear(renderer);
        SDL_RenderCopyEx(
            renderer,
            smiling_emoji_hat, nullptr, nullptr,
            ang, nullptr, SDL_FLIP_NONE
        );
        SDL_RenderPresent(renderer);
        SDL_Delay(10);
    }

    // Clean up and exit
    SDL_DestroyTexture(sad_emoji);
    SDL_DestroyTexture(smiling_emoji);
    SDL_DestroyTexture(smiling_emoji_hat);
    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    IMG_Quit();
    SDL_Quit();
    return 0;
}