using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.Business.Fluent_Validation
{
    public class UrunHareketValidator:AbstractValidator<UrunHareket>
    {
        public UrunHareketValidator()
        {
            RuleFor(c => c.Tarih).NotEmpty().WithMessage("Tarih alanı boş geçilemez.");
            RuleFor(c => c.Adet).NotEmpty().WithMessage("Adet alanı boş geçilemez.");
            RuleFor(c => c.Fiyat).NotEmpty().WithMessage("Fiyat alanı boş geçilemez.");
            RuleFor(c => c.UrunId).NotEmpty().WithMessage("Ürün Id alanı boş geçilemez.");
            RuleFor(c => c.MusteriId).NotEmpty().WithMessage("Müşteri Id alanı boş geçilemez.");
            RuleFor(c => c.PersonelId).NotEmpty().WithMessage("Personel Id alanı boş geçilemez.");
        }
    }
}
