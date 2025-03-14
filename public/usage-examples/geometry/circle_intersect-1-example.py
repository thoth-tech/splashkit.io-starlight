from splashkit import *
import random as rnd

#Method to get the maximum length for the circle to still be on screen
def get_val(rand,large):
    base = 0

    if rand > (large - rand):
        base = large - rand
    else:
        base = rand

    return base

# Method that retrieves a random circle position
def get_circle():
    random_value = rnd.randint(0, 300)
    start_value = get_val(random_value, 600)
    circle = circle_at_from_points(rnd.randint(0 + start_value, 800 - start_value), rnd.randint(start_value, 600 - start_value), random_value)
    return circle

def main():
    circle_1 = get_circle()
    circle_2 = get_circle()

    open_window("Circle X", 800, 600)

    # Draw the Circle and x coordinate on window
    clear_screen(color_white())
    draw_circle_record(color_red(), circle_1)
    draw_circle_record(color_green(), circle_2)
    
    # Checks if the circles intersect or not
    circle_intersect = circles_intersect(circle_1, circle_2)
    draw_text_no_font_no_size("Circle X intersecting with Circle Y is " + str(circle_intersect) , color_black(), 100, 100)
    refresh_screen()

    delay(4000)
    close_all_windows()

if __name__ == "__main__":
    main()
