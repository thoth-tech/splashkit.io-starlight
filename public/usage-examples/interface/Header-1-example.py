from splashkit import *
import os

def main():
    # Window settings
    window_width = 600
    window_height = 400
    main_window = open_window("Header Interactive Example", window_width, window_height)

    # Font settings
    font_name = "Arial"
    font_file = "arial.ttf"
    font_path = os.path.join(os.getcwd(), font_file)

    # Load the font (this returns a Font object)
    if not os.path.exists(font_path):
        print(f"Error: Font file '{font_file}' not found in the current directory.")
        close_window(main_window)
        return
    loaded_font = load_font(font_name, font_path)

    # Initial message
    display_message = "Click the button!"

    # Colors
    white         = rgb_color(255, 255, 255)
    black         = rgb_color(  0,   0,   0)
    dark_orange   = rgb_color(255, 140,   0)
    dark_turquoise= rgb_color(  0, 206, 209)

    # Button settings
    button_width  = 160
    button_height =  50
    button_x      = (window_width  - button_width)  / 2
    button_y      = 180

    while not window_close_requested(main_window):
        process_events()
        clear_screen(white)

        # Header background + separator
        fill_rectangle(dark_orange, 0, 0, window_width, 80)
        draw_line(black, 0, 80, window_width, 80)

        # Header text
        header_text = "Welcome to SplashKit UI"
        hx = (window_width - text_width(header_text, loaded_font, 24)) / 2
        draw_text(header_text, white, loaded_font, 24, hx, 25)

        # Button background
        fill_rectangle(dark_turquoise, button_x, button_y, button_width, button_height)
        # Button text
        btn_txt = "Click Me!"
        bx = button_x + (button_width - text_width(btn_txt, loaded_font, 20)) / 2
        draw_text(btn_txt, white, loaded_font, 20, bx, button_y + 15)

        # Dynamic message
        mx = (window_width - text_width(display_message, loaded_font, 20)) / 2
        draw_text(display_message, black, loaded_font, 20, mx, 300)

        # Click handling
        if mouse_clicked(MouseButton.left_button):
            pos = mouse_position()
            if (button_x <= pos.x <= button_x + button_width and
                button_y <= pos.y <= button_y + button_height):
                display_message = "Button Clicked!"

        refresh_screen()    # no arguments!

    close_window(main_window)

if __name__ == "_main_":
    main()