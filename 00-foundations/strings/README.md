# Strings — DSA Foundation

Strings are sequences of characters and appear frequently in coding interviews.

Many string problems use the same techniques as array problems because a string can often be treated as an array of characters.

---

## 1. What is a String?

A string is a sequence of characters.

Example:

    "hello"

Characters:

    Index:     0   1   2   3   4
    Character: h   e   l   l   o

### Python

    text = "hello"

    print(text[0])  # h
    print(text[2])  # l

---

## 2. String Indexing

Strings are generally zero-indexed.

For:

    "hello"

    text[0] → h
    text[1] → e
    text[4] → o

Direct character access is typically:

    Time: O(1)

---

## 3. Traversing a String

### Python

    text = "hello"

    for character in text:
        print(character)

Complexity:

    Time:  O(n)
    Space: O(1)

Assuming no additional data structure is created.

---

## 4. String Length

### Python

    text = "hello"

    length = len(text)

Typically:

    Time: O(1)

because the string stores its length.

---

## 5. Strings Are Immutable

Strings are immutable in Python and C#.

### Python

    text = "hello"

You cannot directly modify a character:

    text[0] = "H"

This results in an error because strings cannot be changed in-place.

Instead, create a new string:

    text = "H" + text[1:]

For repeated modifications, use an appropriate mutable structure.

Example:

    characters = list(text)

---

## 6. Convert String to Character Array

Converting a string to a character array is useful when we need to modify individual characters.

### Python

    text = "hello"

    characters = list(text)

Result:

    ['h', 'e', 'l', 'l', 'o']

Example:

    characters[0] = 'H'

    text = ''.join(characters)

Result:

    "Hello"

---

## 7. String Comparison

### Python

    a = "hello"
    b = "hello"

    print(a == b)

String comparison can take:

    Time: O(n)

in the worst case because characters may need to be compared.

For example, comparing:

    "abcdefgh"

with:

    "abcdefgz"

requires checking multiple characters before finding the difference.

---

## 8. Reverse a String

### Python

    def reverse_string(text):
        return text[::-1]

Typical complexity:

    Time:  O(n)
    Space: O(n)

A new string is created.

---

## 9. Character Frequency

Frequency counting is one of the most common string techniques.

### Python

    def frequency_count(text):
        frequency = {}

        for character in text:
            frequency[character] = frequency.get(character, 0) + 1

        return frequency

Example:

    text = "banana"

    frequency_count(text)

Result:

    {
        'b': 1,
        'a': 3,
        'n': 2
    }

Complexity:

    Time:  O(n)
    Space: O(k)

where `k` is the number of unique characters.

If the alphabet is fixed, such as lowercase English letters, `k` is bounded by a constant and space can effectively be considered:

    O(1)

---

## 10. Hash Map + String

Hash Maps are commonly used for string frequency and lookup problems.

### Example: Valid Anagram

### Python

    def is_anagram(s, t):
        if len(s) != len(t):
            return False

        count = {}

        for character in s:
            count[character] = count.get(character, 0) + 1

        for character in t:
            if character not in count:
                return False

            count[character] -= 1

        return all(value == 0 for value in count.values())

Complexity:

    Time:  O(n)
    Space: O(k)

This pattern is extremely common in LeetCode.

Common problems:

- Valid Anagram
- Group Anagrams
- Ransom Note
- First Unique Character in a String

---

## 11. Two Pointers + String

Two Pointers are useful when processing characters from both ends.

### Example: Valid Palindrome

### Python

    def is_palindrome(text):
        left = 0
        right = len(text) - 1

        while left < right:
            if text[left] != text[right]:
                return False

            left += 1
            right -= 1

        return True

Complexity:

    Time:  O(n)
    Space: O(1)

This pattern appears frequently in LeetCode.

Common problems:

- Valid Palindrome
- Valid Palindrome II
- Reverse String
- Longest Palindromic Substring

---

## 12. Sliding Window + String

Sliding Window is one of the most important string patterns in Blind 75.

It is commonly used for substring problems.

