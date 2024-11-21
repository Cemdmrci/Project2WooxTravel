🛫 WoOx Travel
Bu proje M&Y Yazılım Eğitim Akademi Danışmanlık bünyesinde Murat Yücedağ eğitmenliği tarafından verilen ödev kapsamında ASP.NET MVC kullanılarak yapılan 2. projedir.

Projeye Genel Bakış
👤 Kullanıcı Arayüzü: Sayfa açıldığında kullanıcıyı -son eklenen 4 destinasyonun veritabanından dinamik olarak geldiği- bir slider/banner karşılıyor. Otomatik olarak değişen bannerlar arasında isterse kullanıcı da manuel olarak geçişler yapabiliyor. Banner üzerinde yer alan 'İncele' butonu aracılığıyla destinasyonun detay sayfasına gidebilme imkanı da bulunmaktadır. Slider/banner'ın hemen altında yer alan alanda ise tüm destinasyonların bir listesi yer almaktadır. Burada her sayfada 5 destinasyon olacak şekilde bir Sayfalama Yapısı kullanılmıştır. Son olarak ise kullanıcı isterse navbar üzerinde bulunan 'Rezervasyon Yap' butonuna tıklayıp karşısına çıkan 'Rezervasyon Oluşturma Pop-Up'ı aracılığıyla rezervasyon oluşturabilir. Bu pop-up'ı detaylıca incelememiz gerekirse kullanıcının bilgilerini girdiği ve kullanıcıya kolaylık sağlamak adına telefon numarası alanının giriş değerlerinin maskelenerek 0(000) 000 00 00 formatına getirildiği bir pop-up'tır.

🖱️ Admin Paneli: Site yöneticileri için geliştirilmiş olan bu panel üzerinde yöneticiler, onlar için planlanan işlemler sınırında sistemin her noktasına dokunabilmektedirler. Kullanıcı arayüzünün footer kısmında bulunan link aracılığıyla ulaşabildikleri 'Admin Giriş Ekranı' aracılığıyla yöneticiler kendi kullanıcı adı ve şifrelerini girerek admin paneline erişebilirler. Bilgilerini doğru girmedikleri takdirde ekranın sağ üst köşesinde 5 saniye duracak şekilde ayarlanan bir error sweetalert ile bilgilendiriliyorlar. Bilgilerini doğru bir şekilde girdikleri senaryoda ise karşılarına admin paneli Dashboard ekranı çıkmaktadır. Yönetici bu panelde sol menü yardımıyla yapmak istediği işlemleri gerçekleştirebilmektedir. İsterse Kategoriler, Destinasyonlar veya Rezervasyonlar üzerinde CRUD işlemleri yapabilirken isterse de 4 adet grafik sayesinde (Line, Bar, Pie ve Doughnut Grafikleri) sistemdeki datalarla hazırlanmış bilgileri görüntüleyebilmektedir. Ayrıca yöneticilere bu panel üzerinden Mesajlaşabilme İmkanı da sunulmuştur.

Kullanılan Teknolojiler ve Uygulamalar
✅ ASP.NET MVC
✅ Entity Framework
✅ Code First
✅ Microsoft SQL Server (MSSQL) Veritabanı
✅ HTML-CSS-Bootstrap
✅ Session
✅ Chart JS ile Line/Bar/Pie/Doughnut Grafikleri
✅ JS
✅ LINQ
✅ Input Alanında Telefon Numarası Maskeleme
✅ SweetAlert
✅ 3D Kredi Kartı ile Ödeme Tasarımı (Girilen kart numarasına göre MasterCard ise farklı Visa ise farklı bir arkaplan rengi oluşmaktadır. Ayrıca CVV kodunu yazarken kartın arka yüzü gözükmektedir.)
✅ Login/Logout İşlemleri
✅ Modal & Pop-Up
✅ Admin Paneli Üzerinden Mesajlaşabilme
✅ Widgets


