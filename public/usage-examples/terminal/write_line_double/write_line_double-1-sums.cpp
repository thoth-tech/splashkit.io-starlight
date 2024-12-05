#include "splashkit.h"
int main()
{
    write_line("Demonstrating write_line(double):");

    // Perform some calculations
    double value1 = 3.14159;  // Example value: pi
    double value2 = 2.71828;  // Example value: e
    double sum = value1 + value2;
    double product = value1 * value2;
    double difference = value1 - value2;
    double quotient = value1 / value2;

    // Output the results using write_line(double data)
    write_line("The values used are:");
    write_line(value1); // Writing the first double value
    write_line(value2); // Writing the second double value

    write_line("Their sum is:");
    write_line(sum); // Writing the sum

    write_line("Their product is:");
    write_line(product); // Writing the product

    write_line("Their difference is:");
    write_line(difference); // Writing the difference

    write_line("Their quotient is:");
    write_line(quotient); // Writing the quotient

    write_line("End of demonstration.");
}
