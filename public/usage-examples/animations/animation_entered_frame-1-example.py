from splashkit import *

script = load_animation_script("WalkingScript", "kermit.txt")
anim = create_animation(script, "WalkFront")

print("Updating animation and checking frame entry...")

for _ in range(10):
    update_animation(anim)
    delay(100)

    if animation_entered_frame(anim):
        print("Entered a new frame!")
        print("Current cell:")
        print(animation_current_cell(anim))

free_animation(anim)
free_animation_script(script)
