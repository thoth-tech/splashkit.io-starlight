from splashkit import *

window = open_window("Push Clip Example", 800, 600)

 
clear_screen(color_white())
fill_circle(color_goldenrod(), 400, 300, 200)
fill_circle(color_swinburne_red(), 400, 300, 180)
refresh_screen()
delay(1000)



clear_screen(color_white())
fill_circle(color_goldenrod(), 400, 300, 200)
fill_circle(color_swinburne_red(), 400, 300, 180)

clip_rect = rectangle_from(400, 95, 205, 410)
draw_rectangle_record(color_royal_blue(),clip_rect)

draw_text_no_font_no_size("First Clipping Rectangle", color_black(), 100, 550)
refresh_screen()
delay(2000)

clear_screen(color_white())
fill_circle(color_goldenrod(), 400, 300, 200)
fill_circle(color_swinburne_red(), 400, 300, 180)

corner_rect = rectangle_from(195, 295, 410, 210)
draw_rectangle_record(color_royal_blue(),corner_rect)

draw_text_no_font_no_size("Second Clipping Rectangle", color_black(), 100, 550)
refresh_screen()
delay(2000)


clear_screen(color_white())
fill_circle(color_goldenrod(), 400, 300, 200)
fill_circle(color_swinburne_red(), 400, 300, 180)
refresh_screen()
delay(100)


clear_screen(color_white())
fill_circle(color_goldenrod(), 400, 300, 200)
fill_circle(color_swinburne_red(), 400, 300, 180)

draw_rectangle_record(color_royal_blue(),clip_rect)
draw_rectangle_record(color_royal_blue(),corner_rect)

draw_text_no_font_no_size("Intersection of Both Rectangles", color_black(), 100, 550)
refresh_screen()
delay(2000)

push_clip(clip_rect)
clear_screen(color_white())
fill_circle(color_goldenrod(), 400, 300, 200)
fill_circle(color_swinburne_red(), 400, 300, 180)
pop_clip()
draw_text_no_font_no_size("First Push Clip", color_black(), 100, 550)
refresh_screen()
delay(2000)

push_clip(clip_rect)
push_clip(corner_rect)
clear_screen(color_white())
fill_circle(color_goldenrod(), 400, 300, 200)
fill_circle(color_swinburne_red(), 400, 300, 180)
pop_clip()
pop_clip()
draw_text_no_font_no_size("Final Result After Second Push Clip", color_black(), 100, 550)
refresh_screen()
delay(4000)



close_window(window)
