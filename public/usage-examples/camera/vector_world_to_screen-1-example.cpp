#include "splashkit.h"

int main()
{
    open_window("World Point to Screen Position", 800, 600);

    // Position the camera away from the origin so the translation is visible.
    move_camera_to(150, 100);

    point_2d world_point = point_at(500, 350);
    vector_2d world_to_screen = vector_world_to_screen();

    // Apply the returned vector to map the world point onto the screen.
    point_2d screen_point = point_at(
        world_point.x + world_to_screen.x,
        world_point.y + world_to_screen.y
    );

    drawing_options screen_options = option_to_screen();

    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_WHITE);

        // Draw the world point normally so it is affected by the camera.
        fill_circle(
            COLOR_BLUE,
            world_point.x,
            world_point.y,
            30
        );

        // Draw the calculated screen point without applying the camera again.
        draw_circle(
            COLOR_RED,
            screen_point.x,
            screen_point.y,
            40,
            screen_options
        );

        draw_text(
            "Vector World To Screen",
            COLOR_BLACK,
            20,
            20,
            screen_options
        );

        draw_text(
            "Camera position: (150, 100)",
            COLOR_BLACK,
            20,
            55,
            screen_options
        );

        draw_text(
            "World point: " + point_to_string(world_point),
            COLOR_BLACK,
            20,
            85,
            screen_options
        );

        draw_text(
            "Translation vector: " + vector_to_string(world_to_screen),
            COLOR_BLACK,
            20,
            115,
            screen_options
        );

        draw_text(
            "Calculated screen point: " + point_to_string(screen_point),
            COLOR_BLACK,
            20,
            145,
            screen_options
        );

        draw_text(
            "The matching circles confirm the coordinate conversion.",
            COLOR_BLACK,
            20,
            175,
            screen_options
        );

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}