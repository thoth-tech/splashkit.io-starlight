from splashkit import *

def main():
    open_window("Least Common Multiple Demo", 640, 400)

    num1 = 12
    num2 = 18

    while not quit_requested():
        process_events()

        # controls
        if key_typed(UP_KEY):
            num1 += 1
        if key_typed(DOWN_KEY) and num1 > 1:
            num1 -= 1
        if key_typed(RIGHT_KEY):
            num2 += 1
        if key_typed(LEFT_KEY) and num2 > 1:
            num2 -= 1
        if key_typed(R_KEY):
            num1, num2 = 12, 18

        result = least_common_multiple(num1, num2)

        clear_screen(COLOR_WHITE)

        # title
        draw_text("LCM CALCULATOR", COLOR_BLUE, "arial", 28, 190, 40)

        # numbers
        draw_text("Number 1: " + str(num1), COLOR_BLACK, "arial", 22, 180, 140)
        draw_text("Number 2: " + str(num2), COLOR_BLACK, "arial", 22, 180, 180)

        # result
        draw_text("LCM: " + str(result), COLOR_RED, "arial", 24, 180, 230)

        # instructions
        draw_text("Controls: UP/DOWN for Number 1,  LEFT/RIGHT for Number 2,  R = reset",
                  COLOR_GRAY, "arial", 16, 40, 330)

        refresh_screen()

    close_all_windows()

if __name__ == "__main__":
    main()
