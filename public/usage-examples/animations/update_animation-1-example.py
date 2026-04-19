from splashkit import *

script = load_animation_script("WalkingScript", "kermit.txt")
anim = create_animation(script, "WalkFront")

print("Updating animation...")

for _ in range(5):
    update_animation(anim)
    delay(100)

    print("Current cell:")
    print(animation_current_cell(anim))

free_animation(anim)
free_animation_script(script)
