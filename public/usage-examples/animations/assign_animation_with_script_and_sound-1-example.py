from splashkit import *

script = load_animation_script("WalkingScript", "kermit.txt")
anim = create_animation()

# assign with sound enabled
assign_animation_with_script_and_sound(anim, script, "WalkFront", True)
write_line(f"Assigned WalkFront -> script identifier index: {animation_index(script, 'WalkFront')}")

free_animation(anim)
free_animation_script(script)
