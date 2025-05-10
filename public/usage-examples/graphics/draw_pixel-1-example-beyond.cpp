#include <SDL2/SDL.h>
#include <array>

struct Point2D
{
    int x, y;
};

constexpr int TRAIL_LENGTH = 50;

void updateMouseHistory(std::array<Point2D, TRAIL_LENGTH> &history, const Point2D &newPos)
{
    for (int i = 0; i < TRAIL_LENGTH - 1; ++i)
        history[i] = history[i + 1];
    history[TRAIL_LENGTH - 1] = newPos;
}

void renderMouseTrail(const std::array<Point2D, TRAIL_LENGTH> &history, SDL_Renderer *renderer)
{
    static const SDL_Color palette[5] = {
        {0, 0, 255, 255},    // Blue
        {255, 0, 0, 255},    // Red
        {0, 255, 0, 255},    // Green
        {255, 255, 0, 255},  // Yellow
        {255, 105, 180, 255} // Pink
    };

    for (int i = 0; i < TRAIL_LENGTH; ++i)
    {
        const auto &pt = history[i];
        const SDL_Color &c = palette[i % 5];
        SDL_SetRenderDrawColor(renderer, c.r, c.g, c.b, c.a);
        SDL_RenderDrawPoint(renderer, pt.x, pt.y);
    }
}

int main(int argc, char *argv[])
{
    // Initialize SDL2 video subsystem
    if (SDL_Init(SDL_INIT_VIDEO) != 0)
    {
        SDL_Log("Unable to initialize SDL: %s", SDL_GetError());
        return 1;
    }

    // Create an SDL2 window
    SDL_Window *window = SDL_CreateWindow(
        "Cursor Trail Demo", SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED, 600, 600, SDL_WINDOW_SHOWN);

    // Create an SDL2 renderer for the window
    SDL_Renderer *renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);

    std::array<Point2D, TRAIL_LENGTH> mouseHistory{};
    bool running = true;

    while (running)
    {
        SDL_Event evt;
        while (SDL_PollEvent(&evt))
        {
            if (evt.type == SDL_QUIT)
                running = false;
        }

        int mx, my;
        SDL_GetMouseState(&mx, &my);                // Get the current mouse position
        updateMouseHistory(mouseHistory, {mx, my}); // Update the mouse trail history

        SDL_SetRenderDrawColor(renderer, 0, 0, 0, 255); // Clear the screen with a black color
        SDL_RenderClear(renderer);

        renderMouseTrail(mouseHistory, renderer); // Draw the mouse trail on the screen
        SDL_RenderPresent(renderer);              // Present the rendered frame to the screen

        SDL_Delay(16); // Delay to limit the frame rate (~60 FPS)
    }

    SDL_DestroyRenderer(renderer); // Destroy the renderer and free its resources
    SDL_DestroyWindow(window);     // Destroy the window and free its resources
    SDL_Quit();                    // Quit SDL2 subsystems

    return 0;
}