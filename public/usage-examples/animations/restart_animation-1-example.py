from splashkit import *

write_line("=== Restart Animation Example ===")
write_line("")

# Load animation script and create animation
script = load_animation_script("explosion", "explosion.txt")
anim = create_animation(script, "Explosion")

restart_count = 0

write_line("Initial State:")
write_line(f"  Current Cell: {animation_current_cell(anim)}")
write_line(f"  Animation Ended: {'Yes' if animation_ended(anim) else 'No'}")
write_line("")

# Update animation until it ends, then restart it
write_line("Running animation cycles...")
write_line("")

for cycle in range(3):
    write_line(f"Cycle {cycle + 1}:")
    
    # Update animation several times
    for i in range(20):
        update_animation(anim)
    
    current_cell = animation_current_cell(anim)
    write_line(f"  After 20 updates - Cell: {current_cell}")
    write_line("  Restarting animation...")
    restart_animation(anim)
    restart_count += 1
    write_line(f"  After restart - Cell: {animation_current_cell(anim)}, Frame Time: {animation_frame_time(anim)}")
    write_line("")

write_line("Summary:")
write_line(f"  Total Restarts: {restart_count}")
write_line(f"  Final Cell: {animation_current_cell(anim)}")

# Cleanup
free_animation(anim)
free_animation_script(script)
