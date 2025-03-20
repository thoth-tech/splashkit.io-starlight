#include "splashkit.h"

int main()
{
    const int SPEED = 3;
    const int PLAYER_RADIUS = 50;

    vector<circle> circles;
    circles.push_back(circle_at(150, 150, 130));
    circles.push_back(circle_at(450, 150, 130));
    circles.push_back(circle_at(150, 450, 130));
    circles.push_back(circle_at(450, 450, 130));

    circle player_circle = circle_at(300, 300, PLAYER_RADIUS);

    open_window("Intersecting Circles?", 600, 600);

    while (!quit_requested())
    {
        process_events();

        if (key_down(LEFT_KEY) && player_circle.center.x > PLAYER_RADIUS)
            player_circle.center.x -= SPEED;
        if (key_down(RIGHT_KEY) && player_circle.center.x < screen_width() - PLAYER_RADIUS)
            player_circle.center.x += SPEED;
        if (key_down(UP_KEY) && player_circle.center.y > PLAYER_RADIUS)
            player_circle.center.y -= SPEED;
        if (key_down(DOWN_KEY) && player_circle.center.y < screen_height() - PLAYER_RADIUS)
            player_circle.center.y += SPEED;

        clear_screen(color_white());
        for (int i = 0; i < 4; i++)
        {
            // Check if the player circle has intersected any other circles
            if (circles_intersect(player_circle, circles[i]))
                fill_circle(COLOR_RED, circles[i]);
            else
                draw_circle(COLOR_RED, circles[i]);
        }
        fill_circle(COLOR_BLUE, player_circle);
        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}
    close_all_windows();
}
