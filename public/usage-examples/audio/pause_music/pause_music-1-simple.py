from splashkit import *


music_state = 1
# Check if audio is ready to use
if not audio_ready():
    open_audio()

# Load music file
music = load_music("adventure", "time_for_adventure.mp3")
play_music(music)

open_window("Pause/Resume", 300, 200)
draw_text_no_font_no_size("Playing", color_black(), 100, 100)

while not quit_requested():
    process_events()
    # Check for pause/play request
    if(key_down(KeyCode.space_key)):
    
        clear_screen(color_white())
        # Check if music is paused or not
        if music_state == 1: # Pause if playing
            pause_music()
            music_state = 0
            draw_text_no_font_no_size("Paused...", color_black(), 100,100)
       
        else: # Play if paused
            resume_music()
            music_state = 1
            draw_text_no_font_no_size("Playing", color_black(), 100, 100)
       
    
    refresh_screen()
    delay(200)

# Cleanup
free_all_music()    
close_all_windows()