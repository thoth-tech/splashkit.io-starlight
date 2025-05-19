#include <iostream>
#include <SDL2/SDL.h>
#include <SDL2/SDL_ttf.h>
#include <SDL2/SDL_main.h>

// Function to check if a font can be loaded
bool has_font(const std::string &font_path)
{
    // Attempt to open the font with a default size (16)
    TTF_Font *font = TTF_OpenFont(font_path.c_str(), 16);
    
    // Load a font
    if (font)
    {
        // Close the font to free resources
        TTF_CloseFont(font);
        return true; // Font found
    }

    // Return false if the font could not be loaded
    return false; // Font not found
}

int main(int argc, char *argv[])
{
    // Initialize SDL2 and SDL_ttf libraries
    if (SDL_Init(SDL_INIT_VIDEO) < 0 || TTF_Init() < 0)
    {
        // Print error message if initialization fails
        std::cerr << "Failed to initialize SDL2 or SDL_ttf: " << TTF_GetError() << std::endl;
        return 1; // Exit with error code
    }

    // Path to the font file (ensure the font file is present in the same directory)
    std::string font_path = "arial.ttf";

    // Check if the font is available
    if (has_font(font_path))
    {
        // Display the text to show the result
        std::cout << "Font found!" << std::endl;
    }
    else
    {
        // Print message if the font is not found
        std::cout << "Font not found!" << std::endl;
    }

    // Clean up and quit the SDL2 and SDL_ttf libraries
    TTF_Quit();
    SDL_Quit();

    // Exit the program successfully
    return 0;
}
