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
    bool music_state = true;

    // Open Window
    open_window("Music File", 600, 600);

    // Create bitmap for pause/play button
    bitmap play_pause = create_bitmap("play_pause", 75, 100);
    fill_rectangle_on_bitmap(play_pause, COLOR_BLACK, 0, 0, 25, 100);
    fill_rectangle_on_bitmap(play_pause, COLOR_BLACK, 50, 0, 25, 100);

    // Main Loop
    while (!quit_requested())
    {
        // Create next track button
        clear_screen(COLOR_WHITE);
        fill_triangle(COLOR_BLACK, 250, 275, 325, 325, 250, 375);
        fill_rectangle(COLOR_BLACK, 330, 275, 10, 100);
        draw_bitmap(play_pause, 125, 275);

        // Draw name of music track to screen
        draw_text("Current Music: " + music_name(current_track), COLOR_BLACK, 100, 150);
        refresh_screen();

        process_events();

        // Check for button click
        if (mouse_clicked(LEFT_BUTTON) && point_in_rectangle(mouse_position(), rectangle_from(250, 275, 125, 100)))
        {
            if (current_track == music_1)
            {
                current_track = music_2;
                play_music(current_track);
                music_state = true;
                clear_bitmap(play_pause, COLOR_WHITE);
                fill_rectangle_on_bitmap(play_pause, COLOR_BLACK, 0, 0, 25, 100);
                fill_rectangle_on_bitmap(play_pause, COLOR_BLACK, 50, 0, 25, 100);
            }
            else
            {
                current_track = music_1;
                play_music(current_track);
                music_state = true;
                clear_bitmap(play_pause, COLOR_WHITE);
                fill_rectangle_on_bitmap(play_pause, COLOR_BLACK, 0, 0, 25, 100);
                fill_rectangle_on_bitmap(play_pause, COLOR_BLACK, 50, 0, 25, 100);
            }
        }
        // Check for play/pause
        if (mouse_clicked(LEFT_BUTTON) && point_in_rectangle(mouse_position(), rectangle_from(125, 275, 75, 100)))
        {
            // Check if music is paused or not
            if (music_state) // Pause if playing
            {
                pause_music();
                music_state = false;
                clear_bitmap(play_pause, COLOR_WHITE);
                fill_triangle_on_bitmap(play_pause, COLOR_BLACK, 0, 0, 75, 50, 0, 100);
            }
            else // Play if paused
            {
                resume_music();
                music_state = true;
                clear_bitmap(play_pause, COLOR_WHITE);
                fill_rectangle_on_bitmap(play_pause, COLOR_BLACK, 0, 0, 25, 100);
                fill_rectangle_on_bitmap(play_pause, COLOR_BLACK, 50, 0, 25, 100);

            }
        }
    }
    close_all_windows();
    free_all_music();
    return 0;
}