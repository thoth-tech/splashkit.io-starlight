from splashkit import *

def main():
    script = load_animation_script('Resources/animations/kermit.txt')
    anim = create_animation_from_script(script, 'WalkFront')

    # Restart the animation
    restart_animation(anim)
    write_line('Animation restarted.')

    free_animation(anim)
    free_animation_script(script)

if __name__ == '__main__':
    main()
