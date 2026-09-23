using static SplashKitSDK.SplashKit;

WriteLine("Hello! This example shows the IPv4 address of this computer.");

// Ask SplashKit for the local IPv4 address
string localAddress = MyIP();

// Display the address in dotted decimal format
WriteLine("This computer's IPv4 address is: " + localAddress);

// The address is also useful as the host a client connects to
WriteLine("A client on this machine can connect to a server using " + localAddress + ".");
