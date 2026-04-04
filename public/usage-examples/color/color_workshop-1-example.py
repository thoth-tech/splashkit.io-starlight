from splashkit import *

open_window("Color Workshop", 960, 540)

segment_count = 16
strip_x = 40
strip_y = 90
strip_width = 880
strip_height = 220
segment_width = strip_width // segment_count

start_red = 255
start_green = 120
start_blue = 40

end_red = 30
end_green = 110
end_blue = 255

frame_count = 0

while not quit_requested():
    process_events()
    clear_screen(color_black())

    for i in range(segment_count):
        t = i / (segment_count - 1)

        # Interpolation formula: value = start + t * (end - start).
        red = int(start_red + t * (end_red - start_red))
        green = int(start_green + t * (end_green - start_green))
        blue = int(start_blue + t * (end_blue - start_blue))

        gradient_color = rgb_color(red, green, blue)
        x = strip_x + i * segment_width

        # Draw one gradient bar for this segment.
        draw_rectangle(gradient_color, x, strip_y, segment_width, strip_height)

        # Show channel values in the HUD every fourth segment.
        if i % 4 == 0:
            label = f"[{i}] R{red} G{green} B{blue}"
            draw_text(label, color_white(), x, strip_y + strip_height + 14)

    selected_index = (frame_count // 20) % segment_count
    selected_t = selected_index / (segment_count - 1)

    selected_red = int(start_red + selected_t * (end_red - start_red))
    selected_green = int(start_green + selected_t * (end_green - start_green))
    selected_blue = int(start_blue + selected_t * (end_blue - start_blue))

    selected_color = rgb_color(selected_red, selected_green, selected_blue)
    selected_x = strip_x + selected_index * segment_width

    # Highlight one segment and print its RGB channels.
    draw_rectangle(color_white(), selected_x - 2, strip_y - 2, segment_width + 4, strip_height + 4)
    draw_rectangle(selected_color, selected_x, strip_y, segment_width, strip_height)

    formula_text = "value = start + t(end - start)"
    hud_text = f"Segment {selected_index} -> R {selected_red}, G {selected_green}, B {selected_blue}"

    draw_text("Color Workshop - Gradient Composer", color_white(), 40, 36)
    draw_text(formula_text, color_white(), 40, 346)
    draw_text(hud_text, color_white(), 40, 378)

    refresh_screen(60)
    frame_count += 1

close_all_windows()
