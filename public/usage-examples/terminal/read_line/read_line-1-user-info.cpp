#include "splashkit.h"

int main()
{
    write_line("Enter your name:");

    // Read the user input
    string name = read_line();

    // Output a greeting
    write_line("Hello, " + name + "!");

    write_line();

    write_line("Enter your age:");

    // Read the user input
    string age = read_line();

    // Output the age
    write_line("You are " + age + " years old.");

    write_line();

    write_line("Enter your favorite colour:");

    // Read the user input
    string colour = read_line();

    // Output the favourite colour
    write_line("Your favourite color is " + colour + ".");
}
