from splashkit import *

script = load_animation_script("WalkingScript", "kermit.txt")
anim = create_animation()

# assign by index (0 = first identifier)
assign_animation_index_with_script(anim, script, 0)
write_line(f"Assigned animation -> script identifier index: 0")

free_animation(anim)
free_animation_script(script)
