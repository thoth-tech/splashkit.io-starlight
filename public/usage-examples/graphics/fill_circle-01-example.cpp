#include "splashkit.h"

int main() {
  open_window("Drawing Example", 800, 600);
  while (!quit_requested()) {
    process_events();
    clear_screen(COLOR_WHITE);
    fill_circle(COLOR_BLUE, 400, 300, 50);
    fill_rectangle(COLOR_RED, 100, 100, 150, 80);
    draw_line(COLOR_GREEN, 50, 50, 750, 550);
    refresh_screen();
  }
  return 0;
}
