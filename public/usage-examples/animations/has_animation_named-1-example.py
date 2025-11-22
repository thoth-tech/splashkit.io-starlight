from splashkit import *

def main():
    script = load_animation_script('Resources/animations/kermit.txt')

    if has_animation_named(script, 'WalkFront'):
        write_line('Has animation named: true')
    else:
        write_line('Has animation named: false')

    free_animation_script(script)

if __name__ == '__main__':
    main()
