from splashkit import *

# Load explosion animation script and create animation
script = load_animation_script("ExplosionScript", "explosion.txt")
anim = create_animation(script, "Explode")

# Get vector for current frame
vec = animation_current_vector(anim)
write_line(f"Current vector: x={vec.x} y={vec.y}")

free_animation(anim)
free_animation_script(script)
