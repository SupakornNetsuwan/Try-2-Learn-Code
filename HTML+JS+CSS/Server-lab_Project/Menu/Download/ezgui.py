from tkinter import *
import os
file_name = input(str("File Name? : "))
root_name = input(str("Root Name? : "))

if os.path.exists(file_name+".py"):
    export = open(file_name + ".py", "w")
else:
    export = open(file_name + ".py", "x")
    pass


def ezGuiStart():
    export.write("from tkinter import *" + "\n" + root_name + " = Tk()" +
                 "\n" + root_name + ".geometry(\"500x500\")" + "\n" + "\n")
    pass


def ezGuiEnd():
    export.write(root_name + ".mainloop()")
    pass


def ezLabel(root, text, column, row):
    Label(root, text=text).grid(column=column, row=row)
    export.write("Label(" + root_name + ",text = " + "\"" + text + "\"" +
                 ").grid(column = " + str(column) + ",row = " + str(row) + ")" + "\n" + "\n")
    pass


def ezEntry(var, root, column, row):
    export.write(str(var) + " = Entry(" + root_name + ")" + "\n" + str(var) +
                 ".grid(column = " + str(column) + ",row = " + str(row) + ")" + "\n" + "\n")
    var = Entry(root).grid(column=column, row=row)
    pass


def ezButton(root, text,command, column, row):
    Button(root, text=text).grid(column=column, row=row)
    export.write("def " + command + "():" + "\n" + "    pass" + "\n" + "\n")
    export.write("Button(" + root_name + ",text = " + "\"" + text + "\"" +
                 ",command = "+command+").grid(column = " + str(column) + ",row = " + str(row) + ")" + "\n" + "\n")
    pass


def ezCheckbox(root, text, column, row):
    Checkbutton(root, text=text).grid(column=column, row=row)
    export.write("Checkbutton(" + root_name + ",text = " + "\"" + text + "\"" +
                 ").grid(column = " + str(column) + ",row = " + str(row) + ")" + "\n" + "\n")
    pass
