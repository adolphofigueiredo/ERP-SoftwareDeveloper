def average(*params):
    if len(params) == 0:
        return "Error: Division by zero"

    total = 0
    for val in params:
        total += val
    
    return total / len(params)

print("Average 1 =", average(1, 2, 3))
print("Average 2 =", average(1, 2, 3, 4, 5, 6))
print("Average 3 =", average())  # The problem here is division by zero, as the len function counts the number of parameters added in this case.

# Since in this case there is a loop, it is possible to use a counter to achieve the same result,
# but if there is no loop and it's simply a formula, it may become impossible to achieve the same result.
