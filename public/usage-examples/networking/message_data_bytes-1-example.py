from splashkit import *


port = 5000

server = create_server_with_port(
    "byte_server",
    port
)

# Create a local connection and send a message
client = open_connection(
    "byte_client",
    "127.0.0.1",
    port
)

delay(100)
check_network_activity()
accept_all_new_connections()

send_message_to_connection("Hi", client)

delay(100)
check_network_activity()

received_message = read_message_from_server(server)

# Read the received message as bytes
data_bytes = message_data_bytes(received_message)

print("Message Data Bytes")
print()
print("Message: Hi")
print("Bytes: ", end="")

for value in data_bytes:
    print(str(value) + " ", end="")

print()

close_all_connections()
close_all_servers()