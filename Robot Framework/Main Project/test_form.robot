*** Settings ***
Documentation     A test suite with a single test for valid login.
...
...               This test has a workflow that is created using keywords in
...               the imported resource file.
Resource          aksorn_resource.robot
Library           SeleniumLibrary

*** Test Cases ***
เริ่มการทดสอบ
    เข้าเว็ป

หน้าที่1
    ใส่รูป
    เงินเดือนที่ต้องการ
    คำนำหน้า
    ชื่อ
    นามสกุล
    ชื่อเล่น
    TITLE
    NAME
    SURNAME
    NICKNAME
    วัน/เดือน/ปีเกิด
    ส่วนสูง/น้ำหนัก
    สัญชาติ
    บัตรประชาชน
    อีเมล
    เบอร์โทรศัพท์/มือถือ
    ที่อยู่ตามทะเบียนบ้าน
    ที่อยู่ปัจจุบัน
    สื่อสังคมออนไลน์
    ต่อไป-หน้าที่1

หน้าที่2
    สถานทางการทหาร
    สถานภาพ
    จำนวนบุตร
    บุตรคนที่1
    บุตรคนที่2
    ต่อไป-หน้าที่2

หน้าที่3
    บิดา
    มารดา
    พี่น้อง
    ต่อไป-หน้าที่3

หน้าที่4
    ประวัติการศึกษา
    ประวัติการทำงาน
    ต่อไป-หน้าที่4

หน้าที่5
    ทักษะทางด้านภาษา
    ทักษะคอมพิวเตอร์
    ต่อไป-หน้าที่5

จบการทดสอบ
    ปิดเว็ป
   













