from splashkit import *

write_line("=== Create Animation Example ===")
write_line("")

# Load animation script
write_line("Step 1: Loading animation script...")
script = load_animation_script("explosion", "explosion.txt")
write_line(f"✓ Script loaded: {animation_script_name(script)}")
write_line("")

# Create animation from script
write_line("Step 2: Creating animation from script...")
anim = create_animation(script, "Explosion")
write_line("✓ Animation created successfully!")
write_line("")

# Display animation details
write_line("Animation Details:")
write_line(f"  Name: {animation_name(anim)}")
write_line(f"  Current Cell: {animation_current_cell(anim)}")
write_line(f"  Frame Time: {animation_frame_time(anim)}")
write_line(f"  Animation Ended: {'Yes' if animation_ended(anim) else 'No'}")
write_line("")

# Test the animation by updating it
write_line("Step 3: Testing animation (5 updates)...")
for i in range(5):
    update_animation(anim)
    write_line(f"  Update {i + 1}: Cell {animation_current_cell(anim)}")

write_line("")
write_line("Animation is working correctly!")

# Cleanup
free_animation(anim)
free_animation_script(script)
