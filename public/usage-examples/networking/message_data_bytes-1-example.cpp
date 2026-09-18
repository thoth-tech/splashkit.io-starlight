#include "splashkit.h"
#include <iostream>
#include <vector>

int main()
{
    unsigned short port = 5000;

    server_socket server = create_server("byte_server", port);

    // Create a local connection and send a message
    connection client = open_connection(
        "byte_client",
        "127.0.0.1",
        port
    );

    delay(100);
    check_network_activity();
    accept_all_new_connections();

    send_message_to("Hi", client);

    delay(100);
    check_network_activity();

    message received_message = read_message(server);

    // Read the received message as bytes
    vector<int8_t> data_bytes =
        message_data_bytes(received_message);

    std::cout << "Message Data Bytes" << std::endl;
    std::cout << std::endl;
    std::cout << "Message: Hi" << std::endl;
    std::cout << "Bytes: ";

    for (int8_t value : data_bytes)
    {
        std::cout << static_cast<int>(value) << " ";
    }

    std::cout << std::endl;

    close_all_connections();
    close_all_servers();

    return 0;
}