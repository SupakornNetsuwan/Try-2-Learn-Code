member = ""
name = ""
discount = 0
pos = 0

for pos in range(1,11):
        name = str(input("Enter Your Name : "))
        if pos <= 3:
            discount = 50
        elif pos <= 6:
            discount = 30
        else:
            discount = 15
            pass
        member = str(member + str(pos) + ". " + "Name : " +  str(name) + " Discount : " + str(discount) + "%" + "\n")
pass

print(member)