Veritabanı Diyagramı
![Ekran görüntüsü 2024-11-21 145512](https://github.com/user-attachments/assets/2076f4eb-a9a6-465b-a1cd-aae33475be0e)
Admin Arayüzü
![screencapture-localhost-44344-Login-Index-2024-11-21-14_47_01](https://github.com/user-attachments/assets/b6176eb0-3b05-4ce8-9f9e-6c6ace040ff4)
![screencapture-localhost-44344-Admin-Profile-2024-11-21-14_57_45](https://github.com/user-attachments/assets/850e6341-d6c3-43e9-8ca7-dcdf24a9099f)
![screencapture-localhost-44344-Admin-Category-CategoryList-2024-11-21-15_00_12](https://github.com/user-attachments/assets/5ca9fb24-bad4-4451-ae79-1f241aab9976)
![screencapture-localhost-44344-Admin-Destination-DestinationList-2024-11-21-15_21_00](https://github.com/user-attachments/assets/6097b2eb-13dc-4913-a503-82c26723af4c)
![screencapture-localhost-44344-Admin-Destination-UpdateDestination-4-2024-11-21-15_21_33](https://github.com/user-attachments/assets/a2fee8b5-ca30-4287-bfbc-ca1ad2eed180)
![screencapture-localhost-44344-Admin-Message-Inbox-2024-11-21-15_22_38](https://github.com/user-attachments/assets/fe69152d-5503-4b8d-bfac-4371b4690bd8)
![screencapture-localhost-44344-Admin-Message-Sendbox-2024-11-21-15_23_22](https://github.com/user-attachments/assets/b6a0b37a-7d24-45ef-ab05-ec065fc89686)
![screencapture-localhost-44344-Admin-Chart-Line-2024-11-21-15_23_38](https://github.com/user-attachments/assets/5dd8b2de-e3ef-4781-b6de-af68c680d493)
![screencapture-localhost-44344-Admin-Chart-Bar-2024-11-21-15_23_58](https://github.com/user-attachments/assets/33b017de-8121-4bf0-ba13-1b606254f204)
![screencapture-localhost-44344-Admin-Chart-Pie-2024-11-21-15_24_19](https://github.com/user-attachments/assets/f92208eb-81a7-4f19-81c0-36809f9c7385)
![screencapture-localhost-44344-Admin-Chart-Doughnut-2024-11-21-15_24_36](https://github.com/user-attachments/assets/81c54b6e-6431-48d0-80da-472af590e43e)
![screencapture-localhost-44344-Admin-Statistic-Index-2024-11-21-15_25_00](https://github.com/user-attachments/assets/cd270895-4878-4055-ab4d-21176cbd1190)
![screencapture-localhost-44344-Admin-CreditCard-Index-2024-11-21-15_25_18](https://github.com/user-attachments/assets/b622e9a4-8a3c-4b78-841c-01374661159d)
![screencapture-localhost-44344-Admin-CreditCard-Index-2024-11-21-15_27_39](https://github.com/user-attachments/assets/94531933-59db-4193-bbdb-39d6ae16a498)
![Ekran görüntüsü 2024-11-21 152847](https://github.com/user-attachments/assets/9c17f328-c309-48f3-acb2-aeda9b2df791)
Kullanıcı Arayüzü
![Ekran görüntüsü 2024-11-21 153359](https://github.com/user-attachments/assets/b993d90c-fdd0-4a0f-b5fe-ba3b0e59799c)
![screencapture-localhost-44344-Default-Index-2024-11-21-15_42_47](https://github.com/user-attachments/assets/8a62ded6-68ce-4a6e-9165-998f6fb75724)
![screencapture-localhost-44344-Default-2024-11-21-15_34_50](https://github.com/user-attachments/assets/a15a8dd8-7356-4954-adde-4f74a99ee413)
![screencapture-localhost-44344-Default-DestinationDetail-1-2024-11-21-15_34_24](https://github.com/user-attachments/assets/6a3542f3-068e-44c1-93f1-7e3555620b12)
![Ekran görüntüsü 2024-11-21 153709](https://github.com/user-attachments/assets/05748f7a-e0e4-477a-af02-e0953d6e7e6a)
![Ekran görüntüsü 2024-11-21 153856](https://github.com/user-attachments/assets/02436943-a209-4d07-89fa-2e1b4d54c117)
![Ekran görüntüsü 2024-11-21 153909](https://github.com/user-attachments/assets/b9ca34b8-30ed-470c-a43a-7cb7a90ab228)


