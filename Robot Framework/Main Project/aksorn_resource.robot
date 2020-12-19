*** Settings ***
Documentation     A resource file with reusable keywords and variables.
...
...               The system specific keywords created here form our own
...               domain specific language. They utilize keywords provided
...               by the imported SeleniumLibrary.
Library           SeleniumLibrary

*** Variables ***
${SERVER}         localhost:7272
${BROWSER}        Firefox
${DELAY}          0
${URL}      https://#############.co.th/######/#####/#####-10
*** Keywords ***
เข้าเว็ป
    Open Browser    ${URL}    ${BROWSER}
    Maximize Browser Window
    Set Selenium Speed    ${DELAY}

ใส่รูป
    Choose File     xpath:/html/body/div[1]/div[3]/div/div/form/div/div/div[1]/div[1]/input     ${CURDIR}\\unnamed.jpg

เงินเดือนที่ต้องการ
    Input Text      xpath:/html/body/div[1]/div[3]/div/div/form/div/div/div[1]/div[5]/div/div/input     1234

คำนำหน้า
    Select From List By Value       name:title_th       นาง

ชื่อ
    Input Text      xpath:/html/body/div[1]/div[3]/div/div/form/div/div/div[1]/div[8]/div/input         ดดดด

นามสกุล
    Input Text      xpath:/html/body/div[1]/div[3]/div/div/form/div/div/div[1]/div[9]/div/input         กกกก

ชื่อเล่น
    Input Text      name:nick_name_th        พพพพ

TITLE
    Select From List By Value       name:title_en       Mrs.

NAME
    Input Text      name:first_name_en       dddd

SURNAME
    Input Text      name:last_name_en        aaaa

NICKNAME
    Input Text      name:nick_name_en        pppp

วัน/เดือน/ปีเกิด
    Click Element      name:date_of_birth
    Select From List By Index   xpath:/html/body/div[2]/div/div/select[2]       40    
    Select From List By Index   xpath:/html/body/div[2]/div/div/select[1]       0 
    Click Element       xpath:/html/body/div[2]/table/tbody/tr[4]/td[4]/a   

ส่วนสูง/น้ำหนัก
    Input Text      height          200     
    Input Text      weight          200

สัญชาติ
    Input Text      name:nationality        อู่อั่น

บัตรประชาชน
    Input Text      id_card         1234567898765

อีเมล
    Input Text      name:email        qqqqqqqqqqqqqqqq@gmail.com

เบอร์โทรศัพท์/มือถือ
    Input Text      telephone         98765432
    Input Text      mobile         987654321

ที่อยู่ตามทะเบียนบ้าน
    Input Text      address_house_official_number         550/24
    Input Text      address_house_official_soi         a4
    Input Text      address_house_official_street         koi
    Input Text      address_house_official_district       the         
    Input Text      address_house_official_aumphur        ka        
    Input Text      address_house_official_province       mo        
    Input Text      address_house_official_postalcode       10401        
    Input Text      address_house_official_country       nice

ที่อยู่ปัจจุบัน
    Input Text      address_house_current_number         550/24
    Input Text      address_house_current_soi         a4
    Input Text      address_house_current_street         koi
    Input Text      address_house_current_district       the         
    Input Text      address_house_current_aumphur        ka        
    Input Text      address_house_current_province       mo            
    Input Text      address_house_current_postalcode       10401        
    Input Text      address_house_current_country       nice   

สื่อสังคมออนไลน์
    Input Text      name:line_account       china   
    Input Text      name:line_hours         000.0001
    Input Text      name:fb_account       china 
    Input Text      name:fb_hours         000.0001  

    Input Text      name:tt_account       china   
    Input Text      name:tt_hours         000.0001

    Input Text      name:other_social       Youtube  
    Input Text      name:other_social_account       china   
    Input Text      name:other_social_hours         000.0001
ต่อไป-หน้าที่1
    Click Element   xpath:/html/body/div[1]/div[3]/div/div/form/div/div/div[1]/div[44]/div/div 

