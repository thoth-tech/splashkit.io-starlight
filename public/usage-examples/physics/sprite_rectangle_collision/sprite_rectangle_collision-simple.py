from splashkit import *

# Open a new window
open_window("Bitmap Collisions", 315, 330)

# Load the bitmap
sk_bmp = load_bitmap("skbox", "skbox.png")

# Create a sprite using the bitmap
sk_sprite = create_sprite(sk_bmp)

# Define sprite and rectangle positions
sk_sprite_loc = Point2D()
sk_sprite_loc.x = 50
sk_sprite_loc.y = 50
sprite_set_position(sk_sprite, sk_sprite_loc)

test_rectangle_1 = Rectangle()
test_rectangle_1.x = 20
test_rectangle_1.y = 20
test_rectangle_1.width = 20
test_rectangle_1.height = 20

test_rectangle_2 = Rectangle()
test_rectangle_2.x = 150
test_rectangle_2.y = 200
test_rectangle_2.width = 20
test_rectangle_2.height = 20

# Clear the screen and draw elements
clear_screen(color_white())
draw_sprite(sk_sprite)
fill_rectangle(color_black(), test_rectangle_1)
fill_rectangle(color_red(), test_rectangle_2)

# Check for collisions
if sprite_rectangle_collision(sk_sprite, test_rectangle_1):
    write_line("Black Rectangle Collision")
if sprite_rectangle_collision(sk_sprite, test_rectangle_2):
    write_line("Red Rectangle Collision")

# Refresh the screen and delay before closing
refresh_screen()
delay(4000)

close_all_windows()
