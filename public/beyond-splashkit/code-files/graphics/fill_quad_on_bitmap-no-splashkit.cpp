#define SDL_MAIN_HANDLED  // Prevent SDL from redefining main
#include <iostream>
#ifdef __APPLE__
#include <SDL.h>
#else
#include <SDL2/SDL.h>
#endif

SDL_Window *sdl_open_window(const char *window_title, const int width, const int height)
{
    // Declare Variables
    SDL_Window *window = nullptr;

    // Check for successful initialisation
    if (SDL_Init(SDL_INIT_VIDEO) < 0)
    {
        std::cout << "SDL could not be initialized: " << SDL_GetError();
        exit(1);
    }

    // Create Window
    window = SDL_CreateWindow(
        window_title,
        SDL_WINDOWPOS_CENTERED,
        SDL_WINDOWPOS_CENTERED,
        width,
        height,
        SDL_WINDOW_OPENGL);

    // Error handling for window
    if (window == NULL)
    {
        SDL_LogError(SDL_LOG_CATEGORY_ERROR, "Could not create window: %s\n", SDL_GetError());
        exit(1);
    }

    return window;
}

// Draw one white quad as two triangles
void drawQuad(SDL_Renderer* ren, int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
{
    SDL_Vertex verts[4];
    SDL_Color white = { 255, 255, 255, 255 };

    verts[0] = {{ float(x1), float(y1) }, white, {0, 0}};
    verts[1] = {{ float(x2), float(y2) }, white, {0, 0}};
    verts[2] = {{ float(x3), float(y3) }, white, {0, 0}};
    verts[3] = {{ float(x4), float(y4) }, white, {0, 0}};

    int idx[6] = { 0, 1, 2, 1, 3, 2 };
    SDL_RenderGeometry(ren, nullptr, verts, 4, idx, 6);
}

int main(int argv, char** args)
{
    SDL_Window* win = sdl_open_window("Windows Logo", 400, 300);

    SDL_Renderer* ren = SDL_CreateRenderer(win, -1, SDL_RENDERER_ACCELERATED);
    if (ren == NULL)
    {
        SDL_LogError(SDL_LOG_CATEGORY_ERROR, "Could not create renderer: %s\n", SDL_GetError());
        exit(1);
    }

    SDL_SetRenderDrawColor(ren, 51, 118, 212, 255); // Windows blue background
    SDL_RenderClear(ren);

    // Draw 4 quad faces with drawQuad()
    drawQuad(ren,  85,  50, 180,  41,  85, 130, 180, 130);
    drawQuad(ren, 193,  40, 323,  26, 193, 130, 323, 130);
    drawQuad(ren,  85, 143, 180, 143,  85, 222, 180, 233);
    drawQuad(ren, 193, 143, 323, 143, 193, 235, 323, 250);

    // Display drawing
    SDL_RenderPresent(ren);

    SDL_Event event;
    while (event.type != SDL_QUIT)
    {
        // Check for quit requested
        SDL_PollEvent(&event);
    }

    // Cleanup and free memory
    SDL_DestroyRenderer(ren);
    SDL_DestroyWindow(win);
    SDL_Quit();

    return 0;
}
