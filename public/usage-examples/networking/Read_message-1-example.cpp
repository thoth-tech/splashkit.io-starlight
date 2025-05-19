#include "splashkit.h"

int main()
{
    // create a TCP server on port 4000
    server_socket server = create_server("my_server", 4000);

    // connect the client to our server
    connection client = open_connection("client", "127.0.0.1", 4000);
    if (!is_connection_open(client))
    {
        write_line("Connection failed.");
        return 1;
    }

    // wait until the server sees the incoming client
    while (!server_has_new_connection(server))
    {
        check_network_activity();
        delay(50);
    }
    connection server_conn = fetch_new_connection(server);

    // server sends its greeting to the client
    send_message_to("Hello from SplashKit server!", server_conn);

    // pump the network so the client can receive it
    check_network_activity();

    // client checks for and reads the message
    if (has_messages(client))
    {
        message msg = read_message(client);
        write_line("Client got: " + message_data(msg));
    }
    else
    {
        write_line("No message arrived.");
    }

    // clean up sockets and server
    close_connection(client);
    close_connection(server_conn);
    close_all_servers();

    return 0;
}