สถานทางการทหาร
    Click Element   xpath:/html/body/div[1]/div[3]/div/div/form/div/div/div[3]/div[1]/div[2]/div[2]/div/div[1]
    Click Element   xpath:/html/body/div[1]/div[3]/div/div/form/div/div/div[3]/div[1]/div[2]/div[2]/div/div[2]
    Select From List By Index   xpath:/html/body/div[2]/div/div/select        15
    Click Link       xpath:/html/body/div[2]/table/tbody/tr[3]/td[4]/a

สถานภาพ
    Click Element       xpath:/html/body/div[1]/div[3]/div/div/form/div/div/div[3]/div[2]/div[2]/div[2]/div/label
    Select From List By Value       name:spouse_title       นาง / Mrs.
    Input Text       name:spouse_name   gg
    Input Text       name:spouse_lastname   bb
    Input Text       name:spouse_office     gg company
    Input Text       name:spouse_position     hr
    Input Text       name:spouse_email     gg@gmail.com
    Input Text       name:spouse_telephone     011111111
    Input Text       name:mobispouse_mobilele     0987654321
    Input Text       name:spouse_address            fbbhfhfhfjfjfjjfjf

จำนวนบุตร
    Select From List By Value       name:number_of_children       2
    Input Text      name:number_of_son        1
    Input Text      name:number_of_daughter        1

บุตรคนที่1
    Input Text      young_name1        q
    Input Text      young_lastname1        w
    Click Element   young_born_1
    Select From List By Index   xpath:/html/body/div[2]/div/div/select[2]       50
    Select From List By Index   xpath:/html/body/div[2]/div/div/select[1]       1
    Click Link      xpath:/html/body/div[2]/table/tbody/tr[3]/td[4]/a 

บุตรคนที่2
    Input Text      young_name2        r
    Input Text      young_lastname2        e
    Click Element   young_born_2        
    Select From List By Index   xpath:/html/body/div[2]/div/div/select[2]       40
    Select From List By Index   xpath:/html/body/div[2]/div/div/select[1]       3
    Click Link      xpath:/html/body/div[2]/table/tbody/tr[4]/td[4]/a

ต่อไป-หน้าที่2
    Click Element       xpath:/html/body/div[1]/div[3]/div/div/form/div/div/div[3]/div[3]/div/div[2]

บิดา
    Set Selenium Speed      1
    Input Text      father_name   k
    Input Text      father_lastname   kt
    Select From List By Value      father_birth_date   1970
    Set Selenium Speed      0
    Input Text      father_occupation   home
    Input Text      father_workplace   home
    Input Text      father_telephone  12345678 
    Input Text      father_mobile      123456789  
    Input Text      father_address      house 

มารดา
    Set Selenium Speed      1
    Input Text      mother_name   k
    Input Text      mother_lastname   kt
    Select From List By Value      mother_birth_date   1970
    Set Selenium Speed      0
    Input Text      mother_occupation   home
    Input Text      mother_workplace   home
    Input Text      mother_telephone  12345678 
    Input Text      mother_mobile      123456789  
    Input Text      mother_address      house 

พี่น้อง
    Set Selenium Speed      1
    Select From List By Value   count_family    2
    Input Text      number_of_your      2
    Select From List By Value       xpath:/html/body/div[1]/div[3]/div/div/form/div/div/div[4]/div[7]/div/div[2]/div/div[1]/div/select    นางสาว / Ms.
    Input Text      brethren_name_1         i
    Input Text      brethren_lastname_1         l
    Input Text      brethren_age_1         22
    Input Text      brethren_study_1         py
    Input Text      brethren_school_1         yy
    Input Text      brethren_position_1         good
    Input Text      brethren_workplace_1         nooo

ต่อไป-หน้าที่3
    Click Element       xpath:/html/body/div[1]/div[3]/div/div/form/div/div/div[4]/div[9]/div/div[2]

