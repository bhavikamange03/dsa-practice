# Searching — DSA

Searching algorithms are used to find a target element or efficiently search a possible answer space.

---

## 1. Linear Search

Checks elements one by one.

### When to use

- Array is unsorted
- Simple sequential search
- No special ordering exists

### Complexity

| Case | Time | Space |
|---|---:|---:|
| Best | O(1) | O(1) |
| Average | O(n) | O(1) |
| Worst | O(n) | O(1) |

---

## 2. Binary Search

Searches a **sorted** array by repeatedly eliminating half of the search space.

### Basic idea

```text
left ───────── mid ───────── right
              ↓
        check target

target > mid → search right
target < mid → search left
```

### Complexity

```text
Time:  O(log n)
Space: O(1) iterative
Space: O(log n) recursive
```

---

## 3. Binary Search Template

Remember these three variables:

```text
left
right
mid
```

Standard boundary:

```text
left = 0
right = n - 1
```

Standard loop:

```text
while left <= right
```

After checking `mid`:

```text
target > numbers[mid]
    → left = mid + 1

target < numbers[mid]
    → right = mid - 1
```

---

## 4. Iterative vs Recursive

| Approach | Time | Space | Recommendation |
|---|---:|---:|---|
| Iterative | O(log n) | O(1) | Preferred |
| Recursive | O(log n) | O(log n) | Understand it |

Both implementations are available in:

```text
01-searching/python/binary_search.py
01-searching/csharp/BinarySearch.cs
```

---

## 5. Common Binary Search Mistakes

### Boundary mistakes

```text
right = n - 1
```

not:

```text
right = n
```

### Infinite loops

Use:

```text
left = mid + 1
right = mid - 1
```

not:

```text
left = mid
right = mid
```

### Wrong condition

Standard exact-match search:

```text
while left <= right
```

### Unsorted input

Standard Binary Search requires a sorted search space.

---

## 6. How to Recognize Binary Search

Ask:

```text
1. Is the input sorted?

2. Can I eliminate half of the search space?

3. Is there a monotonic TRUE/FALSE condition?

4. Am I looking for a boundary?
   - First
   - Last
   - Minimum
   - Maximum

5. Am I searching possible answers rather than elements?
```

If the answer is yes to one or more, consider Binary Search.

---

## 7. Complexity Cheat Sheet

| Algorithm / Pattern | Time | Space |
|---|---:|---:|
| Linear Search | O(n) | O(1) |
| Binary Search | O(log n) | O(1) |
| Recursive Binary Search | O(log n) | O(log n) |
| First Occurrence | O(log n) | O(1) |
| Last Occurrence | O(log n) | O(1) |
| Rotated Sorted Array | O(log n) | O(1) |
| Binary Search on Answer | O(log n × check) | O(1) |

---

## 8 Files

```text
01-searching/
├── README.md
├── python/
│   ├── linear_search.py
│   └── binary_search.py
└── csharp/
    ├── LinearSearch.cs
    └── BinarySearch.cs
```

---

