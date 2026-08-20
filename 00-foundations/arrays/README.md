# Arrays — DSA Foundation

Arrays are one of the most important data structures for coding interviews.

A large portion of LeetCode problems are based directly or indirectly on arrays.

---

## 1. What is an Array?

An array stores multiple values and provides access using an index.

Example:

    Index:   0    1    2    3    4
    Value:  10   20   30   40   50

### Python

    numbers = [10, 20, 30, 40, 50]

    print(numbers[0])  # 10
    print(numbers[3])  # 40

---

## 2. Array Indexing

Most programming languages use zero-based indexing.

    numbers[0]   → first element
    numbers[1]   → second element
    numbers[n-1] → last element

For an array of length n:

    Valid indexes = 0 ... n-1

---

## 3. Common Array Operations

| Operation | Typical Time |
|---|---:|
| Access by index | O(1) |
| Update by index | O(1) |
| Search unsorted array | O(n) |
| Search sorted array | O(log n) with Binary Search |
| Insert at beginning | O(n) |
| Insert at middle | O(n) |
| Insert at end | O(1) amortized |
| Delete from beginning | O(n) |
| Delete from middle | O(n) |
| Delete from end | O(1) |

> Note: Exact complexity can depend on the language and the specific array/dynamic-array implementation.

---

## 4. Traversing an Array

### Python

    numbers = [10, 20, 30, 40, 50]

    for number in numbers:
        print(number)

Time: O(n)

Space: O(1)

Assuming no additional data structure is created.

### C#

    int[] numbers = { 10, 20, 30, 40, 50 };

    foreach (int number in numbers)
    {
        Console.WriteLine(number);
    }

---

## 5. Access

Accessing an element using its index is O(1).

### Python

    numbers = [10, 20, 30, 40, 50]

    x = numbers[3]

The array can directly calculate the memory location of the requested index.

Time: O(1)

---

## 6. Searching

### Linear Search

Used when the array is not necessarily sorted.

### Python

    def linear_search(numbers, target):
        for i in range(len(numbers)):
            if numbers[i] == target:
                return i

        return -1

Time: O(n)

Space: O(1)

---

### Binary Search

Requires a sorted array.

### Python

    def binary_search(numbers, target):
        left = 0
        right = len(numbers) - 1

        while left <= right:
            mid = left + (right - left) // 2

            if numbers[mid] == target:
                return mid

            if numbers[mid] < target:
                left = mid + 1
            else:
                right = mid - 1

        return -1

Time: O(log n)

Space: O(1)

---

## 7. Updating an Element

### Python

    numbers = [10, 20, 30, 40]

    numbers[2] = 100

Result:

    [10, 20, 100, 40]

Time: O(1)

---

## 8. Two-Pointer Technique

Two Pointers is one of the most important array patterns for LeetCode.

Example: reverse an array in-place.

### Python

    def reverse_array(numbers):
        left = 0
        right = len(numbers) - 1

        while left < right:
            numbers[left], numbers[right] = numbers[right], numbers[left]

            left += 1
            right -= 1

Time: O(n)

Space: O(1)

### Common Problems

- Two Sum II
- 3Sum
- Container With Most Water
- Valid Palindrome
- Trapping Rain Water

---

## 9. Sliding Window

Sliding Window is another major LeetCode pattern.

It is commonly used when a problem involves a contiguous subarray or substring.

### Example

Find the maximum sum of a subarray of size k.

### Python

    def max_sum(numbers, k):
        window_sum = sum(numbers[:k])
        maximum = window_sum

        for i in range(k, len(numbers)):
            window_sum += numbers[i]
            window_sum -= numbers[i - k]

            maximum = max(maximum, window_sum)

        return maximum

Time: O(n)

Space: O(1)

### Common Problems

- Best Time to Buy and Sell Stock
- Longest Substring Without Repeating Characters
- Minimum Window Substring
- Permutation in String

---

## 10. Prefix Sum

