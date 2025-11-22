from splashkit import *

# Load an animation script then free all animation scripts
script = load_animation_script("WalkingScript", "kermit.txt")

free_all_animation_scripts()
write_line("All animation scripts freed.")

free_animation_script(script)
