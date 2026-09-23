from splashkit import *
import math

# Window dimensions
WINDOW_WIDTH = 800
WINDOW_HEIGHT = 600

# Open a window for the lantern scene
open_window("The Raycast Lantern", WINDOW_WIDTH, WINDOW_HEIGHT)

# Max ray distance based on window diagonal for scalability
MAX_RAY_DIST = math.sqrt(WINDOW_WIDTH * WINDOW_WIDTH + WINDOW_HEIGHT * WINDOW_HEIGHT)

# Define obstacle rectangles (walls that block light)
obstacle1 = rectangle_from(150, 150, 100, 200)
obstacle2 = rectangle_from(500, 100, 150, 120)
obstacle3 = rectangle_from(350, 350, 200, 80)

# Define edges of each obstacle as lines for ray intersection
# Obstacle 1 edges
obs1_top = line_from(150, 150, 250, 150)
obs1_bottom = line_from(150, 350, 250, 350)
obs1_left = line_from(150, 150, 150, 350)
obs1_right = line_from(250, 150, 250, 350)

# Obstacle 2 edges
obs2_top = line_from(500, 100, 650, 100)
obs2_bottom = line_from(500, 220, 650, 220)
obs2_left = line_from(500, 100, 500, 220)
obs2_right = line_from(650, 100, 650, 220)

# Obstacle 3 edges
obs3_top = line_from(350, 350, 550, 350)
obs3_bottom = line_from(350, 430, 550, 430)
obs3_left = line_from(350, 350, 350, 430)
obs3_right = line_from(550, 350, 550, 430)

# Collect all edges into a list for easy iteration
edges = [
    obs1_top, obs1_bottom, obs1_left, obs1_right,
    obs2_top, obs2_bottom, obs2_left, obs2_right,
    obs3_top, obs3_bottom, obs3_left, obs3_right
]
NUM_EDGES = len(edges)

# Number of rays to cast around the lantern
NUM_RAYS = 360

while not quit_requested():
    process_events()

    # Lantern follows the mouse position
    lantern_pos = mouse_position()

    # Store the endpoint of each ray (intersection or window edge)
    ray_endpoints = []

    # Cast rays in all directions from the lantern
    for i in range(NUM_RAYS):
        angle = i * (360.0 / NUM_RAYS)

        # Create a direction vector for this ray
        heading = vector_from_angle(angle, 1.0)

        # Max ray distance based on window diagonal for scalability
        closest_dist = MAX_RAY_DIST
        closest_pt = point_at(
            lantern_pos.x + heading.x * closest_dist,
            lantern_pos.y + heading.y * closest_dist
        )

        # Check each obstacle edge for intersection
        for j in range(NUM_EDGES):
            hit_pt = point_at(0, 0)

            # Use ray_intersection_point to detect where the ray hits an edge
            if ray_intersection_point(lantern_pos, heading, edges[j], hit_pt):
                # Calculate distance to this intersection
                dist = point_point_distance(lantern_pos, hit_pt)

                # Keep the closest intersection point
                if dist < closest_dist:
                    closest_dist = dist
                    closest_pt = hit_pt

        ray_endpoints.append(closest_pt)

    # Render the scene
    clear_screen(color_black())

    # Draw the illuminated area using filled triangles
    # Each triangle connects the lantern to two adjacent ray endpoints
    for i in range(NUM_RAYS):
        next_i = (i + 1) % NUM_RAYS

        # Fill triangle to create the lit region
        fill_triangle(
            rgba_color(255, 220, 100, 40),
            lantern_pos.x, lantern_pos.y,
            ray_endpoints[i].x, ray_endpoints[i].y,
            ray_endpoints[next_i].x, ray_endpoints[next_i].y
        )

        # Draw triangle outline for subtle light boundary
        draw_triangle(
            rgba_color(255, 220, 100, 15),
            lantern_pos.x, lantern_pos.y,
            ray_endpoints[i].x, ray_endpoints[i].y,
            ray_endpoints[next_i].x, ray_endpoints[next_i].y
        )

    # Draw light rays from lantern to intersection points
    for i in range(0, NUM_RAYS, 6):
        draw_line_point_to_point(rgba_color(255, 200, 50, 20), lantern_pos, ray_endpoints[i])

    # Draw the obstacle outlines on top
    draw_rectangle_record(color_dark_gray(), obstacle1)
    draw_rectangle_record(color_dark_gray(), obstacle2)
    draw_rectangle_record(color_dark_gray(), obstacle3)

    # Fill obstacles to make them look solid
    fill_rectangle_record(color_gray(), obstacle1)
    fill_rectangle_record(color_gray(), obstacle2)
    fill_rectangle_record(color_gray(), obstacle3)

    # Draw the lantern glow at the mouse position
    fill_circle(color_yellow(), lantern_pos.x, lantern_pos.y, 8)
    fill_circle(rgba_color(255, 200, 50, 100), lantern_pos.x, lantern_pos.y, 20)

    # Display instructions
    draw_text_no_font_no_size("Move the mouse to reposition the lantern", color_white(), 10, 10)
    draw_text_no_font_no_size("Rays: " + str(NUM_RAYS) + " | Obstacles: 3", color_white(), 10, 30)

    refresh_screen_with_target_fps(60)

close_all_windows()
