#include <iostream>
#include <SDL2/SDL.h>
#include <splashkit.h>

void no_sk_version()
{
    
    // This version uses the SDL2 library to draw a rectangle to a screen.
    // This would be quite similar to what is happening behind the scenes when using splashkit functions
    
    SDL_Window* window=nullptr;

    //Check for successful initialisation
    if(SDL_Init(SDL_INIT_VIDEO) < 0){
        std::cout << "SDL could not be initialized: " << SDL_GetError();
    }

    // Create Window
    window = SDL_CreateWindow(
        "Draw SDL2 Rectangle",                  
        SDL_WINDOWPOS_CENTERED,            
        SDL_WINDOWPOS_CENTERED,   
        600,                               
        600,                               
        SDL_WINDOW_OPENGL                  
    );

    if (window == NULL) {
        SDL_LogError(SDL_LOG_CATEGORY_ERROR, "Could not create window: %s\n", SDL_GetError());
        exit(1);
    }

    // Create renderer
    SDL_Renderer* renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);
    if (renderer == NULL) {
        SDL_LogError(SDL_LOG_CATEGORY_ERROR, "Could not create rederer: %s\n", SDL_GetError());
        exit(1);
    }

    // Define a rectangle
    SDL_Rect rect = { 100, 100, 400, 300 }; 

    // Clear screen with a black color
    SDL_SetRenderDrawColor(renderer, 0, 0, 0, 255);
    SDL_RenderClear(renderer);

    // Set rectangle color to blue
    SDL_SetRenderDrawColor(renderer, 0, 0, 255, 255);

    // Draw & fill rectangle s
    SDL_RenderDrawRect(renderer, &rect);
    SDL_RenderFillRect(renderer, &rect);

    // Display drawing
    SDL_RenderPresent(renderer);


    SDL_Event event;
    while (event.type != SDL_QUIT) {
        // check for quit requested
        SDL_PollEvent(&event);
    }

    // Cleanup and free memory
    SDL_DestroyRenderer(renderer);
    SDL_DestroyWindow(window);
    SDL_Quit();
}

void sk_version()
{
    
    // This version purely uses SplashKit functions
    // What is shown here is an abstracted version of what is happening above
    
    open_window("Draw SplashKit Rectangle", 600, 600); //Create window
    rectangle rect = rectangle_from(100,100,400,300); //Define a rectangle
    clear_screen(COLOR_BLACK);// Clear screen with a black color
    fill_rectangle(COLOR_BLUE, rect); //Draw & fill rectangle
    refresh_screen(); // Display drawing

    // Hold window until quit requested
    while(!quit_requested())
    {
        process_events();
    }

    // Cleanup and free memory
    close_all_windows();
}

int main(int argv, char** args)
{

    no_sk_version();
    sk_version();
    
    return 0;
}

