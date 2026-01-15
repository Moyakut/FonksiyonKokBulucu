# FonksiyonKokBulucu
İstanbul Kent Üniversitesi Matematik ödevi için yapılmış C# ile programlanmış basit bir kök bulma yazılımı.

## Öğrenci Bilgileri
- **Ad Soyad :** Osman Yakut
- **Öğrenci Numarası :** 2507020079
- **Bölümü :** Bilgisayar Mühendisliği

## Programın çalışma mantığı
- "ax² + bx + c" cinsindeki bir ikinci dereceden fonksiyonun a, b ve c değerleri girildikten sonra yazılım fonksiyonu tanımlar.  
  <img src="FonksiyonKokBulucu/images/fonksiyon_tanımı.png" width="383" height="39" alt="Fonksiyonu Tanımlama"> 
- Tanımlanan fonksiyonun diskriminantı (Δ) yazılım tarafından hesaplanır.   
  <img src="FonksiyonKokBulucu/images/diskriminant.png" width="434" height="36" alt="Fonksiyonu Tanımlama">
- Yazılım; eğer diskriminant (Δ) 0'dan büyükse iki tane kökünü ayrı ayrı hesaplar, 0'a eşitse bir tane olan çift kat kökünü hesaplar ve eğer 0'dan küçükse reel sayılarda kökü yok diye uyarı verir.     
  <img src="FonksiyonKokBulucu/images/kokleri.png" width="500" height="50" alt="Fonksiyonu Tanımlama">

## Programdan Ekran Görüntüleri
### *"İki tane"* reel kök olduğu bir fonksiyon tanımlandığınında
***Örn :*** x² - 5x + 6  
<img src="FonksiyonKokBulucu/images/SS_1.png" width="1091" height="558" alt="Fonksiyonu Tanımlama">
### Bir *"Çift Katlı"* reel kök olduğu bir fonksiyon tanımlandığınında
***Örn :*** x² - 4x + 4  
<img src="FonksiyonKokBulucu/images/SS_3.png" width="1091" height="558" alt="Fonksiyonu Tanımlama">
### Reel bir *"kökü olmayan"* bir fonksiyon tanımlandığınında
***Örn :*** x² - 5x + 6  
<img src="FonksiyonKokBulucu/images/SS_2.png" width="1091" height="558" alt="Fonksiyonu Tanımlama">
