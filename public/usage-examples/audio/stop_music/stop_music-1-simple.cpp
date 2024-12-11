#include "splashkit.h"

int main()
{
    // Check if audio is ready to use
    if(! audio_ready())
        open_audio();

    // Load music file
    music music = load_music("adventure", "time_for_adventure.mp3");
    play_music(music);
    
    open_window("Stop Music", 300, 200);
    draw_text("Click to stop the music", COLOR_BLACK, 25, 100);
    refresh_screen();

    while(! quit_requested())
    {
        process_events();
        // Check for pause/play request
        if(mouse_clicked(LEFT_BUTTON))
        {
            clear_screen(COLOR_WHITE);
            stop_music();
            draw_text("Music Stopped. Exiting...", COLOR_BLACK, 25, 100);
            refresh_screen();
            delay(1300);
            close_all_windows();
        }      
    }
    // Cleanup
    free_all_music();    
}