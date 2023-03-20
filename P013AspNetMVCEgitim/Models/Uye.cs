using System.ComponentModel.DataAnnotations;

namespace P013AspNetMVCEgitim.Models
{
    public class Uye 
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad Alanı Boş Geçilemez!"), StringLength(50)] //StringLength ile ad alanına kaç karakter gönderebileceğini sınırlayabiliriz.
        public string Ad { get; set; }
        [Required(ErrorMessage = "{0} Alanı Boş Geçilemez!"), StringLength(50)]
        public string Soyad { get; set; }
        [Required(ErrorMessage = "Geçersiz Mail Girdiniz!"), StringLength(50)]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Geçersiz Telefon Numarası Girdiniz!"), StringLength(50)]
        public string? Telefon { get; set; }
        [Display(Name ="Tc Kimlik Numarası")] // Ekranda TcKimlikNo yerine Tc Kimlik Numarası yazsın.
        [MinLength(11, ErrorMessage="{0} 11 Karakter Olmalıdır!")]
        [MaxLength(11, ErrorMessage = "{0} 11 Karakter Olmalıdır!")]
        public string? TcKimlikNo { get; set; }
        [Display(Name = "Doğum Tarihi")]
        public DateTime? DogumTarihi { get; set; }
        [Display(Name = "Kullanıcı Adı")]
        public string? KullaniciAdi { get; set; }
        [Display(Name = "Şifre")]
        public string? Sifre { get; set; }
        [Display(Name = "Şifre Tekrar")]
        public string? SifreTekrar { get; set; }

        // String'in yanına soru işareti (?) eklediğimiz zaman zorunlu halden çıkıyor.
    }
}
