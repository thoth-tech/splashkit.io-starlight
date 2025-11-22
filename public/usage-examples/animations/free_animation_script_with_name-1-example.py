from splashkit import *

def main():
    # Register a named script (WalkingScript -> kermit.txt)
    load_animation_script_named('WalkingScript', 'Resources/animations/kermit.txt')

    # Free by name
    free_animation_script_with_name('WalkingScript')
    write_line('Animation script freed (by name).')

if __name__ == '__main__':
    main()
