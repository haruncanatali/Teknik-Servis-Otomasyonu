using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.Business.Fluent_Validation
{
    public class UrunValidator:AbstractValidator<Urun>
    {
        public UrunValidator()
        {
            RuleFor(c => c.UrunAd).Length(1, 200).WithMessage("Ürün adı alanı karakter sınırı [1-200] olmalıdır.").NotEmpty().WithMessage("Ürün adı alanı boş geçilemez.");
            RuleFor(c => c.UrunMarka).Length(1, 75).WithMessage("Ürün marka alanı karakter sınırı [1-75] olmalıdır.").NotEmpty().WithMessage("Ürün marka alanı boş geçilemez.");
            RuleFor(c => c.AlisFiyat).NotEmpty().WithMessage("Alış fiyatı boş geçilemez.");
            RuleFor(c => c.SatisFiyat).NotEmpty().WithMessage("Satış fiyatı boş geçilemez.");
            RuleFor(c => c.UrunStok).NotEmpty().WithMessage("Stok alanı boş geçilemez.");
            RuleFor(c => c.KategoriId).NotEmpty().WithMessage("Kategori Id alanı boş geçilemez.");
        }
    }
}
