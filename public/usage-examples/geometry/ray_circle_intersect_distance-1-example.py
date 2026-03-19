from splashkit import *  # importing SplashKit so we can use its functions

# here I am creating a ray starting from (100,100)
ray_origin = point_at(100, 100)

# this is the direction of the ray, going to the right side
ray_heading = vector_from(1, 0)

# here I am creating a circle at (250,100) with radius 50
target_circle = circle_at(250, 100, 50)

# this function checks how far the ray travels before touching the circle
hit_distance = ray_circle_intersect_distance(ray_origin, ray_heading, target_circle)

# printing the result so we can see what distance we get
write("Ray hit distance: ")
write_line(hit_distance)