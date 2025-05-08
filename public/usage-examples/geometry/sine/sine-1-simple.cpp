#include "splashkit.h"

int main()
{
    write("Enter an angle: ");

    // User inputs angle
    double input = convert_to_double(read_line());
    float result = sine((float)input);

    // Write sine to console
    write("Sine: ");
    write_line(result);
}