### Example

Longest Substring Without Repeating Characters.

### Python

    def longest_unique_substring(text):
        seen = set()

        left = 0
        maximum = 0

        for right in range(len(text)):
            while text[right] in seen:
                seen.remove(text[left])
                left += 1

            seen.add(text[right])

            maximum = max(maximum, right - left + 1)

        return maximum

Complexity:

    Time:  O(n)
    Space: O(k)

where `k` is the number of unique characters.

This is one of the most important Sliding Window patterns in Blind 75.

---

## 13. StringBuilder in C#

Repeated string concatenation can be expensive because strings are immutable.

### Avoid repeated concatenation

    string result = "";

    for (...)
    {
        result += value;
    }

For many repeated modifications, use `StringBuilder`.

### C#

    using System.Text;

    StringBuilder result = new StringBuilder();

    for (...)
    {
        result.Append(value);
    }

    string output = result.ToString();

`StringBuilder` is particularly useful when constructing large strings through many modifications.

---

## 14. Common String Operations

| Operation | Typical Complexity |
|---|---:|
| Character access | O(1) |
| Length | O(1) |
| Traverse | O(n) |
| Compare | O(n) |
| Search character | O(n) |
| Reverse | O(n) |
| Build frequency map | O(n) |
| Sort characters | O(n log n) |

> Note: Exact complexity can depend on the language and implementation.

---

## 15. Important String Patterns

### Frequency Counting

Use when:

- Anagrams
- Character counts
- Duplicate characters
- Frequency comparisons

Common data structure:

    Hash Map / Dictionary

Typical complexity:

    Time: O(n)
    Space: O(k)

---

### Hash Set

Use when:

- Need to detect duplicates
- Need fast membership checking
- Need unique characters

Typical lookup:

    O(1) average

---

### Two Pointers

Use when:

- Checking palindrome
- Comparing from both ends
- Processing characters from opposite directions

Typical complexity:

    Time:  O(n)
    Space: O(1)

---

### Sliding Window

Use when:

- Solving substring problems
- Finding longest/shortest substring
- Working with contiguous sections
- Maintaining a condition while expanding/shrinking a window

Typical complexity:

    Time: O(n)

---

### Stack

Use when:

- Parentheses
- Nested expressions
- Matching opening/closing characters
- Removing adjacent characters

Common problems:

- Valid Parentheses
- Min Stack
- Evaluate Reverse Polish Notation
- Generate Parentheses

---

### Sorting

Use when:

- Character order does not matter
- Comparing anagrams
- Need a canonical representation

Example:

    sorted("listen")

and:

    sorted("silent")

produce the same characters.

Typical complexity:

    Time: O(n log n)

---

## 16. String Complexity Cheat Sheet

| Operation | Complexity |
|---|---:|
| Access character | O(1) |
| Length | O(1) |
| Traverse | O(n) |
| Compare | O(n) |
| Search | O(n) |
| Reverse | O(n) |
| Frequency counting | O(n) |
| Sort characters | O(n log n) |
| Hash Set lookup | O(1) average |
| Hash Map lookup | O(1) average |

---

## 17. Blind 75 Connection

String knowledge directly supports many Blind 75 problems:

- Valid Anagram
- Valid Palindrome
- Longest Substring Without Repeating Characters
- Longest Repeating Character Replacement
- Minimum Window Substring
- Group Anagrams
- Encode and Decode Strings
- Palindromic Substrings
- Longest Palindromic Substring
- Word Break
- Word Search

---

## 18. Key Takeaway

When you see a string problem, first identify the pattern:

    String
       ↓
    Character Frequency?
       ↓
    Hash Map / Hash Set?
       ↓
    Two Pointers?
       ↓
    Sliding Window?
       ↓
    Stack?
       ↓
    Sorting?
       ↓
    Character Array?

The goal is pattern recognition, not memorization.

    Problem
       ↓
    Identify Pattern
       ↓
    Choose Data Structure
       ↓
    Write Brute Force
       ↓
    Analyze Complexity
       ↓
    Optimize