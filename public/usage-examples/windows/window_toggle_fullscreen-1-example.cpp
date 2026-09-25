#include "splashkit.h"

int main()
{
    window notes_window = open_window("Presenter Notes", 480, 280);
    window projector_window = open_window("Projector", 480, 280);

    // Place the windows side by side so both stay visible
    move_window_to(notes_window, 60, 100);
    move_window_to(projector_window, 580, 100);

    int toggle_count = 0;

    while (!quit_requested())
    {
        process_events();

        // Only the projector goes fullscreen, so the notes stay on the presenter's own screen
        if (key_typed(F_KEY))
        {
            window_toggle_fullscreen(projector_window);
            toggle_count++;
        }

        clear_window(notes_window, COLOR_WHITE);
        draw_text_on_window(notes_window, "Presenter Notes", COLOR_BLACK, "arial", 40, 20, 40);
        draw_text_on_window(notes_window, "Press F to toggle the projector", COLOR_DARK_GRAY, "arial", 20, 20, 130);
        refresh_window(notes_window);

        // Show the count on the projector itself, because the notes are hidden while it fills the screen
        if (window_is_fullscreen(projector_window))
        {
            clear_window(projector_window, COLOR_BLACK);
            draw_text_on_window(projector_window, "Big Slide", COLOR_WHITE, "arial", 40, 20, 40);
            draw_text_on_window(projector_window, "Toggles so far: " + std::to_string(toggle_count), COLOR_LIGHT_GRAY, "arial", 30, 20, 120);
        }
        else
        {
            clear_window(projector_window, COLOR_WHITE);
            draw_text_on_window(projector_window, "Big Slide", COLOR_BLACK, "arial", 40, 20, 40);
            draw_text_on_window(projector_window, "Toggles so far: " + std::to_string(toggle_count), COLOR_DARK_GRAY, "arial", 30, 20, 120);
        }

        refresh_window(projector_window);
    }

    close_all_windows();
    return 0;
}
