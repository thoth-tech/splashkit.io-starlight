// Usage Example for: https://splashkit.io/api/graphics/#set-clip-3
// Goal: I am letting the user drag a rectangle and I am calling set_clip(...) to limit later drawing to that region.
// Why: I am showing that clipping is restricting drawing; I am pressing R to reset to the full window.
// Controls: I am dragging with Left Mouse | I am pressing R to reset | I am pressing ESC to quit.

#include "splashkit.h"

int main()
{
    open_window("set_clip, drag to select, R to reset", 800, 500);

    bool is_dragging = false;     // I am tracking whether I am dragging right now
    int  drag_start_x = 0;        // I am remembering where the drag is starting (x)
    int  drag_start_y = 0;        // I am remembering where the drag is starting (y)
    int  frame_count  = 0;        // I am ticking a small animation so clipping is obvious

    while (!quit_requested())
    {
        process_events();

        // I am quitting on ESC
        if (key_typed(ESCAPE_KEY))
        {
            break;
        }

        // I am resetting the clip when I am pressing R
        if (key_typed(R_KEY))
        {
            reset_clip();
        }

        // I am beginning a drag when the left mouse button is going down
        if (!is_dragging && mouse_down(LEFT_BUTTON))
        {
            is_dragging  = true;
            drag_start_x = mouse_x();
            drag_start_y = mouse_y();
        }

        // I am finishing the drag on release and I am setting the clip to that rectangle
        if (is_dragging && !mouse_down(LEFT_BUTTON))
        {
            int drag_end_x = mouse_x();
            int drag_end_y = mouse_y();

            int clip_x;
            if (drag_start_x < drag_end_x)
            {
                clip_x = drag_start_x;
            }
            else
            {
                clip_x = drag_end_x;
            }

            int clip_y;
            if (drag_start_y < drag_end_y)
            {
                clip_y = drag_start_y;
            }
            else
            {
                clip_y = drag_end_y;
            }

            int clip_w = abs(drag_end_x - drag_start_x);
            int clip_h = abs(drag_end_y - drag_start_y);

            if (clip_w > 0 && clip_h > 0)
            {
                set_clip(rectangle_from(clip_x, clip_y, clip_w, clip_h));
            }

            is_dragging = false;
        }

        clear_screen(COLOR_WHITE);

        // I am drawing a moving background so the clipping area is easy to see
        int stripe_offset = frame_count % 60;
        for (int x = -60 + stripe_offset; x < 800; x += 60)
        {
            fill_rectangle(rgb_color(220, 240, 255), x, 0, 30, 500);
        }
        for (int y = 0; y < 500; y += 40)
        {
            draw_line(COLOR_LIGHT_STEEL_BLUE, 0, y, 800, y);
        }

        // I am showing the instructions in ASCII-only text
        draw_text("Drag to set clip | Press R to reset | ESC to quit", COLOR_NAVY, 16, 16);

        // I am drawing a red rubber-band during the drag and I am making sure it is never clipped
        if (is_dragging)
        {
            int drag_end_x = mouse_x();
            int drag_end_y = mouse_y();

            int rect_x;
            if (drag_start_x < drag_end_x)
            {
                rect_x = drag_start_x;
            }
            else
            {
                rect_x = drag_end_x;
            }

            int rect_y;
            if (drag_start_y < drag_end_y)
            {
                rect_y = drag_start_y;
            }
            else
            {
                rect_y = drag_end_y;
            }

            int rect_w = abs(drag_end_x - drag_start_x);
            int rect_h = abs(drag_end_y - drag_start_y);

            reset_clip(); // I am ensuring the preview outline is not affected by any current clip
            draw_rectangle(COLOR_RED, rect_x, rect_y, rect_w, rect_h);
        }

        refresh_screen(60);
        frame_count++;
    }

    // I am closing all windows after I am leaving the loop
    close_all_windows();
    return 0;
}