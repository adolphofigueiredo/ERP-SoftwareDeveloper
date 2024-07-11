city = str(input('Enter the name of the city: ')).strip()

# Split the city name into a list of words in lowercase
city_split = city.lower().split()

# Check if the first word is 'santo'
print('santo' in city_split[0])
