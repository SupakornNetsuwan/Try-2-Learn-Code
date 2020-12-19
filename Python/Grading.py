A = int(input("คะแนนเก็บ : "))
B = int(input("คะแนนกลางภาค : "))
C = int(input("คะแนนปลายภาค : "))
D = A + B + C
if A >= 0 and A <= 30:
    if B >= 0 and B <= 30:
        if C >= 0 and C <= 40:
            if D >= 80 and D <= 100:
                E = "A"
            elif D >= 75 and D < 80:   
                E = "B+"
            elif D >= 70 and D < 75:
                E = "B"
            elif D >= 65 and D < 70:
                E = "C+"
            elif D >= 60 and D < 65:
                E = "C"
            elif D >= 55 and D < 60:
                E = "D+"
            elif D >= 50 and D < 55:
                E = "D"
            elif D >= 0 and D < 50:
                E = "E"
print(E)
