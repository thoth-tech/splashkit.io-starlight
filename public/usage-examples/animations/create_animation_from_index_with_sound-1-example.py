from splashkit import *

script = load_animation_script("WalkingScript", "kermit.txt")

# Create animation from the script using index 0 and play sound if available
anim = create_animation_from_index_with_sound(script, 0, True)
write_line(f"Created animation from index 0 -> name: {animation_name(anim)}")

free_animation(anim)
free_animation_script(script)
