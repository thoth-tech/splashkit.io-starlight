from splashkit import *

script = load_animation_script("ExplosionScript", "explosion.txt")
anim = create_animation(script, "explosion")

entered = animation_entered_frame(anim)
write_line(f"Animation entered frame? {entered}")

free_animation(anim)
free_animation_script(script)
