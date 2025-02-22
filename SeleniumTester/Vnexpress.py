from selenium import webdriver
from selenium.webdriver.chrome.service import Service
from selenium.webdriver.common.by import By



driver = webdriver.Chrome(service=Service('.venv/chromedriver.exe'))
driver.get('https://vnexpress.net/')

articles = driver.find_elements(By.CSS_SELECTOR, '#automation_TV0.item-news')
for article in articles:
    try:
        title = article.find_element(By.CLASS_NAME,'title-news').text
    except:
        pass
    else:
        print(title)
        print("a")

driver.quit()