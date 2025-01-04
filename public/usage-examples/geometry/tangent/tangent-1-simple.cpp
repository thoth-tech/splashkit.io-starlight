#include "splashkit.h"

int main()
{
  write("Enter an angle: ");

  // User inputs angle
  float input = stof(read_line());
  float result = tangent(input);

  // Write tangent to console
  write("Tangent: ");
  write_line(result);
}
