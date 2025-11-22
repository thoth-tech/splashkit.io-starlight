from splashkit import *

script = load_animation_script("WalkingScript", "kermit.txt")

# Create animation from script using named identifier and optionally play start-frame audio
anim = create_animation_with_sound(script, "WalkFront", True)
write_line(f"Created animation by name -> animation: {animation_name(anim)}")

free_animation(anim)
free_animation_script(script)
