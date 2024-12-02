import requests
from telegram import Update, InlineKeyboardButton, InlineKeyboardMarkup
from telegram.ext import ApplicationBuilder, CommandHandler, CallbackQueryHandler, ContextTypes

# Токены API
NEWS_API_TOKEN=<ваш_токен_для_newsapi>
EXCHANGE_API_TOKEN=<ваш_токен_для_exchangerate_api>
WEATHER_API_TOKEN=<ваш_токен_для_weatherapi>


# Получение новостей
def get_latest_news():
    url = f"https://newsapi.org/v2/top-headlines?country=us&apiKey={NEWS_API_TOKEN}"
    response = requests.get(url)
    if response.status_code == 200:
        articles = response.json().get("articles", [])
        return articles[:5]
    return []


# Получение курсов валют
def get_exchange_rates():
    url = f"https://v6.exchangerate-api.com/v6/{EXCHANGE_API_TOKEN}/latest/USD"
    response = requests.get(url)
    if response.status_code == 200:
        rates = response.json().get("conversion_rates", {})
        return {k: rates[k] for k in ['EUR', 'GBP', 'JPY']}
    return {}


# Получение погоды
def get_weather(city="London"):
    url = f"http://api.weatherapi.com/v1/current.json?key={WEATHER_API_TOKEN}&q={city}&aqi=no"
    response = requests.get(url)
    if response.status_code == 200:
        weather = response.json()
        return {
            "city": weather.get("location", {}).get("name"),
            "temp": weather.get("current", {}).get("temp_c"),
            "description": weather.get("current", {}).get("condition", {}).get("text")
        }
    return {}


# Команда новостей
async def news(update: Update, context: ContextTypes.DEFAULT_TYPE) -> None:
    articles = get_latest_news()
    if not articles:
        await update.message.reply_text("Не удалось получить новости. Попробуйте позже.")
        return

    news_text = "Вот последние новости:\n\n"
    for i, article in enumerate(articles, start=1):
        title = article.get("title", "Без заголовка")
        url = article.get("url", "#")
        news_text += f"{i}. [{title}]({url})\n"

    await update.message.reply_text(news_text, parse_mode="Markdown")


# Команда курсов валют
async def exchange(update: Update, context: ContextTypes.DEFAULT_TYPE) -> None:
    rates = get_exchange_rates()
    if not rates:
        await update.message.reply_text("Не удалось получить курсы валют. Попробуйте позже.")
        return

    rates_text = "Курсы валют к USD:\n"
    for currency, rate in rates.items():
        rates_text += f"💵 {currency}: {rate}\n"

    await update.message.reply_text(rates_text)


# Команда погоды
async def weather(update: Update, context: ContextTypes.DEFAULT_TYPE) -> None:
    weather_data = get_weather()
    if not weather_data:
        await update.message.reply_text("Не удалось получить данные о погоде. Попробуйте позже.")
        return

    weather_text = (
        f"🏙️ Город: {weather_data['city']}\n"
        f"🌡️ Температура: {weather_data['temp']}°C\n"
        f"☁️ Описание: {weather_data['description']}"
    )
    await update.message.reply_text(weather_text)


# Стартовое сообщение с кнопками
async def start(update: Update, context: ContextTypes.DEFAULT_TYPE) -> None:
    keyboard = [
        [InlineKeyboardButton("📰 Новости", callback_data="news")],
        [InlineKeyboardButton("💱 Курсы валют", callback_data="exchange")],
        [InlineKeyboardButton("☁️ Погода", callback_data="weather")]
    ]
    reply_markup = InlineKeyboardMarkup(keyboard)
    if update.message:
        await update.message.reply_text("Выберите категорию:", reply_markup=reply_markup)
    elif update.callback_query:
        await update.callback_query.edit_message_text("Выберите категорию:", reply_markup=reply_markup)


# Обработка нажатий на кнопки
async def button_handler(update: Update, context: ContextTypes.DEFAULT_TYPE) -> None:
    query = update.callback_query
    await query.answer()

    if query.data == "news":
        articles = get_latest_news()
        if not articles:
            await query.edit_message_text("Не удалось получить новости. Попробуйте позже.")
            return

        news_text = "Вот последние новости:\n\n"
        for i, article in enumerate(articles, start=1):
            title = article.get("title", "Без заголовка")
            url = article.get("url", "#")
            news_text += f"{i}. [{title}]({url})\n"

        keyboard = [[InlineKeyboardButton("🔄 Назад", callback_data="back")]]
        reply_markup = InlineKeyboardMarkup(keyboard)
        await query.edit_message_text(news_text, parse_mode="Markdown", reply_markup=reply_markup)

    elif query.data == "exchange":
        rates = get_exchange_rates()
        if not rates:
            await query.edit_message_text("Не удалось получить курсы валют. Попробуйте позже.")
            return

        rates_text = "Курсы валют к USD:\n"
        for currency, rate in rates.items():
            rates_text += f"💵 {currency}: {rate}\n"

        keyboard = [[InlineKeyboardButton("🔄 Назад", callback_data="back")]]
        reply_markup = InlineKeyboardMarkup(keyboard)
        await query.edit_message_text(rates_text, reply_markup=reply_markup)

    elif query.data == "weather":
        weather_data = get_weather()
        if not weather_data:
            await query.edit_message_text("Не удалось получить данные о погоде. Попробуйте позже.")
            return

        weather_text = (
            f"🏙️ Город: {weather_data['city']}\n"
            f"🌡️ Температура: {weather_data['temp']}°C\n"
            f"☁️ Описание: {weather_data['description']}"
        )

        keyboard = [[InlineKeyboardButton("🔄 Назад", callback_data="back")]]
        reply_markup = InlineKeyboardMarkup(keyboard)
        await query.edit_message_text(weather_text, reply_markup=reply_markup)

    elif query.data == "back":
        await start(update, context)


# Основная функция
def main():
    TOKEN = <ваш_токен_телеграм_бота>
    application = ApplicationBuilder().token(TOKEN).build()

    application.add_handler(CommandHandler("start", start))
    application.add_handler(CommandHandler("news", news))
    application.add_handler(CommandHandler("exchange", exchange))
    application.add_handler(CommandHandler("weather", weather))
    application.add_handler(CallbackQueryHandler(button_handler))

    print("Бот запущен...")
    application.run_polling()


if __name__ == "__main__":
    main()
