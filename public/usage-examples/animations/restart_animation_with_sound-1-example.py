from splashkit import *

def main():
    script = load_animation_script('Resources/animations/kermit.txt')
    anim = create_animation_from_script(script, 'WalkFront')

    # Restart animation and let any first-frame sound play
    restart_animation_with_sound(anim, True)
    write_line('Animation restarted (with_sound=true).')

    free_animation(anim)
    free_animation_script(script)

if __name__ == '__main__':
    main()
