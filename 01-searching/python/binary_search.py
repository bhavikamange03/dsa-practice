# ============================================================
# Binary Search
# ============================================================
#
# Binary Search requires a sorted array.
#
# Two implementations:
# 1. Iterative Binary Search
# 2. Recursive Binary Search
#
# Time Complexity:
#   Both: O(log n)
#
# Space Complexity:
#   Iterative: O(1)
#   Recursive: O(log n) because of the call stack
# ============================================================


# ------------------------------------------------------------
# 1. Iterative Binary Search
# ------------------------------------------------------------

def binary_search_iterative(numbers, target):
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


# ------------------------------------------------------------
# 2. Recursive Binary Search
# ------------------------------------------------------------

def binary_search_recursive(numbers, target, left, right):

    # Base case:
    # Search space is empty
    if left > right:
        return -1

    mid = left + (right - left) // 2

    if numbers[mid] == target:
        return mid

    if numbers[mid] < target:
        return binary_search_recursive(
            numbers,
            target,
            mid + 1,
            right
        )

    return binary_search_recursive(
        numbers,
        target,
        left,
        mid - 1
    )


# ------------------------------------------------------------
# Public function for easier use
# ------------------------------------------------------------

def binary_search(numbers, target):
    return binary_search_recursive(
        numbers,
        target,
        0,
        len(numbers) - 1
    )

def find_first(numbers, target):
    left = 0
    right = len(numbers) - 1
    answer = -1

    while left <= right:
        mid = left + (right - left) // 2

        if numbers[mid] == target:
            answer = mid
            right = mid - 1

        elif numbers[mid] < target:
            left = mid + 1

        else:
            right = mid - 1

    return answer


def find_last(numbers, target):
    left = 0
    right = len(numbers) - 1
    answer = -1

    while left <= right:
        mid = left + (right - left) // 2

        if numbers[mid] == target:
            answer = mid
            left = mid + 1

        elif numbers[mid] < target:
            left = mid + 1

        else:
            right = mid - 1

    return answer

# ------------------------------------------------------------
# Tests
# ------------------------------------------------------------

assert binary_search_iterative(
    [1, 3, 5, 7, 9, 11, 13],
    11
) == 5

assert binary_search_iterative(
    [1, 3, 5, 7, 9, 11, 13],
    4
) == -1


assert binary_search(
    [1, 3, 5, 7, 9, 11, 13],
    11
) == 5

assert binary_search(
    [1, 3, 5, 7, 9, 11, 13],
    4
) == -1


# Edge cases

assert binary_search_iterative([], 5) == -1
assert binary_search([], 5) == -1

assert binary_search_iterative([5], 5) == 0
assert binary_search([5], 5) == 0

print("All Binary Search tests passed!")

numbers = [1, 2, 2, 2, 2, 3, 4]

assert find_first(numbers, 2) == 1
assert find_last(numbers, 2) == 4

assert find_first(numbers, 5) == -1
assert find_last(numbers, 5) == -1

print("First/Last occurrence tests passed!")