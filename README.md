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
