def average(*parameters):
    total = 0

    for val in parameters:
        total += val
    
    return total / len(parameters)

print("Average 1 = ", average(1,2,3))
print("Average 2 = ", average(1,2,3,4,5,6))
print("Average 3 = ", average())                     #The problem is in the division by zero, as the len function serves to count the number of parameters added in this case. Try to write average(0).

#As in this case there is a loop, it is possible to use a counter to reach the same result,
#but if there is no loop and it is simply a formula, it may become impossible to achieve the same result.
