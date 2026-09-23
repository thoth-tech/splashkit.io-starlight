from splashkit import *

open_window("Bitmap Layer Studio", 960, 540)

# Scene setup: open window and load four bitmap layers.
background_layer = load_bitmap("background_layer", "layer_background.png")
mid_layer = load_bitmap("mid_layer", "layer_midground.png")
props_layer = load_bitmap("props_layer", "layer_props.png")
foreground_layer = load_bitmap("foreground_layer", "layer_foreground.png")

alpha = 0.45
bg_red = 48
bg_green = 88
bg_blue = 128
fg_red = 250
fg_green = 216
fg_blue = 126

# Formula layer: C_out = alpha * C_fg + (1 - alpha) * C_bg.
out_red = int(alpha * fg_red + (1.0 - alpha) * bg_red)
out_green = int(alpha * fg_green + (1.0 - alpha) * bg_green)
out_blue = int(alpha * fg_blue + (1.0 - alpha) * bg_blue)
blend_guide = rgba_color(out_red, out_green, out_blue, 255)
overlay_guide = rgba_color(fg_red, fg_green, fg_blue, int(alpha * 255))

while not quit_requested():
    process_events()
    clear_screen()

    # Layer pipeline: draw bitmaps back-to-front for stable compositing.
    draw_bitmap(background_layer, 0, 0)
    draw_bitmap(mid_layer, 0, 0)
    draw_bitmap(props_layer, 0, 0)
    draw_bitmap(foreground_layer, 0, 0)

    # Visual pass: draw depth guides and decorative perspective lines.
    draw_line(blend_guide, 0, 370, 960, 370)
    draw_line(overlay_guide, 480, 120, 180, 520)
    draw_line(overlay_guide, 480, 120, 780, 520)
    draw_line(blend_guide, 120, 500, 840, 500)

    refresh_screen(60)

free_all_bitmaps()
close_all_windows()
