#include "splashkit.h"

int main() {
  open_window("Sprite Example", 800, 600);
  bitmap bmp = load_bitmap("player", "images/player.png");
  sprite player = create_sprite(bmp);
  while (!quit_requested()) {
    process_events();
    clear_screen(COLOR_WHITE);
    draw_sprite(player);
    refresh_screen();
  }
  return 0;
}
