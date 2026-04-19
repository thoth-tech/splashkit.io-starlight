from splashkit import *

script = load_animation_script("WalkingScript", "kermit.txt")
anim = create_animation(script, "WalkFront")

print("Frame time in current frame:")

for _ in range(5):
    update_animation(anim)
    delay(200)

    print(animation_frame_time(anim))

free_animation(anim)
free_animation_script(script)
