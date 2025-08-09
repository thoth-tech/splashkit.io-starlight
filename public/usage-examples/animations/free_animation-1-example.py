from splashkit import *

def main():
    open_window("Animation Memory Management", 800, 600)
    
    # Load animation script and bitmap
    particle_script = load_animation_script("particles", "particle.txt")
    particle_bmp = load_bitmap("particle", "particle.png")
    bitmap_set_cell_details(particle_bmp, 32, 32, 2, 2, 4)  # 2x2 grid, 4 frames
    
    particles = []
    spawn_timer = create_timer("spawn_timer")
    start_timer(spawn_timer)
    
    animation_count = 0
    max_particles = 20
    
    while not quit_requested():
        process_events()
        
        # Spawn new particles every 200ms
        if timer_ticks(spawn_timer) > 200 and len(particles) < max_particles:
            new_particle = create_animation(particle_script, "sparkle")
            particles.append(new_particle)
            animation_count += 1
            start_timer(spawn_timer)
        
        # Update all particles and remove finished ones
        for i in range(len(particles) - 1, -1, -1):
            update_animation(particles[i])
            
            # Free animation when it ends
            if animation_ended(particles[i]):
                free_animation(particles[i])  # Clean up animation memory
                particles.pop(i)
        
        # Manual cleanup with 'C' key
        if key_typed(KeyCode.c_key):
            for particle in particles:
                free_animation(particle)  # Free each animation
            particles.clear()
            write_line(f"Manually freed all {len(particles)} animations")
        
        clear_screen(color_dark_blue())
        
        # Draw all active particles
        for i, particle in enumerate(particles):
            # Spread particles across screen
            x = 50 + (i % 10) * 70
            y = 100 + (i // 10) * 80
            
            draw_bitmap(particle_bmp, x, y, option_with_animation(particle))
            
            # Draw particle info
            draw_text(str(i), color_white(), x, y - 15)
            draw_text(f"F:{animation_current_cell(particle)}", color_yellow(), x, y + 35)
        
        # Draw UI
        draw_text("Animation Memory Management Demo", color_white(), 10, 10)
        draw_text("Particles spawn automatically and are freed when finished", color_white(), 10, 30)
        draw_text("Press 'C' to manually clear all particles", color_white(), 10, 50)
        
        # Memory info
        draw_text(f"Active Animations: {len(particles)}", color_green(), 10, 80)
        draw_text(f"Total Created: {animation_count}", color_cyan(), 10, 100)
        draw_text(f"Max Capacity: {max_particles}", color_orange(), 10, 120)
        
        # Memory usage indicator
        usage_ratio = len(particles) / max_particles
        if usage_ratio < 0.5:
            usage_color = color_green()
        elif usage_ratio < 0.8:
            usage_color = color_yellow()
        else:
            usage_color = color_red()
        
        bar_width = 200
        bar_height = 20
        bar_x = 300
        bar_y = 80
        
        draw_rectangle(color_white(), bar_x, bar_y, bar_width, bar_height)
        draw_rectangle(usage_color, bar_x + 2, bar_y + 2, 
                      int((bar_width - 4) * usage_ratio), bar_height - 4)
        draw_rectangle(color_black(), bar_x, bar_y, bar_width, bar_height, option_line_width(2))
        draw_text("Memory Usage", color_white(), bar_x, bar_y - 20)
        
        # Show cleanup message
        if not particles and animation_count > 0:
            draw_text("All animations properly freed!", color_green(), 10, 150)
        
        refresh_screen(60)
    
    # Final cleanup - free any remaining animations
    for particle in particles:
        free_animation(particle)
    particles.clear()
    
    # Clean up other resources
    free_animation_script(particle_script)
    free_bitmap(particle_bmp)
    free_timer(spawn_timer)
    close_all_windows()
    
    write_line("Program ended - all resources cleaned up properly")

if __name__ == "__main__":
    main()
