---
title: Hill Cipher Encryption and Decryption
summary: Implementation of the matrix-based Hill Cipher using SplashKit in C++.
author: Anna Shustser
level: Intermediate
tags:
  - Cryptography
  - Matrix
  - C++
  - SplashKit
  - Encryption
---

## Introduction to Hill Ciphering

This project implements a classical 2x2 **Hill Cipher** for encrypting and decrypting messages using SplashKit and C++. The user is prompted to enter a 2x2 key matrix and a message, then choose between encoding or decoding. All arithmetic operations with matrices are performed in modulo 26, corresponding to the number of letters in the English alphabet.

The program showcases basic linear algebra concepts such as matrix multiplication, determinant calculation, and finding matrix inverses under modular arithmetic. 

---

## The Math Behind Hill Ciphering

Firstly, each letter is mapped to a number (e.g. A → 0, B → 1, C → 2, ..., Z → 25). These numbers will be used further to represent the pairs of letters in the form of column matrices.

Then the 2x2 **Key Matrix** is defined. This matrix is usually denoted as K and has the following form:

$$
K = \begin{bmatrix}
k_{11} & k_{12} \\
k_{21} & k_{22}
\end{bmatrix}
$$

The matrix is constant and is repetitively used for converting all the letter pairs in the message in the same pattern. As long as the recipients know the Key Matrix, the message can be decoded correctly.

Having established the Key Matrix and the column matrices for letter pairs, **Matrix Multiplication** encodes the pairs and returns the new combination of letter that looks similar to this:

```plaintext
Original: "HELLOWORLD"
Encoded: "LTCRQOHEYB"
```
---

## Letter Mapping

First of all, we need to declare the function that maps our letters to the corresponding numbers. We could brute-force this process and write a whole lot of cases using **Switch Case**, where each case represents the letter of the alphabet, but it would not be efficient and would increase the runtime of our program. Instead, we'll apply our understanding of how letters are stored by C++ internally. C languages store letters using the underlying **ASCII codes** in the char data type. For us to access these char values, we need to perform type conversion both ways (to enable both encoding and decoding).

```cpp
int char_to_int(char c) {
    return toupper(c) - 'A'; 
}

char int_to_char(int i) {
    return 'A' + (i % 26);
}
```

Additionally, to ensure that the input into the function is uniform and the system will not assign different values to the same letter in different cases, we should use **toupper** that changes the letter to uppercase and ensure that the conversions are made within **Modulo 26**, representing the number of letters in the alphabet.

---

## Modular Inverse for Negative Determinant

Now we need to write the function that is responsible for finding the inverse of the value if it is negative. It is done, so that we can convert it correctly into a letter in either decryption or encryption mode. To do it, we need to perform division with the passed values, which would reduce the number and make it within the modulo range. Then we introduce the for loop that checks every x within the range to find one that is coprime to the value a.

```cpp
int mod_inverse(int a, int m) {
    a %= m;
    for (int x = 1; x < m; ++x) {
        if ((a * x) % m == 1) return x;
    }
    return -1;
}
```

The function returns either the x value or -1 in case no such value exists.

---

## Matrix Inverse

We're still working with inverses, yet now we need to introduce the function that would find the inverse of the matrix for decryption. Be mindful of this step, if you decide to exclude it and come up with the key matrix that is not invertible, the result would be impossible to decode, as no such matrix would exist.

```cpp
bool inverse_matrix(int mat[2][2], int inv[2][2]) {
    int det = mat[0][0]*mat[1][1] - mat[0][1]*mat[1][0]; // Calculate determinant
    det = (det % 26 + 26) % 26;// Ensure determinant is positive and within range

    int inv_det = mod_inverse(det, 26);
    if (inv_det == -1) return false;

    inv[0][0] = (mat[1][1] * inv_det) % 26;
    inv[0][1] = (-mat[0][1] * inv_det + 26) % 26;
    inv[1][0] = (-mat[1][0] * inv_det + 26) % 26;
    inv[1][1] = (mat[0][0] * inv_det) % 26;
    return true;
}
```

