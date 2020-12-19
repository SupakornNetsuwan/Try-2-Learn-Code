from tkinter import *
app = Tk()
# app.geometry("500x500")

Sel_Monthly = IntVar()
Sel_Type = IntVar()
result = StringVar()

Label(app,text = "Cutomer Name").grid(column = 0,row = 0,stick = "w")

Cutomer_Name = Entry(app,width = 30)
Cutomer_Name.grid(column = 1,row = 0)

Label(app,text = "Email").grid(column = 0,row = 1,stick = "w")

Email = Entry(app,width = 30)
Email.grid(column = 1,row = 1)

Label(app,text = "Address").grid(column = 0,row = 2,stick = "w")

Address = Entry(app,width = 30)
Address.grid(column = 1,row = 2)

Label(app,text = "Mobile").grid(column = 0,row = 3,stick = "w")

Mobile = Entry(app,width = 30)
Mobile.grid(column = 1,row = 3)

Label(app,text = "Monthly").grid(column = 0,row = 4)
Radiobutton(app,text = "1 Month",value = 1,variable = Sel_Monthly).grid(column = 0,row = 5,stick = "w")
Radiobutton(app,text = "3 Month",value = 3,variable = Sel_Monthly).grid(column = 0,row = 6,stick = "w")
Radiobutton(app,text = "6 Month",value = 6,variable = Sel_Monthly).grid(column = 0,row = 7,stick = "w")
Radiobutton(app,text = "12 Month",value = 12,variable = Sel_Monthly).grid(column = 0,row = 8,stick = "w")

Label(app,text = "Type").grid(column = 1,row = 4)
Radiobutton(app,text = "Student",value = 10,variable = Sel_Type).grid(column = 1,row = 5,stick = "w")
Radiobutton(app,text = "Official",value = 5,variable = Sel_Type).grid(column = 1,row = 6,stick = "w")
Radiobutton(app,text = "General Public",value = 0,variable = Sel_Type).grid(column = 1,row = 7,stick = "w")

def register():
    month = Sel_Monthly.get()
    name = Cutomer_Name.get()
    mail = Email.get()
    defresult = month * 250
    discount = int(Sel_Type.get())
    if month == 6:
        discount = Sel_Type.get() + 5
        pass
    if month == 12:
        discount = Sel_Type.get() + 10
        pass
    cost = defresult - (int(defresult * discount) / 100)
    result.set("Name : {} \n Email : {} \n Cost : {}".format(name,mail,cost))
    pass
Button(app,text = "Register",width = 20,command = register).grid(column = 1,row = 9)

def quit():
    app.quit()
    pass
Button(app,text = "Quit",width = 20,command = quit).grid(column = 1,row = 10)

Label(app,text = "",textvariable = result).grid(column = 0,row = 10,stick = "w")

app.mainloop()