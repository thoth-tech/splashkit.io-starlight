#include "splashkit.h"

int main()
{
    int music_state = 1;
    //  Check if audio is ready to use
    if(! audio_ready())
        open_audio();

    //  Load music file
    music music = load_music("adventure", "time_for_adventure.mp3");
    play_music(music);
    
    open_window("Pause/Resume", 300, 200);
    draw_text("Playing", COLOR_BLACK, 100, 100);

    while(! quit_requested())
    {
        process_events();
        // Check for pause/play request
        if(key_down(SPACE_KEY))
        {
            clear_screen(COLOR_WHITE);
            // Check if music is paused or not
            if (music_state == 1){ // Pause if playing
                pause_music();
                music_state = 0;
                draw_text("Paused...", COLOR_BLACK, 100,100);
            }
            else{ // Play if paused
                resume_music();
                music_state = 1;
                draw_text("Playing", COLOR_BLACK, 100, 100);
            }
        }
        refresh_screen();
        delay(200);
    }
    // Cleanup
    free_all_music();    
    close_all_windows();
}