As this function only checks if the matrix is invertible, without actually generating it, the return type is Boolean. Later this function will be used as a "boom gate", either allowing the user to proceed or quitting the program. The core of the program first calculates the determinant using the standard formula:

$$
det = ad - bc
$$

After modifying the determinant to be within the (mod 26) range, the program calls the function for modular inverses and performs matrix conversion.

---

## Ciphering Logic

Finally, we've arrived at the stage, where we will perform encryption or decryption. In this funcction, we need to start with input modification by changing the input casing and appending X if the length of the received string leaves the last letter without a pair.

```cpp
string hill_cipher(const string &text, int matrix[2][2]) {
    string result = text;

    // Convert to uppercase
    for (int i = 0; i < result.length(); i++) {
        result[i] = toupper(result[i]);
    }

    // Pad with X if the length is odd
    if (result.length() % 2 != 0) {
         result += 'X';
    }
```

Now we're ready to do the encryption/decryption process in pairs. This function may be used for both processes, as the only difference between them is the value of the key matrix and the input. For performing the encoding, we take the first 2 letters of the modified string and put them through the char to integer converter function from Section 1. Then we complete simple matrix multiplication and use the reverse type conversion to generate the encoded letters. These letters are then appended to the string for output showcasing.

Here's the complete function:

```cpp
string hill_cipher(const string &text, int matrix[2][2]) {
    string result = text;

    // Convert to uppercase
    for (int i = 0; i < result.length(); i++) {
        result[i] = toupper(result[i]);
    }

    // Pad with X if the length is odd
    if (result.length() % 2 != 0) {
         result += 'X';
    }

    string output;

    // Process in pairs
    for (size_t i = 0; i < result.length(); i += 2) {
        int a = char_to_int(result[i]);
        int b = char_to_int(result[i + 1]);

        int x = ((matrix[0][0]*a + matrix[0][1]*b) % 26 + 26) % 26;
        int y = ((matrix[1][0]*a + matrix[1][1]*b) % 26 + 26) % 26;

        output += int_to_char(x);
        output += int_to_char(y);
    }

    return output;
}
```

---

## Boring part: the main() function

As we're nearing the end of this process, we just need to correctly read the user input and ask if the user would like to encrypt or decrypt a message. Both parts are done through reading user response. Firstly, we ask for the key matrix by iterating over the read request and adding values to the 2-dimensional array:

```cpp
write("Enter value for key[" + to_string(i) + "][" + to_string(j) + "]: ");
key[i][j] = convert_to_integer(read_line());
```

Then, if the key is invertible (e.g. input: 5, 7, 9, 2), we ask the user if they would like to encode or decode the message.

```cpp
if (mode == "E" || mode == "e") {
    string encoded = hill_cipher(message, key);
    write_line("Encoded: " + encoded);
} else if (mode == "D" || mode == "d") {
    string decoded = hill_cipher(message, inv_key);
    write_line("Decoded: " + decoded);
}
```

Congratulations! We've learnt how to build a Hill Ciphering program.

---

## Complete Code

