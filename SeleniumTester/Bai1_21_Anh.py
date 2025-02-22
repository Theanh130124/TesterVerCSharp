

from selenium import webdriver
from selenium.webdriver.chrome.service import Service
from selenium.webdriver.common.by import By

kw_21_Anh = input("Nhap tu khoa = ")

driver = webdriver.Chrome(service=Service('.venv/chromedriver.exe'))
driver.get('https://www.google.com/')

# lấy element
#Do name cố định
el = driver.find_element(By.NAME , 'q')
#Gửi dữ liệu lên
el.send_keys(kw_21_Anh)

#Khi bấm enter
el.submit()

results = driver.find_elements(By.CSS_SELECTOR, '.g h3') #Do .g ta thấy của google là cố định
for r in results:
    print(r.text)
driver.quit()