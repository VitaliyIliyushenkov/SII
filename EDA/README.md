## Описание проекта
Данный проект представляет собой проведение разведочного анализа данных (EDA) на основе реального датасета о продажах электронных товаров. В ходе анализа изучается структура данных, распределение переменных, выявляются зависимости, а также обрабатываются выбросы и пропущенные значения. Проект ориентирован на улучшение понимания данных и их подготовку для дальнейшего использования, например, в машинном обучении или бизнес-аналитике.

## 🚀 Используемый датасет
**Название датасета:** Sales Analysis Dataset

**Описание:** Данные о продажах электронных товаров в США. Содержит информацию о заказах, включая:

1. Идентификатор заказа (Order ID)
2. Название продукта (Product)
3. Количество заказанного (Quantity Ordered)
4. Цена за единицу (Price Each)
5. Дата заказа (Order Date)
6. Адрес покупки (Purchase Address)

## Основные шаги анализа
**1. Загрузка данных**

Импорт данных и первичный осмотр: вывод структуры таблицы, просмотр первых строк.

**2. Обработка пропущенных значений**

Выявление и удаление строк с пропущенными данными для обеспечения корректности анализа.

**3. Анализ распределения переменных**

Построение гистограмм для числовых переменных (например, Price Each).

**4. Исследование корреляций**

Изучение зависимости между ценой за единицу и количеством заказов.

**5. Выявление выбросов**

Использование ящиков с усами (boxplot) для нахождения аномалий в данных.

**6. Изучение категориальных переменных**

Анализ распределения популярности товаров.

**7. Обобщенная визуализация**

Построение нескольких графиков для представления ключевых результатов анализа.

## Используемые технологии
1. Python: основной язык программирования.
2. Pandas: для работы с табличными данными.
3. Matplotlib: для построения визуализаций.
4. Jupyter Notebook (опционально): для интерактивного выполнения анализа.

## 🛠️ Установка и настройка
**1. Склонируйте проект:**

    git clone https://github.com/VitaliyIliyushenkov/SII.git

**2. Установите зависимости (Python версия 3.12.0 или выше):**

    python -m venv venv
    venv\Scripts\activate   
    pip install -r requirements.txt

**3. Запуск проекта:**

    python main.py
