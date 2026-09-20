from splashkit import *

audio_closed = False

open_window("Audio Control Demonstration", 700, 420)
open_audio()

while not quit_requested():
    process_events()

    # Close the audio system once when the user requests it.
    if key_typed(KeyCode.space_key) and not audio_closed:
        close_audio()
        audio_closed = True

    clear_screen(rgb_color(242, 246, 252))
    fill_rectangle(rgb_color(31, 45, 72), 0, 0, 700, 90)
    draw_text("Close Audio Demonstration", color_white(), 215, 35)

    draw_text("Press SPACE to close the SplashKit audio system.", color_black(), 180, 135)
    fill_rectangle(color_white(), 170, 190, 360, 110)

    if audio_closed:
        fill_circle(rgb_color(211, 47, 47), 225, 245, 18)
        draw_text("Audio status: CLOSED", rgb_color(211, 47, 47), 265, 238)
        draw_text("All audio has been stopped.", color_black(), 250, 270)
    else:
        fill_circle(rgb_color(46, 125, 50), 225, 245, 18)
        draw_text("Audio status: READY", rgb_color(46, 125, 50), 265, 238)
        draw_text("The audio system is available.", color_black(), 245, 270)

    draw_text("Close the window to finish.", rgb_color(80, 90, 105), 260, 350)
    refresh_screen_with_target_fps(60)

# Release the audio system if the window was closed before Space was pressed.
if not audio_closed:
    close_audio()
