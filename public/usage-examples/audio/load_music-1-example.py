from splashkit import *

# Check if audio is ready to use
if not audio_ready():
    open_audio()

music_names = ["adventure", "NoAdventure"]

load_music("adventure", "time_for_adventure.mp3")

for i in range(len(music_names)):
    # Check for successful load
    if has_music(music_names[i]):
        write_line(f"{music_names[i]} successfully loaded. Ready for playback.")
    else:
        write_line(f"Failed to load {music_names[i]}, check file location.")

# Cleanup
free_all_music()
