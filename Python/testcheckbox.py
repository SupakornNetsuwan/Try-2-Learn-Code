from tkinter import *
root = Tk()
root.option_add("Font","consolas 20")
root.geometry("500x300")

it = IntVar()
mt = IntVar()
mh = IntVar()
eai = IntVar()
result = StringVar()

def check_major():
    store_result = ""
    print("Name =",name.get())
    print("Average =",ave.get())
    print("Gender =",gender.get())
    print("It = %d\nMT = %d\nMath = %d\nE-Ai = %d" %(it.get(),mt.get(),mh.get(),eai.get()))
    tg = it.get()
    mg = mt.get()
    mag = mh.get()
    eag = eai.get()
    if tg == 1:
        store_result += "IT "
    if mg == 1:
        store_result += "MT "
    if mag == 1:
        store_result += "Math "
    if eag == 1:
        store_result += "E-Ai "

    result.set("คุณได้เลือก วิชาเอกตามนี้ " + store_result)
    pass

Label(root,text = "Student Name : ").grid(row = 0, column = 0,stick = "sw")
Label(root,text = "Average : ").grid(row = 1, column = 0,stick = "sw")


# Student name
name = Entry(root)
name.grid(row = 0, column = 1)

# Average
ave = Entry(root)
ave.grid(row = 1,column = 1)

gender = StringVar()

Label(root,text = "Gender : ").grid(row = 2, column = 0,stick = "sw")
Radiobutton(root, text = "Male",value = "male",variable = gender).grid(row = 2 , column = 1,stick = "w")
Radiobutton(root, text = "Female",value = "female",variable = gender).grid(row = 2 , column = 1,stick = "e")

Checkbutton(root, text = "IT",variable = it).grid(row = 3 , column = 1,stick = "w")
Checkbutton(root, text = "MT",variable = mt).grid(row = 4 , column = 1,stick = "w")
Checkbutton(root, text = "Math",variable = mh).grid(row = 5 , column = 1,stick = "w")
Checkbutton(root, text = "EAI",variable = eai).grid(row = 6 , column = 1,stick = "w")


Button(root,text = "OK",width = 6,command = check_major).grid(row = 7 , column = 1,stick = "w")
Button(root,text = "Quit",width = 6,command = quit).grid(row = 7 , column = 1,stick = "e")
Label(root,text = "Result = ").grid(row = 8 , column = 0)
Label(root,textvariable = result).grid(row = 8 , column = 1)

root.mainloop()
