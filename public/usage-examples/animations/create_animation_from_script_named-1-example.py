from splashkit import *

# Create an animation by script name
anim = create_animation_from_script_named("WalkingScript", "WalkFront")
write_line(f"Created animation from script name -> name: {animation_name(anim)}")

free_animation(anim)
