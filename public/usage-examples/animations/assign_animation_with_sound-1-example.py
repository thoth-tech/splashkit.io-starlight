from splashkit import *

script = load_animation_script("WalkingScript", "kermit.txt")
anim = create_animation(script, "WalkFront")

# Assign by name and play sound if present on start frame
assign_animation_with_sound(anim, "WalkFront", True)
write_line(f"Assigned WalkFront with sound -> animation name: {animation_name(anim)}")

free_animation(anim)
free_animation_script(script)
