#include "splashkit.h"

int main()
{
  write("Enter an angle: ");

  // User inputs angle
  float input = stof(read_line());
  float result = sine(input);

  // Write sine to console
  write("Sine: ");
  write_line(result);
}
