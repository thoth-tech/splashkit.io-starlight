#include "splashkit.h"

int main()
{
    write_line("=== Free Animation Script Example ===");
    write_line("");
    
    // Load animation script
    write_line("Step 1: Loading animation script...");
    animation_script script = load_animation_script("explosion", "explosion.txt");
    write_line("✓ Script loaded: " + animation_script_name(script));
    write_line("  Animations in script: " + std::to_string(animation_count(script)));
    write_line("");

    write_line("Step 2: Creating animation from script...");
    animation anim = create_animation(script, "Explosion");
    write_line("✓ Animation created: " + animation_name(anim));
    write_line("");
    
    // Use the animation
    write_line("Step 3: Using animation (updating 3 times)...");
    for (int i = 0; i < 3; i++)
    {
        update_animation(anim, 0.1f);
        write_line("  Update " + std::to_string(i + 1) + ": Cell " + std::to_string(animation_current_cell(anim)));
    }
    write_line("");
    
    // Free animation first
    write_line("Step 4: Freeing animation...");
    free_animation(anim);
    write_line("✓ Animation freed");
    write_line("");
    
    // Free script after animation
    write_line("Step 5: Freeing animation script...");
    write_line("Note: Animation must be freed before freeing the script");
    free_animation_script(script);
    write_line("✓ Script freed");
    write_line("");
    
    write_line("Cleanup Summary:");
    write_line("  Animation: FREED");
    write_line("  Script: FREED");
    write_line("  All memory properly released!");

    return 0;
}
