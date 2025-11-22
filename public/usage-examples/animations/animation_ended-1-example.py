from splashkit import *

script = load_animation_script("ExplosionScript", "explosion.txt")
anim = create_animation(script, "explosion")

ended = animation_ended(anim)
write_line(f"Animation ended? {ended}")

free_animation(anim)
free_animation_script(script)
