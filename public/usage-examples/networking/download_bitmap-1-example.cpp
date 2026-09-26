#include "splashkit.h"

int main()
{
    string image_url =
        "https://programmers.guide/resources/code-examples/part-0/earth.png";

    // Download the bitmap from the web server
    bitmap earth = download_bitmap("Earth", image_url, 443);

    open_window("Downloaded Bitmap", 700, 500);

    while (!quit_requested())
    {
        process_events();

        clear_screen(color_white());

        draw_text(
            "Bitmap downloaded from the internet",
            color_black(),
            170,
            40
        );

        // Draw the downloaded bitmap
        draw_bitmap(earth, 220, 100);

        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}