#include "splashkit.h"

int main()
{
    // Declare Variables
    double volume = 1.0;
    double m_scroll_val = 1.0;
    double scroll_delta = m_scroll_val;
    //  Check if audio is ready to use
    if(! audio_ready())
        open_audio();

    //  Load music file and start playback
    load_music("adventure", "time_for_adventure.mp3");
    play_music("adventure");

    // Open Window
    open_window("Change Volume", 800, 600);

    // Main Loop
    while (! quit_requested())
    {
        process_events();

        // Check for mouse scroll
        m_scroll_val = m_scroll_val + mouse_wheel_scroll().y;

        // Check if scroll up & volume not max
        if(scroll_delta > m_scroll_val && volume > 0)
        {
            volume -= 0.01;
        }
        // Check if scroll down & volume not min
        if(scroll_delta < m_scroll_val && volume < 1)
        {
            volume += 0.01;
        }
        // Set volume
        set_music_volume(volume);

        // Stop scroll input from affecting the next iteration
        scroll_delta = m_scroll_val;

        // Draw volume to screen
        clear_screen(COLOR_WHITE);
        draw_text("Scroll to change the volume",COLOR_BLACK,100,100);
        draw_text("Volume: %" + std::to_string(static_cast<int>(music_volume() * 100)),COLOR_BLACK,100,300);
        refresh_screen();

        // Loop Music
        if (!music_playing())
        {
            play_music("adventure");
        }
    }
    // Cleanup
    close_all_windows();
    free_all_music();

    return 0;
}