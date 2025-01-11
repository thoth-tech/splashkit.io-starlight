#include "splashkit.h"

int main()
{

  font my_font;

  // Check if program has font
  write("Font available before loading: ");
  write_line(has_font(my_font));

  // Load font
  my_font = load_font("MyFont", "RobotoSlab.ttf");

  // Check if program has font again
  write("Font available after loading: ");
  write_line(has_font(my_font));

  return 0;
}
