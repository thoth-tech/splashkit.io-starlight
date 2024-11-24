from splashkit import *

def main():
    window = create_window("Simple Red Triangle", 800, 600)

    while not window.close_requested:
        process_events()
        clear_screen(color_white())
        fill_triangle(color_red(), 400, 100, 600, 500, 200, 500)
        refresh_window(window)

    close_window(window)

if __name__ == "__main__":
    main()
