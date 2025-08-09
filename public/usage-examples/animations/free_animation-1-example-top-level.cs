using static SplashKitSDK.SplashKit;
using System.Collections.Generic;

OpenWindow("Animation Memory Management", 800, 600);

// Load animation script and bitmap
var particleScript = LoadAnimationScript("particles", "particle.txt");
var particleBmp = LoadBitmap("particle", "particle.png");
BitmapSetCellDetails(particleBmp, 32, 32, 2, 2, 4); // 2x2 grid, 4 frames

List<Animation> particles = new List<Animation>();
var spawnTimer = CreateTimer("spawn_timer");
StartTimer(spawnTimer);

int animationCount = 0;
int maxParticles = 20;

while (!QuitRequested())
{
    ProcessEvents();
    
    // Spawn new particles every 200ms
    if (TimerTicks(spawnTimer) > 200 && particles.Count < maxParticles)
    {
        var newParticle = CreateAnimation(particleScript, "sparkle");
        particles.Add(newParticle);
        animationCount++;
        StartTimer(spawnTimer);
    }
    
    // Update all particles and remove finished ones
    for (int i = particles.Count - 1; i >= 0; i--)
    {
        UpdateAnimation(particles[i]);
        
        // Free animation when it ends
        if (AnimationEnded(particles[i]))
        {
            FreeAnimation(particles[i]); // Clean up animation memory
            particles.RemoveAt(i);
        }
    }
    
    // Manual cleanup with 'C' key
    if (KeyTyped(KeyCode.CKey))
    {
        foreach (var particle in particles)
        {
            FreeAnimation(particle); // Free each animation
        }
        particles.Clear();
        WriteLine($"Manually freed all {particles.Count} animations");
    }
    
    ClearScreen(ColorDarkBlue());
    
    // Draw all active particles
    for (int i = 0; i < particles.Count; i++)
    {
        // Spread particles across screen
        int x = 50 + (i % 10) * 70;
        int y = 100 + (i / 10) * 80;
        
        DrawBitmap(particleBmp, x, y, OptionWithAnimation(particles[i]));
        
        // Draw particle info
        DrawText(i.ToString(), ColorWhite(), x, y - 15);
        DrawText($"F:{AnimationCurrentCell(particles[i])}", ColorYellow(), x, y + 35);
    }
    
    // Draw UI
    DrawText("Animation Memory Management Demo", ColorWhite(), 10, 10);
    DrawText("Particles spawn automatically and are freed when finished", ColorWhite(), 10, 30);
    DrawText("Press 'C' to manually clear all particles", ColorWhite(), 10, 50);
    
    // Memory info
    DrawText($"Active Animations: {particles.Count}", ColorGreen(), 10, 80);
    DrawText($"Total Created: {animationCount}", ColorCyan(), 10, 100);
    DrawText($"Max Capacity: {maxParticles}", ColorOrange(), 10, 120);
    
    // Memory usage indicator
    float usageRatio = (float)particles.Count / maxParticles;
    var usageColor = usageRatio < 0.5f ? ColorGreen() : 
                     usageRatio < 0.8f ? ColorYellow() : ColorRed();
    
    int barWidth = 200;
    int barHeight = 20;
    int barX = 300;
    int barY = 80;
    
    DrawRectangle(ColorWhite(), barX, barY, barWidth, barHeight);
    DrawRectangle(usageColor, barX + 2, barY + 2, 
                  (int)((barWidth - 4) * usageRatio), barHeight - 4);
    DrawRectangle(ColorBlack(), barX, barY, barWidth, barHeight, OptionLineWidth(2));
    DrawText("Memory Usage", ColorWhite(), barX, barY - 20);
    
    // Show cleanup message
    if (particles.Count == 0 && animationCount > 0)
    {
        DrawText("All animations properly freed!", ColorGreen(), 10, 150);
    }
    
    RefreshScreen(60);
}

// Final cleanup - free any remaining animations
foreach (var particle in particles)
{
    FreeAnimation(particle);
}
particles.Clear();

// Clean up other resources
FreeAnimationScript(particleScript);
FreeBitmap(particleBmp);
FreeTimer(spawnTimer);
CloseAllWindows();

WriteLine("Program ended - all resources cleaned up properly");
