scoreM = float(input("กลางภาค : "))
scoreF = float(input("ปลายภาค : "))
scoreC = float(input("คะแนนเก็บ : "))
personal = float(input("คะแนนจิตพิสัย : "))

total = scoreM + scoreF + scoreC + personal

if scoreM <= 30 and scoreF <= 30 and scoreC <= 30 and personal <= 10:
    if total <= 100 and total >= 80:
        Grade = "4"
    elif total >= 70:
        Grade = "3"
    elif total >= 60:
        Grade = "2"
    elif total >= 50:
        Grade = "1"
    elif total < 50 and total <= 0:
        Grade = "0"
        pass
    print("เกรด = " , Grade)
else:
    print("เกิดข้อผิดพลาด กรุณาตรวจสอบคะแนนอีกครั้ง")
    pass