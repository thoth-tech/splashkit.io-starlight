// I am reading an integer and printing whether it is prime using is_prime_number.
#include "splashkit.h"
#include <iostream>
using namespace std;

int main()
{
    cout << "Enter an integer: ";
    long long n; cin >> n;

    bool prime = is_prime_number((int)n);
    cout << n << (prime ? " is prime\n" : " is not prime\n");
    return 0;
}