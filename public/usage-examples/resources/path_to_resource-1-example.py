from splashkit import *

resource_path = path_to_resource(
    "example.png",
    ResourceKind.image_resource
)

write_line("Image resource path: " + resource_path)