from splashkit import *

# Variable declarations
point_1 = point_at(50, 75)
guess = False
write_line("Guess the coordinate inside (100,100)")

while not guess:

    # Get user input
    write("Enter your coordinates as x,y: ")
    guess_input = read_line()
    coords = split(guess_input, ',')
    guess_x = convert_to_double(coords[0])
    guess_y = convert_to_double(coords[1])

    # Convert input 
    point_2 = point_at(guess_x, guess_y)
    
    # Clues
    if point_1.x > guess_x:
        write_line("x is too low")
    elif point_1.x < guess_x:
        write_line("x is too high")
    else:
        write_line("x is correct !!!")
    
    if point_1.y > guess_y: 
        write_line("y is too low")
    elif point_1.y < guess_y: 
        write_line("y is too high")
    else: 
        write_line("y is correct !!!")

    # Point comparison 
    guess = same_point(point_1, point_2)
    if not guess:
        write_line("Try Again!")
    else:
        write_line("You Win!")