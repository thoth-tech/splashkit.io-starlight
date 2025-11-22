from splashkit import *


def main():
    script = load_animation_script('Resources/animations/kermit.txt')
    anim = create_animation_from_script(script, 'WalkFront')

    # Advance with pct and allow frame sounds to play
    update_animation(anim, 0.25, True)
    write_line('Animation updated (pct=0.25, with_sound=true).')

    free_animation(anim)
    free_animation_script(script)

if __name__ == '__main__':
    main()
    main()
    main()
    main()
