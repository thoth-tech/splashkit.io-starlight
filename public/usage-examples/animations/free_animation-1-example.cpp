#include "splashkit.h"

int main()
{
    write_line("=== Free Animation Example ===");
    write_line("");
    
    // Load animation script
    write_line("Step 1: Loading animation script...");
    animation_script script = load_animation_script("explosion", "explosion.txt");
    write_line("✓ Script loaded");
    write_line("");

    // Create animation
    write_line("Step 2: Creating animation...");
    animation anim = create_animation(script, "Explosion");
    write_line("✓ Animation created");
    write_line("  Name: " + animation_name(anim));
    write_line("  Current Cell: " + std::to_string(animation_current_cell(anim)));
    write_line("");
    
    // Use the animation
    write_line("Step 3: Using animation (updating 5 times)...");
    for (int i = 0; i < 5; i++)
    {
        update_animation(anim, 0.1f);
        write_line("  Update " + std::to_string(i + 1) + ": Cell " + std::to_string(animation_current_cell(anim)));
    }
    write_line("");
    
    // Free the animation
    write_line("Step 4: Freeing animation...");
    free_animation(anim);
    write_line("✓ Animation freed (memory released)");
    write_line("");
    
    write_line("Animation Status: FREED");
    write_line("The animation memory has been properly cleaned up.");
    write_line("");

    // Cleanup script
    write_line("Step 5: Freeing animation script...");
    free_animation_script(script);
    write_line("✓ Script freed");
    write_line("");
    write_line("All resources cleaned up successfully!");

    return 0;
}
