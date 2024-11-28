#include "splashkit.h"

int main(){
    open_window("Rectangle on Bitmap", 400, 400);
    bitmap bmp = create_bitmap("bricks", 400, 400);


     for (int i = 0; i < 50; i++)
    {
                double x = rand()%350;  
                double y = rand()%350;  
                double width = rand()%50; 
                double height = rand()%50; 

        color randomColor = rgb_color(rand() % 255, rand() % 255, rand() % 255);

        draw_rectangle_on_bitmap(bmp, randomColor, x, y, width, height);
    }

    draw_bitmap(bmp, 0,0);

    refresh_screen();
    delay(5000);
    close_all_windows();

    return 0;
}
