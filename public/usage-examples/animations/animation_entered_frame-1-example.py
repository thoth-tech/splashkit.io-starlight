from splashkit import *

open_window("Animation Frame Tracker", 800, 500)

frame_script = load_animation_script("FrameCycle", "frame_cycle.txt")
frame_animation = create_animation(frame_script, "Cycle")

entered_new_frame = False
frame_notice_countdown = 0
current_frame = 0

while not quit_requested():
    process_events()
    update_animation(frame_animation)

    entered_new_frame = animation_entered_frame(frame_animation)
    current_frame = animation_current_cell(frame_animation)

    # Keep the triggered message visible long enough to be noticed.
    if entered_new_frame:
        frame_notice_countdown = 30
    elif frame_notice_countdown > 0:
        frame_notice_countdown -= 1

    clear_screen(color_white())
    draw_text("Animation Frame Tracker", color_black(), 270, 60)
    draw_text(
        "The highlighted circle shows the current animation frame.",
        color_black(),
        175,
        100
    )

    fill_circle(color_gray(), 160, 240, 50)
    fill_circle(color_gray(), 320, 240, 50)
    fill_circle(color_gray(), 480, 240, 50)
    fill_circle(color_gray(), 640, 240, 50)

    if current_frame == 0:
        fill_circle(color_blue(), 160, 240, 50)
    elif current_frame == 1:
        fill_circle(color_blue(), 320, 240, 50)
    elif current_frame == 2:
        fill_circle(color_blue(), 480, 240, 50)
    elif current_frame == 3:
        fill_circle(color_blue(), 640, 240, 50)

    draw_text("Frame 1", color_black(), 130, 310)
    draw_text("Frame 2", color_black(), 290, 310)
    draw_text("Frame 3", color_black(), 450, 310)
    draw_text("Frame 4", color_black(), 610, 310)

    if frame_notice_countdown > 0:
        draw_text(
            "A new animation frame was entered!",
            color_green(),
            245,
            390
        )
    else:
        draw_text(
            "Waiting for the next frame...",
            color_black(),
            275,
            390
        )

    refresh_screen(60)

free_animation(frame_animation)
free_animation_script(frame_script)
close_all_windows()
