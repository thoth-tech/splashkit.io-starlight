from splashkit import *


def main():
    open_window("Archimedes' Voyage", 800, 600)

    water_level = 350
    boat_width = 140
    boat_height = 60

    gravity = 0.18
    buoyancy_strength = 0.012
    damping = 0.985

    boat_bitmap = create_bitmap(
        "archimedes_boat",
        int(boat_width),
        int(boat_height)
    )

    boat = create_sprite(boat_bitmap)

    sprite_set_position(
        boat,
        point_at(330, 180)
    )

    sprite_set_velocity(
        boat,
        vector_to(0, 0)
    )

    water = rectangle_from(
        0,
        water_level,
        800,
        250
    )

    while not quit_requested():
        process_events()

        current_velocity = sprite_velocity(boat)

        velocity_x = current_velocity.x
        velocity_y = current_velocity.y + gravity

        boat_x = sprite_x(boat)
        boat_y = sprite_y(boat)

        boat_area = rectangle_from(
            boat_x,
            boat_y,
            boat_width,
            boat_height
        )

        boat_bottom = boat_y + boat_height

        submerged_depth = max(
            0.0,
            min(
                boat_height,
                boat_bottom - water_level
            )
        )

        if rectangles_intersect(boat_area, water):
            force_magnitude = (
                submerged_depth * buoyancy_strength
            )

            buoyancy_force = vector_from_angle(
                270,
                force_magnitude
            )

            velocity_y += buoyancy_force.y

        velocity_y *= damping

        sprite_set_velocity(
            boat,
            vector_to(
                velocity_x,
                velocity_y
            )
        )

        update_sprite(boat)

        boat_x = sprite_x(boat)
        boat_y = sprite_y(boat)

        clear_screen(color_sky_blue())

        fill_rectangle_record(
            rgba_color(40, 130, 210, 220),
            water
        )

        hull = quad_from(
            boat_x,
            boat_y,
            boat_x + boat_width,
            boat_y,
            boat_x + 25,
            boat_y + boat_height,
            boat_x + boat_width - 25,
            boat_y + boat_height
        )

        fill_quad(
            color_red(),
            hull
        )

        draw_quad(
            color_black(),
            hull
        )

        draw_line(
            color_black(),
            boat_x + boat_width / 2,
            boat_y,
            boat_x + boat_width / 2,
            boat_y - 80
        )

        sail_x1 = boat_x + boat_width / 2
        sail_y1 = boat_y - 75

        sail_x2 = boat_x + boat_width / 2
        sail_y2 = boat_y - 5

        sail_x3 = boat_x + boat_width / 2 + 55
        sail_y3 = boat_y - 5

        fill_triangle(
            color_white(),
            sail_x1,
            sail_y1,
            sail_x2,
            sail_y2,
            sail_x3,
            sail_y3
        )

        draw_triangle(
            color_black(),
            sail_x1,
            sail_y1,
            sail_x2,
            sail_y2,
            sail_x3,
            sail_y3
        )

        draw_text_no_font_no_size(
            "Archimedes' Voyage",
            color_black(),
            20,
            20
        )

        draw_text_no_font_no_size(
            "Gravity pulls down while buoyancy pushes upward.",
            color_black(),
            20,
            50
        )

        draw_text_no_font_no_size(
            "Submerged depth: "
            + str(int(submerged_depth)),
            color_black(),
            20,
            80
        )

        draw_text_no_font_no_size(
            "Vertical velocity: "
            + str(round(sprite_velocity(boat).y, 6)),
            color_black(),
            20,
            110
        )

        refresh_screen_with_target_fps(60)

    free_sprite(boat)
    free_bitmap(boat_bitmap)


main()