from splashkit import *

# Use the script name to retrieve the script, then assign the WalkFront animation
anim = create_animation()
script = animation_script_named("WalkingScript")

assign_animation_with_script_named(anim, "WalkingScript", "WalkFront")
write_line(f"Assigned WalkFront -> script name: {animation_script_name(script)}")

free_animation(anim)
free_animation_script(script)