ประวัติการศึกษา
    Set Selenium Speed      0
    Input Text      xpath:/html/body/div[1]/div[3]/div/div/form/div/div/div[5]/div[1]/div[2]/div/div[1]/div[1]/div/input   height
    Input Text      xpath:/html/body/div[1]/div[3]/div/div/form/div/div/div[5]/div[1]/div[2]/div/div[1]/div[2]/div/input   gggg
    Input Text      xpath:/html/body/div[1]/div[3]/div/div/form/div/div/div[5]/div[1]/div[2]/div/div[2]/div[1]/div/input         jjj
    Input Text      xpath:/html/body/div[1]/div[3]/div/div/form/div/div/div[5]/div[1]/div[2]/div/div[2]/div[2]/div/input      5
    Select From List By Value   start_date_1    2010
    Select From List By Value   end_date_1    2013
    Input Text      xpath:/html/body/div[1]/div[3]/div/div/form/div/div/div[5]/div[1]/div[2]/div/div[3]/div/div/input   pppp
    Click button    xpath:/html/body/div[1]/div[3]/div/div/form/div/div/div[5]/div[2]/div/div[2]/button   

ประวัติการทำงาน
    Set Selenium Speed      2
    Click Element   start_date_work_2       
    Select From List By Index   xpath:/html/body/div[2]/div[1]/div/select[2]       50
    Select From List By Index   xpath:/html/body/div[2]/div[1]/div/select[1]       2

    Click Element       end_date_work_2       
    Select From List By Index   xpath:/html/body/div[2]/div[1]/div/select[2]       5
    Select From List By Index   xpath:/html/body/div[2]/div[1]/div/select[1]       2
    Set Selenium Speed      0

    Input Text      name:company_name[]   pppp
    Input Text      name:business_type[]   pppp
    Input Text      name:position[]   pppp
    Input Text      name:role[]   pppp
    Input Text      latest_salary_2   123456
    Input Text      name:reasons_leaving[]   123456
    
    Select From List By Value   date_training_1       1970
    Input Text      name:training_subject[]   asjiodas
    Input Text      name:training_place[]   asjiodas
ต่อไป-หน้าที่4
    Click button    btn_save_form_work

ทักษะทางด้านภาษา
    Set Selenium speed      1
    Select From List By Value   form-3-select       ดี
    Input Text      name:eng_name_test   asjiodas
    Input Text      name:eng_level_test   asjiodas
    Click Element      name:eng_year_test   
    Select From List By Index   xpath:/html/body/div[2]/div/div/select       5
    Click Link      xpath:/html/body/div[2]/table/tbody/tr[3]/td[4]/a
    Click Link      add_lang

    Input Text      name:language[]   asjiodas
    Select From List By Value   name:level_language[]       ดี
    Input Text      name:language_name_test[]   asjiodas
    Input Text      name:language_level_test[]   asjiodas
    Input Text      name:language_year_test[]   asjiodas
    Click Element       language_year_test_1
    Select From List By Index   xpath:/html/body/div[2]/div/div/select  6
    Click Link      xpath:/html/body/div[2]/table/tbody/tr[3]/td[4]/a
ทักษะคอมพิวเตอร์
    Select Checkbox     xpath:/html/body/div[1]/div[3]/div/div/form/div/div/div[7]/div[6]/div[1]/div[1]/div/div[1]/input
    Select From List By Value       xpath:/html/body/div[1]/div[3]/div/div/form/div/div/div[7]/div[6]/div[1]/div[2]/select      ดีมาก
    
    Select Checkbox     xpath:/html/body/div[1]/div[3]/div/div/form/div/div/div[7]/div[6]/div[6]/div[1]/div/div[1]/input
    Input Text          name:other_skills_computer      html
    Input Text          name:other_skill        IDK
    Input Text          name:hobby_holiday        gog
    Input Text          name:hobby_sport           gogl
    Input Text          name:hobby_other          gogle
ต่อไป-หน้าที่5
    Click Element       xpath:/html/body/div[1]/div[3]/div/div/form/div/div/div[7]/div[11]/div/div[2]

ปิดเว็ป
    Close Browser