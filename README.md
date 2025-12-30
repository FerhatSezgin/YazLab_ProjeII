# SOSYAL AĞ GRAF ANALİZİ  
**YazLab Proje II – Detaylı Proje Raporu**

---

## 1. Giriş

Günümüzde sosyal ağlar, bireyler arasındaki ilişkilerin modellenmesi ve analiz edilmesi açısından önemli veri kaynaklarıdır. Sosyal ağlar matematiksel olarak graf yapıları ile temsil edilir. Bu projede, sosyal ağ verileri üzerinde graf teorisine dayalı algoritmaların uygulanması ve görsel olarak analiz edilmesi amaçlanmıştır.

Bu proje, bir sosyal ağın düğüm ve kenar yapısını okuyarak aşağıdaki işlemleri kullanıcıya sunan bir masaüstü analiz aracı geliştirmeyi hedeflemektedir:

- Bağlantı analizi  
- En kısa yol hesaplama  
- Merkezilik ölçümü  
- Graf renklendirme  
- DFS ve BFS gezintileri  

---

## 2. Projenin Amacı

- Sosyal ağları matematiksel graf modeliyle temsil etmek  
- Graf algoritmalarını gerçek veri üzerinde uygulamak  
- Ağın yapısal özelliklerini görsel ve sayısal olarak analiz etmek  
- En etkili bireyleri ve kritik bağlantıları belirlemek  
- Kullanıcıya etkileşimli bir analiz ortamı sunmak  

---

## 3. Kullanılan Teknolojiler

| Teknoloji | Açıklama |
|----------|---------|
| C# (.NET) | Uygulamanın ana geliştirme dili |
| WinForms | Masaüstü arayüzü |
| JSON | Sosyal ağ verilerinin saklanması |
| Grafik Çizim | Düğümler ve kenarların görselleştirilmesi |
| Nesne Tabanlı Programlama | Modüler ve sürdürülebilir yapı |

---

## Proje Klasör Yapısı

```text
/SocialNetworkGraphAnalysis
│
├── Data
│   └── social_network.json
│
├── Models
│   ├── Node.cs
│   ├── Edge.cs
│   └── Graph.cs
│
├── Algorithms
│   ├── BFS.cs
│   ├── DFS.cs
│   ├── AStar.cs
│   ├── Centrality.cs
│   └── WelshPowellColoring.cs
│
├── Services
│   └── GraphLoader.cs
│
├── UI
│   ├── MainForm.cs
│   ├── GraphRenderer.cs
│   └── Controls
│
├── Utils
│   └── MathHelper.cs
│
├── Program.cs
└── README.md
```

---

## 4. Graf Yapısı

- **Düğümler (Vertices):** Kullanıcıları temsil eder  
- **Kenarlar (Edges):** İki kullanıcı arasındaki bağlantıyı temsil eder  
- Graf yapısı yönsüz ve ağırlıksız bir sosyal ağ grafıdır.

Graf, JSON dosyasından okunarak belleğe yüklenir ve `GrafYapisi` sınıfları ile yönetilir.

---

## 5. Kullanılan Algoritmalar

### 5.1 BFS (Breadth First Search)

Bir düğümden başlayarak komşuların katman katman gezilmesini sağlar.

**Kullanım Amaçları:**
- Ağın yayılım analizi  
- En kısa kenar sayısına göre mesafe ölçümü  

---

### 5.2 DFS (Depth First Search)

Bir düğümden başlayarak mümkün olduğunca derine inerek gezinti yapar.

**Kullanım Amaçları:**
- Ağın bağlantı bütünlüğünü kontrol etme  
- Alt bileşenleri keşfetme  

---

### 5.3 A* (A-Star) Algoritması

İki kullanıcı arasındaki en kısa etkileşim zincirini bulmak için kullanılmıştır.

---

### 5.4 Merkezilik (Centrality) Analizi

Bir düğümün ağ üzerindeki etki gücünü hesaplar.  
Merkezilik değeri yüksek olan kullanıcılar ağın bilgi yayılımında kritik rol oynar.

---

### 5.5 Welsh–Powell Graf Renklendirme

Komşu düğümlerin aynı renge sahip olmamasını sağlar.

**Amaç:**
- Grafın daha anlaşılır hale getirilmesi  
- Görsel çakışmaların engellenmesi  

---

## 6. Sistemin Çalışma Mantığı

1. JSON dosyasından sosyal ağ verileri okunur  
2. Düğümler ve kenarlar belleğe aktarılır  
3. Kullanıcı arayüzünden istenen algoritma seçilir  
4. Sonuçlar grafik üzerinde vurgulanır ve sayısal olarak kullanıcıya sunulur  

---

## 7. Arayüz Tasarımı

Kullanıcı:

- Algoritma seçebilir  
- Düğüm belirleyebilir  
- En kısa yol ve merkezilik hesaplatabilir  
- Grafın renklendirilmiş halini görüntüleyebilir  

Arayüz tamamen etkileşimlidir ve analiz sonuçları anlık olarak görselleştirilir.

---

## 8. Projenin Kazanımları

- Graf teorisi uygulamalı olarak öğrenilmiştir  
- Arama ve yol bulma algoritmaları gerçek veriye uygulanmıştır  
- Sosyal ağ analizi mantığı kavranmıştır  
- Görsel analiz kabiliyeti geliştirilmiştir  

---

## 9. Sonuç

Bu proje; sosyal ağların matematiksel olarak analiz edilmesini sağlayan, kullanıcı dostu, genişletilebilir ve akademik olarak güçlü bir masaüstü uygulamasıdır.  
Graf algoritmalarının gerçek sosyal ağ senaryosuna uygulanması sayesinde, ağın yapısal özellikleri net biçimde ortaya konulmuştur.
