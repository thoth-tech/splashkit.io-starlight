#include "splashkit.h"

int main()
{
    open_window("Save Bitmap", 800, 600);

    int opacity_value = 0;
    bitmap image_bitmap = load_bitmap("image_bitmap", "image1.jpg");

    while (!quit_requested())
    {
        process_events();

        if (key_typed(RETURN_KEY))
        {
            save_bitmap(image_bitmap, "saved_bitmap");
            opacity_value = 2500;
        }

        if (opacity_value != 0)
        {
            opacity_value -= 1;
        }

        clear_screen(color_white());
        draw_bitmap(image_bitmap, 200, 155);
        draw_text("Press the 'Enter' key to save the above bitmap to desktop", color_black(), 175, 450);
        draw_text("Image saved to desktop!", rgba_color(0, 0, 0, opacity_value), 310, 470);
        refresh_screen();
    }
    close_all_windows();
    return 0;
}