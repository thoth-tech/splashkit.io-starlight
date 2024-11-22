#include "splashkit.h"

int main()
{
  window my_window = open_window("Fill Rectangle On Window", 800, 600);

  // Fill rectangle on the window and refresh
  fill_rectangle_on_window(my_window, color_blue(), 300, 250, 200, 100);
  refresh_window(my_window);

  delay(3000);
  close_window(my_window);

  return 0;
}