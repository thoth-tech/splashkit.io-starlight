#include "splashkit.h"

int main()
{
    bool audio_closed = false;

    open_window("Audio Control Demonstration", 700, 420);
    open_audio();

    while (!quit_requested())
    {
        process_events();

        // Close the audio system once when the user requests it.
        if (key_typed(SPACE_KEY) && !audio_closed)
        {
            close_audio();
            audio_closed = true;
        }

        clear_screen(rgb_color(242, 246, 252));
        fill_rectangle(rgb_color(31, 45, 72), 0, 0, 700, 90);
        draw_text("Close Audio Demonstration", COLOR_WHITE, 215, 35);

        draw_text("Press SPACE to close the SplashKit audio system.", COLOR_BLACK, 180, 135);
        fill_rectangle(COLOR_WHITE, 170, 190, 360, 110);

        if (audio_closed)
        {
            fill_circle(rgb_color(211, 47, 47), 225, 245, 18);
            draw_text("Audio status: CLOSED", rgb_color(211, 47, 47), 265, 238);
            draw_text("All audio has been stopped.", COLOR_BLACK, 250, 270);
        }
        else
        {
            fill_circle(rgb_color(46, 125, 50), 225, 245, 18);
            draw_text("Audio status: READY", rgb_color(46, 125, 50), 265, 238);
            draw_text("The audio system is available.", COLOR_BLACK, 245, 270);
        }

        draw_text("Close the window to finish.", rgb_color(80, 90, 105), 260, 350);
        refresh_screen(60);
    }

    // Release the audio system if the window was closed before Space was pressed.
    if (!audio_closed)
    {
        close_audio();
    }

    return 0;
}
