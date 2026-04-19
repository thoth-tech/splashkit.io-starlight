from splashkit import *

script = load_animation_script("ExplosionScript", "explosion.txt")
anim = create_animation(script, "explosion")

print("Has animation ended?")
print(animation_ended(anim))

for _ in range(10):
    update_animation(anim)
    delay(100)

    print("Current cell:")
    print(animation_current_cell(anim))

    if animation_ended(anim):
        print("Animation ended!")
        break

free_animation(anim)
free_animation_script(script)
