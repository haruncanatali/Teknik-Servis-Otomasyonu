using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.Business.Fluent_Validation
{
    public class ArizaDetayValidator:AbstractValidator<ArizaDetay>
    {
        public ArizaDetayValidator()
        {
            RuleFor(c => c.Sorun).Length(1, 500).WithMessage("Sorun alanı karakter sınırı [1-500] olmalıdır.").NotEmpty().WithMessage("Sorun alanı boş geçilemez.");
            RuleFor(c => c.Aciklama).Length(1, 2500).WithMessage("Açıklama alanı karakter sınırı [1-2500] olmalıdır.");
            RuleFor(c => c.Yapilanİslemler).Length(1, 3000).WithMessage("Yapılan işlemler alanı karakter sınırı [1-3000] olmalıdır.");
            RuleFor(c => c.OnFiyat).NotEmpty().WithMessage("Ön fiyat alanı boş geçilemez.");
        }
    }
}
