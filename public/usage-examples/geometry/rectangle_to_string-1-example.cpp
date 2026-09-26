#include "splashkit.h"
#include <string>

int main()
{
    rectangle rect = rectangle_from(10, 20, 100, 50);
    std::string result = rectangle_to_string(rect);

    write_line(result);

    return 0;
}
