from splashkit import *

script = load_animation_script("WalkingScript", "kermit.txt")

print("Freeing animation script: " + animation_script_name(script))
free_animation_script(script)
