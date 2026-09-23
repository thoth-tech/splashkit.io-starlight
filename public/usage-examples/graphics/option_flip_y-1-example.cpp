#include "splashkit.h"

int main()
{
    open_window("Image Flipping Simulator", 800, 600);

    int opacity_value = 255;
    string displayed_text = "This bitmap is not flipped along its Y axis";
    bool flipped = false;
    bitmap image_bitmap = load_bitmap("image_bitmap", "image1.jpg");

    while (!quit_requested())
    {
        process_events();

        if (button("Click to invert Y axis", rectangle_from(320, 450, 160, 30)) && flipped == false)
        {
            opacity_value = 0;
            displayed_text = "This bitmap has been flipped along its Y axis";
            flipped = true;
        }
        else if (button("Click to invert Y axis", rectangle_from(320, 450, 160, 30)) && flipped == true)
        {
            opacity_value = 0;
            displayed_text = "This bitmap is not flipped along its Y axis";
            flipped = false;
        }

        if (opacity_value != 255)
        {
            opacity_value += 1;
        }

        clear_screen(color_white());
        if (flipped == false)
        {
            draw_bitmap(image_bitmap, 200, 155);
        }
        else
        {
            draw_bitmap(image_bitmap, 200, 155, option_flip_y());
        }
        draw_text(displayed_text, rgba_color(0, 0, 0, opacity_value), 200, 100);
        draw_interface();
        refresh_screen();
    }
    close_all_windows();
    return 0;
}