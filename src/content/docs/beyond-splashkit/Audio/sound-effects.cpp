#include "splashkit.h"
#include <iostream>
#include <SDL2/SDL.h>
#include <SDL2/SDL_mixer.h>

SDL_Window* sdl_open_window()
{
    // Open window without SplashKit.

    // Declare Variables
    SDL_Window* window=nullptr;

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

void music_and_effects_no_sk()
{
    // Open Window and load sound effects
    SDL_Window* window = sdl_open_window();
    // Check for successful initialisation
    if(SDL_Init(SDL_INIT_VIDEO) < 0 | SDL_Init(SDL_INIT_AUDIO) < 0){
        std::cout << "SDL could not be initialized: " << SDL_GetError();
        exit(1);
    }
    if ( Mix_OpenAudio(MIX_DEFAULT_FREQUENCY, MIX_DEFAULT_FORMAT, 2, 4096 ) < 0 )
    {
        std::cout << "SDL Mixer could not be initialized: " << SDL_GetError();
        exit(1);
    }

    Mix_Chunk* jump = Mix_LoadWAV("Resources/sounds/jump.wav");
    Mix_Chunk* explosion = Mix_LoadWAV("Resources/sounds/explosion.wav");
    Mix_Music* music = Mix_LoadMUS("Resources/sounds/time_for_adventure.mp3");
    if (jump == NULL | explosion == NULL | music == NULL) {
        SDL_LogError(SDL_LOG_CATEGORY_ERROR, "Could not create audio: %s\n", Mix_GetError());
        exit(1);
    }   
    Mix_PlayMusic(music, -1);

    // Hang window until quit
    SDL_Event event;
    while (event.type != SDL_QUIT) {

        if (event.type == SDL_MOUSEBUTTONDOWN) {
        Mix_PlayChannel(-1, explosion, 0);
        }
        if (event.type == SDL_KEYDOWN && event.key.keysym.sym == SDLK_SPACE) {
            Mix_PlayChannel(-1, jump, 0);
        }
        SDL_PollEvent(&event);
    }
    // Cleanup and free memory
    SDL_DestroyWindow(window);
    Mix_FreeMusic(music);
    Mix_FreeChunk(jump);
    Mix_FreeChunk(explosion);
}


void music_and_effects_sk()
{
    float volume = 0.5;
    // Open Window and load sound effects
    open_window("test", 600,600);
    load_sound_effect("jump","jump.wav");
    load_sound_effect("explosion","explosion.wav");
    load_music("adventure", "time_for_adventure.mp3");
    play_music("adventure",1000);

    // Hang window until quit
    while (!quit_requested())
    {
        process_events();
        if(key_down(SPACE_KEY)) 
            play_sound_effect("jump");
        if(mouse_clicked(LEFT_BUTTON))
            play_sound_effect("explosion",volume);
    }
    // Cleanup and free memory
    close_all_windows();
    free_all_sound_effects();
    free_all_music();
}

int main(int argv, char** args)
{
    music_and_effects_no_sk();
    music_and_effects_sk();
    
    return 0;
}