# <p align="center"> Regular expressions - REGEX - Exercises <p>

## Extract emails
Write a program to **extract all email addresses from a given text**. The text comes at the only input line. Print the emails on the console, each at a separate line. Emails are considered to be in format **<user>@<host>**, where: 
- **<user>** is a sequence of letters and digits, where '.', '-' and '_' can appear between them. Examples of valid users: **"stephan"**, **"mike03"**, **"s.johnson"**, **"st_steward"**, **"softuni-bulgaria"**, **"12345"**. Examples of invalid users: **''--123"**, **"....."**, **"nakov_-"**, **"_steve"**, **".info"**. 
- **<host>** is a sequence of at least two words, separated by dots '.'. Each word is sequence of letters and can have hyphens '-' between the letters. Examples of hosts: **"softuni.bg"**, **"software-university.com"**, **"intoprogramming.info"**, **"mail.softuni.org"**. Examples of invalid hosts: **"helloworld"**, **".unknown.soft."**, **"invalid-host-"**, **"invalid-"**. 
- Examples of **valid emails:** info@softuni-bulgaria.org, kiki@hotmail.co.uk, no-reply@github.com, s.peterson@mail.uu.net, info-bg@software-university.software.academy. 
- Examples of **invalid emails:** --123@gmail.com, …@mail.bg, .info@info.info, _steve@yahoo.cn, mike@helloworld, mike@.unknown.soft., s.johnson@invalid-.

#### Examples

| **Input**| **Output**|
|---|---|
|Please contact us at: support@github.com.	|support@github.com|
|Just send email to s.miller@mit.edu and j.hopking@york.ac.uk for more information.|s.miller@mit.edu <br/> j.hopking@york.ac.uk|
|Many users @ SoftUni confuse email addresses. We @ Softuni.BG provide high-quality training @ home or @ class. –- steve.parker@softuni.de.|steve.parker@softuni.de|

## Replace A Tag

Write a program that replaces in a HTML document given as string all the tags <a href=…>…</a>
with corresponding tags [URL href=…>…[/URL].
Read an input, until you receive “end” command.
 Print the result on the console. 