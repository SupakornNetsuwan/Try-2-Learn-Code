import smtplib
from email.mime.text import MIMEText
from email.mime.multipart import MIMEMultipart
from email.mime.base import MIMEBase
from email import encoders
import os.path
import os

def Sent_Email(email,password,send_to_email,subject,message,file):

    msg = MIMEMultipart()
    msg['From'] = email
    msg['To'] = send_to_email
    msg['Subject'] = subject

    # Attach the message to the MIMEMultipart object
    msg.attach(MIMEText(message, 'plain'))
    try:
        server = smtplib.SMTP('smtp.gmail.com', 587)
        server.starttls()
        pass
    except:
        return("[Sent Email]: Can't Connect To The Gmail Server")
        pass

    try:
        fn = os.path.basename(file)
        attachment = open(file,"rb")
        part = MIMEBase('application','octet-stream')
        part.set_payload((attachment).read())
        encoders.encode_base64(part)
        part.add_header('Content-Disposition', "attachment; filename= %s" % fn)

        msg.attach(part)
        pass
    except:
        return("[Sent Email]: Error With Send File")
        pass


    try:
        server.login(email, password)
        text = msg.as_string() # You now need to convert the MIMEMultipart object to a string to send
        server.sendmail(email, send_to_email, text)
        server.quit()
        pass
    except:
        return("[Sent Email]: Email or Password Incorrect")
        pass
    pass
    return("[Sent Email]: Done")

def C_log(filename):
    filename = filename + ".txt"
    path = "./" + filename
    if os.path.exists(path) == True:
        os.remove(path)
        log = open(filename,"x")
        log.close()
    else:
        log = open(filename,"x")
        log.close()
        pass
        pass
    pass
def C_Log_A(file,txt):
    file = file + ".txt"
    path = "./" + file
    log = open(path,"a")
    log.write(txt + "\n")
    log.close()
    pass

def C_Log_Br(file):
    file = file + ".txt"
    path = "./" + file
    log = open(path,"a")
    log.write("\n")
    log.close()
    pass