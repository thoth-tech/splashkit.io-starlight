from splashkit import *

write_line("=== Update Animation Example ===")
write_line("")

# Load animation script and create animation
script = load_animation_script("explosion", "explosion.txt")
anim = create_animation(script, "Explosion")

write_line("Starting animation sequence...")
write_line("")

update_count = 0

# Update animation and track progress
for update_count in range(1, 16):
    update_animation(anim)
    
    write_line(f"Update {update_count}:")
    write_line(f"  Cell: {animation_current_cell(anim)}")
    write_line(f"  Frame Time: {animation_frame_time(anim)}")
    write_line("")

write_line("Animation Complete!")
write_line(f"Total Updates: 15")
write_line(f"Final Cell: {animation_current_cell(anim)}")

# Cleanup
free_animation(anim)
free_animation_script(script)
