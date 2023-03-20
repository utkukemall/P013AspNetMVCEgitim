using Microsoft.EntityFrameworkCore;

namespace P013AspNetMVCEgitim.Models
{
    // InMemoryDb kullanabilmek için projeye sağ tık nuget package manager menüsünü aç 
    // Açtığımız menüden Browse sekmesine geçip EntityFrameworkCore.InMemort paketini ve EntityFrameworkCore.design paketlerini yüklüyoruz.
    // Installed yüklü olan paketleri Browse ise yükleyebileceğimiz paketleri gösterir.
    public class UyeContext : DbContext
    {
        public DbSet <Uye> Uyes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // EntityFrameworkCore veritabanı işlemleri için yapılandırma ayarlarını yapabildiğimiz metot.
            optionsBuilder.UseInMemoryDatabase("InMemoryDb"); // Bilgisayarımızın ram belleğini sanal veritabanı olarak kullanmasını sağlayan ayarı yaptık.
            // Bu ayardan sonra projemizin program.cs classına gidip bu UyeContext sınıfını servis olarak ekliyoruz.
            base.OnConfiguring(optionsBuilder); 
        }
    }
}
