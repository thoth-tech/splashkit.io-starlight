from splashkit import *

window = open_window("timer_ticks Example", 800, 600)

timer = create_timer("demo timer")
start_timer(timer)

font = get_system_font()

while not window_close_requested(window):
    process_events()
    clear_screen(color_white())

    elapsed = timer_ticks(timer)

    draw_text("timer_ticks Example", color_black(), font, 24, 20, 20)
    draw_text("Elapsed time (ms): " + str(elapsed), color_blue(), font, 24, 20, 70)
    draw_text("This value increases while the timer is running.", color_green(), font, 24, 20, 120)

    refresh_screen()

    if elapsed > 5000:
        break

close_all_windows()