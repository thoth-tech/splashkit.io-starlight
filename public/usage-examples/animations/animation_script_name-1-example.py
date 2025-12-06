from splashkit import *

script = load_animation_script("WalkingScript", "kermit.txt")
name = animation_script_name(script)
write_line(f"Script name: {name}")

free_animation_script(script)
