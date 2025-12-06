from splashkit import *

def main():
    load_animation_script_named('WalkingScript', 'Resources/animations/kermit.txt')
    present = has_animation_script('WalkFront')

    if present:
        write_line('Has animation script: true')
    else:
        write_line('Has animation script: false')

    free_animation_script_with_name('WalkingScript')

if __name__ == '__main__':
    main()
