#include "splashkit.h"

int main()
{
    // Initialise quad coords
    double q1_corners[4][2] = {{400,200},{300, 300},{300,0},{200,200}};
    double q2_corners[4][2] = {{400,210},{310, 300},{600,300},{400,390}};
    double q3_corners[4][2] = {{200,400},{300, 300},{300,600},{400,400}};
    double q4_corners[4][2] = {{200,390},{290, 300},{0,300},{200,210}};
    quad q1;
    quad q2;
    quad q3;
    quad q4;

    // set coords
    for (int i = 0; i < 4; i++) {
        q1.points[i] = point_at(q1_corners[i][0],q1_corners[i][1]);
        q2.points[i] = point_at(q2_corners[i][0],q2_corners[i][1]);
        q3.points[i] = point_at(q3_corners[i][0],q3_corners[i][1]);
        q4.points[i] = point_at(q4_corners[i][0],q4_corners[i][1]);
    }

    // Create Window
    window window1 = open_window("Draw Quad On Window 1", 600, 600);
    window window2 = open_window("Draw Quad On Window 2", 600, 600);
    clear_screen(COLOR_WHITE);

    
    draw_quad_on_window(window1, COLOR_BLACK, q1);
    draw_quad_on_window(window1, COLOR_GREEN, q2);
    draw_quad_on_window(window2, COLOR_RED, q3);
    draw_quad_on_window(window2, COLOR_BLUE, q4);
    refresh_screen();
    delay(5000);
    close_all_windows();
    return 0;
}
    
    