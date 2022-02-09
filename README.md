# Python Documentation

# Prime Number Finder

This Python script is designed to find and print all prime numbers starting from 1. It uses a simple yet efficient algorithm to check if a number is prime, and then prints it if it is.

## Script Explanation

The script is divided into two main functions: `is_prime(n)` and `prime_number_finder()`.

### `is_prime(n)`

This function checks if a given number `n` is prime. It first checks if `n` is less than or equal to 1, in which case it returns `False` as these are not prime numbers. If `n` is less than or equal to 3, it returns `True` as 2 and 3 are prime numbers. 

Next, it checks if `n` is divisible by 2 or 3, in which case it returns `False` as these are not prime numbers. 

Finally, it checks for divisibility by all numbers from 5 to square root of `n`. If `n` is divisible by any of these, it returns `False`. If `n` passes all these checks, it is a prime number and the function returns `True`.

### `prime_number_finder()`

This function starts with `num` equal to 1 and checks if it is prime using the `is_prime(n)` function. If it is, it prints the number. It then increments `num` by 1 and repeats the process indefinitely.

## Running the Script

To run the script, simply execute the Python file from your command line:

```bash
python prime_number_finder.py
```

This will start printing prime numbers, starting from 2.

## Libraries Used

This script does not use any external libraries. It only uses built-in Python functionality.

## Conclusion

This script is a simple and efficient way to find prime numbers. It can be used as a standalone program, or integrated into other scripts to provide prime number functionality.

---

# C# Documentation

# CSharp Prime Number Checker

This C# script is a simple console application that checks if a given number is a prime number or not.

## Script Description

The script prompts the user to enter a number. It then checks if the entered number is a prime number or not. If the number is prime, it outputs "{number} is a prime number." If the number is not prime, it outputs "{number} is not a prime number."

## Code Breakdown

The script is divided into two main parts:

1. The `Main` method: This is the entry point of the application. It prompts the user to enter a number, converts the input to an integer, and then calls the `IsPrime` method with the entered number. It then outputs the result.

2. The `IsPrime` method: This method takes an integer as an argument and checks if it's a prime number or not. It uses a simple algorithm to check for primality: if the number is less than or equal to 1, it's not prime. If the number is 2, it's prime. If the number is divisible by 2, it's not prime. For numbers greater than 2, it checks if the number is divisible by any odd number up to the square root of the number. If it finds a divisor, it returns false (not prime). If it doesn't find a divisor, it returns true (prime).

## Imported Libraries

The script uses the following libraries:

1. `System`: This is a built-in .NET library that provides fundamental classes and base classes that define commonly-used value and reference data types, events and event handlers, interfaces, attributes, and processing exceptions. In this script, it is used for console input/output and for the `Math` class.

2. `System.Math`: This is a built-in .NET class that provides methods and constants for trigonometric, logarithmic, and other common mathematical functions. In this script, it is used to calculate the square root of a number.

---

# Java Documentation

# Prime Number Finder

This Java program is designed to determine whether a given number is a prime number or not. A prime number is a natural number greater than 1 that has no positive divisors other than 1 and itself. The program asks the user to input a number and then checks if the number is prime or not.

## Code Explanation

The script begins by importing the `java.util.Scanner` library. This library is a simple text scanner which can parse primitive types and strings using regular expressions. It is used in this script to get the user's input.

The main function of the script starts by creating a new instance of the Scanner class, which is used to read the user's input. The user is then prompted to enter a number.

The script then initializes a boolean variable `flag` to false. This variable is used to indicate whether the number entered by the user is a prime number or not.

The script then enters a for loop that runs from 2 to half of the number entered by the user. For each iteration, the script checks if the number entered by the user is divisible by the current iteration number. If it is, the script sets `flag` to true and breaks out of the loop. This is because a prime number should only be divisible by 1 and itself, so if the number is divisible by any other number, it is not a prime number.

Finally, the script checks the value of `flag`. If `flag` is still false, this means that the number was not divisible by any number other than 1 and itself, so it is a prime number. The script then prints a message to the console stating that the number is a prime number. If `flag` is true, this means that the number was divisible by a number other than 1 and itself, so it is not a prime number. The script then prints a message to the console stating that the number is not a prime number.

## Usage

To use this script, simply run it in a Java environment. When prompted, enter the number you want to check. The script will then tell you whether the number is a prime number or not.

---
