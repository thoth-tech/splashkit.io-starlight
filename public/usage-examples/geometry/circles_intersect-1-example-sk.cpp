#include "splashkit.h"
#include <thread>
#include <chrono>

int main()
{
    // Open the gameplay window 
    open_window("Dodge the Bouncing Balls", 800, 600);

    // Initialize player and enemy circles 
    circle player_circle   = circle_at(400, 300, 20);
    circle enemy_circle_1  = circle_at(100, 100, 30);
    circle enemy_circle_2  = circle_at(700, 500, 30);

    // Assign initial velocities to make enemies bounce off the window edges
    double enemy_dx_1 = 3, enemy_dy_1 = 2;
    double enemy_dx_2 = -2, enemy_dy_2 = -3;

    // Run the main game loop until the player quits or a collision occurs
    while (!quit_requested())
    {
        process_events();

        // Update player position based on arrow key inputs
        if (key_down(LEFT_KEY))
        {
            player_circle.center.x -= 5;
        }
        if (key_down(RIGHT_KEY))
        {
            player_circle.center.x += 5;
        }
        if (key_down(UP_KEY))
        {
            player_circle.center.y -= 5;
        }
        if (key_down(DOWN_KEY))
        {
            player_circle.center.y += 5;
        }

        // Move enemy 1 and bounce off the edges of the window
        enemy_circle_1.center.x += enemy_dx_1;
        enemy_circle_1.center.y += enemy_dy_1;
        if (enemy_circle_1.center.x < enemy_circle_1.radius ||
            enemy_circle_1.center.x > screen_width() - enemy_circle_1.radius)
        {
            enemy_dx_1 = -enemy_dx_1;
        }
        if (enemy_circle_1.center.y < enemy_circle_1.radius ||
            enemy_circle_1.center.y > screen_height() - enemy_circle_1.radius)
        {
            enemy_dy_1 = -enemy_dy_1;
        }

        // Move enemy 2 and bounce off the edges of the window
        enemy_circle_2.center.x += enemy_dx_2;
        enemy_circle_2.center.y += enemy_dy_2;
        if (enemy_circle_2.center.x < enemy_circle_2.radius ||
            enemy_circle_2.center.x > screen_width() - enemy_circle_2.radius)
        {
            enemy_dx_2 = -enemy_dx_2;
        }
        if (enemy_circle_2.center.y < enemy_circle_2.radius ||
            enemy_circle_2.center.y > screen_height() - enemy_circle_2.radius)
        {
            enemy_dy_2 = -enemy_dy_2;
        }

        // Render player and enemy circles on screen
        clear_screen(COLOR_WHITE);
        fill_circle(COLOR_GREEN, player_circle);
        fill_circle(COLOR_RED,   enemy_circle_1);
        fill_circle(COLOR_RED,   enemy_circle_2);
        refresh_screen(60);

        // Display "Game Over" and exit if a collision is detected
        if (circles_intersect(player_circle, enemy_circle_1) ||
            circles_intersect(player_circle, enemy_circle_2))
        {
            clear_screen(COLOR_WHITE);
            draw_text("Game Over", COLOR_BLACK, 350, 280);
            refresh_screen(60);

            std::this_thread::sleep_for(std::chrono::milliseconds(2000));

            break;
        }
    }

    return 0;
}