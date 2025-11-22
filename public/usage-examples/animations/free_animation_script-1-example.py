from splashkit import *

def main():
    script = load_animation_script("Resources/animations/kermit.txt")

    # Free the frames and data for the animation script
    free_animation_script(script)
    write_line("Animation script freed.")

if __name__ == '__main__':
    main()
