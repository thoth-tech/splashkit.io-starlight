from splashkit import *

# Load an animation script and count its animations
script = load_animation_script("WalkingScript", "kermit.txt")
count = animation_count(script)
write_line(f"This script contains {count} animations.")
