from splashkit import *

open_window("Start-Stop Stopwatch", 600, 300)

# Create a named timer - it is not started until start_timer is called
game_timer = create_timer("game_timer")

while not quit_requested():
    process_events()

    # Start the timer when SPACE is pressed
    if key_typed(KeyCode.space_key):
        start_timer(game_timer)

    # Stop the timer when S is pressed
    if key_typed(KeyCode.s_key):
        stop_timer(game_timer)

    clear_screen(color_white())

    # Use timer_started to check whether the timer is currently running
    is_running = timer_started(game_timer)

    # Display the timer status
    if is_running:
        draw_text_font_as_string("Status: Running", color_green(), "Arial", 28, 170, 80)
    else:
        draw_text_font_as_string("Status: Stopped", color_red(), "Arial", 28, 170, 80)

    # Display elapsed milliseconds
    draw_text_font_as_string("Elapsed: " + str(timer_ticks(game_timer)) + " ms",
                             color_black(), "Arial", 20, 185, 140)

    draw_text_font_as_string("[SPACE] Start   [S] Stop", color_gray(), "Arial", 16, 165, 220)

    refresh_screen_with_target_fps(60)

close_all_windows()
