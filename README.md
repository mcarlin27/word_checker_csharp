# Worch Counter

#### A program that allows users to submit two inputs and determine the occurence of the first input in the second. 6/2/17

#### By **Marilyn Carlin**

## Description

A website created with C# and HTML where a user can submit text to two input fields and detemine the occurence of the first input within the second.



### Specs
| Behavior | First Input | Second Input | Example Output | Reasoning for Spec |
| :-------------     | :------------- | :------------- | :------------- | :------------- |
| **Recognize Matching Single Letter User Inputs** | "a" | "a" | "Match: 1" | Simplest possible inputs, no need to use arrays or a for loop. |
| **Fail to Recognize Partial Match of Single Letter User Inputs** | "a" | "am" | "Match: 0" | Matches at this time should not include partial matches. |
| **Recognize Match of Single Letter First Input in Multi-letter Second Input** | "a" | "a m" | "Match: 1" | Next simplest step. Now splitting string and using for loop. |
| **Recognize Multiple Matches of Single Letter First Input to Multi-letter Second Input** | "a" | "a m a" | "Match: 2" | For loop should catch multiple instances at a time. |
| **Recognize Matching Multi Letter (word) User Inputs** | "alex" | "alex" | "Match: 1" | No need to split string or use for loop.  |
| **Recognize Match of Multi-letter User Input in Multi-item Second Input** | "alex" | "alex m" | "Match: 1" | Now using a for loop, and splitting string input using Arrays. |
| **Recognize Multiple Matches of Multi-letter First Input to Multi-letter Second Inputs** | "alex" | "alex and alex" | "Match: 2" | For loop should catch every instance of the word. |
| **Fail to Recognize Match of Multi-letter User Inputs Without Case Matching** | "alex" | "Alex" | "Match: 0" | Matches at this time should be case sensitive, as the program does not at this point standardize input cases. |
| **Recognize Match Regardless of Case** | "alex" | "Alex" | "Match: 1" | Loop should catch instances of the word without being case sensitive. |
| **Recognize Match Regardless of Punctuation** | "alex" | "Alex, and Alex!" | "Match: 2" | Loop should exclude punctuation external to the word from the search. |
| **Recognize Partial Matches** | "meow" | "homeowner" | "Match: 1" | Program should allow user to include results for partial matches. Instructions for this project explicitly excluded partial matches, but if I have time I would like to try to make it work, as personal experience has shown me this can be a helpful search function. |

## Setup/Installation Requirements

1. To run this program, you must have a C# compiler. I use [Mono](http://www.mono-project.com).
2. Install the [Nancy](http://nancyfx.org/) framework to use the view engine. Follow the link for installation instructions.
3. Clone this repository.
4. Open the command line--I use PowerShell--and navigate into the repository. Use the command "dnx kestrel" to start the server.
5. On your browser, navigate to "localhost:5004" and enjoy!

## Known Bugs
* Program does not run.

## Technologies Used
* C#
  * Nancy framework
  * Razor View Engine
  * ASP.NET Kestrel HTTP server
  * xUnit

* HTML

## Support and contact details

_Email no one with any questions, comments, or concerns._

### License

*{This software is licensed under the MIT license}*

Copyright (c) 2017 **_{Marilyn Carlin}_**
