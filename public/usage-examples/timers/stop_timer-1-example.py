from splashkit import *

open_window("Press S to Stop Timer", 700, 220)

create_timer("demo")
start_timer_named("demo")

while not quit_requested():
    process_events()

    if key_typed(KeyCode.s_key) and timer_started_named("demo"):
        stop_timer_named("demo")

    status = "Running" if timer_started_named("demo") else "Stopped"
    ticks = timer_ticks_named("demo")

    clear_screen(color_white())

    draw_text_no_font_no_size("Press S to stop the timer", color_black(), 20, 20)
    draw_text_no_font_no_size(f"Status: {status}", color_blue(), 20, 70)
    draw_text_no_font_no_size(f"Ticks: {ticks}", color_red(), 20, 110)

    refresh_screen()

close_all_windows()