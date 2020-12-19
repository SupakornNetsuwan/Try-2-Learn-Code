import os
def read():
  try:
    if os.path.exists("letter.txt"):
      read = open("letter.txt","r")
      ar = read.read()
      info = ar.split(";")
      print("============================================")
      for x in range(len(info)):
          user = info[x].split(",")
          print(" From :",user[0],"\n","To :",user[1],"\n","Letter :",user[2])
          print("============================================")
      read.close()
    else:
      print("The file does not exist")
  except:
    pass
pass