Prefix sums allow repeated range-sum queries efficiently.

Example:

    numbers = [1, 2, 3, 4]

    prefix = [0, 1, 3, 6, 10]

### Python

    def build_prefix_sum(numbers):
        prefix = [0]

        for number in numbers:
            prefix.append(prefix[-1] + number)

        return prefix

Time: O(n)

Space: O(n)

After preprocessing, a range-sum query can be calculated in O(1).

---

## 11. Sorting

Sorting is frequently used before applying other techniques.

### Python

    numbers.sort()

Typical comparison-based sorting:

    O(n log n)

Sorting often enables:

- Two Pointers
- Binary Search
- Duplicate detection
- Interval processing
- Greedy solutions

---

## 12. Hashing + Arrays

A Hash Map can reduce many array problems from O(n²) to O(n).

### Example: Two Sum

Brute Force:

    Time: O(n²)
    Space: O(1)

Hash Map Solution:

### Python

    def two_sum(numbers, target):
        seen = {}

        for i, number in enumerate(numbers):
            complement = target - number

            if complement in seen:
                return [seen[complement], i]

            seen[number] = i

        return []

Time: O(n) average

Space: O(n)

---

## 13. Common Array Patterns

### Hash Map

Use when:

- Need fast lookup
- Need frequency/count
- Need to remember previously seen values

Typical complexity:

    Time: O(n)
    Space: O(n)

---

### Two Pointers

Use when:

- Working from both ends
- Array is sorted
- Looking for pairs/triplets
- Comparing elements

Typical complexity:

    Time: O(n)
    Space: O(1)

---

### Sliding Window

Use when:

- Problem involves a contiguous subarray
- Need longest/shortest/max/min window
- Maintaining a running condition

Typical complexity:

    Time: O(n)

---

### Prefix Sum

Use when:

- Repeated range-sum queries
- Cumulative values
- Subarray sum problems

Typical complexity:

    Preprocessing: O(n)
    Range Query:   O(1)

---

### Binary Search

Use when:

- Data is sorted
- Search space can be divided in half
- Answer has a monotonic property

Typical complexity:

    Time: O(log n)

---

## 14. Array Complexity Cheat Sheet

| Operation | Time |
|---|---:|
| Access | O(1) |
| Update | O(1) |
| Linear Search | O(n) |
| Binary Search | O(log n) |
| Insert at Start | O(n) |
| Insert in Middle | O(n) |
| Insert at End | O(1) amortized |
| Delete at Start | O(n) |
| Delete in Middle | O(n) |
| Delete at End | O(1) |
| Typical Comparison Sort | O(n log n) |

---

## 15. Important Interview Questions

When you see an array problem, ask:

1. Is the array sorted?
2. Can I use a Hash Map?
3. Can I use Two Pointers?
4. Is this a Sliding Window problem?
5. Can Prefix Sum help?
6. Can I sort first?
7. Can I solve it in-place?
8. Can Binary Search reduce the search space?
9. Do I need O(1) extra space?
10. What is the brute-force solution first?

---

## 16. Blind 75 Connection

Array knowledge directly supports many Blind 75 problems:

- Two Sum
- Best Time to Buy and Sell Stock
- Contains Duplicate
- Product of Array Except Self
- Maximum Subarray
- Maximum Product Subarray
- 3Sum
- Container With Most Water
- Find Minimum in Rotated Sorted Array
- Search in Rotated Sorted Array
- Combination Sum
- Merge Intervals
- Insert Interval
- Set Matrix Zeroes
- Spiral Matrix

---

## 17. Key Takeaway

Do not memorize solutions.

When you see an array problem, first identify the pattern:

    Array
      ↓
    Sorted?
      ↓
    Hash Map?
      ↓
    Two Pointers?
      ↓
    Sliding Window?
      ↓
    Prefix Sum?
      ↓
    Binary Search?
      ↓
    Sort?
      ↓
    Brute Force → Optimize

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
    