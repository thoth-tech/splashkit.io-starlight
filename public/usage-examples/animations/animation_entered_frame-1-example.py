from splashkit import *

# Load animation script and create animation
script = load_animation_script("explosion", "explosion.txt")
anim = create_animation(script, "Explosion")

write_line("=== Animation Entered Frame Example ===")
write_line("")

frame_enter_count = 0
updates = 0

write_line("Tracking frame transitions...")
write_line("")

# Update animation and track frame entries
for i in range(20):
    update_animation(anim)
    updates += 1
    
    # Check if animation entered a new frame
    if animation_entered_frame(anim):
        frame_enter_count += 1
        write_line(f"Update {updates}: Entered NEW FRAME! (Total: {frame_enter_count}, Cell: {animation_current_cell(anim)})")
    
    # Restart if animation ends
    if animation_ended(anim):
        restart_animation(anim)

write_line("")
write_line("Summary:")
write_line(f"Total Updates: {updates}")
write_line(f"Total Frame Entries: {frame_enter_count}")
write_line(f"Current Cell: {animation_current_cell(anim)}")

# Cleanup
free_animation(anim)
free_animation_script(script)
