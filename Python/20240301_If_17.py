height = float(input('What is your height in meters? '))
weight = float(input('What is your weight in kilograms? '))
bmi = weight / height ** 2
print('The BMI of this person is {:.2f}.'.format(bmi))
if bmi < 18.5:
    print('You are underweight.')
elif 18.5 <= bmi < 25:
    print('Congratulations! You are at your ideal weight.')
elif 25 <= bmi < 30:
    print('Warning! This is considered overweight.')
elif 30 <= bmi < 40:
    print('Warning! Your weight is dangerous to your health.')
elif bmi >= 40:
    print('Warning! This is morbid obesity.')
