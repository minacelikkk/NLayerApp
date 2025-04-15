# 🧱 NLayerApp – ASP.NET Core ile Katmanlı Mimari Uygulaması

**NLayerApp**, .NET 6 kullanılarak geliştirilen, sağlam ve sürdürülebilir yazılım geliştirme prensiplerine uygun çok katmanlı (n-layer) mimariye sahip bir Web API projesidir. Bu proje; Entity Framework Core, AutoMapper, Redis, FluentValidation ve Swagger gibi modern .NET bileşenlerini kullanarak gerçek dünya uygulamalarına temel oluşturur.

---

## 📂 Proje Mimarisi

Projede 6 temel katman yer alır:

- **NLayer.Core**: Domain modelleri ve servis interface’leri
- **NLayer.Repository**: Entity Framework Core ile veri erişimi (DbContext, Generic Repository)
- **NLayer.Service**: İş kuralları ve iş mantığı
- **NLayer.API**: Controller’ların bulunduğu RESTful API sunum katmanı
- **NLayer.Caching**: Redis destekli cache işlemleri
- **NLayer.Web** *(isteğe bağlı)*: MVC yapısında web kullanıcı arayüzü

Bu yapı ile projede ayrık sorumluluklar net bir şekilde tanımlanır ve geliştirilebilirlik artar.
