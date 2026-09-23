#include "splashkit.h"

int main()
{
    write_line("Hello! This example shows the IPv4 address of this computer.");

    // Ask SplashKit for the local IPv4 address
    string local_address = my_ip();

    // Display the address in dotted decimal format
    write_line("This computer's IPv4 address is: " + local_address);

    // The address is also useful as the host a client connects to
    write_line("A client on this machine can connect to a server using " + local_address + ".");

    return 0;
}
