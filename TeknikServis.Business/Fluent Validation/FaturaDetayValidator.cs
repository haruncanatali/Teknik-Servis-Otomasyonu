using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.Business.Fluent_Validation
{
    public class FaturaDetayValidator:AbstractValidator<FaturaDetay>
    {
        public FaturaDetayValidator()
        {
            RuleFor(c => c.UrunAd).Length(1, 200).WithMessage("Ürün adı alanı karakter sınırı [1,200] olmalıdır.").NotEmpty().WithMessage("Ürün adı alanı boş geçilemez.");
            RuleFor(c => c.Adet).NotEmpty().WithMessage("Adet alanı boş geçilemez.");
            RuleFor(c => c.FaturaId).NotEmpty().WithMessage("Fatura Id alanı boş geçilemez.");
            RuleFor(c => c.Fiyat).NotEmpty().WithMessage("Fiyat alanı boş geçilemez.");
            RuleFor(c => c.Tutar).NotEmpty().WithMessage("Tutar alanı boş geçilemez.");
        }
    }
}
