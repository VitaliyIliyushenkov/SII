Telegram Bot: Новости, Погода и Курсы Валют
Этот проект представляет собой Telegram-бота, который предоставляет пользователям информацию о новостях, погоде и курсах валют.
Бот реализован на Python с использованием библиотеки python-telegram-bot.

🚀 Функционал:

1. 📰 Новости: Получение последних заголовков с использованием NewsAPI.
2. ☁️ Погода: Информация о текущей погоде через WeatherAPI.
3. 💱 Курсы валют: Конвертация валют с использованием ExchangeRate-API.

🔑 Генерация токенов:

1. Telegram Bot Token: Создать бота через BotFather.
2. NewsAPI Token: https://newsapi.org/
3. ExchangeRate-API Token: https://app.exchangerate-api.com/
4. WeatherAPI Token: https://www.weatherapi.com/

🛠️ Установка и настройка
1. Склонируйте проект:

    git clone https://github.com/VitaliyIliyushenkov/SII.git

2. Установите зависимости (Python версия 3.12.0 или выше):

    python -m venv venv
    venv\Scripts\activate   
    pip install -r requirements.txt

3. Измените токены API:

    TOKEN=<ваш_токен_телеграм_бота>
    NEWS_API_TOKEN=<ваш_токен_для_newsapi>
    EXCHANGE_API_TOKEN=<ваш_токен_для_exchangerate_api>
    WEATHER_API_TOKEN=<ваш_токен_для_weatherapi>

4. Запуск проекта:

    python main.py
