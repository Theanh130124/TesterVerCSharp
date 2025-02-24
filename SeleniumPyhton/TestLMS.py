from operator import index
import json
from selenium import webdriver
from selenium.common import NoSuchElementException
from selenium.webdriver.chrome.service import Service
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import  WebDriverWait
from selenium.webdriver.support import  expected_conditions as ex
import time

from selenium.webdriver.support.select import Select

driver = webdriver.Chrome(service=Service(".venv/chromedriver.exe"))


driver.get("https://lms.ou.edu.vn/")
driver.implicitly_wait(5) #Chờ ngầm định 3s
driver.find_element(By.CLASS_NAME,'main-btn').click()
driver.find_element(By.CLASS_NAME,'login100-form-btn').click()

#Select_box ưu tiên dùng id
user_type = Select(driver.find_element(By.ID,"form-usertype"))
user_type.select_by_index(0) # 0 là sinh viên chính qui
user_name = driver.find_element(By.ID,'form-username')
pass_word = driver.find_element(By.ID,'form-password')
with open('data/account.json',encoding='utf-8') as f :
    user = json.load(f)
    user_name.send_keys(user['user'])
    pass_word.send_keys(user['pass'])
captcha_input = driver.find_element(By.NAME,'form-captcha')
captcha_code = input('Nhap capcha nhin thay vao')
captcha_input.send_keys(captcha_code)
driver.find_element(By.CLASS_NAME,'m-loginbox-submit-btn').click()
# driver.implicitly_wait(8) #Vì ajax -> cho nay cho het time luon
#Cho duoc thi dung luon
items = WebDriverWait(driver , 10).until(ex.presence_of_all_elements_located((By.CSS_SELECTOR,'a > span.multiline'))) #presence ... -> su xuat hien cua cac elements



# #course-info-container-1699-4 > div > div > a > span.multiline

# items = driver.find_elements(By.CSS_SELECTOR,'a span.multiline')# a > span.multiline khi span la con truc tiep cua the a , la the <a> roi toi the <span> luon khong co the trung gian
for item in items:
    title = item.text
    print(title)
driver.execute_script("window.scrollTo(0,300)")  #Viet o day vi ngta tat script tren web
driver.save_screenshot('img/lms_ou.png') #Chup man hinh

driver.close()