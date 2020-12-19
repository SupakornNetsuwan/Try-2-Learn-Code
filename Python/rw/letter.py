import read
import write

while True:
    r_type = input("Mode : (Read / Write)" + "\n")
    if r_type == "Write" or r_type =="write" or r_type =="w":
        write.write()
    elif r_type == "Read" or r_type =="read" or r_type =="r":
        read.read()
        pass
    pass