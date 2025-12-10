from splashkit import *

# Load animation script and create animation
script = load_animation_script("explosion", "explosion.txt")
anim = create_animation(script, "Explosion")

write_line("=== Animation Ended Example ===")
write_line("")

# Check animation state initially
write_line("Initial State:")
write_line(f"Current Cell: {animation_current_cell(anim)}")
write_line(f"Animation Ended: {'Yes' if animation_ended(anim) else 'No'}")
write_line("")

# Update animation multiple times to reach the end
write_line("Updating animation...")
for i in range(50):
    update_animation(anim)

write_line("")

# Check final state
write_line("Final State:")
write_line(f"Current Cell: {animation_current_cell(anim)}")
write_line(f"Animation Ended: {'Yes' if animation_ended(anim) else 'No'}")
write_line("")

# Restart and check again
write_line("Restarting animation...")
restart_animation(anim)
write_line("After Restart:")
write_line(f"Current Cell: {animation_current_cell(anim)}")
write_line(f"Animation Ended: {'Yes' if animation_ended(anim) else 'No'}")

# Cleanup
free_animation(anim)
free_animation_script(script)
