# 🎯 NTP_Odev_YuzTanima - Gerçek Zamanlı Yüz Tespiti

OpenCvSharp ve kamera girişi kullanarak gerçek zamanlı yüz tespiti yapan C# Windows Forms uygulaması.

## 📋 Özellikler

- **Gerçek Zamanlı Yüz Tespiti**: Canlı kamera akışında yüzleri tespit eder
- **Gri Tonlama Dönüşümü**: Kamera karelerini işleme için gri tona çevirir
- **Görsel Geri Bildirim**: Tespit edilen yüzlerin etrafına kırmızı dikdörtgen çizer
- **Hata Yönetimi**: Kamera ve dosya işlemleri için kapsamlı hata yönetimi
- **Kaynak Yönetimi**: Uygulama kapanırken kaynakların düzgün temizlenmesi

## 🛠️ Kullanılan Teknolojiler

- **.NET 9.0** - Modern .NET framework
- **Windows Forms** - Masaüstü uygulama framework'ü
- **OpenCvSharp4** - C# için bilgisayar görü kütüphanesi
- **Haar Cascade Classifier** - Yüz tespiti algoritması

## 📦 Gereksinimler

- Windows 10/11
- .NET 9.0 SDK
- Webcam veya kamera cihazı
- Visual Studio 2022 veya VS Code (isteğe bağlı)

## 🚀 Kurulum ve Ayarlama

### 1. Repository'yi Klonlayın
```bash
git clone https://github.com/kullaniciadi/NTP_Odev_YuzTanima.git
cd NTP_Odev_YuzTanima
```

### 2. Bağımlılıkları Geri Yükleyin
```bash
dotnet restore
```

### 3. Projeyi Derleyin
```bash
dotnet build
```

### 4. Uygulamayı Çalıştırın
```bash
dotnet run
```

## 🎮 Nasıl Kullanılır

1. **Uygulamayı Başlatın**: Çalıştırılabilir dosyayı çalıştırın veya `dotnet run` kullanın
2. **Kamerayı Başlatın**: "Kamerayı Başlat" butonuna tıklayın
3. **Yüz Tespiti**: Uygulama kamera akışında otomatik olarak yüzleri tespit edecek
4. **Görsel Geri Bildirim**: Tespit edilen yüzler kırmızı dikdörtgenlerle vurgulanacak
5. **Uygulamayı Kapatın**: X butonunu kullanarak kapatın, kaynaklar otomatik olarak temizlenecek

## 📁 Proje Yapısı

```
NTP_Odev_YuzTanima/
├── Form1.cs                    # Ana uygulama mantığı
├── Form1.Designer.cs           # Form tasarımı ve UI bileşenleri
├── Program.cs                  # Uygulama giriş noktası
├── NTP_Odev_YuzTanima.csproj   # Proje yapılandırması
├── haarcascade_frontalface_default.xml  # Yüz tespiti modeli
├── bin/                        # Derlenmiş ikili dosyalar
└── README.md                   # Bu dosya
```

## 🔧 Ana Bileşenler

### Form1.cs
- **VideoCapture**: Kamera girişini yönetir
- **CascadeClassifier**: Haar cascade'leri kullanarak yüz tespiti
- **Timer**: Kare işleme aralığını kontrol eder
- **Görüntü İşleme**: Gri tonlama dönüşümü ve yüz tespiti

### Yüz Tespiti Süreci
1. Kameradan kare yakala
2. Gri tona çevir
3. Haar cascade sınıflandırıcısını uygula
4. Tespit edilen yüzlerin etrafına dikdörtgen çiz
5. İşlenmiş kareyi göster

## 📊 Performans

- **Kare Hızı**: ~30 FPS (timer aralığı ile ayarlanabilir)
- **Tespit Doğruluğu**: Ön yüzler için yüksek doğruluk
- **Kaynak Kullanımı**: Gerçek zamanlı işleme için optimize edilmiş
- **Bellek Yönetimi**: OpenCV nesnelerinin otomatik temizlenmesi

## 🐛 Sorun Giderme

### Yaygın Sorunlar

**Kamera açılmıyor:**
- Kameranın başka bir uygulama tarafından kullanılmadığından emin olun
- Kamera izinlerini kontrol edin
- Kamera sürücülerinin yüklü olduğunu doğrulayın

**Haar cascade dosyası bulunamıyor:**
- `haarcascade_frontalface_default.xml` dosyasının çıktı dizininde olduğundan emin olun
- Dosya izinlerini kontrol edin

**Performans sorunları:**
- Daha iyi performans için timer aralığını azaltın
- Kamerayı kullanan diğer uygulamaları kapatın
- Yeterli sistem kaynakları olduğundan emin olun

## 🤝 Katkıda Bulunma

1. Repository'yi fork edin
2. Özellik dalı oluşturun (`git checkout -b feature/HarikaOzellik`)
3. Değişikliklerinizi commit edin (`git commit -m 'Harika Özellik Ekle'`)
4. Dalı push edin (`git push origin feature/HarikaOzellik`)
5. Pull Request açın

## 📝 Lisans

Bu proje MIT Lisansı altında lisanslanmıştır - detaylar için [LICENSE](LICENSE) dosyasına bakın.

## 👨‍💻 Yazar

**Yasir Arda**

- Email:yasirardaayvacioglu@gmail.com


## 🙏 Teşekkürler

- Mükemmel bilgisayar görü kütüphanesi için OpenCV ekibi
- C# wrapper için OpenCvSharp katkıcıları
- .NET framework ve Windows Forms için Microsoft

## 📈 Gelecek Geliştirmeler

- [ ] Çoklu yüz tespiti algoritmaları
- [ ] Yüz tanıma yetenekleri
- [ ] Kayıt ve oynatma özellikleri
- [ ] Gelişmiş görüntü işleme filtreleri
- [ ] Çoklu dil desteği
- [ ] Yapılandırma ayarları paneli

---

⭐ **Bu repository'yi faydalı bulduysanız yıldızlayın!**
