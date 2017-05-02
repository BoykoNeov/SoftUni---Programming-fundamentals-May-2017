# <p align="center"> Lists - Exercises <p>



## Array Manipulator
Write a program that r**eads an array of integers** from the console and **set of commands** and **executes them over the array**. The commands are as follows:
- **add <index> <element>** – adds element at the specified index (elements right from this position inclusively are shifted to the right).
- **addMany <index> <element 1> <element 2> … <element n>** – adds a set of elements at the specified index.
- **contains <element>** – prints the index of the first occurrence of the specified element (if exists) in the array or -1 if the element is not found.
- **remove <index>** – removes the element at the specified index.
- **shift <positions> – shifts every element** of the array the number of positions **to the left** (with rotation).
For example, [1, 2, 3, 4, 5] -> shift 2 -> [3, 4, 5, 1, 2]
- **sumPairs** – sums the elements in the array by pairs (first + second, third + fourth, …).
For example, [1, 2, 4, 5, 6, 7, 8] -> [3, 9, 13, 8].
- **print** – stop receiving more commands and print the last state of the array.

#### Examples

|**Input**|**Output**|
|---|---|
|1 2 4 5 6 7 <br/> add 1 8 <br/> contains 1 <br/> contains -3 <br/> print|0 <br/> -1 <br/> [1, 8, 2, 4, 5, 6, 7]|
|1 2 3 4 5 <br/> addMany 5 9 8 7 6 5 <br/> contains 15 <br/> remove 3 <br/> shift 1 <br/> print|-1 <br/> [2, 3, 5, 9, 8, 7, 6, 5, 1]|
|2 2 4 2 4 <br/> add 1 4 <br/> sumPairs <br/> print|[6, 6, 6]|
|1 2 1 2 1 2 1 2 1 2 1 2 <br/> sumPairs <br/> sumPairs <br/> addMany 0 -1 -2 -3 <br/> print|[-1, -2, -3, 6, 6, 6]|


## Bomb Numbers
Write a program that **reads sequence of numbers** and **special bomb number** with a certain **power**. Your task is to **detonate every occurrence of the special bomb number** and according to its power **his neighbors from left and right**. Detonations are performed from left to right and all detonated numbers disappear. Finally print the **sum of the remaining elements** in the sequence.

#### Examples

|**Input**|**Output**|**Comments**|
|---|---|---|
|1 2 2 4 2 2 2 9 <br/> 4 2	|12|	Special number is 4 with power 2. After detontaion we left with the sequence [1, 2, 9] with sum 12.|
|1 4 4 2 8 9 1 <br/> 9 3	|5|	Special number is 9 with power 3. After detontaion we left with the sequence [1, 4] with sum 5. Since the 9 has only 1 neighbour from the right we remove just it (one number instead of 3).
|1 7 7 1 2 3 <br/> 7 1	|6|	Detonations are performed from left to right. We could not detonate the second occurance of 7 because its already destroyed by the first occurance. The numbers [1, 2, 3] survive. Their sum is 6.|
|1 1 2 1 1 1 2 1 1 1 <br/> 2 1	|4|	The red and yellow numbers disappear in two sequential detonations. The result is the sequence [1, 1, 1, 1]. Sum = 4.|

integers from the console and set of commands and executes them over
// the array. The commands are as follows:
// add index element – adds element at the specified index (elements right from this position inclusively
// are shifted to the right).
// addMany index element1 element2 elementN – adds a set of elements at the specified index.
// contains element – prints the index of the first occurrence of the specified element (if exists) in the array
// or -1 if the element is not found.
// remove index – removes the element at the specified index.
// shift positions – shifts every element of the array the number of positions to the left (with rotation).
// sumPairs – sums the elements in the array by pairs (first + second, third + fourth, …).
// print – stop receiving more commands and print the last state of the array.

## Append Lists
Write a program to **append several lists** of numbers.
- Lists are separated by **‘|’**.
- Values are separated by **spaces** (‘ ’, **one or several**)
- Order the lists from the **last to the first**, and their values from **left to right**.

#### Examples

|**Input**|**Output**|
|---|---|
|1 2 3 \|4 5 6 \|  7  8	|7 8 4 5 6 1 2 3|
|7 \| 4  5\|1 0\| 2 5 \|3	|3 2 5 1 0 4 5 7|
|1\| 4 5 6 7  \|  8 9	|8 9 4 5 6 7 1|

> #### Hints
> - Create a new empty list for the results.
> - Split the input by ‘|’ into array of tokens.
> - Pass through each of the obtained tokens from tight to left.
> For each token, split it by space and append all non-empty tokens to the results.
> - Print the results.

