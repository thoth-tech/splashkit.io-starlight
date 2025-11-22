from splashkit import *

script = load_animation_script("WalkingScript", "kermit.txt")
idx = animation_index(script, "WalkFront")
write_line(f"Index of WalkFront: {idx}")

free_animation_script(script)
