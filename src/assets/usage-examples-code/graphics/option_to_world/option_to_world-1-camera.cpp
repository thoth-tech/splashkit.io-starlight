// Usage Example for: https://splashkit.io/api/graphics/#option-to-world
// Goal: I am demonstrating world vs screen coordinates by panning a camera.
// Why: I am showing how world-anchored things move under the camera while a screen HUD does not.
// Controls: I am using Arrow keys to pan camera | I am pressing C to reset | I am pressing SPACE to toggle HUD | I am pressing ESC to quit.

#include "splashkit.h"
#include <cstdio>

int main()
{
    open_window("Option To World - camera", 800, 480);

    // I am storing the camera offset in world space.
    double cam_x = 0.0;
    double cam_y = 0.0;
    const double CAM_SPEED = 8.0;

    bool show_hud = true;  // I am showing a screen-fixed HUD.

    while (!quit_requested())
    {
        process_events();

        // I am quitting when ESC is pressed.
        if (key_typed(ESCAPE_KEY))
        {
            break;
        }
        // I am panning the camera with Arrow keys.
        if (key_down(LEFT_KEY))
        {
            cam_x = cam_x - CAM_SPEED;
        }
        if (key_down(RIGHT_KEY))
        {
            cam_x = cam_x + CAM_SPEED;
        }
        if (key_down(UP_KEY))
        {
            cam_y = cam_y - CAM_SPEED;
        }
        if (key_down(DOWN_KEY))
        {
            cam_y = cam_y + CAM_SPEED;
        }
        // I am toggling the HUD with SPACE.
        if (key_typed(SPACE_KEY))
        {
            show_hud = !show_hud;
        }
        // I am resetting the camera with C.
        if (key_typed(C_KEY))
        {
            cam_x = 0.0;
            cam_y = 0.0;
        }

        clear_screen(rgb_color(255, 255, 255));

        // I am drawing a light grid in world space.
        const color LIGHT = rgb_color(200, 200, 200);
        for (int gx = -1600; gx <= 1600; gx += 80)
        {
            draw_line(LIGHT, gx - cam_x, -2000.0 - cam_y, gx - cam_x, 2000.0 - cam_y);
        }
        for (int gy = -1600; gy <= 1600; gy += 80)
        {
            draw_line(LIGHT, -2000.0 - cam_x, gy - cam_y, 2000.0 - cam_x, gy - cam_y);
        }

        // I am drawing two world-anchored shapes.
        draw_circle(rgb_color(100, 149, 237), (int)(200.0 - cam_x), (int)(120.0 - cam_y), 28.0);
        draw_rectangle(rgb_color(255, 140, 0), (int)(400.0 - cam_x), (int)(200.0 - cam_y), 80, 52);

        // I am drawing a screen-fixed HUD (wider so text is not clipped).
        if (show_hud)
        {
            fill_rectangle(rgb_color(10, 24, 48), 10, 480 - 60, 420, 48);
            draw_text("SCREEN HUD (fixed) - toggle with SPACE",
                      rgb_color(255, 255, 255), "arial", 14, 16, 480 - 44);
        }

        // I am drawing the on-screen instructions.
        char info[160];
        std::snprintf(info, sizeof(info),
                      "Camera: x=%.0f y=%.0f  |  Arrows: pan  |  C: reset  |  SPACE: HUD  |  ESC: quit",
                      cam_x, cam_y);
        draw_text(info, rgb_color(0, 0, 0), "arial", 14, 10, 10);

        refresh_screen(60);
    }
    return 0;
}