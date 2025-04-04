#include "splashkit.h"

int main()
{
    write("Enter an angle: ");

    // User inputs angle
    double input = convert_to_double(read_line());
    float result = cosine((float)input);

    // Write cosine to console
    write("Cosine: ");
    write_line(result);
}
