from splashkit import *

#  Variable Declerations
point_1 = point_at(50,75)
write_line("Guess the coordinate inside (100,100) ")

while (True):

    # Get user input
    write("Enter your coordinates as x,y: ")
    guess = read_line()
    coords = split(guess,',')
    guess_x = convert_to_double(coords[0])
    guess_y = convert_to_double(coords[1])


    # convert input 
    point_2 = point_at(guess_x,guess_y)
    
    #clues
    if point_1.x > guess_x:
        write_line("x is to low")
    elif (point_1.x < guess_x):
        write_line("x is to high")
    else:
        write_line("x is correct !!!")
    
    if (point_1.y > guess_y): 
        write_line("y is to low")
    elif (point_1.y < guess_y): 
        write_line("y is to high")
    else: 
        write_line("y is correct !!!")


    # Point Comparison 
    if not same_point(point_1,point_2):
    
        write_line("Try Again!")
    
    else:
    
        write_line("You Win!")
        break
    




