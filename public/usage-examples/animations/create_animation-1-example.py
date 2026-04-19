from splashkit import *

script = load_animation_script("WalkingScript", "kermit.txt")

print("Creating animation...")
anim = create_animation(script, "WalkFront")

print("Animation name:")
print(animation_name(anim))

free_animation(anim)
free_animation_script(script)
