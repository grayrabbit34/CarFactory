# Araba Üretim Konsol Uygulaması

Bu proje, bir araba fabrikasında araba üretimini simüle eden bir C# konsol uygulamasıdır. Kullanıcıdan alınan bilgilerle `Car` sınıfı üzerinden araba nesneleri oluşturulur ve bunlar bir listeye kaydedilir.

---

## 🚗 Özellikler

- Kullanıcıya araba üretmek isteyip istemediği sorulur (`e` / `h` girişi).
- Her araba için kullanıcıdan şu bilgiler alınır:
  - Seri Numarası
  - Marka
  - Model
  - Renk
  - Kapı Sayısı (yalnızca sayı kabul edilir)
- Kapı sayısına sayısal olmayan bir değer girildiğinde:
  - Uyarı mesajı gösterilir.
  - `goto` komutuyla tekrar giriş istenir.
- Arabanın üretim tarihi sistem saatiyle otomatik olarak atanır (`DateTime.Now`).
- Kullanıcı birden fazla araba üretebilir.
- Tüm arabalar `List<Car>` içinde saklanır.
- Kullanıcı işlem yapmak istemediğinde, liste yazdırılır:
  - Seri Numarası ve Marka bilgileri konsola yazdırılır.
- Uygulama, `return` komutu ile sonlandırılır.

---

## 🛠️ Teknik Bilgiler

- C# programlama dili kullanılmıştır.
- `goto` komutu yalnızca kapı sayısı hatalı girildiğinde kullanılmıştır.
- Diğer tüm akış kontrolleri `while` döngüleri ve `return` komutu ile sağlanmıştır.
- `List<Car>` global tanımlanarak birden fazla araba nesnesi aynı koleksiyonda tutulmuştur.
- Hatalı girişler `try-catch` blokları ile yakalanmıştır.
