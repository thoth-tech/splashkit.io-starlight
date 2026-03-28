#include "splashkit.h"
#include <vector>

// Constants for physics
const double G = 10.0; // Scaled Gravitational Constant for visual appeal
const int WINDOW_WIDTH = 800;
const int WINDOW_HEIGHT = 600;

int main()
{
    open_window("Celestial Mechanics", WINDOW_WIDTH, WINDOW_HEIGHT);

    // Load a simple circle bitmap for planets
    bitmap planet_bmp = create_bitmap("planet", 20, 20);
    clear_bitmap(planet_bmp, COLOR_TRANSPARENT);
    fill_circle_on_bitmap(planet_bmp, COLOR_WHITE, 10, 10, 10);

    // Create 3 planetary Sprites with varying masses
    // Sun-like mass
    sprite sun = create_sprite(planet_bmp);
    sprite_set_x(sun, WINDOW_WIDTH / 2 - 10);
    sprite_set_y(sun, WINDOW_HEIGHT / 2 - 10);
    sprite_set_mass(sun, 1000.0);

    // Planet-like mass
    sprite planet = create_sprite(planet_bmp);
    sprite_set_x(planet, WINDOW_WIDTH / 2 + 150);
    sprite_set_y(planet, WINDOW_HEIGHT / 2 - 10);
    sprite_set_mass(planet, 10.0);
    sprite_set_velocity(planet, vector_to(0, 8)); // Horizontal tangent velocity

    // Moon-like mass
    sprite moon = create_sprite(planet_bmp);
    sprite_set_x(moon, WINDOW_WIDTH / 2 + 170);
    sprite_set_y(moon, WINDOW_HEIGHT / 2 - 10);
    sprite_set_mass(moon, 1.0);
    sprite_set_velocity(moon, vector_to(0, 10));

    std::vector<sprite> bodies;
    bodies.push_back(sun);
    bodies.push_back(planet);
    bodies.push_back(moon);

    while (!quit_requested())
    {
        process_events();

        // N-Body Gravity Calculation
        for (int i = 0; i < bodies.size(); i++)
        {
            for (int j = 0; j < bodies.size(); j++)
            {
                if (i == j) continue;

                // Position difference
                point_2d p1 = sprite_position(bodies[i]);
                point_2d p2 = sprite_position(bodies[j]);

                vector_2d direction = vector_to(p2.x - p1.x, p2.y - p1.y);
                double distance = vector_magnitude(direction);

                // Prevent division by zero and extreme forces when overlapping
                if (distance < 5.0) distance = 5.0;

                // F = G * (m1 * m2) / r^2
                double force_magnitude = (G * sprite_mass(bodies[i]) * sprite_mass(bodies[j])) / (distance * distance);

                // Apply force to body i towards body j (F = m*a -> a = F/m)
                vector_2d force_vector = vector_multiply(unit_vector(direction), force_magnitude);
                vector_2d acceleration = vector_multiply(force_vector, 1.0 / sprite_mass(bodies[i]));
                sprite_set_velocity(bodies[i], vector_add(sprite_velocity(bodies[i]), acceleration));
            }
        }

        // Update movement
        for (unsigned int i = 0; i < bodies.size(); i++)
        {
            update_sprite(bodies[i]);
        }

        // Rendering
        clear_screen(COLOR_BLACK);

        for (unsigned int i = 0; i < bodies.size(); i++)
        {
            draw_sprite(bodies[i]);
        }

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}
