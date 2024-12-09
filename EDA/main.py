import pandas as pd
import matplotlib.pyplot as plt

# 1. Загрузка и первичный осмотр данных
data = pd.read_csv('Sales-Analysis-Dataset/Sales_April_2019.csv')
print(data.head())

# 2. Обработка пропущенных значений (удаление)
print(data.isnull().sum())
data.dropna(inplace=True)

# 3. Анализ распределения переменных (гистограмма)
data['Price Each'] = pd.to_numeric(data['Price Each'], errors='coerce')
plt.hist(data['Price Each'], bins=20, color='blue', alpha=0.7)
plt.xlabel('Цена за единицу')
plt.ylabel('Частота')
plt.title('Распределение цен за единицу товара')
plt.show()

# 4. Исследование корреляций (связь Price Each и Quantity Ordered)
data['Quantity Ordered'] = pd.to_numeric(data['Quantity Ordered'], errors='coerce')
correlation = data['Price Each'].corr(data['Quantity Ordered'])
print("Correlation between Price Each and Quantity Ordered:", correlation)

# 5. Выявление выбросов (ящик с усами для Quantity Ordered)
plt.boxplot(data['Quantity Ordered'].dropna())
plt.ylabel('Количество заказано')
plt.title('Ящик с усами: Анализ выбросов в количестве заказов')
plt.show()

# 6. Изучение категориальных переменных (популярность продуктов)
product_counts = data['Product'].value_counts()
product_counts.plot(kind='bar', color='orange')
plt.xlabel('Продукт')
plt.ylabel('Частота')
plt.title('Частота продаж продуктов')
plt.xticks(rotation=45)
plt.show()

# 7. Визуализация результатов
plt.figure(figsize=(12, 8))

plt.subplot(2, 2, 1)
plt.hist(data['Price Each'], bins=20, color='blue', alpha=0.7)
plt.xlabel('Цена за единицу')
plt.ylabel('Частота')
plt.title('Распределение цен за единицу товара')

plt.subplot(2, 2, 2)
plt.scatter(data['Price Each'], data['Quantity Ordered'], color='green')
plt.xlabel('Цена за единицу')
plt.ylabel('Количество заказано')
plt.title('Диаграмма рассеяния: цена и количество')

plt.subplot(2, 2, 3)
plt.boxplot(data['Quantity Ordered'].dropna())
plt.ylabel('Количество заказано')
plt.title('Анализ выбросов в количестве заказов')

plt.subplot(2, 2, 4)
product_counts = data['Product'].value_counts()
product_counts.plot(kind='bar', color='orange')
plt.xlabel('Продукт')
plt.ylabel('Частота')
plt.title('Частота продаж продуктов')
plt.xticks(rotation=45)

plt.tight_layout()
plt.show()








