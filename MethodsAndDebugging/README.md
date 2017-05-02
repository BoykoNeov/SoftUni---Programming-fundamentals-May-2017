# <p align="center"> Methods and Debugging - Exercises <p>

## Scratch Pad
// Testing passing arrays to methods and returning arrays from methods

## Shifting Arrays
// Shifting arrays in different ways

## Recursive Fibonacci
Calculate a Fibonacci sequence to n-th number (or n-th + 1, depending on definition) using recursion or not (choice is given)

##  Primes in Given Range
Write a method that calculates **all prime numbers in given range** and returns them as list of integers.Write a **method** to **print a list of integers**. Write a program that **enters two integer numbers** (each at a separate line) and prints all primes in their range, separated by a comma.

```csharp
static List<int> FindPrimesInRange(startNum, endNum)
{
    …
}
```
#### Examples

| **Start and End Number**| **Output**|
|---|---|
|0 <br/> 10|2, 3, 5, 7|
|5 <br/> 11|5, 7, 11|
|100 <br/> 200|101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199|
|250 <br/> 950|251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397, 401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499, 503, 509, 521, 523, 541, 547, 557, 563, 569, 571, 577, 587, 593, 599, 601, 607, 613, 617, 619, 631, 641, 643, 647, 653, 659, 661, 673, 677, 683, 691, 701, 709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787, 797, 809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887, 907, 911, 919, 929, 937, 941, 947|
|100 <br/> 50|(empty list)|

## Experimenting With The Judge
Trying to elicit different error messages, memory usage values and program run times from the Judge

## Experiments
// Playing around with methods and arrays

## Get Max
Get the biggest of three numbers using recursion

##  Hello, Name!
Write a **method** that receives a name as **parameter** and prints on the console. **“Hello, <name>!”**

#### Examples

| **Input**| **Output**|
|---|---|
|Peter|Hello, Peter!|

## Euclidian Algorithm
 The program accepts two integers on two lines and calculates the greates common divisor using Euclidean Algorithm and Recursion
 The process of data entry is repeated until a valid integer is entered.

## English Name оf The Last Digit
Write a **method** that returns the **English name** of the last digit of a given number. Write a program that reads an integer and prints the returned value from this method.

#### Examples

| **Input**| **Output**|
|---|---|
|1024	|four|
|512	|two|

##  Master Numbers
A master number is an integer that holds the following properties:
- Is **symmetric** (palindrome), e.g. 5, 77, 282, 14341, 9553559.
- Its **sum of digits is divisible by 7**, e.g. 77, 313, 464, 5225, 37173.
- Holds **at least one even digit**, e.g. 232, 707, 6886, 87578.
Write a program to **print all master numbers** in the range **[1…n]**.

#### Examples

| **Input**| **Output**|
|---|---|
|600	|232 <br/> 383 <br/> 464 <br/> 545|
|5000	|232 <br/> 383 <br/> 464 <br/> 545 <br/> 626 <br/> 696 <br/> 707 <br/> 858 <br/> 1661 <br/> 2552 <br/> 3443 <br/> 4334|

> #### Hints
> 1.	Write 3 utility methods:
> - IsPalindrome(int num)
> - SumOfDigits(int num)
> - ContainsEvenDigit(int num)
> 2.	Loop through all numbers in range [1…n] and check every number with the helper methods.



## Factorial Trailing Zeroes
Create a program that counts the trailing zeroes of the factorial of a given number.

#### Examples

| **Input**| **Output**|**Comments**|
|---|---|---|
|5	|1|	5! = 120 -> One trailing zero |
|100	|24|	100! = 93326215443944152681699238856266700490715968264381621468592963895217599993229915608941463976156518286253697920827223758251185210916864000000000000000000000000 -> 24 trailing zeroes|

> #### Hints
> 1.	You may use your solution from the previous problem. Add additional method that counts and returns the number of zeroes a number has.

##  Debugging Exercise: Substring
The goal of this exercise is to practice debugging techniques in scenarios where a piece of code does not work correctly. Your task is to pinpoint the bug and fix it (without rewriting the entire code). Test your fixed solution in the judge system: 
You can download the broken solution from here.
Problem Description
You are given a text and a number count. Your program should search through the text for the letter 'p' (ASCII code 112) and print 'p' along with count letters to its right.
For example, we are given the text "phahah put" and count = 3. We find a match of 'p' in the first letter so we print it and the 3 letters to its right. The result is "phah". We continue and find another match of 'p', but there aren't 3 letters to its right, so we print only "put". 
Each match should be printed on a separate line. If there are no matches of 'p' in the text, we print "no".
#### Input

- The first line holds the text to be processed (string).
- The second line holds the number count.

#### Output

For each match, print the matched substring at separate line. Print "no" if there are no matches.
Constraints
- The number count will be in the range [0 ... 100].

#### Tests

