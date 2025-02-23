# from sys import executable
#
# from select import error
# from selenium import webdriver
# from selenium.common import NoSuchElementException
# from selenium.webdriver.chrome.service import Service
# from selenium.webdriver.common.by import By
#
# driver = webdriver.Chrome(service=Service(".venv/chromedriver.exe"))
#
# driver.get("https://vnexpress.net/")
#
# print(driver.title)#Lay cai tieu de
#
# articles = driver.find_elements(By.CSS_SELECTOR,"article.item-news")
#
# for item in articles:
#     try:
#         title = item.find_element(By.TAG_NAME,"h3").text
#         print(title)
#         print("===============================")
#     except NoSuchElementException:
#         print(error)
#
#
# # print(driver.page_source) # in ra file source
# driver.close()