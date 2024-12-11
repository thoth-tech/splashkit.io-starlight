#include "splashkit.h"

int main()
{
    // Check if audio is ready to use
    if(! audio_ready())
        open_audio();

    // Load music file and start playback
    music music = load_music("adventure", "time_for_adventure.mp3");
    play_music(music);
    // Open Window
    open_window("Music File", 600, 600);

    // Main Loop
    while (! quit_requested())
    {
        process_events();
        
        clear_screen(COLOR_WHITE);
        // Draw name of music track to screen
        draw_text("Current Music: " + music_name(music),COLOR_BLACK,100,300);
        refresh_screen();
    }
    close_all_windows();
    free_music(music);

}