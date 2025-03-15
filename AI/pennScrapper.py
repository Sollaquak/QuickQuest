#import correct library packages
from bs4 import BeautifulSoup
import requests

#get html data from penn state website
url = 'https://www.psu.edu/resources/first-year-students/requirements'
html_text = requests.get(url,timeout=120).text
soup = BeautifulSoup(html_text, "lxml")
title = soup.find('h1').text
tables = soup.find('div', class_= 'theme-cache-1oxbgxm')
if tables:
    for table in tables:
        print(table)
else:
    print("no table found")

'''
all_text = soup.find_all('p')
for texts in all_text:
    print(texts.text)
'''
#to help debug


