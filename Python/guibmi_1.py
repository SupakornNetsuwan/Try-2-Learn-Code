from tkinter import *

app = Tk() 
app.title("BMI Calculator")
app.resizable(0,0)
def cal_bmi():
    w = float(input_W.get())
    h = float(input_H.get())
    rh = h / 100
    result = float(w/(rh*rh))
    text_showresult["text"] = '%.3f' % result
    if result < 18.50:
        text_var = "น้ำหนักน้อย"
    elif result <= 22.90:
        text_var = "ปกติ"
    elif result <= 24.90:
        text_var = "ท้วม"
    elif result <= 29.90:
        text_var = "อ้วน"
    elif result > 30:
        text_var = "อ้วนมาก"
    text_showcal["text"] = text_var
    pass
text_H = Label(app,text = "Height :",height = 2, width = 10,font=("", 25)).grid(column=0, row=0)
input_H = Entry(app,font=("", 25))
input_H.grid(column=1, row=0)
text_cm = Label(app, text = "cm.",height = 2, width = 10,font=("", 25)).grid(column=2, row=0)
text_W = Label(app,text = "Width :",height = 2, width = 10,font=("", 25)).grid(column=0, row=1)
input_W = Entry(app,font=("", 25))
input_W.grid(column=1, row=1)
text_kg = Label(app,height = 2,text = "kg.", width = 10,font=("", 25)).grid(column=2, row=1)
cal_button = Button(app,text = "Calculate",command = cal_bmi, width = 10,height = 5,font = ("",10)).grid(column=2, row=3)
text_result = Label(app,text = "Result : ",height = 2, width = 10,font=("", 25)).grid(column=0, row=3)
text_showresult = Label(app,text = "0", height = 2, width = 10,font=("", 25))
text_showresult.grid(column=1, row=3)
text_result = Label(app,text = "อยู่ในเกณท์ : ",height = 2, width = 10,font=("", 25)).grid(column=0, row=4)
text_showcal = Label(app,text = "รอระบุ", height = 2, width = 10,font=("", 25))
text_showcal.grid(column=1, row=4)

app.mainloop()