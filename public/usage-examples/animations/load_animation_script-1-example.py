from splashkit import *

print("Loading animation script...")

script = load_animation_script("WalkingScript", "kermit.txt")

print("Script name:")
print(animation_script_name(script))

print("Animations in script:")
print(animation_count(script))

free_animation_script(script)
