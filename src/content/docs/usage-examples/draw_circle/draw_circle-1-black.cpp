#include "splashkit.h"


int main()
{
   //Opens A Window
   open_window("Circle", 800, 600);
   //Clears the screen and sets it to a light blue colour 
   clear_screen(COLOR_LIGHT_BLUE);
   //Draws a black circle with it's x and y position, as well as radius size
   draw_circle(COLOR_BLACK, 400, 300, 250);

   refresh_screen(60);
   delay(4000);



}