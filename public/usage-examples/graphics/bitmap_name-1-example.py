from splashkit import *

def main():
    my_image = load_bitmap("logo", "splashkit.png")
    name = bitmap_name(my_image)

    open_window("Bitmap Name Example", 800, 600)

    # Center the image in the window
    x = (800 - bitmap_width(my_image)) // 2
    y = (600 - bitmap_height(my_image)) // 2
    draw_bitmap(my_image, x, y)

    write_line("Bitmap name: " + name)
    
    refresh_screen()  # Important!
    delay(3000)

main()