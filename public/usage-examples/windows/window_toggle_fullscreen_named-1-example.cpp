#include "splashkit.h"

int main()
{
    // The remote only needs the player's caption, so it never has to hold the player's window handle
    string player_caption = "Video Player";

    window remote_window = open_window("Remote Control", 480, 280);
    window player_window = open_window(player_caption, 480, 280);

    // Place the windows side by side so both stay visible
    move_window_to(remote_window, 60, 100);
    move_window_to(player_window, 580, 100);

    int command_count = 0;

    while (!quit_requested())
    {
        process_events();

        // Pressing F is the remote's fullscreen button, and pressing it again undoes it
        if (key_typed(F_KEY))
        {
            window_toggle_fullscreen(player_caption);
            command_count++;
        }

        clear_window(remote_window, COLOR_WHITE);
        draw_text_on_window(remote_window, "Remote Control", COLOR_BLACK, "arial", 40, 20, 40);
        draw_text_on_window(remote_window, "Press F to toggle the player", COLOR_DARK_GRAY, "arial", 20, 20, 130);
        refresh_window(remote_window);

        // Count the commands on the player itself, because the remote is hidden while the player fills the screen
        clear_window(player_window, COLOR_BLACK);
        draw_text_on_window(player_window, "Now Playing", COLOR_WHITE, "arial", 40, 20, 40);
        draw_text_on_window(player_window, "Commands received: " + std::to_string(command_count), COLOR_LIGHT_GRAY, "arial", 30, 20, 120);
        draw_text_on_window(player_window, "Press F to toggle", COLOR_LIGHT_GRAY, "arial", 20, 20, 190);
        refresh_window(player_window);
    }

    close_all_windows();
    return 0;
}
