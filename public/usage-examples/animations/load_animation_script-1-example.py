from splashkit import *

def main():
    # Register the script by name using the kermit.txt resource
    script = load_animation_script('WalkingScript', 'Resources/animations/kermit.txt')
    write_line('Loaded animation script -> name: WalkingScript')

    free_animation_script(script)

if __name__ == '__main__':
    main()
