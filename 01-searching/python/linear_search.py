def linear_search(numbers, target):
    for i, number in enumerate(numbers):
        if number == target:
            return i

    return -1


def main():
    numbers = [10, 25, 30, 45, 50]

    print(linear_search(numbers, 45))
    print(linear_search(numbers, 100))

if __name__ == "__main__":
    main()
