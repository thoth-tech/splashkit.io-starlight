from splashkit import *

open_window("Bitmap Bounding Rectangle", 800, 600)

refresh_counter = 0
vertical_bitmap_pos = Point2D()
horizontal_bitmap_pos = Point2D()
bitmap_rectangle = Rectangle
vertical_bitmap = load_bitmap("vertical_bitmap", "image1.jpeg")
horizontal_bitmap = load_bitmap("horizontal_bitmap", "image2.png")
     
while not quit_requested():
    process_events()
    
    refresh_counter += 1
    if refresh_counter <= 15000:
        # Function used here ↓
        bitmap_rectangle = bitmap_bounding_rectangle(vertical_bitmap)
        vertical_bitmap_pos = point_at(200, 120)
        horizontal_bitmap_pos = point_at(1000, 1000)
        bitmap_rectangle.x = 450
        bitmap_rectangle.y = 120
    elif refresh_counter > 15000 and refresh_counter <= 30000:
        # Function used here ↓
        bitmap_rectangle = bitmap_bounding_rectangle(horizontal_bitmap)
        vertical_bitmap_pos = point_at(1000, 1000)
        horizontal_bitmap_pos = point_at(150, 243)
        bitmap_rectangle.x = 450
        bitmap_rectangle.y = 243
    else:
        refresh_counter = 0
        
    clear_screen(color_white())

    draw_rectangle_record(color_black(), bitmap_rectangle)
    draw_bitmap(vertical_bitmap, vertical_bitmap_pos.x, vertical_bitmap_pos.y)
    draw_bitmap(horizontal_bitmap, horizontal_bitmap_pos.x, horizontal_bitmap_pos.y)

    refresh_screen()
    
close_all_windows()