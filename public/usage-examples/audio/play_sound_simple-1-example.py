from splashkit import *

# Init audio
if not audio_ready():
    open_audio()

# Load short sound effects
load_sound_effect("beep", "short_beep.mp3")

# Play sound effect
play_sound_effect("beep")

# Wait so the sound can be heard
delay(1500)

# Free resources
free_all_sound_effects()
