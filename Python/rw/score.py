import openpyxl 

path = "hello_world.xlsx"

wb_obj = openpyxl.load_workbook(path) 

sheet_obj = wb_obj.active 

cell_obj = ""

for i in range(1,2):
    cell_obj += str(sheet_obj.cell(row = i, column = i))
    pass

print(cell_obj.) 