|**Input**|**Program Output**|**Expected Output**|
|---|---|---|
|phahah put <br/> 3| no |phah <br/> put|
|No match <br/> 5| no |phah <br/> no|
|preparation <br/> 5| no |phah <br/> prepa|
|preparation <br/> 0| no |phah <br/> p <br/> p|

## 	** Debugging Exercise: Instruction Set
Write an **instruction interpreter** that executes an arbitrary number of **instructions.** The program should **parse the
 instructions, execute** them and **print the result.** The following instruction set should be supported:

- **INC &lt;operand1&gt;** – increments the operand by 1

- **DEC &lt;operand1&gt;** – decrements the operand by 1

+ **ADD &lt;operand1&gt; &lt;operand2&gt;** – performs addition on the two operands

- **MLA &lt;operand1&gt; &lt;operand2&gt;**– performs multiplication on the two operands

- **END** – end of input

#### Output

The result of each instruction should be printed on a separate line on the console.

#### Constraints
- The operands will be valid integers in the range [−2 147 483 648 … 2 147 483 647].

#### Tests

|**Input**|**Program Output**|**Expected Output**|
|---|---|---|
|INC 0 <br/>  END|0 <br/> 0 <br/> … (infinite)|1|
|ADD 1323134 421315521 <br/> END|422638655 <br/> 422638655 <br/> … (infinite)|422638655|
|DEC 57314183 <br/> END|57314183 <br/> 57314183 <br/> … (infinite)|57314182|
|MLA 252621 324532 <br/>  END|379219748 <br/> 379219748 <br/> … (infinite)|81983598372|

## 	** Debugging Exercise: Be Positive

#### Problem Description

A program is designed to take some **sequences of numbers** from the console, to **process them** as described below

and **print** each obtained sequence.

#### Input

- On the first line of input you are given a count **N – the number of sequences.**

- On each of **the next N lines** you will receive some **numbers surrounded by whitespaces**.

#### Processing Logic

You need to check each number, if it’s **positive** – print it on the console; if it’s **negative**, add to its value the value of

the next number and only print the result if it’s not negative. You only perform the addition once, e.g. if you have

the sequence: -3, 1, 3, the algorithm is as follows:

- -3 is negative =&gt; add to it the next number (1) =&gt; -3 + 1 = -2 still negative =&gt; do not print anything (and don’t

keep adding numbers, you stop here).

- The next number we consider is 3 which is positive =&gt; print it.

If no numbers can be obtained in this manner for the given sequence, print **“(empty)”.**

#### Tests

|**Input**|**Expected Output**|**Comments**|
|---|---|---|
|3 <br> 3 -4 5 2 123 <br> -1 -1 3 4 <br> -2 1|3 1 2 123 <br/> 3 4 <br/> (empty)|(3) (-4 + 5 = 1 &gt; 0) (2) (123) <br/> (-1 + (-1) &lt; 0) (3) (4) <br/> (-2 + 1 &lt; 0)|

## 	** Debugging Exercise: Sequence of Commands

#### Problem Description

You are given a program that reads a **n numbers** and a **sequence of commands** to be executed over these numbers.

#### Input

- The first line holds an integer n – the count of numbers.

- The second line holds n numbers – integers separated by space.

- Each of the next few lines hold commands in format: “[action] [i-th element] [value]”.

- The commands sequence end with a command “stop”.

#### Commands

Commands are given in format **“[action] [i-th element] [value]”.** Elements are indexed from 1 to n.

The **action** can be **“multiply”, “add”, “subtract”, “rshift” or “lshift”.**

- The actions **“multiply”, “add”** and **“subtract”** have parameters. The first parameter is the **index** of the

element that needs to be changed (in range **[1...n]**). The second parameter is the value with which we

manipulate the element.

- The command **“lshift”** moves the first element last. E.g. **“lshift”** over {1, 2, 3} will produce {2, 3, 1}.

- The command **“rshift”** moves the last element first. E.g. **“rshift”** over {1, 2, 3} will produce {3, 1, 2}.

#### Output

Print the values of the **n elements** after the execution of each command (except the last **“stop”** command).
#### Constraints

- The **number n** will be an integer in the range [1 … 15].

- Each **element of the array** will be an integer in the range [0 … 2 63 -1].

- The **number i** and the **number of commands** will be integers in the range [1 … 10].

- The **number value** will be an integer in the range [-100 … 100]. If the command is **“rshift”** or **“lshift”** there

are no parameters.

#### Tests

|**Input**|**Program Output**|**Expected Output**|
|---|---|---|
|5 <br/> 3 0 9 333 11 <br/> add 2 2 <br/> subtract 1 1 <br/> multiply 3 3 <br/> rshift <br/> stop|3 0 9 333 11 <br/> 3 0 9 333 11|3 2 9 333 11 <br/> 2 2 9 333 11 <br/> 2 2 27 333 11 <br/> 11 2 2 27 333|