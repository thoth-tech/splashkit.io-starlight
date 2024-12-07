from splashkit import *


# Check if audio is ready to use
if not audio_ready():
    open_audio()

# Load music file
load_music("adventure", "time_for_adventure.mp3")

# Check for successful load
if has_music("adventure"):
    write_line("Music successfully loaded. Ready for playback.")
else:
    write_line("Loading music failed.")

# Cleanup
free_all_music()
