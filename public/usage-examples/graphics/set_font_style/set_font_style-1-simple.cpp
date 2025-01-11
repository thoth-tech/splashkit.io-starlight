#include "splashkit.h"

int main()
{
  open_window("Set Font Style", 800, 600);

  font my_font = load_font("MyFont", "RobotoSlab.ttf");

  // Set font style to bold
  set_font_style(my_font, BOLD_FONT);
  draw_text("Hello, SplashKit!", color_black(), my_font, 40, 250, 270);
  refresh_screen();

  delay(5000);
  close_all_windows();
}
