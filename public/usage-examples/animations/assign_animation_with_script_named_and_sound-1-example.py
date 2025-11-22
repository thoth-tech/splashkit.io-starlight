from splashkit import *

anim = create_animation()
script = animation_script_named("WalkingScript")

# Assign by script name + animation name and play sound on first frame if any
assign_animation_with_script_named_and_sound(anim, "WalkingScript", "WalkFront", True)
write_line(f"Assigned WalkFront -> script name: {animation_script_name(script)}")

free_animation(anim)
free_animation_script(script)
