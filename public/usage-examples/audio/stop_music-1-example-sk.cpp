#include "splashkit.h"

int main()
{
    // Check if audio is ready to use
    if(! audio_ready())
    {
        open_audio();
    }
        

    // Load music file
    music music = load_music("adventure", "time_for_adventure.mp3");
    play_music(music);
    bool music_playing = true;

    open_window("Stop/Start", 300, 200);

    while(! quit_requested())
    {
        process_events();
        // Check for stop/play request
        if(mouse_clicked(LEFT_BUTTON))
        {
            if (music_playing)
                {
                    // Stop if playing
                    stop_music();
                    music_playing = false;
                }
                else
                {
                    // Play if stopped
                    play_music(music);
                    music_playing = true;
                }
         }

        // Display text showing if music is playing or not
        clear_screen(COLOR_WHITE);
        if (music_playing)
        {
            draw_text("Music Playing", COLOR_BLACK, 100, 100);
        }
        else
        {
            draw_text("Music Stopped", COLOR_BLACK, 100, 100);
        }
        refresh_screen();
    }

    // Cleanup
    free_all_music();    
}