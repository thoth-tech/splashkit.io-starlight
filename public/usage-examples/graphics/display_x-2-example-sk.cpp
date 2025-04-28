#include "splashkit.h"

const int MAX_DISPLAYS = 10;

int main()
{
    // Load Font
    font font = load_font("font", "RobotoSlab.ttf");

    // Set number of displays
    int disp_count = number_of_displays();

    // Arrays for storing display details
    int disp_store[MAX_DISPLAYS][4];
    string disp_names[MAX_DISPLAYS];

    // Create variables for offset
    int min_x = 0;
    int min_y = 0;

    // Loop through displays collect details
    for (unsigned int i = 0; i < disp_count; i++)
    {
        // Set details for display
        display disp_details = display_details(i);

        // Get coordinate info for display
        int disp_x = display_x(disp_details);
        int disp_y = display_y(disp_details);

        // Get resolution for display
        int disp_width = display_width(disp_details);
        int disp_height = display_height(disp_details);

        // Get name for display
        string disp_name = display_name(disp_details);

        // Add details to display store
        disp_store[i][0] = disp_x;
        disp_store[i][1] = disp_y;
        disp_store[i][2] = disp_width;
        disp_store[i][3] = disp_height;
        disp_names[i] = disp_name;     

        // Set min coordinate offset for drawing
        if (disp_x < min_x) min_x = disp_x;
        if (disp_y < min_y) min_y = disp_y;
    }

    window wind = open_window("Display X", 800, 600);

    for (int i = 0; i < disp_count; i++)
    {
        // Set Display Variables
        int origin_x = disp_store[i][0];
        int origin_y = disp_store[i][1];
        int len_w = disp_store[i][2];
        int len_h = disp_store[i][3];        

        // Create strings for display
        string display_name_string = "Name: " + disp_names[i];
        string display_num_string = "Display Number: " + std::to_string(i + 1);
        string display_coord_string = "Display Coordinates: (" + std::to_string(origin_x) + ", " + std::to_string(origin_y) + ")";

        // Refactor size and normalize for 300,300 origin in window
        origin_x = (origin_x - min_x + 300) / 8;
        origin_y = (origin_y - min_y + 400) / 8;
        len_w = len_w / 8;
        len_h = len_h / 8;

        // Draw Display setup to screen and label
        rectangle disp = rectangle_from(origin_x, origin_y, len_w, len_h);
        draw_rectangle_on_window(wind, COLOR_BLACK, disp);
        draw_text_on_window(wind, display_name_string, COLOR_BLACK, font, 10, origin_x + 5, origin_y + 5);
        draw_text_on_window(wind, display_num_string, COLOR_BLACK, font, 10, origin_x + 5, origin_y + 20);
        draw_text_on_window(wind, display_coord_string, COLOR_BLACK, font, 10, origin_x + 5, origin_y + 35);
        refresh_screen();
    }
    draw_text_on_window(wind, "Display X value represents the horizontal offset of a display,", color_black(), font, 16, 10, 10);
    draw_text_on_window(wind, "where 0,0 is the top left corner of the main display.", color_black(), font, 16, 10, 30);
    refresh_screen();
    while (!quit_requested())
    {
        process_events();
    }
    return 0;
}
