from splashkit import *


def main():
    # Load script and create a named animation
    script = load_animation_script("Resources/animations/kermit.txt")
    anim = create_animation_from_script(script, "WalkFront")

    # Free (dispose) the animation resources
    free_animation(anim)
    write_line("Animation freed.")

    # free the underlying script resource too
    free_animation_script(script)

if __name__ == '__main__':
    main()
    main()
    main()
    main()
