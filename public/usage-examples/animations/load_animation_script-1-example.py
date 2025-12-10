from splashkit import *

write_line("=== Load Animation Script Example ===")
write_line("")

# Load an animation script from file
write_line("Loading animation script from file...")
write_line("File: explosion.txt")
write_line("")

explosion_script = load_animation_script("explosion", "explosion.txt")

# Check if the script was loaded successfully
if has_animation_script("explosion"):
    write_line("✓ Animation Script Loaded Successfully!")
    write_line("")
    write_line("Script Details:")
    write_line(f"  Script Name: {animation_script_name(explosion_script)}")
    write_line(f"  Animation Count: {animation_count(explosion_script)}")
    write_line("  Has Script 'explosion': Yes")
else:
    write_line("✗ Failed to load animation script!")

# Cleanup
write_line("")
write_line("Cleaning up...")
free_animation_script(explosion_script)
write_line("✓ Script freed")