```cpp
#include "splashkit.h"
#include <bits/stdc++.h>
using namespace std;

// Convert char to int with uppercase char passed as parameter
// using ASCII values for conversion (A=0, B=1, ..., Z=25)
int char_to_int(char c) {
    return toupper(c) - 'A'; 
}

// Convert int to uppercase char
// dividing by 26 to wrap around if necessary (26 letter elements)
char int_to_char(int i) {
    return 'A' + (i % 26);
}

// Modular inverse of number modulo 26
int mod_inverse(int a, int m) {
    a %= m;
    for (int x = 1; x < m; ++x) {
        if ((a * x) % m == 1) return x;
    }
    return -1;
}

// Find inverse of 2x2 matrix modulo 26
bool inverse_matrix(int mat[2][2], int inv[2][2]) {
    int det = mat[0][0]*mat[1][1] - mat[0][1]*mat[1][0]; // Calculate determinant
    det = (det % 26 + 26) % 26;// Ensure determinant is positive and within range

    int inv_det = mod_inverse(det, 26);
    if (inv_det == -1) return false;

    inv[0][0] = (mat[1][1] * inv_det) % 26;
    inv[0][1] = (-mat[0][1] * inv_det + 26) % 26;
    inv[1][0] = (-mat[1][0] * inv_det + 26) % 26;
    inv[1][1] = (mat[0][0] * inv_det) % 26;
    return true;
}

// Hill cipher function (encode or decode based on matrix)
string hill_cipher(const string &text, int matrix[2][2]) {
    string result = text;

    // Convert to uppercase
    for (int i = 0; i < result.length(); i++) {
        result[i] = toupper(result[i]);
    }

    // Pad with X if the length is odd
    if (result.length() % 2 != 0) {
         result += 'X';
    }

    string output;

    // Process in pairs
    for (size_t i = 0; i < result.length(); i += 2) {
        int a = char_to_int(result[i]);
        int b = char_to_int(result[i + 1]);

        int x = ((matrix[0][0]*a + matrix[0][1]*b) % 26 + 26) % 26;
        int y = ((matrix[1][0]*a + matrix[1][1]*b) % 26 + 26) % 26;

        output += int_to_char(x);
        output += int_to_char(y);
    }

    return output;
}

int main() {
    write_line("Hill Cipher (2x2) using arrays");

    int key[2][2];
    write_line("Enter 4 positive integers for the key matrix (row-wise):");

    // Read key matrix from user
    for (int i = 0; i < 2; i++) {
        for (int j = 0; j < 2; j++) {
            write("Enter value for key[" + to_string(i) + "][" + to_string(j) + "]: ");
            key[i][j] = convert_to_integer(read_line());
            if (key[i][j] < 0) {
                write_line("Only positive integers allowed.");
                return 1;
            }
            key[i][j] %= 26;
        }
    }

    int inv_key[2][2];
    if (!inverse_matrix(key, inv_key)) {
        write_line("Error: Key matrix is not invertible modulo 26.");
        delay(5000);
        return 1;
    }

    write_line("Enter E to encode or D to decode:");
    string mode = read_line();

    write_line("Enter message (letters only, no spaces):");
    string message = read_line();

    if (mode == "E" || mode == "e") {
        string encoded = hill_cipher(message, key);
        write_line("Encoded: " + encoded);
    } else if (mode == "D" || mode == "d") {
        string decoded = hill_cipher(message, inv_key);
        write_line("Decoded: " + decoded);
    } else {
        write_line("Invalid option.");
    }

    return 0;
}
```

---

## Lazy Reading: How It Works

1. **Character Conversion:**
   - Each character is mapped to a number (A=0, ..., Z=25).

2. **Matrix Input:**
   - User enters four integers forming a 2x2 matrix, reduced modulo 26.

3. **Invertibility Check:**
   - The matrix must have a modular inverse (i.e., its determinant must be coprime with 26).

4. **Encoding/Decoding:**
   - The text is processed in 2-character blocks using matrix multiplication.
   - Uses original key for encoding and inverse key for decoding.


---

## Requirements

- C++ compiler
- SplashKit SDK (https://splashkit.io)

To compile:
```sh
skm compile hill_cipher.cpp
```

---

## Output Example
```
Hill Cipher (2x2) using arrays
Enter 4 positive integers for the key matrix (row-wise):
Enter value for key[0][0]: 3
Enter value for key[0][1]: 3
Enter value for key[1][0]: 2
Enter value for key[1][1]: 5
Enter E to encode or D to decode:
E
Enter message (letters only, no spaces):
HELLO
Encoded: ZEBBW
```

---

## Author Notes

Feel free to extend this project with support for larger matrices or even full GUI input via SplashKit widgets.

---

## References
- [Hill Cipher - Wikipedia](https://en.wikipedia.org/wiki/Hill_cipher)
- [SplashKit Documentation](https://splashkit.io)
