using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.Business.Fluent_Validation
{
    public class UrunTakipValidator:AbstractValidator<UrunTakip>
    {
        public UrunTakipValidator()
        {
            RuleFor(c => c.Durum).Length(1, 250).WithMessage("Durum alanı karakter sınırı [1-250] olmalıdır.").NotEmpty().WithMessage("Durum alanı boş geçilemez.");
            RuleFor(c => c.Tarih).NotEmpty().WithMessage("Tarih alanı boş geçilemez.");
            RuleFor(c => c.TakipKodu).NotEmpty().WithMessage("Takip kodu alanı boş geçilemez."); 
            RuleFor(c => c.UrunId).NotEmpty().WithMessage("Ürün Id alanı boş geçilemez.");
        }
    }
}
