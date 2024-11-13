#include "splashkit.h"

int main()
{
    // Initialise quad coords
    quad q1, q2, q3, q4;
    double q1_corners[4][2] = {{400,200},{300, 300},{300,0},{200,200}};
    double q2_corners[4][2] = {{400,210},{310, 300},{600,300},{400,390}};
    double q3_corners[4][2] = {{200,400},{300, 300},{300,600},{400,400}};
    double q4_corners[4][2] = {{200,390},{290, 300},{0,300},{200,210}};
    

    // set coords for quad
    for (int i = 0; i < 4; i++) {
        q1.points[i] = point_at(q1_corners[i][0],q1_corners[i][1]);
        q2.points[i] = point_at(q2_corners[i][0],q2_corners[i][1]);
        q3.points[i] = point_at(q3_corners[i][0],q3_corners[i][1]);
        q4.points[i] = point_at(q4_corners[i][0],q4_corners[i][1]);
    }

    // Create Window

    open_window("Draw Quad", 600, 600);
    clear_screen(COLOR_BLACK);

    
    draw_quad(COLOR_WHITE, q1);
    draw_quad(COLOR_GREEN, q2);
    draw_quad(COLOR_RED, q3);
    draw_quad(COLOR_BLUE, q4);
    refresh_screen();
    delay(5000);
    close_all_windows();
    return 0;
}
    
    