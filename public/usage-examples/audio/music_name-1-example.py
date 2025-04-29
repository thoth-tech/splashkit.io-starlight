from splashkit import *

# Check if audio is ready to use
if not audio_ready():
    open_audio()
    
# Load music file and start playback
music_1 = load_music("byte blast", "byte-blast.mp3")
music_2 = load_music("pixel fight", "pixel-fight.mp3")
current_track = music_1
play_music(current_track)

# Open Window
open_window("Music File", 600, 600)

rect = rectangle_from(235, 275, 125, 100)

# Main Loop
while not quit_requested():
    # Create next track button
    clear_screen(color_white())
    fill_triangle(color_black(), 250, 275, 325, 325, 250, 375)
    fill_rectangle(color_black(), 235, 275, 10, 100)
    draw_rectangle_record(color_white(), rect)

    # Draw name of music track to screen
    draw_text_no_font_no_size("Current Music: " + music_name(current_track), color_black(), 100, 150)
    refresh_screen()

    process_events()

    # Check for button click
    if (mouse_clicked(MouseButton.left_button) & point_in_rectangle(mouse_position(), rect)):
        if (current_track == music_1):
            current_track = music_2
            play_music(current_track)
        else:
            current_track = music_1
            play_music(current_track)
    
close_all_windows()
free_all_music()
