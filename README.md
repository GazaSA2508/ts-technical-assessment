## 📝 Garreth Hall - Technical Assessment

This repository contains solutions to two coding challenges: **Longest Sentence** detection and **Deepest Pit** calculation. Both questions have been answered with best practices in mind, unit testing and input validation.

---

### Table of Contents

- [Longest Sentence](#longest-sentence)
- [Deepest Pit](#deepest-pit)
- [Technologies](#technologies)

---

### Longest Sentence

#### 💡 Overview
The **Longest Sentence** detection challenge analyses a text string to find the sentence containing the largest number of words. 

A valid word must contain at least one letter (A–Z or a–z).

Sentences are split by punctuation: ., ?, !

#### ❤️ Key Features

- Splits text into sentences based on punctuation.
- Counts words in each sentence.
- A word must only contain letters.
- Returns maximum word count for the sentence containing the most words.
- Handles edge cases such as empty sentences or strings with multiple consecutive punctuation marks.
- Unit tests validate various sentence structures and punctuation combinations.

#### 📄 Example Input (String containing any number of sentences)
```
"We test coders. Give us a try?"
```

#### ✅ Output (The maximum number of words found in a sentence)
```
4
```

---

### Deepest Pit

#### 💡 Overview
The **Depest Pit** calculation calculates the deepest pit in an array of integers while enforcing specific constraints. A pit is defined as a strictly decreasing sequence followed by a strictly increasing sequence. 

The depth of a pit is the minimum of the drop and rise values.

Additional validation is included to ensure the array length and element values conform to the specified rules.

#### ❤️ Key Features

- Enforces strict decreasing then increasing sequences.
- Constraint Enforcement validating an array length (1 to 1,000,000) and element values (0 to 1,000,000).
- Error handling where descriptive exceptions are thrown for invalid input.
- Includes MSTest unit tests for validation of constraints.
- Handles arrays without valid pits (ie: when no pit exists) by returning -1 .

#### 📄 Example Input (Integer Array)
```
"{ 1, 2, 3, 1, 2, 3, 1, 2, 3 }"
```

#### ✅ Output (Depth of the deepest pit as an integer)
```
2
```

---

### Technologies

[![C#](https://img.shields.io/badge/.Net-8-orange)](https://dotnet.microsoft.com/) [![C#](https://img.shields.io/badge/C%23-.NET_Core-blue)](https://dotnet.microsoft.com/) [![MSTest](https://img.shields.io/badge/Testing-MSTest-green)](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest)

- .NET 8
- C# .NET Core
- MSTest unit tests
