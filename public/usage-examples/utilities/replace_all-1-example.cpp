#include "splashkit.h"
#include <iostream>
int main() {
    std::string s = "foo is not bar, but foo can be bar";
    std::cout << replace_all(s, "foo", "bar") << std::endl;
    return 0;
}
