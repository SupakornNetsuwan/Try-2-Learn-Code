import math
def HtoM(hour):
    x = int(hour)
    mint = x * 60
    return mint
    pass

def billPark(time):
    flo = math.ceil((time / 60))
    if time > 360:
        print("ค่าบริการ", 200, "บาท")
    elif time > 180:
        print("ค่าบริการ", flo * 20, "บาท")
    elif time >= 15:
        print("ค่าบริการ", flo * 10, "บาท")
    else:
        print("ค่าบริการฟรี")

def pstart():
    timeIn = str(input("เวลาเข้า : "))
    timeOut= str(input("เวลาออก : "))
    reltimein = timeIn.split(":",1)
    reltimeout = timeOut.split(":",1)
    howlong = (int(reltimeout[0]) - int(reltimein[0]))
    hour = HtoM(howlong)
    minut = (int(reltimeout[1]) - int(reltimein[1]))
    total = hour + minut
    print("คุณได้ใช้บริการไปทั้งหมด",total / 60 ,"ชั่วโมง")
    billPark(total)
    pass

pstart()