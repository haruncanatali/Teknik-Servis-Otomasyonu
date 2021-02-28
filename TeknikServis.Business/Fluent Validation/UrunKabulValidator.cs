using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.Business.Fluent_Validation
{
    public class UrunKabulValidator:AbstractValidator<UrunKabul>
    {
        public UrunKabulValidator()
        {
            RuleFor(c => c.GelisTarihi).NotEmpty().WithMessage("Geliş tarihi alanı boş geçilemez.");
            RuleFor(c => c.UrunId).NotEmpty().WithMessage("Urun Id alanı boş geçilemez.");
            RuleFor(c => c.MusteriId).NotEmpty().WithMessage("Müşteri Id alanı boş geçilemez.");
            RuleFor(c => c.PersonelId).NotEmpty().WithMessage("Personel Id alanı boş geçilemez.");
        }
    }
}
