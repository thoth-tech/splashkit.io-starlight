#include "splashkit.h"
#include <string>

int main()
{
    open_window("Boat Buoyancy", 800, 600);

    // Create a simple boat shape for the simulation
    bitmap boat_bitmap = create_bitmap("boat_bitmap", 120, 50);
    clear_bitmap(boat_bitmap, COLOR_TRANSPARENT);

    fill_rectangle_on_bitmap(boat_bitmap, COLOR_BROWN, 10, 20, 100, 20);
    fill_triangle_on_bitmap(boat_bitmap, COLOR_RED, 20, 20, 60, 0, 100, 20);

    sprite boat = create_sprite(boat_bitmap);

    // Position the boat above the water
    sprite_set_x(boat, 340);
    sprite_set_y(boat, 20);

    // Define the water area and surface level
    rectangle water_area = rectangle_from(0, 350, 800, 250);
    double water_surface = water_area.y;

    double gravity_strength = 0.7;
    double damping_strength = 0.05;
    double buoyancy_scale = 0.05;

    double vertical_velocity = 0;

    while (!quit_requested())
    {
        process_events();

        // Apply gravity to pull the boat downward
        vertical_velocity += gravity_strength;

        double boat_bottom = sprite_y(boat) + sprite_height(boat);

        // Check how much of the boat is underwater
        if (boat_bottom > water_surface)
        {
            double submerged_depth = boat_bottom - water_surface;

            // Limit buoyancy so the force stays stable
            if (submerged_depth > sprite_height(boat))
            {
                submerged_depth = sprite_height(boat);
            }

            // Apply upward force based on submerged depth
            double upward_force = submerged_depth * buoyancy_scale;
            vector_2d buoyancy = vector_from_angle(270, upward_force);

            vertical_velocity += buoyancy.y;
        }

        // Reduce movement over time for smoother floating
        vertical_velocity *= (1.0 - damping_strength);

        // Update the boat position using velocity
        sprite_set_y(boat, sprite_y(boat) + vertical_velocity);

        clear_screen(COLOR_WHITE);

        // Draw the water area and surface
        quad water_quad = quad_from(
            point_at(0, 350),
            point_at(800, 350),
            point_at(0, 600),
            point_at(800, 600)
        );

        draw_quad(COLOR_DEEP_SKY_BLUE, water_quad);
        draw_line(COLOR_BLUE, 0, 350, 800, 350);

        // Display the boat sprite
        draw_sprite(boat);

        // Show the current movement speed
        draw_text("Boat floats using vector based buoyancy.", COLOR_BLACK, 20, 20);
        draw_text("Vertical Velocity: " + std::to_string(vertical_velocity), COLOR_BLACK, 20, 50);

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}
