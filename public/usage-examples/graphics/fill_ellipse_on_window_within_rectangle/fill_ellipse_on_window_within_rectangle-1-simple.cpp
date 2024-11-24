#include "splashkit.h"

int main()
{
  window my_window = open_window("Draw Snowman On Window", 800, 600);

  // Define rectangles for each ellipse
  rectangle body = rectangle_from(300, 400, 200, 200);
  rectangle head = rectangle_from(320, 240, 160, 160);
  rectangle left_eye = rectangle_from(350, 300, 10, 10);
  rectangle right_eye = rectangle_from(400, 300, 10, 10);

  // Draw snowman to window and refresh
  clear_screen(COLOR_LIGHT_BLUE);
  fill_ellipse_on_window(my_window, COLOR_WHITE, body);
  fill_ellipse_on_window(my_window, COLOR_WHITE, head);
  fill_ellipse_on_window(my_window, COLOR_BLACK, left_eye);
  fill_ellipse_on_window(my_window, COLOR_BLACK, right_eye);
  fill_triangle_on_window(my_window, COLOR_ORANGE, 325, 330, 375, 320, 375, 340);
  refresh_window(my_window);

  delay(6000);
  close_window(my_window);

  return 0;
}
