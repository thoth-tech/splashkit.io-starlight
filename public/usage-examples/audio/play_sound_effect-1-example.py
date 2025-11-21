from splashkit import *

open_audio()
load_sound_effect("beep", "beep.ogg")
s = sound_effect_named("beep")
play_sound_effect(s)
delay(1200)
close_audio()
