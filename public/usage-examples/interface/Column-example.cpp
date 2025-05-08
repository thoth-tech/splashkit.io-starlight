#include <iostream>
#include <string>
using namespace std;

const int CONTAINER_WIDTH = 50; // Simulated container width in characters

// Display columns with increasing percentage width
void add_column_relative(double width)
{
    int pixels = int(CONTAINER_WIDTH * width); // Convert relative width to "pixels"
    string bar = string(pixels, '=');          // Create visual column
    cout << "[" << bar << "] " << int(width * 100) << "%" << endl;
}

int main()
{
    for (int i = 1; i <= 5; i++)
        add_column_relative(i * 0.2); // 20%, 40%, 60%, 80%, 100%

    return 0;
}
