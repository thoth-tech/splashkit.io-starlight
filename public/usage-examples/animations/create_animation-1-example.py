from splashkit import *

open_window("Animation Demo", 800, 600)

# Load the bitmap that contains the animation frames
player_bitmap = load_bitmap("player", "player.png")

# Load animation script
load_animation_script("player", "player.txt")

# Create animation
player_anim = create_animation("player", "WalkFront")

# Main game loop
while not quit_requested():
    process_events()
    clear_screen(color_white())

    # Update animation
    update_animation(player_anim)
    
    # Draw the current frame of the animation
    draw_bitmap(player_bitmap, 400, 300, animation_current_cell(player_anim))

    refresh_screen(60)

close_all_windows()