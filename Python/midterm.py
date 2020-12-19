class Comission():
    def __init__(self):
        self.Name = input("Name : ")
        self.Role = input("Role : ")
        self.Salary = 0
        self.Sales = int(input("Sales : "))
        self.Total = 0
        self.Check_role()
        pass
    def Check_role(self):
        Role = self.Role.lower()
        if Role == "boss":
            self.Salary = 60000
        elif Role == "vice boss":
            self.Salary = 35000
        else:
            self.Salary = 18000
        self.Comis_cal()
        pass
    def Comis_cal(self):
        Sales = self.Sales
        if Sales >= 5000000:
            commis = Sales * 5 / 100
        elif Sales > 4000000:
            commis = Sales * 4 / 100
        elif Sales > 3000000:
            commis = Sales * 3 / 100
        else:
            commis = Sales * 2 / 100
            pass
        self.Total = self.Salary + commis
        print("================================================================")
        print("Name :",self.Name ,"\n" + "Role :", self.Role ,"\n" + "Salary :", self.Salary ,"\n" + "Comission :", commis , "\n" + "Total Salary :",self.Total)
        print("================================================================")
    pass
run = Comission()