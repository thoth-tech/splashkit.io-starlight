#include "splashkit.h"

int main()
{
    write_line("=== Create Animation Example ===");
    write_line("");
    
    // Load the animation script
    write_line("Loading animation script...");
    animation_script script = load_animation_script("explosion", "explosion.txt");
    write_line("Script loaded successfully!");
    write_line("");

    // Create an animation from the script
    write_line("Creating animation from script...");
    animation anim = create_animation(script, "Explosion");
    write_line("✓ Animation Created Successfully!");
    write_line("");
    
    // Display animation information
    write_line("Animation Details:");
    write_line("  Name: " + animation_name(anim));
    write_line("  Current Cell: " + std::to_string(animation_current_cell(anim)));
    write_line("  Animation Ended: " + string(animation_ended(anim) ? "Yes" : "No"));
    write_line("  Frame Time: " + std::to_string(animation_frame_time(anim)));
    write_line("  Script Name: " + animation_script_name(script));
    write_line("  Total Animations in Script: " + std::to_string(animation_count(script)));

    // Free resources
    free_animation(anim);
    free_animation_script(script);

    close_all_windows();
    return 0;
}
