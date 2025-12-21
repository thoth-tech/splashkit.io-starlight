from splashkit import *

script = load_animation_script("WalkingScript", "kermit.txt")
anim = create_animation(script, "WalkFront")

print("Freeing animation: " + animation_name(anim))
free_animation(anim)

free_animation_script(script)
