from splashkit import *

# Load the script and create a simple animation object
script = load_animation_script("WalkingScript", "kermit.txt")
anim = create_animation()

# Assign the animation to follow the named animation inside the script
assign_animation_with_script(anim, script, "WalkFront")
write_line(f"Assigned animation -> script index: {animation_index(script, 'WalkFront')}")

free_animation(anim)
free_animation_script(script)
