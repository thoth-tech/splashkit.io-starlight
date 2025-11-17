from splashkit import *

# Create a ray from origin pointing right
ray_origin = point_at(0, 0)
ray_direction = vector_to(1, 0)

# Create a circle to test intersection
center_point = point_at(50, 0)
target = circle_at(center_point, 25)

# Calculate distance to circle intersection
distance = ray_circle_intersect_distance(ray_origin, ray_direction, target)

print(f"Distance to circle: {distance}")
