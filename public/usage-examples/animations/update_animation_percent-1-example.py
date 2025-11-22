from splashkit import *

def main():
    script = load_animation_script('Resources/animations/kermit.txt')
    anim = create_animation_from_script(script, 'WalkFront')

    # Update with an explicit dt/pct
    update_animation(anim, 0.25)
    write_line('Animation updated (pct=0.25).')

    free_animation(anim)
    free_animation_script(script)

if __name__ == '__main__':
    main()
