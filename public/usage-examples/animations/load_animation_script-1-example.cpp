#include "splashkit.h"

int main()
{
    write_line("=== Load Animation Script Example ===");
    write_line("");
    
    // Load an animation script from file
    write_line("Loading animation script from file...");
    write_line("File: explosion.txt");
    write_line("");
    
    animation_script explosion_script = load_animation_script("explosion", "explosion.txt");

    // Check if the script was loaded successfully
    if (has_animation_script("explosion"))
    {
        write_line("✓ Animation Script Loaded Successfully!");
        write_line("");
        write_line("Script Details:");
        write_line("  Script Name: " + animation_script_name(explosion_script));
        write_line("  Animation Count: " + std::to_string(animation_count(explosion_script)));
        write_line("  Has Script 'kermit': Yes");
    }
    else
    {
        write_line("✗ Failed to load animation script!");
    }

    // Free the animation script when done
    free_animation_script(kermit_script);

    close_all_windows();
    return 0;
}
