# Tuples a and b are defined
a = (2, 5, 4)
b = (5, 8, 1, 2)

# Tuple c is the concatenation of a and b
c = a + b

# Print the original tuples
print(a)
print(b)

# Print the concatenated tuple
print(c)

# Print the sorted version of the concatenated tuple
print(sorted(c))

# Print the length of the concatenated tuple
print(len(c))

# Print the number of times 5 appears in the concatenated tuple
print(c.count(5))

# Print the concatenated tuple again
print(c)

# Print the index of the first occurrence of 4 in the concatenated tuple
print(c.index(4))

# Print the concatenated tuple again
print(c)

# Print the index of the first occurrence of 5 in the concatenated tuple
print(c.index(5))

# Print the index of the first occurrence of 5 starting from position 2
print(c.index(5, 2))
