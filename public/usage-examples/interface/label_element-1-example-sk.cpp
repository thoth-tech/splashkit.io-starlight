#include "splashkit.h"

int main()
{
	// Open a window
	open_window("SplashKit Interface Demo", 600, 400);

	while (!window_close_requested("SplashKit Interface Demo"))
	{
		process_events();
		clear_screen(COLOR_WHITE);
		
		// Define the main panel
		rectangle main_panel_area = rectangle_from(50, 50, 500, 300);

		// Create the panel
		start_panel("MainPanel", main_panel_area);

		// Add label to the panel
		label_element("Welcome to the SplashKit Interface!");
		end_panel("MainPanel");


		// Draw all panels and interface elements
		draw_interface();

		refresh_screen(60);
	}

	return 0;
}
