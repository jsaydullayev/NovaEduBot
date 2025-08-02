using System.Drawing;
using System.Net.NetworkInformation;

namespace NovaEduBot;
public static class BotMessages
{
    public const string WelcomeMessage = "🚀 Edu Nova – Kelajak kasblari makoni! " +
        "\r\n\r\nBiz bilan birgalikda yangi kasb va bilimlarni o‘rganing: " +
        "\r\n\r\n📦 Logistika \r\n🛍 Uzum Market \r\n🤖 Sun’iy intellekt (AI) " +
        "\r\n🌍 Til kurslari \r\n\r\n🎯 Maqsadimiz – sizni zamonaviy va daromadli kasblar bilan ta’minlash! " +
        "\r\n\r\n📲 Bugun ro‘yxatdan o‘ting va kelajak sari birinchi qadamni qo‘ying! \r\n+998996812100" +
        "\r\n+998958612100\r\n\r\nhttps://t.me/edunova_navoiy\r\n\r\nhttps://t.me/edunova_navoiy_gruppa";

    public const string LogisticsCourseInfo = "LOGISTIKA KURSI – 2 HAFTADA PROFESSIONALLIK" +
        "\r\n\r\n🚛 Mahsulot yetkazib berish, ombor yuritish, vaqtingizni boshqarish, narxlarni optimallashtirish – bularni hammasini 0 dan o‘rganasiz!" +
        "\r\n\r\n💼 Kurs kimlar uchun?\r\n• 2 haftadan kiyin pul topishni boshlashni xoxlaganlar " +
        "\r\n• Kelajakda kompaniya ochmoqchilar\r\n• Ish topmoqchi bo‘lgan yoshlar uchun!" +
        "\r\n\r\n🎓 Kurs natijasi:\r\n• Kurs yakunida 100% daromadga chiqish." +
        "\r\n• Amaliy topshiriqlar.\r\n• Ishga kirishda yordam!" +
        "\r\n\r\n🔥 Sifat, tezlik va foyda — barchasi bu kursda bor!" +
        "\r\n\r\n📲 Bugun ro‘yxatdan o‘ting va kelajak sari birinchi qadamni qo‘ying! ";


    public const string UzumMarketCourseInfo = "🔵  UZUM MARKET KURSI – A DAN Z GACHA\r\n" +
        "📦 Uzum’da sotishni o‘rganmoqchimisiz?\r\nU holda bu kurs aynan siz uchun! " +
        "\r\n\r\nBiz sizga:\r\n\r\n✅ Mahsulot joylash" +
        "\r\n✅ Sarlavha, ta’rif, rasm, narxni to‘g‘ri qo‘yish" +
        "\r\n✅ Sotuvni oshirish sirlari\r\n✅ Reklama va tendensiyalarni tushunish" +
        "\r\n✅ Va eng asosiysi – foyda qilishni o‘rgatamiz!" +
        "\r\n\r\n🎯 Natija: Ko‘pchilik talabalarimiz kurs davomida ham pul ishlashni boshlagan!" +
        "\r\n💰 Siz ham istaysizmi o‘z daromadingizni 2-3 baravar oshirishni?" +
        "\r\n🚀 Unda joyingizni band qiling!\r\n\r\n\U0001f7e3 Joylar soni cheklangan!     " +
        "\r\n\r\n📲 Bugun ro‘yxatdan o‘ting va kelajak sari birinchi qadamni qo‘ying";


    public const string EnglishCourseInfo = "🔵  UZUM MARKET KURSI – A DAN Z GACHA" +
        "\r\n📦 Uzum’da sotishni o‘rganmoqchimisiz?" +
        "\r\nU holda bu kurs aynan siz uchun! " +
        "\r\n\r\nBiz sizga:\r\n\r\n✅ Mahsulot joylash" +
        "\r\n✅ Sarlavha, ta’rif, rasm, narxni to‘g‘ri qo‘yish" +
        "\r\n✅ Sotuvni oshirish sirlari\r\n✅ Reklama va tendensiyalarni tushunish" +
        "\r\n✅ Va eng asosiysi – foyda qilishni o‘rgatamiz!" +
        "\r\n\r\n🎯 Natija: Ko‘pchilik talabalarimiz kurs davomida ham pul ishlashni boshlagan!" +
        "\r\n💰 Siz ham istaysizmi o‘z daromadingizni 2-3 baravar oshirishni?" +
        "\r\n🚀 Unda joyingizni band qiling!\r\n\r\n\U0001f7e3 Joylar soni cheklangan!" +
        "\r\n\r\n📲 Bugun ro‘yxatdan o‘ting va kelajak sari birinchi qadamni qo‘ying";


    public const string AI_CourseInfo = "🔵  UZUM MARKET KURSI – A DAN Z GACHA" +
        "\r\n📦 Uzum’da sotishni o‘rganmoqchimisiz?\r\nU holda bu kurs aynan siz uchun! " +
        "\r\n\r\nBiz sizga:\r\n\r\n✅ Mahsulot joylash\r\n✅ Sarlavha, ta’rif, rasm, narxni to‘g‘ri qo‘yish" +
        "\r\n✅ Sotuvni oshirish sirlari\r\n✅ Reklama va tendensiyalarni tushunish" +
        "\r\n✅ Va eng asosiysi – foyda qilishni o‘rgatamiz!" +
        "\r\n\r\n🎯 Natija: Ko‘pchilik talabalarimiz kurs davomida ham pul ishlashni boshlagan!" +
        "\r\n💰 Siz ham istaysizmi o‘z daromadingizni 2-3 baravar oshirishni?\r\n🚀 Unda joyingizni band qiling!" +
        "\r\n\r\n\U0001f7e3 Joylar soni cheklangan!     " +
        "\r\n\r\n📲 Bugun ro‘yxatdan o‘ting va kelajak sari birinchi qadamni qo‘ying";

}