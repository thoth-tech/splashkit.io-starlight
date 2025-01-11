#include "splashkit.h"

int main()
{
  // Open the window
  open_window("Vector Visualisations", 300, 300);
  
  // Define the outer circle
  circle outer_circle;
  outer_circle.center = point_at(150, 150);
  outer_circle.radius = 75;
 
  // Define the inner point
  point_2d inner_point = {150, 150};
  
  // Define the veclocity vector
  vector_2d velocity = {10, 10};
  vector_2d escape = vector_out_of_circle_from_point(inner_point, outer_circle, velocity);
  
  // Create line representing the escape vector
  line vector_line = line_from(inner_point, escape);
  
  // Clear the screen and draw shapes
  clear_screen();
  fill_circle(COLOR_BLACK, outer_circle);
  fill_circle(COLOR_YELLOW, circle_at(inner_point, 3));
  
  // Draw the escape vector line
  draw_line(COLOR_RED, vector_line);
  
  // Refresh the screen
  refresh_screen();
  
  // Wait and close the window
  delay(4000);
  close_all_windows();
  
  return 0;
}