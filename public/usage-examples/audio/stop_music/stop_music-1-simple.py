from splashkit import *


# Check if audio is ready to use
if not audio_ready():
    open_audio()

# Load music file
music = load_music("adventure", "time_for_adventure.mp3")
play_music(music)

open_window("Stop Music", 300, 200)
draw_text_no_font_no_size("Click to stop the music", color_black(), 25, 100)
refresh_screen()

while not quit_requested():

    process_events()
    # Check for pause/play request
    if(mouse_clicked(MouseButton.left_button)):
    
        clear_screen(color_white())
        stop_music()
        draw_text_no_font_no_size("Music Stopped. Exiting...", color_black(), 25, 100)
        refresh_screen()
        delay(1300)
        close_all_windows()
        

# Cleanup
free_all_music()   