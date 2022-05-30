# E ticaret sitesi / E commerce site

<br>

## Veri Tabanı Oluşturma
Veritabanı, dotnet tools ile oluşturulur. İlk önce "appsettings.json" dosyasındaki connection string'in düzenlenmesi gerekmektedir. Düzenleme yapılması durumunda, konsola "dotnet ef database update" komutunun yapılması ile veritabanı oluşturulacaktır. Kullanılan dotnet tools versiyonu "6.0.4".

<br>

## Yönetici(Admin) Girişi
"Models --> DataLayer --> ProductContext.cs" dosyası içerisinden varsayılan yönetici tanımlanmıştır. Bu bölümden varsayılan yönetici değiştirilebilir. Varsayılan yönetici, yönetici yetkisi verebilir ve yönetici yetkili hesap oluşturabilmektedir.
