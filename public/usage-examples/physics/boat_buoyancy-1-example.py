from splashkit import *

# This example demonstrates a simple buoyancy simulation.
# The boat first falls because of gravity.
# Once the bottom of the boat goes below the water surface,
# buoyancy pushes it upward based on how deep it is submerged.
# Damping is also used so the boat settles instead of bouncing forever.

open_window("Boat Buoyancy", 800, 600)

# Create a bitmap for the boat so the program is self-contained
boat_bitmap = create_bitmap("boat_bitmap", 120, 50)
clear_bitmap(boat_bitmap, COLOR_TRANSPARENT)

# Draw a simple boat shape so the motion is easy to see
fill_rectangle_on_bitmap(boat_bitmap, COLOR_BROWN, 10, 20, 100, 20)
fill_triangle_on_bitmap(boat_bitmap, COLOR_RED, 20, 20, 60, 0, 100, 20)

# Create a sprite from the bitmap so it can be moved around the screen
boat = create_sprite(boat_bitmap)

# Start the boat well above the water so the falling motion is clearly visible
sprite_set_x(boat, 340)
sprite_set_y(boat, 20)

# Define the water area
water_area = rectangle_from(0, 350, 800, 250)
water_surface = water_area.y

# These values are tuned so the boat sinks a little, then rises and settles
gravity_strength = 0.7
damping_strength = 0.05
buoyancy_scale = 0.05

# Track vertical motion manually
vertical_velocity = 0

while not quit_requested():
    process_events()

    # Gravity always pulls the boat downward
    # This makes the boat fall naturally before water begins pushing back
    vertical_velocity += gravity_strength

    # Find the bottom of the boat
    # Using the bottom gives a more believable buoyancy trigger than a collision circle
    boat_bottom = sprite_y(boat) + sprite_height(boat)

    # Only apply buoyancy after the boat has actually gone below the water surface
    # This allows the boat to sink slightly first instead of floating too early
    if boat_bottom > water_surface:
        # Calculate how deep the boat is below the water surface
        submerged_depth = boat_bottom - water_surface

        # Limit the depth so the upward push does not become unrealistically strong
        if submerged_depth > sprite_height(boat):
            submerged_depth = sprite_height(boat)

        # The deeper the boat goes, the stronger the upward buoyancy becomes
        upward_force = submerged_depth * buoyancy_scale

        # Use vector_from_angle so the example still demonstrates upward vector creation
        buoyancy = vector_from_angle(270, upward_force)

        # Apply the vertical part of the buoyancy vector
        vertical_velocity += buoyancy.y

    # Damping reduces repeated bouncing and helps the boat stabilise
    vertical_velocity *= (1.0 - damping_strength)

    # Move the boat using the current vertical speed
    sprite_set_y(boat, sprite_y(boat) + vertical_velocity)

    clear_screen(COLOR_WHITE)

    # Create the water shape as a quad because draw_quad needs a quad object
    water_quad = quad_from(
        point_at(0, 350),
        point_at(800, 350),
        point_at(0, 600),
        point_at(800, 600)
    )

    # Draw the water so it is clear where buoyancy begins
    draw_quad(COLOR_DEEP_SKY_BLUE, water_quad)

    # Draw the water surface line
    draw_line(COLOR_BLUE, 0, 350, 800, 350)

    # Draw the boat
    draw_sprite(boat)

    # Show motion information so the effect is easier to understand
    draw_text("Boat falls, sinks slightly, then floats.", COLOR_BLACK, 20, 20)
    draw_text("Vertical Velocity: " + str(vertical_velocity), COLOR_BLACK, 20, 50)

    refresh_screen(60)