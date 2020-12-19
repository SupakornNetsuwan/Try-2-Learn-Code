import os
import datetime
def write():
  if os.path.exists("letter.txt"):
    read = open("letter.txt","a")
    print("============================================")
    to = input("To : ")
    l_from = input("From : ")
    letter = input("Letter : ")
    read.write(l_from +","+ to +","+ letter +";")
    print("                    Done!                   ")
    print("============================================")
  else:
    print("The file does not exist")
  pass
