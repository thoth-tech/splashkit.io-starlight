#include "splashkit.h"

int main()
{
    open_window("Animation Frame Tracker", 800, 500);

    animation_script frame_script =
        load_animation_script("FrameCycle", "frame_cycle.txt");
    animation frame_animation = create_animation(frame_script, "Cycle");

    bool entered_new_frame = false;
    int frame_notice_countdown = 0;
    int current_frame = 0;

    while (!quit_requested())
    {
        process_events();
        update_animation(frame_animation);

        entered_new_frame = animation_entered_frame(frame_animation);
        current_frame = animation_current_cell(frame_animation);

        // Keep the triggered message visible long enough to be noticed.
        if (entered_new_frame)
        {
            frame_notice_countdown = 30;
        }
        else if (frame_notice_countdown > 0)
        {
            frame_notice_countdown--;
        }

        clear_screen(COLOR_WHITE);
        draw_text("Animation Frame Tracker", COLOR_BLACK, 270, 60);
        draw_text("The highlighted circle shows the current animation frame.", COLOR_BLACK, 175, 100);

        fill_circle(COLOR_GRAY, 160, 240, 50);
        fill_circle(COLOR_GRAY, 320, 240, 50);
        fill_circle(COLOR_GRAY, 480, 240, 50);
        fill_circle(COLOR_GRAY, 640, 240, 50);

        if (current_frame == 0)
        {
            fill_circle(COLOR_BLUE, 160, 240, 50);
        }
        else if (current_frame == 1)
        {
            fill_circle(COLOR_BLUE, 320, 240, 50);
        }
        else if (current_frame == 2)
        {
            fill_circle(COLOR_BLUE, 480, 240, 50);
        }
        else if (current_frame == 3)
        {
            fill_circle(COLOR_BLUE, 640, 240, 50);
        }

        draw_text("Frame 1", COLOR_BLACK, 130, 310);
        draw_text("Frame 2", COLOR_BLACK, 290, 310);
        draw_text("Frame 3", COLOR_BLACK, 450, 310);
        draw_text("Frame 4", COLOR_BLACK, 610, 310);

        if (frame_notice_countdown > 0)
        {
            draw_text("A new animation frame was entered!", COLOR_GREEN, 245, 390);
        }
        else
        {
            draw_text("Waiting for the next frame...", COLOR_BLACK, 275, 390);
        }

        refresh_screen(60);
    }

    free_animation(frame_animation);
    free_animation_script(frame_script);
    close_all_windows();
    return 0;
}