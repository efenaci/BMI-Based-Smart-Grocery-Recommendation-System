# 🛒 VKİ Tabanlı Akıllı Market Yönlendirme Sistemi

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white)

Kullanıcıların boy ve kilo bilgilerine göre **Vücut Kitle İndeksini (VKİ)** hesaplayan, çıkan sonuca göre sağlık durumunu analiz ederek kişiye özel market reyonları öneren ve seçilen reyonlarda sepet, vergi ve ödeme işlemlerini gerçekleştiren **C# Windows Forms** masaüstü uygulamasıdır.

---

## 🖥️ Uygulama Ekranları ve Akış

### 1. Giriş ve VKİ Hesaplama Ekranı
Kullanıcı santimetre (cm) cinsinden boyunu ve kilogram cinsinden kilosunu girerek **HESAPLA** butonuna tıklar. Sistem VKİ değerini otomatik olarak hesaplar ve ilgili sonuç ekranına yönlendirir.

<p align="center">
  <img src="giriş.png" alt="VKİ Hesaplama Giriş Ekranı" width="700">
</p>

---

### 2. VKİ Analizi ve Reyon Yönlendirme Ekranları
Hesaplanan VKİ değerine göre sistem kullanıcıyı **Zayıf**, **Normal Kilolu** veya **Fazla Kilolu** kategorilerinden birine yerleştirir, sağlık önerisinde bulunur ve hedefine uygun reyon seçeneklerini sunar:

* **Zayıf Aralığı:** Sağlıklı kilo almak veya ayırt etmeden kilo almak için uygun reyonlara yönlendirir.
<p align="center">
  <img src="zayıf.png" alt="Zayıf VKİ Sonuç Ekranı" width="700">
</p>

* **Normal Kilolu Aralığı:** Formu korumak, sağlıklı kilo almak veya kas kütlesi artırmak için reyon seçenekleri sunar.
<p align="center">
  <img src="normal.png" alt="Normal Kilolu VKİ Sonuç Ekranı" width="700">
</p>

* **Fazla Kilolu Aralığı:** Kilo verme önerisiyle birlikte düşük kalorili ve dengeli reyon seçeneklerini listeler.
<p align="center">
  <img src="fazlakilolu.png" alt="Fazla Kilolu VKİ Sonuç Ekranı" width="700">
</p>

---

### 3. Market Reyonları ve Alışveriş Ekranları
Kullanıcı kendisine önerilen **5 farklı reyondan** birini seçtiğinde ilgili reyon penceresi açılır. Her reyonda o kategoriye özel ürünler ve birim fiyatları listelenir. Kullanıcı ürünleri sepetine ekleyebilir, **HESAPLA** butonu ile ara toplamı görebilir, **ÖDEME YAP** butonu ile vergi dahil net tutarı hesaplayıp ödemesini tamamlayabilir. Sol üstteki geri butonu ile bir önceki menüye dönülerek diğer reyonlardan da alışveriş yapılabilir.

#### 🥗 Sağlıklı Ürünler Reyonu
<p align="center">
  <img src="sağlıklıürünreyonu.png" alt="Sağlıklı Ürünler Reyonu" width="700">
</p>

#### 🧀 Gıda Ürünleri Reyonu
<p align="center">
  <img src="gıdareyonu.png" alt="Gıda Ürünleri Reyonu" width="700">
</p>

#### 💪 Protein Ağırlıklı Ürünler Reyonu
<p align="center">
  <img src="proteinliürünreyonu.png" alt="Protein Ağırlıklı Ürünler Reyonu" width="700">
</p>

#### 🍎 Meyveler Reyonu
<p align="center">
  <img src="meyvereyonu.png" alt="Meyveler Reyonu" width="700">
</p>

#### 🥦 Sebzeler Reyonu
<p align="center">
  <img src="sebzereyonu.png" alt="Sebzeler Reyonu" width="700">
</p>

---

## ✨ Özellikler

* **Otomatik VKİ Hesaplama ve Sınıflandırma:** Boy ve kilo verileriyle VKİ hesaplama; Zayıf, Normal ve Fazla Kilolu aralıklarına göre dinamik geri bildirim.
* **Kişiselleştirilmiş Reyon Önerisi:** Kullanıcının VKİ aralığına ve hedefine uygun **5 farklı reyon** (*Sağlıklı Ürünler, Gıda Ürünleri, Protein Ağırlıklı Ürünler, Meyveler, Sebzeler*) arasında yönlendirme.
* **Dinamik Sepet ve Fiyat Hesaplama:** Reyon içerisinden ürün seçimi, anlık sepet listeleme ve toplam tutar hesaplama.
* **Vergi ve Ödeme Sistemi:** Sepet tutarı üzerinden otomatik vergi hesaplama, net toplam gösterimi ve ödeme onay bildirimi.
* **Çoklu Reyon Gezinmesi:** Geri dönme butonu sayesinde önceki menüye dönüp farklı reyonlardan alışverişe devam edebilme.

---

## 🛠️ Kullanılan Teknolojiler

* **Dil:** C#
* **Arayüz:** Windows Forms (WinForms)
* **Geliştirme Ortamı:** Visual Studio
