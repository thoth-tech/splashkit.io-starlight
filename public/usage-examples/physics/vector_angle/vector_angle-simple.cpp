#include "splashkit.h"

int main()
{
    // Define the vector
    vector_2d my_vector_1;
    my_vector_1.x = 200;
    my_vector_1.y = 100;

    // Calculate the angle of the vector
    double my_vector_1_angle = vector_angle(my_vector_1);

    // Output the vector and its angle
    write_line(vector_to_string(my_vector_1));
  	write("Vector Angle: ");
    write_line(my_vector_1_angle);

    return 0;
}
