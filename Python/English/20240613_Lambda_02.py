#Using lambda with sorted:
#When you use sorted with lambda, you can sort items based on a specific criterion defined by the lambda function.
#Here’s the basic syntax:

#sorted(iterable, key=lambda x: expression)

#iterable: This is the collection of items you want to sort, such as a list.

#key: This parameter specifies a function (or lambda function) that calculates a value from each item in the iterable. This value is used to determine the sort order.

#lambda x: expression: This is the lambda function that takes an element x from the iterable and returns a value (expression). The key function will use this value to sort the items.

#Example:
#Let's say you have a list of tuples representing people's names and ages:

people = [('Alice', 25), ('Bob', 30), ('Carol', 20)]

#If you want to sort this list by age (the second element of each tuple), you can use sorted with a lambda function:

sorted_people = sorted(people, key=lambda person: person[1])

#lambda person: person[1]: This lambda function takes each tuple person and returns the second element (person[1]), which is the age.

#Result:
#After sorting, sorted_people will be:

[('Carol', 20), ('Alice', 25), ('Bob', 30)]

#In this way, lambda with sorted allows you to specify custom sorting logic based on any aspect of the items in your iterable, making it flexible and powerful for various sorting tasks in Python.
