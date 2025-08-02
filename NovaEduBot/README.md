# NovaEduBot

Telegram boti - ta'lim kurslari uchun.

## Yangi funksionallik

### Rasm bilan xabar yuborish

Endi `/start` buyrug'i chaqirilganda WelcomeMessage bilan birga rasm ham yuboriladi.

### Fayllar tuzilishi

- `info.json` - rasmlar va matnlar uchun konfiguratsiya fayli
- `InfoService.cs` - JSON fayldan ma'lumotlarni o'qish va yozish uchun
- `Info.cs` - ma'lumotlar modeli

### info.json faylini sozlash

```json
{
  "Text": "WelcomeMessage",
  "ImageUrl": "https://i.postimg.cc/5tVmjrsD/photo-2025-08-01-23-44-40.jpg"
}
```

- `Text` - qaysi xabar uchun rasm kerakligini belgilaydi
- `ImageUrl` - rasm URL manzili

### Xavfsizlik

Bot tokeni kod ichida emas, tashqi fayldan o'qiladi (xotiraga asoslanib).

## O'rnatish

1. `info.json` faylini to'g'ri rasm URL bilan sozlang
2. Bot tokenini to'g'ri o'rnating
3. Dasturni ishga tushiring

## Xatoliklar

Agar rasm yuborishda xatolik bo'lsa, bot avtomatik ravishda faqat matn yuboradi va xatolik haqida ma'lumot beradi. 