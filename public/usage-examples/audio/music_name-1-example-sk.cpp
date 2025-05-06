#include "splashkit.h"

int main()
{
    // Check if audio is ready to use
    if(!audio_ready())
    {
        open_audio();
    }
    // Load music file and start playback
    music music_1 = load_music("byte blast", "byte-blast.mp3");
    music music_2 = load_music("pixel fight", "pixel-fight.mp3");
    music current_track = music_1;
    play_music(current_track);

    // Open Window
    open_window("Music File", 600, 600);

    rectangle rect = rectangle_from(235, 275, 125, 100);

    // Main Loop
    while (!quit_requested())
    {
        // Create next track button
        clear_screen(COLOR_WHITE);
        fill_triangle(COLOR_BLACK, 250, 275, 325, 325, 250, 375);
        fill_rectangle(COLOR_BLACK, 235, 275, 10, 100);
        draw_rectangle(COLOR_WHITE, rect);

        // Draw name of music track to screen
        draw_text("Current Music: " + music_name(current_track), COLOR_BLACK, 100, 150);
        refresh_screen();

        process_events();

        // Check for button click
        if (mouse_clicked(LEFT_BUTTON) & point_in_rectangle(mouse_position(), rect))
        {
            if (current_track == music_1)
            {
                current_track = music_2;
                play_music(current_track);
            }
            else
            {
                current_track = music_1;
                play_music(current_track);
            }
        }
    }
    close_all_windows();
    free_all_music();
    return 0;
}