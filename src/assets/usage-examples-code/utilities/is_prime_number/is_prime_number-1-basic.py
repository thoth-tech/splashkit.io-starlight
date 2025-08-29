# I am reading an integer and printing whether it is prime using is_prime_number.
from splashkit import is_prime_number

n = int(input("Enter an integer: "))
print(f"{n} {'is prime' if is_prime_number(n) else 'is not prime'}")