# E ticaret sitesi / E commerce site

## Veri Tabanı Oluşturma
Veritabanı, dotnet tools ile oluşturulur. İlk önce "appsettings.json" dosyasındaki connection string'in düzenlenmesi gerekmektedir. Düzenleme yapılması durumunda, konsola "dotnet ef database update" komutunun yazılması ile veritabanı oluşturulacaktır. 

![version](https://img.shields.io/badge/dotnet_version-6.0.4-blue)

## Yönetici(Admin) Girişi
"Models --> DataLayer --> ProductContext.cs" dosyası içerisinden varsayılan yönetici tanımlanmıştır. Bu bölümden varsayılan yönetici değiştirilebilir. Değiştirilmesi durumunda veritabanı baştan oluşturulmalıdır. Varsayılan yönetici, tanımlı bir yönetici yetkisi olmaksızın başkalarına yönetici yetkisi verebilir, düzenleyebilir ve yönetici yetkili hesap oluşturabilmektedir.

