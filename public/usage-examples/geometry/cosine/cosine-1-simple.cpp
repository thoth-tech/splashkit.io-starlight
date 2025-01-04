#include "splashkit.h"

int main()
{
  write("Enter an angle: ");

  // User inputs angle
  float input = stof(read_line());
  float result = cosine(input);

  // Write cosine to console
  write("Cosine: ");
  write_line(result);
}
