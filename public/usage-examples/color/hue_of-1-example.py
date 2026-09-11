from splashkit import *


def main():
    open_window("Hue Of", 800, 600)

    while not quit_requested():
        process_events()

        selected_hue = mouse_x() / screen_width()

        if selected_hue < 0.0:
            selected_hue = 0.0
        elif selected_hue > 1.0:
            selected_hue = 1.0

        selected_color = hsb_color(
            selected_hue,
            1.0,
            1.0
        )

        # Read the hue component from the selected color
        hue = hue_of(selected_color)

        clear_screen(color_white())

        fill_rectangle(
            selected_color,
            100,
            120,
            600,
            300
        )

        draw_rectangle(
            color_black(),
            100,
            120,
            600,
            300
        )

        draw_text(
            "Move the mouse left and right to change the color",
            color_black(),
            "Arial",
            20,
            150,
            60
        )

        draw_text(
            f"Hue: {hue:.3f}",
            color_black(),
            "Arial",
            20,
            330,
            460
        )

        refresh_screen()

    close_all_windows()


main()