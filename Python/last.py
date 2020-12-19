class bmi:
    def __init__(self,weight,height):
        self.weight = weight
        self.height = height
        self.bmi = ""

    def getbmi(self):
        heiM = (self.height / 100) ** 2
        self.bmi = (self.weight / heiM)
        return self.bmi

    def getresult(self,x):
        if x < 18.5 and x > 0:
            result = "น้ำหนักต่ำกว่าเกณฑ์"
        elif x >= 18.5 and x <= 22.9:
            result = "สมส่วน"
        elif x >= 23.0 and x <= 24.9:
            result = "น้ำหนักเกิน"
        elif x >= 25.0 and x <= 29.9:
            result = "โรคอ้วน"
        elif x >= 30.0:
            result = "โรคอ้วนอันตราย"
        return result
    
    pass

inpname = str(input("Name : "))
inpwei = float(input("Weight : "))
inphei = float(input("Height : "))
run = bmi(inpwei,inphei)
print("\n","ชื่อ :",inpname ,"\n","ส่วนสูง :",inpwei,"\n","น้ำหนัก :",inphei,"\n","BMI :",'%.2f' % run.getbmi(),"\n","ภาวะเสี่ยงต่อโรค :", run.getresult(int(run.getbmi())))
