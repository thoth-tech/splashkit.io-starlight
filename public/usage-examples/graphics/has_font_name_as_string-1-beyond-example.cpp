#include <iostream>
#include <SDL2/SDL.h>
#include <SDL2/SDL_ttf.h>
#include <SDL2/SDL_main.h>


// Function to check if a font can be loaded
bool has_font(const std::string &font_path)
{
    TTF_Font *font = TTF_OpenFont(font_path.c_str(), 16);
    if (font)
    {
        TTF_CloseFont(font);
        return true;
    }
    return false;
}

int main(int argc, char *argv[])

{
    // Initialize SDL2 and SDL_ttf
    if (SDL_Init(SDL_INIT_VIDEO) < 0 || TTF_Init() < 0)
    {
        std::cerr << "Failed to initialize SDL2 or SDL_ttf: " << TTF_GetError() << std::endl;
        return 1;
    }

    std::string font_path = "arial.ttf"; // Ensure the font file is present in the same directory
    if (has_font(font_path))
    {
        std::cout << "Font found!" << std::endl;
    }
    else
    {
        std::cout << "Font not found!" << std::endl;
    }

    // Clean up and quit
    TTF_Quit();
    SDL_Quit();
    return 0;
}
