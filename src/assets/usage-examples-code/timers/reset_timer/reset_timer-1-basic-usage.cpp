#include <iostream>
#include "splashkit.h"

int main()
{
    timer myTimer = create_timer("my_timer"); 
    start_timer(myTimer);
    delay(2000);
    
    // Reset the timer
    reset_timer(myTimer);
    
    std::cout << "Timer reset!" << std::endl;
    free_timer(myTimer);

    return 0;
}
