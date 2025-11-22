from splashkit import *

# Load script and create animation
script = load_animation_script("ExplosionScript", "explosion.txt")
anim = create_animation(script, "explosion")

# Query the frame time value (in scripts the frame 'dur' indicates duration)
t = animation_frame_time(anim)
write_line(f"Time spent in current frame: {t}")

free_animation(anim)
free_animation_script(script)
