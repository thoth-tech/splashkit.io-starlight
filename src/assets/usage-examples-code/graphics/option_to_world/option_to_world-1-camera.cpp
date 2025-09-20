// I am demonstrating world vs screen coordinates by panning a camera.
// Arrow keys are panning the camera; SPACE toggles showing a screen-fixed HUD; ESC quits.

#include "splashkit.h"
#include <cmath>
#include <cstdio>   // for std::snprintf

int main()
{
    const int window_width = 800;
    const int window_height = 480;
    open_window("Option To World — camera (world vs screen)", window_width, window_height);

    // I am representing the camera as an (x,y) offset in world space
    double camera_x = 0.0;
    double camera_y = 0.0;
    const double cam_speed = 8.0;

    bool show_screen_hud = true;

    while (!quit_requested())
    {
        process_events(); // I am handling input every frame

        // I am using clear if-blocks with braces for controls
        if (key_typed(ESCAPE_KEY))
        {
            break;
        }
        if (key_down(LEFT_KEY))
        {
            camera_x = camera_x - cam_speed;
        }
        if (key_down(RIGHT_KEY))
        {
            camera_x = camera_x + cam_speed;
        }
        if (key_down(UP_KEY))
        {
            camera_y = camera_y - cam_speed;
        }
        if (key_down(DOWN_KEY))
        {
            camera_y = camera_y + cam_speed;
        }
        if (key_typed(SPACE_KEY))
        {
            show_screen_hud = !show_screen_hud;
        }
        if (key_typed(C_KEY))
        {
            camera_x = 0.0;
            camera_y = 0.0;
        }

        // clear to white
        clear_screen(rgb_color(255, 255, 255));

        // I am drawing a simple world grid and world objects transformed by camera
        for (int gx = -1600; gx <= 1600; gx += 80)
        {
            draw_line(rgb_color(200, 200, 200),
                      static_cast<double>(gx) - camera_x,
                      -2000.0 - camera_y,
                      static_cast<double>(gx) - camera_x,
                      2000.0 - camera_y);
        }
        for (int gy = -1600; gy <= 1600; gy += 80)
        {
            draw_line(rgb_color(200, 200, 200),
                      -2000.0 - camera_x,
                      static_cast<double>(gy) - camera_y,
                      2000.0 - camera_x,
                      static_cast<double>(gy) - camera_y);
        }

        // I am showing world-anchored shapes
        draw_circle(rgb_color(100, 149, 237),
                    static_cast<int>(200.0 - camera_x),
                    static_cast<int>(120.0 - camera_y),
                    28.0);

        draw_rectangle(rgb_color(255, 140, 0),
                       static_cast<int>(400.0 - camera_x),
                       static_cast<int>(200.0 - camera_y),
                       80, 52);

        // I am optionally drawing a screen-fixed HUD that is not affected by camera
        if (show_screen_hud)
        {
            fill_rectangle(rgb_color(10, 24, 48),
                           10, window_height - 60, 260, 48);
            draw_text("SCREEN HUD (fixed) — toggled by SPACE",
                      rgb_color(255, 255, 255), "arial", 14, 16, window_height - 44);
        }

        // I am drawing camera coordinates and instructions inside the window
        char cam_info[128];
        std::snprintf(cam_info, sizeof(cam_info),
                      "Camera: x=%.0f y=%.0f  — Arrows pan • C reset • SPACE toggle HUD • ESC quit",
                      camera_x, camera_y);
        draw_text(cam_info, rgb_color(0, 0, 0), "arial", 14, 10, 10);

        refresh_screen(60);
    }

    return 0;
}