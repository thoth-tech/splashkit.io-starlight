from splashkit import *


image_url = (
    "https://programmers.guide/resources/code-examples/"
    "part-0/earth.png"
)

# Download the bitmap from the web server
earth = download_bitmap("Earth", image_url, 443)

open_window("Downloaded Bitmap", 700, 500)

while not quit_requested():
    process_events()

    clear_screen(color_white())

    draw_text_font_as_string(
        "Bitmap downloaded from the internet",
        color_black(),
        "Arial",
        20,
        170,
        40
    )

    # Draw the downloaded bitmap
    draw_bitmap(earth, 220, 100)

    refresh_screen_with_target_fps(60)

close_all_windows()