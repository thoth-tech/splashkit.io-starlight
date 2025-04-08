from splashkit import *

# Check if audio is ready to use
if not audio_ready():
    open_audio()

# Load music file
load_music("adventure", "time_for_adventure.mp3")

# Fade music in over 2 seconds
fade_music_in_named("adventure",2000)

# Hold program for 10 seconds
delay(10000)

# Free resources
free_all_music()
