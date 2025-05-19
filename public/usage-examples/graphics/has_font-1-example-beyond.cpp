#include <SDL2/SDL.h>
#include <SDL2/SDL_ttf.h>
#include <iostream>
#include <string>
#include <direct.h>  // For _getcwd()

int main(int argc, char* argv[])
{
    // 1. Simulate "has_font" before loading
    std::cout << "Font available before loading: False\n";

    // Initialize SDL and TTF
    if (SDL_Init(SDL_INIT_VIDEO) != 0)
    {
        std::cerr << "SDL_Init failed: " << SDL_GetError() << "\n";
        return 1;
    }
    if (TTF_Init() == -1)
    {
        std::cerr << "TTF_Init failed: " << TTF_GetError() << "\n";
        SDL_Quit();
        return 1;
    }

    // Build full font path (assuming arial.ttf is in the same directory)
    char cwd[1024];
    _getcwd(cwd, sizeof(cwd));
    std::string fontPath = std::string(cwd) + "\\arial.ttf";

    // Load the font
    TTF_Font* my_font = TTF_OpenFont(fontPath.c_str(), 24);
    if (!my_font)
    {
        std::cerr << "Failed to load font: " << TTF_GetError() << "\n";
        TTF_Quit();
        SDL_Quit();
        return 1;
    }

    // 2. Simulate "has_font" after loading
    std::cout << "Font available after loading: True\n";

    // Clean up
    TTF_CloseFont(my_font);
    TTF_Quit();
    SDL_Quit();

    return 0;
}
