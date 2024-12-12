#include <iostream>
#include <SDL2/SDL.h>



SDL_Window* sdl_open_window()
{
    // This function demonstrates how we can open window without SplashKit.

    // Declare Variables
    SDL_Window* window = nullptr;

    // Check for successful initialisation
    if(SDL_Init(SDL_INIT_VIDEO) < 0){
        std::cout << "SDL could not be initialized: " << SDL_GetError();
        exit(1);
    }

    // Create Window
    window = SDL_CreateWindow(
        "No SK Window",                  
        SDL_WINDOWPOS_CENTERED,            
        SDL_WINDOWPOS_CENTERED,   
        800,                               
        600,                               
        SDL_WINDOW_OPENGL                  
    );
    // Error handling for window
    if (window == NULL) {
        SDL_LogError(SDL_LOG_CATEGORY_ERROR, "Could not create window: %s\n", SDL_GetError());
        exit(1);
    }   

    return window;
}

int main(int argv, char** args)
{
    
    SDL_Window* window = sdl_open_window();
    
    // Hang window until quit
    SDL_Event event;
    while (event.type != SDL_QUIT) {
        SDL_PollEvent(&event);
    }
    // Cleanup and free memory
    SDL_DestroyWindow(window);
    return 0;
}