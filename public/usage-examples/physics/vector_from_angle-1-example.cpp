#include "splashkit.h"
#include <algorithm>
#include <string>

int main()
{
    open_window("Archimedes' Voyage", 800, 600);

    const double water_level = 350;
    const double boat_width = 140;
    const double boat_height = 60;
    const double gravity = 0.18;
    const double buoyancy_strength = 0.012;
    const double damping = 0.985;

    // Create a transparent bitmap in memory.
    bitmap boat_bitmap = create_bitmap(
        "archimedes_boat",
        static_cast<int>(boat_width),
        static_cast<int>(boat_height));

    // Use the bitmap to create a sprite for movement and velocity.
    sprite boat = create_sprite(boat_bitmap);
    sprite_set_position(boat, point_at(330, 180));
    sprite_set_velocity(boat, vector_to(0, 0));

    rectangle water = rectangle_from(0, water_level, 800, 250);

    while (!quit_requested())
    {
        process_events();

        vector_2d velocity = sprite_velocity(boat);

        // Gravity pulls the boat downward.
        velocity.y += gravity;

        double boat_x = sprite_x(boat);
        double boat_y = sprite_y(boat);

        rectangle boat_area = rectangle_from(
            boat_x,
            boat_y,
            boat_width,
            boat_height);

        double boat_bottom = boat_y + boat_height;

        double submerged_depth = std::max(
            0.0,
            std::min(boat_height, boat_bottom - water_level));

        if (rectangles_intersect(boat_area, water))
        {
            // Buoyancy increases as more of the boat is submerged.
            double force_magnitude =
                submerged_depth * buoyancy_strength;

            vector_2d buoyancy_force =
                vector_from_angle(270, force_magnitude);

            velocity.y += buoyancy_force.y;
        }

        // Damping gradually reduces the oscillation.
        velocity.y *= damping;

        sprite_set_velocity(boat, velocity);
        update_sprite(boat);

        boat_x = sprite_x(boat);
        boat_y = sprite_y(boat);

        clear_screen(COLOR_SKY_BLUE);
        fill_rectangle(rgba_color(40, 130, 210, 220), water);

        quad hull = quad_from(
            boat_x,
            boat_y,
            boat_x + boat_width,
            boat_y,
            boat_x + 25,
            boat_y + boat_height,
            boat_x + boat_width - 25,
            boat_y + boat_height);

        fill_quad(COLOR_RED, hull);
        draw_quad(COLOR_BLACK, hull);

        draw_line(
            COLOR_BLACK,
            boat_x + boat_width / 2,
            boat_y,
            boat_x + boat_width / 2,
            boat_y - 80);

        triangle sail = triangle_from(
            boat_x + boat_width / 2,
            boat_y - 75,
            boat_x + boat_width / 2,
            boat_y - 5,
            boat_x + boat_width / 2 + 55,
            boat_y - 5);

        fill_triangle(COLOR_WHITE, sail);
        draw_triangle(COLOR_BLACK, sail);

        draw_text(
            "Archimedes' Voyage",
            COLOR_BLACK,
            20,
            20);

        draw_text(
            "Gravity pulls down while buoyancy pushes upward.",
            COLOR_BLACK,
            20,
            50);

        draw_text(
            "Submerged depth: " + std::to_string(static_cast<int>(submerged_depth)),
            COLOR_BLACK,
            20,
            80);

        draw_text(
            "Vertical velocity: " + std::to_string(sprite_velocity(boat).y),
            COLOR_BLACK,
            20,
            110);

        refresh_screen(60);
    }

    free_sprite(boat);
    free_bitmap(boat_bitmap);

    return 0;
}