from splashkit import *


def main():
    script = load_animation_script('Resources/animations/kermit.txt')
    anim = create_animation_from_script(script, 'WalkFront')

    # Default update (no explicit delta)
    update_animation(anim)
    write_line('Animation updated (default update).')

    free_animation(anim)
    free_animation_script(script)

if __name__ == '__main__':
    main()
    main()
    main()
    main()
