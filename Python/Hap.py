a = 3
b = 12
n = 13
print((a**b)%n)
for i in range(0,b):
    if ((a ** i)%n) == 0:
        print(i)
        pass
    pass