from splashkit import *


# Check if audio is ready to use
if not audio_ready():
    open_audio()

# Load music file and start playback
music = load_music("adventure", "time_for_adventure.mp3")
play_music(music)

# Open Window
open_window("Music File", 600, 600)

# Main Loop
while not quit_requested():

    process_events()
    
    clear_screen(color_white())
    # Draw name of music track to screen
    draw_text_no_font_no_size("Current Music: " + music_name(music),color_black(),100,300)
    refresh_screen()
close_all_windows()
free_music(music)
