from splashkit import *

script = animation_script_named("WalkingScript")
name = animation_script_name(script)
write_line(f"Named script loaded: {name}")

free_animation_script(script)
