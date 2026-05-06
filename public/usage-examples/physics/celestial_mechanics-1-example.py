from splashkit import *

# Constants for physics
G = 10.0 # Scaled Gravitational Constant for visual appeal
WINDOW_WIDTH = 800
WINDOW_HEIGHT = 600

def main():
    open_window("Celestial Mechanics", WINDOW_WIDTH, WINDOW_HEIGHT)

    # Load a simple circle bitmap for planets
    planet_bmp = create_bitmap("planet", 20, 20)
    clear_bitmap(planet_bmp, color_transparent())
    fill_circle_on_bitmap(planet_bmp, color_white(), 10, 10, 10)

    # Create 3 planetary Sprites with varying masses
    # Sun-like mass
    sun = create_sprite(planet_bmp)
    sprite_set_x(sun, WINDOW_WIDTH / 2 - 10)
    sprite_set_y(sun, WINDOW_HEIGHT / 2 - 10)
    sprite_set_mass(sun, 1000.0)

    # Planet-like mass
    planet = create_sprite(planet_bmp)
    sprite_set_x(planet, WINDOW_WIDTH / 2 + 150)
    sprite_set_y(planet, WINDOW_HEIGHT / 2 - 10)
    sprite_set_mass(planet, 10.0)
    sprite_set_velocity(planet, vector_to(0, 8)) # Vertical tangent velocity

    # Moon-like mass
    moon = create_sprite(planet_bmp)
    sprite_set_x(moon, WINDOW_WIDTH / 2 + 170)
    sprite_set_y(moon, WINDOW_HEIGHT / 2 - 10)
    sprite_set_mass(moon, 1.0)
    sprite_set_velocity(moon, vector_to(0, 10))

    bodies = [sun, planet, moon]

    while not quit_requested():
        process_events()

        # N-Body Gravity Calculation
        for i in range(len(bodies)):
            for j in range(len(bodies)):
                if i == j:
                    continue

                # Position difference
                p1 = sprite_position(bodies[i])
                p2 = sprite_position(bodies[j])

                # direction = p2 - p1
                direction = vector_to(p2.x - p1.x, p2.y - p1.y)
                distance = vector_magnitude(direction)

                # Prevent division by zero and extreme forces when overlapping
                if distance < 5.0:
                    distance = 5.0

                # F = G * (m1 * m2) / r^2
                force_magnitude = (G * sprite_mass(bodies[i]) * sprite_mass(bodies[j])) / (distance * distance)

                # Apply force to body i towards body j (a = F/m)
                force_vector = vector_multiply(unit_vector(direction), force_magnitude)
                acceleration = vector_multiply(force_vector, 1.0 / sprite_mass(bodies[i]))
                sprite_set_velocity(bodies[i], vector_add(sprite_velocity(bodies[i]), acceleration))

        # Update movement
        for body in bodies:
            update_sprite(body)

        # Rendering
        clear_screen(color_black())
        
        for body in bodies:
            draw_sprite(body)

        refresh_screen_with_target_fps(60)

    close_all_windows()

if __name__ == "__main__":
    main()
