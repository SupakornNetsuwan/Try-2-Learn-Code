major = []

for i in range(1,23):
    major.append(str(i) + ". " + str(input(str(i) + ". ")))
    pass

while True:
    print("============================================")
    pos = input("Insert Major Code or Press Q to quit" +"\n" + " Major Code : ")
    print("============================================")
    if( pos.isdigit()):
        print(major[int(pos) - 1])
    elif pos == "Q" or pos == "q":
        break
    else:
        print("Must Be Number!")
    pass