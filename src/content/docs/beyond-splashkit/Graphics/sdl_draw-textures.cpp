#include <iostream>
#include <SDL2/SDL.h>
#include <SDL2/SDL_image.h>


SDL_Window* sdl_open_window()
{
    // Open window without SplashKit.

    //Declare Variables
    SDL_Window* window=nullptr;

    //Check for successful initialisation
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
SDL_Renderer* sdl_create_renderer(SDL_Window* window)
{
    SDL_Renderer* renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);
    if (renderer == NULL) {
        SDL_LogError(SDL_LOG_CATEGORY_ERROR, "Could not create rederer: %s\n", SDL_GetError());
        exit(1);
    }

    return renderer;
}


int main(int argv, char** args)
{
    // This program demonstrates how we can load textures and draw them on a window without using splashkit 
    
    SDL_Window* window = sdl_open_window();
    SDL_Renderer* renderer = sdl_create_renderer(window);


    // Create a surface for imported image
    SDL_Surface* background = IMG_Load("Resources/images/photo.jpg");
    if (background == NULL) {
        std::cout << "Failed to load background.jpg" << SDL_GetError();
        exit(1);
    }  
    // Convert surface to texture
    SDL_Texture* background_texture = SDL_CreateTextureFromSurface(renderer, background);
    if (background_texture == NULL) {
        std::cout << "Failed to create texture" << SDL_GetError();
        exit(1);
    }
    SDL_FreeSurface(background); // Free memory

    // Get image size to avoid stretching
    int background_width = 0, background_height = 0;
    SDL_QueryTexture(background_texture, NULL, NULL, &background_width, &background_height);

    // Hang window until quit
    SDL_Event event;
    while (event.type != SDL_QUIT) {
        SDL_PollEvent(&event);

        // Draw image to screen
        SDL_Rect background_rect = { 75, 125, background_width, background_height }; 
        SDL_RenderCopy(renderer, background_texture, NULL, &background_rect); 

        // Display drawing
        SDL_RenderPresent(renderer);

    }
    // Cleanup and free memory
    SDL_DestroyWindow(window);
    SDL_DestroyRenderer(renderer);
    return 0;
}