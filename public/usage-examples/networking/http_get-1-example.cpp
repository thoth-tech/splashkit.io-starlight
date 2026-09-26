#include "splashkit.h"
#include <iostream>

int main()
{
    string url = "http://example.com";
    unsigned short port = 80;

    std::cout << "HTTP GET Request" << std::endl;
    std::cout << std::endl;
    std::cout << "Requesting: " << url << std::endl;
    std::cout << std::endl;

    // Make a GET request to the web resource
    http_response response = http_get(url, port);

    // Convert the response into text
    string response_text = http_response_to_string(response);

    std::cout << "Response received:" << std::endl;
    std::cout << response_text.substr(0, 200) << std::endl;

    // Release the HTTP response
    free_response(response);

    return 0;
}