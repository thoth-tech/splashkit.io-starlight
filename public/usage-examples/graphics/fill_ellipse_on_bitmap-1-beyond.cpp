#define SDL_MAIN_HANDLED
#include <iostream>
#include <SDL2/SDL.h>
#endif

// Helper: Draw a filled ellipse with alpha
void fill_ellipse(SDL_Renderer* renderer, SDL_Color color, int x, int y, int w, int h) {
    // SDL2 does not natively support filled ellipses with alpha;
    // So, this function draws an outlined ellipse as a placeholder.
    // For true filled & alpha, you would use SDL2_gfx (ask if you want that).
    SDL_SetRenderDrawColor(renderer, color.r, color.g, color.b, color.a);
    // Approximate filled ellipse with many lines (for demo)
    for (int i = -h / 2; i <= h / 2; ++i) {
        int rx = static_cast<int>((w / 2.0) * sqrt(1.0 - (i * i) / ((h / 2.0) * (h / 2.0))));
        SDL_RenderDrawLine(renderer, x + w / 2 - rx, y + h / 2 + i, x + w / 2 + rx, y + h / 2 + i);
    }
}

int main(int argc, char* argv[]) {
    if (SDL_Init(SDL_INIT_VIDEO) != 0) {
        std::cerr << "SDL_Init Error: " << SDL_GetError() << std::endl;
        return 1;
    }

    SDL_Window* window = SDL_CreateWindow("Window", SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED, 400, 300, SDL_WINDOW_SHOWN);
    if (!window) {
        std::cerr << "Window creation failed: " << SDL_GetError() << std::endl;
        SDL_Quit();
        return 1;
    }

    SDL_Renderer* renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED | SDL_RENDERER_PRESENTVSYNC);
    if (!renderer) {
        std::cerr << "Renderer creation failed: " << SDL_GetError() << std::endl;
        SDL_DestroyWindow(window);
        SDL_Quit();
        return 1;
    }

    // "Bitmap" surface will be rendered onto the window each frame
    // --- draw water surface ---
    bool running = true;
    while (running) {
        // Handle events
        SDL_Event e;
        while (SDL_PollEvent(&e)) {
            if (e.type == SDL_QUIT)
                running = false;
        }

        // Fill background with light blue
        SDL_SetRenderDrawColor(renderer, 200, 230, 255, 255);
        SDL_RenderClear(renderer);

        // Define blue tones for the ripples
        SDL_Color ripple_colors[5] = {
            {100, 150, 255, 100},
            {120, 170, 255,  80},
            {140, 190, 255,  60},
            {160, 210, 255,  40},
            {180, 230, 255,  20}
        };

        int center_x = 200;
        int center_y = 150;
        for (int i = 0; i < 5; ++i) {
            // Draw concentric ellipses, increasing in size and decreasing in alpha
            fill_ellipse(
                renderer, ripple_colors[i],
                center_x - (100 + i * 30),
                center_y - (75 + i * 20),
                200 + i * 60,
                150 + i * 40
            );
        }

        SDL_RenderPresent(renderer);
        SDL_Delay(16);
    }

    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();
    return 0;
}
