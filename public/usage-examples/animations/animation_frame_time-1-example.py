from splashkit import *

# Load animation script and create animation
script = load_animation_script("explosion", "explosion.txt")
anim = create_animation(script, "Explosion")

write_line("=== Animation Frame Time Example ===")
write_line("")
write_line("Tracking frame time during animation...")
write_line("")

# Track frame time over several updates
for i in range(10):
    frame_time_before = animation_frame_time(anim)
    cell_before = animation_current_cell(anim)
    
    update_animation(anim)
    
    frame_time_after = animation_frame_time(anim)
    cell_after = animation_current_cell(anim)
    
    write_line(f"Update {i + 1}:")
    write_line(f"  Before: Cell {cell_before}, Frame Time: {frame_time_before}")
    write_line(f"  After:  Cell {cell_after}, Frame Time: {frame_time_after}")
    write_line("")
    
    # Restart when animation ends
    if animation_ended(anim):
        write_line("  [Animation ended - restarting]")
        restart_animation(anim)
        write_line("")

# Cleanup
free_animation(anim)
free_animation_script(script)
