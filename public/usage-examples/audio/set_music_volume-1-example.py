from splashkit import *

# Declare Variables
volume = 1.0
m_scroll_val = 1.0
scroll_delta = m_scroll_val
# Check if audio is ready to use
if not audio_ready():
    open_audio()

# Load music file and start playback
load_music("adventure", "time_for_adventure.mp3")
play_music_named("adventure")

# Open Window
open_window("Change Volume", 800, 600)

# Main Loop
while  not quit_requested():

    process_events()

    # Check for mouse scroll
    m_scroll_val = m_scroll_val + mouse_wheel_scroll().y

    # Check if scroll up & volume not max
    if(scroll_delta > m_scroll_val and volume > 0):
        volume -= 0.01

    # Check if scroll down & volume not min
    if(scroll_delta < m_scroll_val  and volume < 1):
        volume += 0.01
    
    # Set volume
    set_music_volume(volume)

    # Stop scroll input from affecting the next iteration
    scroll_delta = m_scroll_val

    # Draw volume to screen
    clear_screen(color_white())
    draw_text_no_font_no_size("Scroll to change the volume",color_black(),100,100)
    draw_text_no_font_no_size(f"Volume: %{int((music_volume() * 100))}",color_black(),100,300)
    refresh_screen()

    # Loop Music
    if not music_playing():
        play_music_named("adventure")

# Cleanup
close_all_windows()
free_all_music()
