using SplashKitSDK;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        SplashKit.OpenWindow("Animation Memory Management", 800, 600);
        
        // Load animation script and bitmap
        AnimationScript particleScript = SplashKit.LoadAnimationScript("particles", "particle.txt");
        Bitmap particleBmp = SplashKit.LoadBitmap("particle", "particle.png");
        SplashKit.BitmapSetCellDetails(particleBmp, 32, 32, 2, 2, 4); // 2x2 grid, 4 frames
        
        List<Animation> particles = new List<Animation>();
        Timer spawnTimer = SplashKit.CreateTimer("spawn_timer");
        SplashKit.StartTimer(spawnTimer);
        
        int animationCount = 0;
        int maxParticles = 20;
        
        while (!SplashKit.QuitRequested())
        {
            SplashKit.ProcessEvents();
            
            // Spawn new particles every 200ms
            if (SplashKit.TimerTicks(spawnTimer) > 200 && particles.Count < maxParticles)
            {
                Animation newParticle = SplashKit.CreateAnimation(particleScript, "sparkle");
                particles.Add(newParticle);
                animationCount++;
                SplashKit.StartTimer(spawnTimer);
            }
            
            // Update all particles and remove finished ones
            for (int i = particles.Count - 1; i >= 0; i--)
            {
                SplashKit.UpdateAnimation(particles[i]);
                
                // Free animation when it ends
                if (SplashKit.AnimationEnded(particles[i]))
                {
                    SplashKit.FreeAnimation(particles[i]); // Clean up animation memory
                    particles.RemoveAt(i);
                }
            }
            
            // Manual cleanup with 'C' key
            if (SplashKit.KeyTyped(KeyCode.CKey))
            {
                foreach (Animation particle in particles)
                {
                    SplashKit.FreeAnimation(particle); // Free each animation
                }
                particles.Clear();
                SplashKit.WriteLine($"Manually freed all {particles.Count} animations");
            }
            
            SplashKit.ClearScreen(SplashKit.ColorDarkBlue());
            
            // Draw all active particles
            for (int i = 0; i < particles.Count; i++)
            {
                // Spread particles across screen
                int x = 50 + (i % 10) * 70;
                int y = 100 + (i / 10) * 80;
                
                SplashKit.DrawBitmap(particleBmp, x, y, SplashKit.OptionWithAnimation(particles[i]));
                
                // Draw particle info
                SplashKit.DrawText(i.ToString(), SplashKit.ColorWhite(), x, y - 15);
                SplashKit.DrawText($"F:{SplashKit.AnimationCurrentCell(particles[i])}", 
                                 SplashKit.ColorYellow(), x, y + 35);
            }
            
            // Draw UI
            SplashKit.DrawText("Animation Memory Management Demo", SplashKit.ColorWhite(), 10, 10);
            SplashKit.DrawText("Particles spawn automatically and are freed when finished", SplashKit.ColorWhite(), 10, 30);
            SplashKit.DrawText("Press 'C' to manually clear all particles", SplashKit.ColorWhite(), 10, 50);
            
            // Memory info
            SplashKit.DrawText($"Active Animations: {particles.Count}", SplashKit.ColorGreen(), 10, 80);
            SplashKit.DrawText($"Total Created: {animationCount}", SplashKit.ColorCyan(), 10, 100);
            SplashKit.DrawText($"Max Capacity: {maxParticles}", SplashKit.ColorOrange(), 10, 120);
            
            // Memory usage indicator
            float usageRatio = (float)particles.Count / maxParticles;
            Color usageColor = usageRatio < 0.5f ? SplashKit.ColorGreen() : 
                              usageRatio < 0.8f ? SplashKit.ColorYellow() : SplashKit.ColorRed();
            
            int barWidth = 200;
            int barHeight = 20;
            int barX = 300;
            int barY = 80;
            
            SplashKit.DrawRectangle(SplashKit.ColorWhite(), barX, barY, barWidth, barHeight);
            SplashKit.DrawRectangle(usageColor, barX + 2, barY + 2, 
                                  (int)((barWidth - 4) * usageRatio), barHeight - 4);
            SplashKit.DrawRectangle(SplashKit.ColorBlack(), barX, barY, barWidth, barHeight, 
                                  SplashKit.OptionLineWidth(2));
            SplashKit.DrawText("Memory Usage", SplashKit.ColorWhite(), barX, barY - 20);
            
            // Show cleanup message
            if (particles.Count == 0 && animationCount > 0)
            {
                SplashKit.DrawText("All animations properly freed!", SplashKit.ColorGreen(), 10, 150);
            }
            
            SplashKit.RefreshScreen(60);
        }
        
        // Final cleanup - free any remaining animations
        foreach (Animation particle in particles)
        {
            SplashKit.FreeAnimation(particle);
        }
        particles.Clear();
        
        // Clean up other resources
        SplashKit.FreeAnimationScript(particleScript);
        SplashKit.FreeBitmap(particleBmp);
        SplashKit.FreeTimer(spawnTimer);
        SplashKit.CloseAllWindows();
        
        SplashKit.WriteLine("Program ended - all resources cleaned up properly");
    }
}
