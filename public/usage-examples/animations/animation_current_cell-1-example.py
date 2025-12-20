from splashkit import *

# Load an animation script and create the animation
script = load_animation_script("WalkingScript", "kermit.txt")
anim = create_animation(script, "WalkFront")

# Query current cell
cell = animation_current_cell(anim)
write_line(f"Current cell index: {cell}")

# Free resources (good practice in examples)
free_animation(anim)
free_animation_script(script)
