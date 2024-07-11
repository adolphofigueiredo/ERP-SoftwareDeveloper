from time import sleep

# Countdown loop from 10 to 0
for count in range(10, -1, -1):
    print(count)  # Print the current count
    sleep(1)      # Pause execution for 1 second

print('Boooooooom')  # After countdown, print "Boooooooom"
