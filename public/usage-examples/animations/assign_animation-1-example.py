from splashkit import *

script = load_animation_script("WalkingScript", "kermit.txt")
anim = create_animation(script, "WalkFront")

# Switch to a different named animation in the current script
assign_animation(anim, "Dance")
write_line(f"Animation assigned to: {animation_name(anim)}")

free_animation(anim)
free_animation_script(script)
