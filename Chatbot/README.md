Telegram Bot: Новости, Погода и Курсы Валют
Этот проект представляет собой Telegram-бота, который предоставляет пользователям информацию о новостях, погоде и курсах валют. Бот реализован на Python с использованием библиотеки python-telegram-bot

🚀 Функционал
📰 Новости: Получение последних заголовков с использованием NewsAPI.
☁️ Погода: Информация о текущей погоде через WeatherAPI.
💱 Курсы валют: Конвертация валют с использованием ExchangeRate-API.

🔑 Генерация токенов
Другой пользователь должен создать аккаунты на указанных сервисах и получить свои токены:

Telegram Bot Token: Создать бота через BotFather.
NewsAPI Token: https://newsapi.org/
ExchangeRate-API Token: https://app.exchangerate-api.com/
WeatherAPI Token: https://www.weatherapi.com/

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