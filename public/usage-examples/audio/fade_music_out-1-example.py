from splashkit import *

# Check if audio is ready to use
if not audio_ready():
    open_audio()

# Load music file and start playback
load_music("adventure", "time_for_adventure.mp3")
play_music_named("adventure")

# Wait 1 second before fadeout
delay(1000)

# Fade music out over 3 seconds
fade_music_out(3000)

# Hold program for 4 seconds
delay(4000)

# Free resources
free_all_music()
