A = int(input("A : "))
B = int(input("B : "))
if A >= 0 and A <= 10:
    if B >= 0 and B <= 10:
        print(A+B)
    else:
        print("Check B")
else:
    print("Check A")
