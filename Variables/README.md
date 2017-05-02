# <p align="center"> Data Type And Variables - Exercises <p>

##  **Circle Area (12 Digits Precision)**

#### Problem Description

Write program to enter a radius r (real number) and **print the area** of the circle with exactly **12 digits** after the decimal point. Use data type of **enough precision** to hold the results.

#### Examples

|**Input**|**Output**|
|---|---|
|2.5	| 19.634954084936|
|1.2	|4.523893421169|

> #### Hints
> - You might use the data type double. It has precision of 15-16 digits.

##  Exact Sum of Real Numbers

#### Problem Description

Write program to enter n numbers and calculate and print their **exact sum** (without rounding).

#### Examples

|**Input**|**Output**|
|---|---|
|3 <br/> 1000000000000000000 </br> 5 </br> 10|1000000000000000015|
|2 <br/> 0.00000000003 <br/> 333333333333.3	|333333333333.30000000003|


> #### Hints
> - If you use types like **float** or **double**, the result will lose some of its precision. Also it might be printed in scientific notation.
> - You might use the **decimal** data type which holds real numbers with high precision with less loss.
> - Note that **decimal** numbers sometimes hold the unneeded zeroes after the decimal point, so **0m** is different than **0.0m** and **0.00000m**.

## Fast Prime Checker - Refactor

#### Problem Description

You are given a program that checks if numbers in a given range [2...N] are prime. For each number is printed "{number} is prime -> {True or False}". The code however, is not very well written. Your job is to modify it in a way that is **easy to read and understand.**

#### Code

```csharp
int ___Do___ = int.Parse(Console.ReadLine());
for (int DAVIDIM = 0; DAVIDIM <= ___Do___; DAVIDIM++)
{    bool TowaLIE = true;
         for (int delio = 2; delio <= Math.Sqrt(DAVIDIM); delio++)
    {
        if  (DAVIDIM % delio == 0)
        {
            TowaLIE = false;
            break;
        }
    }
    Console.WriteLine($"{DAVIDIM} is prime -> {TowaLIE}");
}

``` 

#### Examples

|**Input**|**Output**|
|---|---|
|5|2 -> True <br/> 3 -> True <br/> 4 -> False <br/> 5 -> True|

> #### Hints
> - Search how to check if a number is prime
> - Rename all variables such as to be clear what is their role in the algorithm

## Integer to Hex and Binary

#### Problem Description

Create a program to convert a **decimal number** to **hexadecimal** and **binary** number and print it.

#### Examples

|**Input**|**Output**|
|---|---|
|10	|A <br/> 1010|
|420	| 1A4 <br/> 110100100|
|256	|100 <br/> 100000000|

> #### Hints
> - Use Convert.ToString(number, base) and string.ToUpper().


## Random Tests / Different Integers Size

#### Problem Description

Given an input integer, you must **determine which primitive data types** are capable of properly storing that input.

#### Input
- You receive **N** – integer which can be arbitrarily large or small

#### Output
You must determine if the given primitives are capable of storing it. If yes, then print:
```
- {N} can fit in:
- * dataType
```
If there is more than one appropriate data type, print each one on its own line and order them by size
**(sbyte < byte < short < ushort < int < uint < long).**
If the number cannot be stored in one of the four aforementioned primitives, print the line: 

```
- {N} can't fit in any type
```

#### Examples

|**Input**|**Output**|
|---|---|
|-150	|-150 can fit in: <br/> * short <br/> * int <br/> * long|
|150000|	150000 can fit in: <br/> * int <br/> * uint <br/> * long|
|1500000000	|1500000000 can fit in: <br/> * int <br/> * uint <br/> * long|
|213333333333333333333333333333333333	|213333333333333333333333333333333333 can't fit in any type|


## Test
// Playing around with "+" , Concat and StringBuilder


##  Thea the Photographer
**This problem is from the Programming Fundamentals Retake Exam (11 September 2016).**
Thea is a photographer. She takes pictures of people on special events. She is a good friend and you want to help her.
She wants to inform her clients when their pictures will be ready. Since the number of pictures is big and it requires time for editing (#nofilter, #allnatural) every single picture - you decide to write a program in order to help her.
Thea follows this pattern: first she takes all pictures. Then she goes through every single picture to filter these pictures that are considered "good". Then she needs to upload every single filtered picture to her cloud. She is considered ready when all filtered pictures are uploaded in her picture storage.
You will receive the amount of pictures she had taken. Then the approximate time in seconds for every picture to be filtered. Then a filter factor – a percentage (integer number) of the total photos (rounded to the nearest bigger integer value e.g. 5.01 -> 6) that are good enough to be given to her clients (Photoshop may do miracles but Thea does not). Approximate time for every picture to be uploaded will be given again in seconds. Your task is: based on this input to display total time needed for her to be ready with the pictures in given below format.

#### Input
- On the first line you will receive an integer **N** – the amount of pictures Thea had taken.
- On the second line you will receive an integer **FT** – the amount of time (filter time) in seconds that Thea will require to filter every single picture.
- On the third line you will receive an integer **FF** – the filter factor or the percentage of the total pictures that are considered “good” to be uploaded.
- On the fourth line you will receive an integer **UT** – the amount of time needed for every filtered picture to be uploaded to her storage.
- The input will be in the described format, there is no need to check it explicitly.

#### Output

Print the amount of time Thea will need in order to have her pictures ready to be sent to her client in given format:
- **d:HH:mm:ss** 
- **d** - days needed – starting from 0.
- **HH** –  hours needed – from 00 to 24.
- **mm** – minutes needed – from 00 to 59.
- **ss** – minutes needed – from 00 to 59.
#### Constrains
- The amount of total pictures Thea will have taken is range [0 … 1 000 000]
- The seconds for both filtering and uploading will be in range [0 … 100 000]
- The filter factor will be an integer number between [0 … 100].

#### Examples

|**Input**|**Output**|**Comments**|
|---|---|---|
|1000 <br/> 1 <br/> 50 <br/> 1|0:00:25:00|Total pictures = 1 000, 50% of them are useful -> Filtered pictures = 500 <br/> Total pictures * filter time = 1000 s <br/> Filtered pictures * upload time = 500 s <br/> Total time = 1500 s|
|5342 <br/> 2 <br/> 82 <br/> 3|0:06:37:07|Total pictures = 5342 - 82% of them are useful -> 4380.44-> 4381 filtered.|
