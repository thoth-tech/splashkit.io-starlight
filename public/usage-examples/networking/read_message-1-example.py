import splashkit

def main():
    # create a TCP server on port 4000
    server = splashkit.create_server_with_port("my_server", 4000)

    # connect the client to our server
    client = splashkit.open_connection("client", "127.0.0.1", 4000)
    if not splashkit.is_connection_open(client):
        print("Connection failed.")
        return

    # wait until the server sees the incoming client
    while not splashkit.server_has_new_connection(server):
        splashkit.check_network_activity()
        splashkit.delay(50)
    server_conn = splashkit.fetch_new_connection(server)

    # server sends its greeting
    splashkit.send_message_to_connection("Hello from SplashKit server!", server_conn)

    # pump the network so the client can receive it
    splashkit.check_network_activity()

    # client reads and prints the message
    if splashkit.has_messages_on_connection(client):
        msg = splashkit.read_message_from_connection(client)
        print("Client got:", splashkit.message_data(msg))
    else:
        print("No message arrived.")

    # clean up
    splashkit.close_connection(client)
    splashkit.close_connection(server_conn)
    splashkit.close_all_servers()

if __name__ == "__main__":
    main()
