from splashkit import *

script = load_animation_script("WalkingScript", "kermit.txt")

# Create an animation from the script by name
anim = create_animation(script, "WalkFront")
write_line(f"Created animation -> name: {animation_name(anim)}")

free_animation(anim)
free_animation_script(script)
