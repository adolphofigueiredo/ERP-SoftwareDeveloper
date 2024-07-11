#Lambda in Python is a way to create anonymous functions, which are functions without a name.
#It allows you to define a small, one-line function that can take any number of arguments, but can only have one expression.
#The general syntax of a lambda function looks like this:

#lambda arguments: expression

# - lambda:     This keyword is used to indicate that you're creating a lambda function.
# - arguments:  These are the input parameters of the function, similar to what you would define in a regular function.
# - expression: This is a single expression that the lambda function evaluates and returns as its result.

#Lambda functions are typically used in situations where you need a quick function for a short period of time.
#They are often used as arguments to higher-order functions like `map()`, `filter()`, or `sorted()`, where you need a simple function and don’t want to define a formal function using `def`.

#For example, a lambda function that squares a number looks like this:


square = lambda x: x ** 2

#Here, `lambda x: x ** 2` defines a function that takes an argument `x` and returns `x` squared. This lambda function can be used just like a regular function:

result = square(5)  # result will be 25


#In summary, lambda functions are a concise way to create small, anonymous functions in Python, useful for quick operations where defining a full function using `def` would be more cumbersome.
