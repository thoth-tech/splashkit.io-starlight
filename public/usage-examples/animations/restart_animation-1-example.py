from splashkit import *

def main():
    open_window("Animation Restart Demo", 800, 600)
    
    # Load animation script and bitmap
    dance_script = load_animation_script("dancer", "dancer.txt")
    dancer_bmp = load_bitmap("dancer", "dancer.png")
    bitmap_set_cell_details(dancer_bmp, 80, 80, 3, 3, 9)  # 3x3 grid, 9 frames
    
    # Create animation
    dance_anim = create_animation(dance_script, "dance_sequence")
    
    dancer_pos = point_at(400, 300)
    is_playing = True
    show_restart_message = False
    restart_timer = create_timer("restart_timer")
    
    while not quit_requested():
        process_events()
        
        # Toggle animation playback with spacebar
        if key_typed(KeyCode.space_key):
            if is_playing:
                # Stop the animation (it will pause at current frame)
                is_playing = False
            else:
                # Restart animation from beginning
                restart_animation(dance_anim)
                is_playing = True
                show_restart_message = True
                start_timer(restart_timer)
        
        # Auto-restart when animation ends
        if is_playing and animation_ended(dance_anim):
            restart_animation(dance_anim)
            show_restart_message = True
            start_timer(restart_timer)
        
        # Update animation only when playing
        if is_playing:
            update_animation(dance_anim)
        
        # Hide restart message after 1 second
        if show_restart_message and timer_ticks(restart_timer) > 1000:
            show_restart_message = False
        
        clear_screen(color_light_blue())
        
        # Draw dancer
        draw_bitmap(dancer_bmp, dancer_pos.x - 40, dancer_pos.y - 40,
                   option_with_animation(dance_anim))
        
        # Draw UI
        draw_text("Animation Restart Demo", color_black(), 10, 10)
        draw_text("Press SPACE to stop/restart animation", color_black(), 10, 30)
        draw_text("Animation auto-restarts when it ends", color_black(), 10, 50)
        
        # Show current animation state
        status = "PLAYING" if is_playing else "STOPPED"
        status_color = color_green() if is_playing else color_red()
        draw_text(f"Status: {status}", status_color, 10, 80)
        draw_text(f"Frame: {animation_current_cell(dance_anim)}", color_blue(), 10, 100)
        draw_text(f"Ended: {'Yes' if animation_ended(dance_anim) else 'No'}", 
                 color_purple(), 10, 120)
        
        # Show restart message
        if show_restart_message:
            draw_text("*** ANIMATION RESTARTED ***", color_red(), 10, 150)
        
        # Draw animation progress bar
        progress_width = 300
        progress_height = 20
        progress_x = 10
        progress_y = 180
        
        draw_rectangle(color_white(), progress_x, progress_y, progress_width, progress_height)
        draw_rectangle(color_black(), progress_x, progress_y, progress_width, progress_height, 
                      option_line_width(2))
        
        # Calculate progress based on current frame
        if animation_current_cell(dance_anim) >= 0:
            progress = animation_current_cell(dance_anim) / 8.0  # 0-8 frames
            fill_width = int(progress * (progress_width - 4))
            draw_rectangle(color_orange(), progress_x + 2, progress_y + 2, 
                          fill_width, progress_height - 4)
        
        draw_text("Animation Progress", color_black(), progress_x, progress_y - 20)
        
        refresh_screen(60)
    
    # Clean up
    free_animation(dance_anim)
    free_animation_script(dance_script)
    free_bitmap(dancer_bmp)
    free_timer(restart_timer)
    close_all_windows()

if __name__ == "__main__":
    main()
