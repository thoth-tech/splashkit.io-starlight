from splashkit import *

open_window("Simple Timer Display", 800, 600)

timer = create_timer("Example Timer")
start_timer(timer)

while not quit_requested():
    process_events()

    elapsed_seconds = timer_ticks(timer) / 1000.0

    clear_screen(color_white())

    draw_text_no_font_no_size("Timer created and running", color_black(), 20, 20)
    draw_text_no_font_no_size(
        "Elapsed time: " + format(elapsed_seconds, ".1f") + " seconds",
        color_black(),
        20,
        60
    )
    draw_text_no_font_no_size(
        "Close the window to finish.",
        color_black(),
        20,
        100
    )

    refresh_screen_with_target_fps(60)

free_timer(timer)