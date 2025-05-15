#include "splashkit.h"

int main()
{
    // Establish a TCP connection to a local server on port 8080
    connection conn = open_connection("local server connection", "127.0.0.1", 8080);

    if (is_connection_open(conn))
    {
        write_line("Connection successfully established.");
    }
    else
    {
        write_line("Failed to connect.");
    }

    return 0;
}
