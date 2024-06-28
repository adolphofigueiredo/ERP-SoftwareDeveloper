def area(base: float, height: float) -> float:
    if not isinstance(base, (int, float)) or not isinstance(height, (int, float)):
        raise ValueError("Both base and height must be numbers.")
    return base * height

print("Area 1 = ", area(3.2, 4.5))
print("Area 2 = ", area(5, 4))

try:
    print("Area 3 = ", area("A", 3))  # This will now raise a ValueError
except ValueError as e:
    print("Error:", e)

try:
    print("Area 4 = ", area("A", "B"))  # This will now raise a ValueError
except ValueError as e:
    print("Error:", e)
