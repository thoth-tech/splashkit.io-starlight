#include "splashkit.h"

int main()
{
    int numbers[] = {17, 18};

    for (int i = 0; i < 2; i++)
    {
        int num = numbers[i];
        if (is_prime_number(num)) // SplashKit function
            write_line(std::to_string(num) + " is prime");
        else
            write_line(std::to_string(num) + " is not prime");
    }

    return 0;
}
