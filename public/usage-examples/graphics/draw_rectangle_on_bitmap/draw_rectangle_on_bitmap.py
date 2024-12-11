from splashkit import *

open_window("Rectangle on Bitmap", 400, 400)
bmp = create_bitmap("bricks",400,400)


for i in range(50):

                x = rnd_int(350); 
                y = rnd_int(350); 
                width = rnd_int(50); 
                height = rnd_int(50); 

                randomColor = rgb_color(rnd_int(255), rnd_int(255), rnd_int(255)); 

                draw_rectangle_on_bitmap(bmp, randomColor, x, y, width, height);




draw_bitmap(bmp, 0,0)

refresh_screen()
delay(5000)
close_all_windows()