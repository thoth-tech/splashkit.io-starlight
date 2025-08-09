#include "splashkit.h"
#include <vector>

int main()
{
    open_window("Animation Memory Management", 800, 600);
    
    // Load animation script and bitmap
    animation_script particle_script = load_animation_script("particles", "particle.txt");
    bitmap particle_bmp = load_bitmap("particle", "particle.png");
    bitmap_set_cell_details(particle_bmp, 32, 32, 2, 2, 4); // 2x2 grid, 4 frames
    
    std::vector<animation> particles;
    timer spawn_timer = create_timer("spawn_timer");
    start_timer(spawn_timer);
    
    int animation_count = 0;
    int max_particles = 20;
    
    while (!quit_requested())
    {
        process_events();
        
        // Spawn new particles every 200ms
        if (timer_ticks(spawn_timer) > 200 && particles.size() < max_particles)
        {
            animation new_particle = create_animation(particle_script, "sparkle");
            particles.push_back(new_particle);
            animation_count++;
            start_timer(spawn_timer);
        }
        
        // Update all particles and remove finished ones
        for (int i = particles.size() - 1; i >= 0; i--)
        {
            update_animation(particles[i]);
            
            // Free animation when it ends
            if (animation_ended(particles[i]))
            {
                free_animation(particles[i]); // Clean up animation memory
                particles.erase(particles.begin() + i);
            }
        }
        
        // Manual cleanup with 'C' key
        if (key_typed(key_c))
        {
            for (animation& particle : particles)
            {
                free_animation(particle); // Free each animation
            }
            particles.clear();
            write_line("Manually freed all " + std::to_string(particles.size()) + " animations");
        }
        
        clear_screen(color_dark_blue());
        
        // Draw all active particles
        for (int i = 0; i < particles.size(); i++)
        {
            // Spread particles across screen
            int x = 50 + (i % 10) * 70;
            int y = 100 + (i / 10) * 80;
            
            draw_bitmap(particle_bmp, x, y, option_with_animation(particles[i]));
            
            // Draw particle info
            draw_text(std::to_string(i), color_white(), x, y - 15);
            draw_text("F:" + std::to_string(animation_current_cell(particles[i])), 
                     color_yellow(), x, y + 35);
        }
        
        // Draw UI
        draw_text("Animation Memory Management Demo", color_white(), 10, 10);
        draw_text("Particles spawn automatically and are freed when finished", color_white(), 10, 30);
        draw_text("Press 'C' to manually clear all particles", color_white(), 10, 50);
        
        // Memory info
        draw_text("Active Animations: " + std::to_string(particles.size()), color_green(), 10, 80);
        draw_text("Total Created: " + std::to_string(animation_count), color_cyan(), 10, 100);
        draw_text("Max Capacity: " + std::to_string(max_particles), color_orange(), 10, 120);
        
        // Memory usage indicator
        float usage_ratio = (float)particles.size() / max_particles;
        color usage_color = usage_ratio < 0.5 ? color_green() : 
                           usage_ratio < 0.8 ? color_yellow() : color_red();
        
        int bar_width = 200;
        int bar_height = 20;
        int bar_x = 300;
        int bar_y = 80;
        
        draw_rectangle(color_white(), bar_x, bar_y, bar_width, bar_height);
        draw_rectangle(usage_color, bar_x + 2, bar_y + 2, 
                      (int)((bar_width - 4) * usage_ratio), bar_height - 4);
        draw_rectangle(color_black(), bar_x, bar_y, bar_width, bar_height, option_line_width(2));
        draw_text("Memory Usage", color_white(), bar_x, bar_y - 20);
        
        // Show cleanup message
        if (particles.empty() && animation_count > 0)
        {
            draw_text("All animations properly freed!", color_green(), 10, 150);
        }
        
        refresh_screen(60);
    }
    
    // Final cleanup - free any remaining animations
    for (animation& particle : particles)
    {
        free_animation(particle);
    }
    particles.clear();
    
    // Clean up other resources
    free_animation_script(particle_script);
    free_bitmap(particle_bmp);
    free_timer(spawn_timer);
    close_all_windows();
    
    write_line("Program ended - all resources cleaned up properly");
    
    return 0;
}
