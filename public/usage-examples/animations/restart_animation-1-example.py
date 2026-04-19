from splashkit import *

script = load_animation_script("WalkingScript", "kermit.txt")
anim = create_animation(script, "WalkFront")

print("Updating animation a few times...")
for i in range(10):
    update_animation(anim)

print("Restarting animation...")
restart_animation(anim)

free_animation(anim)
free_animation_script(script)
