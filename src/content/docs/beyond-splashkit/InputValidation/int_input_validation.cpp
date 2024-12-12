#include <iostream>
#include <splashkit.h>

bool nosk_is_integer(string text)
{
    // Function to check if input is a valid integer
    // This is what SplashKit abstracts from the user when calling is_integer

    string s = trim(text);
    if(s.empty() || ((!isdigit(s[0])) && (s[0] != '-') && (s[0] != '+'))) return false;
    
    char * p;
    strtol(s.c_str(), &p, 10);
    
    return (*p == 0);
}

int non_sk_convert_int_validation()
{
    std::cout << "This function converts user input into an integer with input validation using non Splashkit functions." << std::endl;

    string x;
    std::cout << "Please enter an integer: " << std::endl;

    // Holds program in a loop until user enters a valid integer
    while (!nosk_is_integer(x))
    {
        std::cin >> x;
        if (!nosk_is_integer(x)) std::cout << "Please enter a valid integer." << std::endl;
    }

    // Convert to integer and write back to console
    int int_x = std::stoi(x);
    std::cout << "Your integer entered was: " << x << std::endl;
    
    return int_x;
}

int sk_convert_int_validation()
{
    write_line("This function converts user input into an integer with input validation using Splashkit functions.");
    string x;
    write_line("Please enter an integer: ");

    // Holds program in a loop until user enters a valid integer
    while (!is_integer(x)){
        x = read_line();
        if (!is_integer(x)) write_line("Please enter a valid integer.");
    }

    // Convert to integer and write back to console
    int int_x = convert_to_integer(x);
    write("Your integer entered was: ");
    write_line(x);
    return int_x;
}



int main(int argc, char* argv[])
{
    int sk_int;
    int nsk_int;

    sk_int = sk_convert_int_validation();
    nsk_int = non_sk_convert_int_validation();

    write("The sum of the two integers is: ");
    write_line(sk_int + nsk_int);
    return 0;
}

