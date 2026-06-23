#include "splashkit.h"

int main()
{
    write("Enter an angle: ");

    // User inputs angle
    double input = convert_to_double(read_line());
    float result = tangent((float)input);

    // Write tangent to console
    write("Tangent: ");
    write_line(result);
}
