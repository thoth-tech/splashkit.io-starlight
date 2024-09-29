#include "splashkit.h"
#include <string> 

int main()
{
    // Let's print single integer
    write_line(5);
    write_line(10);
    write_line(15);

    // Let's print Multi-digit integer
    write_line(67890);

    // Let's do print integer after calculation
    int a = 500 - 200;
    int b = 15 * 8;
    int c = 600 / 20;
    write_line(a);  
    write_line(b);  
    write_line(c);  

    // Let's print negative and large integers
    int negative_num = -999;
    int large_num = 2147483647; 
    write_line(negative_num); 
    write_line(large_num);    

    // Handling string to integer mismatch
    string str_num = "123";
    int num = 456;

    int converted_str_num = std::stoi(str_num);  
    write_line(converted_str_num + num); 

    return 0;
}
