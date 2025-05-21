#include "splashkit.h"

int main()
{
    // Start a simple TCP server on localhost:8080
    create_server("local server", 8080);

    // Establish a TCP connection to the local server
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
