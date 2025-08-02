using NovaEduBot;
using Telegram.Bot;
using Telegram.Bot.Types.ReplyMarkups;

// Tokenni tashqi fayldan o'qish uchun
string botToken = "8424330974:AAEe6C_Gbb6aOcLgywC3ueTq52HIjc00d2U";



var courses = new Dictionary<string, string>
{
    { "Logistika", BotMessages.LogisticsCourseInfo },
    { "Ingliz tili", BotMessages.EnglishCourseInfo },
    { "Uzum market", BotMessages.UzumMarketCourseInfo },
    { "Sun'iy intelekt", BotMessages.AI_CourseInfo }
};

var userStates = new Dictionary<long, string>();
var userData = new Dictionary<long, Dictionary<string, string>>();

var botClient = new TelegramBotClient(botToken);

async Task HandleStartAsync(long chatId)
{
    var buttons = courses.Keys
    .Select(k => new[] { new KeyboardButton(k) })
    .ToArray();

    string ImageUrl = "https://i.postimg.cc/5tVmjrsD/photo-2025-08-01-23-44-40.jpg";

        try
        {
            Console.WriteLine($"Rasm yuborishga urinish: {ImageUrl}");
            await botClient.SendPhoto(
                chatId,
                photo: ImageUrl,
                caption: BotMessages.WelcomeMessage,
                replyMarkup: new ReplyKeyboardMarkup(keyboard: buttons)
                {
                    ResizeKeyboard = true
                }
            );
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Rasm yuborishda xatolik: {ex.Message}");
            // Rasm yuborishda xatolik bo'lsa, faqat matn yuboramiz
            await botClient.SendMessage(
                chatId,
                BotMessages.WelcomeMessage,
                replyMarkup: new ReplyKeyboardMarkup(keyboard: buttons)
                {
                    ResizeKeyboard = true
                }
            );
        }

    userStates[chatId] = "start";
}

async Task HandleCourseAsync(long chatId, string courseName)
{
    userStates[chatId] = "course";
    userData[chatId] = new Dictionary<string, string> { ["course"] = courseName };
    await botClient.SendMessage(
        chatId,
        $"{courses[courseName]}\n\nRegistratsiya uchun tugmani bosing.",
        replyMarkup: new ReplyKeyboardMarkup(
        new[]
        {
            new[]
            {
                new KeyboardButton("📝 Registratsiya uchun tugmani bosing")
            },
            new[]
            {
                new KeyboardButton("🔙 Orqaga")
            }
        })
        {
            ResizeKeyboard = true
        }
);
}

async Task AskNameAsync(long chatId)
{
    userStates[chatId] = "ask_name";
    await botClient.SendMessage(chatId, "Ism-Familiyangizni kiriting:", replyMarkup: new ReplyKeyboardRemove());
}

async Task AskDistrictAsync(long chatId, string name)
{
    userData[chatId]["name"] = name;
    userStates[chatId] = "ask_district";
    await botClient.SendMessage(chatId, "Qaysi tumanda yashaysiz?");
}

async Task AskPhoneAsync(long chatId, string district)
{
    userData[chatId]["district"] = district;
    userStates[chatId] = "ask_phone";
    await botClient.SendMessage(chatId, "Telefon raqamingizni kiriting:");
}

async Task FinishRegistrationAsync(long chatId, string phone)
{
    userData[chatId]["phone"] = phone;
    userStates[chatId] = "done";
    await botClient.SendMessage(
        chatId,
        "Ma'lumotlaringiz qabul qilindi!\nSizga operatorlarimiz javob yozishadi.",
        replyMarkup: new ReplyKeyboardMarkup(
    new[]
    {
        new[]
        {
            new KeyboardButton("📚 Kurslar haqida ma'lumot")
        }
    })
        {
            ResizeKeyboard = true
        }
    );
    long channelId = -1002858505104;
    string userInfo = $"Yangi registratsiya:\n" +
                      $"Kurs: {userData[chatId]["course"]}\n" +
                      $"Ism: {userData[chatId]["name"]}\n" +
                      $"Tuman: {userData[chatId]["district"]}\n" +
                      $"Telefon: {userData[chatId]["phone"]}";
    await botClient.SendMessage(channelId, userInfo);
}

// --- Asosiy handler ---
botClient.StartReceiving(
    async (bot, update, token) =>
    {
        if (update.Message is not { } message) return;
        var chatId = message.Chat.Id;
        var text = message.Text;

        if (text == "/start")
        {
            await HandleStartAsync(chatId);
            return;
        }
        if (courses.ContainsKey(text))
        {
            await HandleCourseAsync(chatId, text);
            return;
        }
        if (text == "📝 Registratsiya uchun tugmani bosing")
        {
            await AskNameAsync(chatId);
            return;
        }
        if (text == "🔙 Orqaga")
        {
            await HandleStartAsync(chatId);
            return;
        }
        if (text == "📚 Kurslar haqida ma'lumot")
        {
            await HandleStartAsync(chatId);
            return;
        }
        if (userStates.TryGetValue(chatId, out var state))
        {
            switch (state)
            {
                case "ask_name":
                    await AskDistrictAsync(chatId, text);
                    break;
                case "ask_district":
                    await AskPhoneAsync(chatId, text);
                    break;
                case "ask_phone":
                    await FinishRegistrationAsync(chatId, text);
                    break;
            }
        }
    },
    (bot, exception, token) =>
    {
        Console.WriteLine(exception);
        return Task.CompletedTask;
    }
);

Console.WriteLine("Bot ishga tushdi. To'xtatish uchun Ctrl+C bosing.");
await Task.Delay(-1);