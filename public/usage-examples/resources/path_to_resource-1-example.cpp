#include "splashkit.h"

int main()
{
    string resource_path = path_to_resource(
        "example.png",
        IMAGE_RESOURCE
    );

    write_line("Image resource path: " + resource_path);

    return 0;
}