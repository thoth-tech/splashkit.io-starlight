from splashkit import write_line, is_prime_number

numbers = [17, 18]

for num in numbers:
    if is_prime_number(num):  # SplashKit function
        write_line(f"{num} is prime")
    else:
        write_line(f"{num} is not prime")
