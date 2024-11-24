#include "splashkit.h"

int main()
{
  window my_window = open_window("Draw Snowman On Window", 800, 600);

  // Draw snowman to window and refresh
  clear_screen(COLOR_LIGHT_BLUE);
  fill_ellipse_on_window(my_window, COLOR_WHITE, 300, 400, 200, 200);
  fill_ellipse_on_window(my_window, COLOR_WHITE, 320, 240, 160, 160);
  fill_ellipse_on_window(my_window, COLOR_BLACK, 350, 300, 10, 10);
  fill_ellipse_on_window(my_window, COLOR_BLACK, 400, 300, 10, 10);
  fill_triangle_on_window(my_window, COLOR_ORANGE, 325, 330, 375, 320, 375, 340);
  refresh_window(my_window);

  delay(6000);
  close_window(my_window);
}