## Sum Adjacent Equal Numbers
Write a program to **sum all adjacent equal numbers** in a list of decimal numbers, starting from **left to right**.
- After two numbers are summed, the obtained result could be equal to some of its neighbors and should be summed as well (see the examples below).
- Always sum the **leftmost** two equal neighbors (if several couples of equal neighbors are available).

#### Examples

|**Input**|**Output**|**Explanation**|
|---|---|---|
|3 3 6 1	|12 1|	3 3 6 1 -> 6 6 1 -> 12 1|
|8 2 2 4 8 16	|16 8 16|	8 2 2 4 8 16 -> 8 4 4 8 16 -> 8 8 8 16 -> 16 8 16|
|5 4 2 1 1 4	|5 8 4|	5 4 2 1 1 4 -> 5 4 2 2 4 -> 5 4 4 4 -> 5 8 4|

> #### Hints
> 1.	Read the **input** and parse it to **list of numbers**.
> 2.	Find the **leftmost** two **adjacent equal cells**.
> 3.	**Replace** them with their **sum**.
> 4.	**Repeat** (1) and (2) until no two equal adjacent cells survive.
> 5.	*Print** the processed list of numbers.

## Split by Word Casing
Read a **text**, split it into words and distribute them into **3 lists**.
- **Lower-case** words like “programming”, “at” and “databases” – consist of lowercase letters only.
- **Upper-case** words like “PHP”, “JS” and “SQL” – consist of uppercase letters only.
- **Mixed-case** words like “C#”, “SoftUni” and “Java” – all others.
Use the following **separators** between the words: **, ; : . ! ( ) " ' \ / [ ] space**

#### Examples

|**Input**|**Output**|
|---|---|
|Learn programming at SoftUni: Java, PHP, JS, HTML 5, CSS, Web, C#, SQL, databases, AJAX, etc.|	Lower-case: programming, at, databases, etc <br/> Mixed-case: Learn, SoftUni, Java, 5, Web, C# <br/> Upper-case: PHP, JS, HTML, CSS, SQL, AJAX|

> #### Hints
> - **Split** the input text using the above described **separators**.
> - **Process** the obtained **list of words** one by one.
> - Create 3 lists of words (initially empty): lowercase words, mixed-case words and uppercase words.
> - Check each word and append it to one of the above 3 lists:
> Count the **lowercase letters** and **uppercase letters**.
> If all letters are **lowercase**, append the word to the lowercase list.
> If all letters are **uppercase**, append the word to the uppercase list.
> Otherwise the word is considered mixed-case -> append it to the mixed-case list.
> - Print the obtained 3 lists as shown in the example above.

## 06.Square Numbers
Read a **list of integers** and **extract all square numbers** from it and print them in **descending order**. A **square number** is an integer which is the square of any integer. For example, 1, 4, 9, 16 are square numbers.

#### Examples

|**Input**|**Output**|
|---|---|
|3 16 4 5 6 8 9 	|16 9 4|
|12 1 9 4 16 8 25 |49 16	49 25 16 16 9 4 1|

> #### Hints
> - To find out whether an integer is **“square number”**, check whether its square root is integer number (has no fractional part):
> **if (√num == (int)√num) …**
> - To order the results list in descending order use sorting by lambda function:
> **squareNums.Sort((a, b) => b.CompareTo(a));**

## Count Numbers
Read a **list of integers** in range [0…1000] and **print them in ascending order** along with their **number of occurrences**.

#### Examples

|**Input**|**Output**|
|---|---|
|8 2 2 8 2 2 3 7|2 -> 4 <br/> 3 -> 1 <br/> 7 -> 1 <br/> 8 -> 2|
|10 8 8 10 10|8 -> 2 <br/> 10 -> 3|

> #### Hints
> Several algorithms can solve this problem:
> - Use an **array count[0…1000]** to count in **counts[x]** the occurrences of each element **x**.
> - *Sort** the numbers and count occurrences of each number.
> - Use a dictionary **counts<int, int>** to count in **counts[x]** the occurrences of each element **x**.

### Counting Occurrences Using Array
1.	Read the input elements in array of integers **nums[]**.
2.	Assume **max** holds the largest element in **nums[]**.
- **max = nums.Max()**
3.	Allocate an array **counts[0 … max+1]**.
- It will hold for each number x its number of occurrences **counts[x]**.
4.	**Scan** the input elements and for each element x increase counts[x].
- For each value **v** in **[0…max]**, print **v -> count[v]**.
- Skip all values which do not occur in **nums[]**, i.e. **counts[v] == 0**.
This algorithm has a serious drawback:
- It depends on **mapping numbers to array indexes**.
- It will work well for input values in the range [0…1000].
- It will **not work** for very large and very small values, e.g. if the input holds -100 000 000 or 100 000 000.
- It will **not work** for real numbers, e.g. 3.14 or 2.5.

