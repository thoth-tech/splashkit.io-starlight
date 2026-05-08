from splashkit import *

open_window("Boat Buoyancy", 800, 600)

# Create a simple boat shape for the simulation
boat_bitmap = create_bitmap("boat_bitmap", 120, 50)
clear_bitmap(boat_bitmap, color_transparent())

fill_rectangle_on_bitmap(boat_bitmap, color_brown(), 10, 20, 100, 20)
fill_triangle_on_bitmap(boat_bitmap, color_red(), 20, 20, 60, 0, 100, 20)

boat = create_sprite(boat_bitmap)

# Position the boat above the water
sprite_set_x(boat, 340)
sprite_set_y(boat, 20)

# Define the water area and surface level
water_area = rectangle_from(0, 350, 800, 250)
water_surface = water_area.y

gravity_strength = 0.7
damping_strength = 0.05
buoyancy_scale = 0.05

vertical_velocity = 0

while not quit_requested():
    process_events()

    # Apply gravity to pull the boat downward
    vertical_velocity += gravity_strength

    boat_bottom = sprite_y(boat) + sprite_height(boat)

    # Check how much of the boat is underwater
    if boat_bottom > water_surface:
        submerged_depth = boat_bottom - water_surface

        # Limit buoyancy so the force stays stable
        if submerged_depth > sprite_height(boat):
            submerged_depth = sprite_height(boat)

        # Apply upward force based on submerged depth
        upward_force = submerged_depth * buoyancy_scale
        buoyancy = vector_from_angle(270, upward_force)

        vertical_velocity += buoyancy.y

    # Reduce movement over time for smoother floating
    vertical_velocity *= (1.0 - damping_strength)

    # Update the boat position using velocity
    sprite_set_y(boat, sprite_y(boat) + vertical_velocity)

    clear_screen(color_white())

    # Draw the water area and surface
    water_quad = quad_from(
        point_at(0, 350),
        point_at(800, 350),
        point_at(0, 600),
        point_at(800, 600)
    )

    draw_quad(color_deep_sky_blue(), water_quad)
    draw_line(color_blue(), 0, 350, 800, 350)

    # Display the boat sprite
    draw_sprite(boat)

    # Show the current movement speed
    draw_text_no_font_no_size(
        "Boat floats using vector based buoyancy.",
        color_black(),
        20,
        20
    )

    draw_text_no_font_no_size(
        "Vertical Velocity: " + str(round(vertical_velocity, 2)),
        color_black(),
        20,
        50
    )

    refresh_screen_with_target_fps(60)

close_all_windows()
