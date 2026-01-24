#include "splashkit.h"

int main() {
  open_window("Mouse Example", 800, 600);
  while (!quit_requested()) {
    process_events();
    clear_screen(COLOR_WHITE);
    draw_text("Mouse X: " + to_string(mouse_x()), COLOR_BLACK, 20, 20);
    draw_text("Mouse Y: " + to_string(mouse_y()), COLOR_BLACK, 20, 45);
    refresh_screen();
  }
  return 0;
}
