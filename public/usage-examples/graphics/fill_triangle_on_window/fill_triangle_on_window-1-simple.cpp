#include "splashkit.h"

int main()
{
  window my_window = open_window("Fill Triangle On Window", 800, 600);

  // Fill triangle on the window and refresh
  fill_triangle_on_window(my_window, color_blue(), 300, 250, 500, 250, 400, 350);
  refresh_window(my_window);

  delay(3000);
  close_window(my_window);

  return 0;
}