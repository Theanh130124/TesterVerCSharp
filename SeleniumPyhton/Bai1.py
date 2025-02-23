
from select import error
from selenium import webdriver
from selenium.common import NoSuchElementException
from selenium.webdriver.chrome.service import Service
from selenium.webdriver.common.by import By
import time


kw = input('Nhap vao tu khoa ban muon tim kiem')
driver = webdriver.Chrome(service=Service(".venv/chromedriver.exe"))

driver.get("https://www.google.com/")

items = driver.find_element(By.NAME,"q")
items.send_keys(kw) #Gui theo send_keys(kw)
items.submit()#Khi bam gui
time.sleep(15)  # Chờ 2 giây để Google load kết quả -> de xac nhan khong phai la robot

results = driver.find_elements(By.CSS_SELECTOR,'.g')  # lay class g

for res in results:
    try:
        title_bai1 = res.find_element(By.TAG_NAME,'h3').text
        print(title_bai1)
        url_bai1 = res.find_element(By.TAG_NAME,'a').get_attribute("href")
        print(url_bai1)
        print("=============================================")
    except NoSuchElementException:
        print(error)




driver.close()