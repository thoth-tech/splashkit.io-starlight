#include "splashkit.h"

int main()
{
    open_window("Lines From Triangle", 400, 400);
    //Triangle from pair cordinates sequentially
    triangle newTriangle = triangle_from(100, 100, 200, 80, 150, 200);

    //Loop through and display each line (edge) of the triangle individually
    for (line l : lines_from(newTriangle))
    {
        clear_screen(COLOR_WHITE);
        draw_line(COLOR_RED, l);
        refresh_screen();
        delay(800);
    }

    //Pause briefly at the end
    delay(1000);
    return 0;
}
