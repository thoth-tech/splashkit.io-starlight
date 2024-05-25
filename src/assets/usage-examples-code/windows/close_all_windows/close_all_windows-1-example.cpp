#include "splashkit.h"  
#include <thread>       
#include <chrono>       

int main()
{
    // Open a few windows
    open_window("Window 1", 800, 600);
    open_window("Window 2", 800, 600);
    open_window("Window 3", 800, 600);

    write_line("Opened 3 windows. Waiting for 5 seconds...");

    // Wait for 5 seconds
    std::this_thread::sleep_for(std::chrono::seconds(5));

    // Close all windows
    close_all_windows();
    write_line("All windows have been closed.");

    return 0;
}
