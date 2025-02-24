from sys import executable

from select import error
from selenium import webdriver
from selenium.common import NoSuchElementException
from selenium.webdriver.chrome.service import Service
from selenium.webdriver.common.by import By


#Lấy title , description , url_image
driver = webdriver.Chrome(service=Service(".venv/chromedriver.exe"))

driver.get("https://vnexpress.net/")

# print(driver.title)#Lay cai tieu de

articles = driver.find_elements(By.CSS_SELECTOR,"article.item-news")

for index, item in enumerate(articles,start =1):
    if index > 10 :
        break
    try:
        title = item.find_element(By.CSS_SELECTOR,"h3").text
        print(title)
        description = item.find_element(By.CSS_SELECTOR,".description").text
        print(description)
        url_img = item.find_element(By.CSS_SELECTOR,".thumb img").get_attribute("src")
        print(url_img)
        print("===============================")
    except NoSuchElementException as er:
        print(er)


# print(driver.page_source) # in ra file source
driver.close()