*** Settings ***
Library  sentemail.py

*** Test Cases ***
Test Send Email
    C Log  Log
    C Log A  Log  Test Email
    C Log Br  Log
    C Log A  Log  Work!
    Sent Email  Censor_Email  Censor_Password  Censor_Email  This is Test Sent Email  Work  ./Log.txt