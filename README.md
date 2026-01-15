# Fonksiyon Kök Bulucu
İstanbul Kent Üniversitesi Matematik ödevi için yapılmış C# ile programlanmış, ikinci derecen fonksiyonların köklerini hesaplayan bir konsol uygulaması.

## 🧑‍💻 Öğrenci Bilgileri :
- **Ad Soyad :** Osman Yakut
- **Öğrenci Numarası :** 2507020079
- **Bölümü :** Bilgisayar Mühendisliği

## ⚙️ Programın Çalışma Mantığı :
1. **Fonksiyonun Tanımlanması:**
   "ax² + bx + c" formatındaki ikinci dereceden fonksiyonun a, b ve c katsayıları kullanıcıdan alınır.
    <br>
    <img src="FonksiyonKokBulucu/images/fonksiyon_tanımı.png" width="383" height="39" alt="Fonksiyonu Tanımlama"> 
3. **Diskriminant Hesaplaması:**
    Tanımlanan fonksiyonun diskriminantı (Δ) yazılım tarafından hesaplanır.
    <br> 
    <img src="FonksiyonKokBulucu/images/diskriminant.png" width="434" height="36" alt="Fonksiyonu Tanımlama">
4. **Diskriminanta Göre Kök Hesaplama**
   - **Δ > 0:** Durumunda *iki adet* reel kökü olduğu
   - **Δ = 0:** Durumunda tek bir *çift katlı* kökü olduğu
   - **Δ < 0:** Durumunda reel bir *kökü olmadığı* belirtilir
   <br>
   <img src="FonksiyonKokBulucu/images/diskriminant.png" width="434" height="36" alt="Fonksiyonu Tanımlama">

## 💻 Programın Bazı ÖZellikleri :
1. **Girilen değerlerden oluşturulan fonksiyonu konsola görsel olarak yazdırılması : **
   <br>
   <img src="FonksiyonKokBulucu/images/fonksiyon_tanımı.png" width="383" height="39" alt="Fonksiyonu Tanımlama">
2. **Sayı girilmesi istendiğinde girilen girdinin bir sayı olup olmadığının kontrolü : **
   - Eğer sayı yerine başka bir karakter (a, x, y, !, ? vb.) girilirse hata mesajı verilmesi.
3. 

## 📷 Programdan Ekran Görüntüleri
### 1. *"İki tane"* reel kök olduğu bir fonksiyon tanımlandığınında
- ***Örn :*** x² - 5x + 6  
  <img src="FonksiyonKokBulucu/images/SS_1.png" width="1091" height="558" alt="Fonksiyonu Tanımlama">
### 2. Bir *"Çift Katlı"* reel kök olduğu bir fonksiyon tanımlandığınında
- ***Örn :*** x² - 4x + 4  
  <img src="FonksiyonKokBulucu/images/SS_3.png" width="1091" height="558" alt="Fonksiyonu Tanımlama">
### 3. Reel bir *"kökü olmayan"* bir fonksiyon tanımlandığınında
- ***Örn :*** 3x² + 4x + 8  
  <img src="FonksiyonKokBulucu/images/SS_2.png" width="1091" height="558" alt="Fonksiyonu Tanımlama">
