using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.Business.Fluent_Validation
{
    public class FaturaBilgiValidator:AbstractValidator<FaturaBilgi>
    {
        public FaturaBilgiValidator()
        {
            RuleFor(c => c.Seri).NotEmpty().Length(1).WithMessage("Seri alanı 1 hane olmalıdır.").WithMessage("Seri alanı boş geçilemez.");
            RuleFor(c => c.SiraNo).NotEmpty().WithMessage("Sıra no alanı boş geçilemez.").Length(1,13).WithMessage("Sıra no alanı karakter sınırı [1,13] olmalıdır.");
            RuleFor(c => c.Tarih).NotEmpty().WithMessage("Tarih alanı boş geçilemez.");
            RuleFor(c => c.MusteriId).NotEmpty().WithMessage("Müşteri Id alanı boş geçilemez.");
            RuleFor(c => c.PersonelId).NotEmpty().WithMessage("Personel Id alanı boş geçilemez.");
            RuleFor(c => c.Saat).NotEmpty().WithMessage("Saat alanı boş geçilemez.").Length(1,5).WithMessage("Saat alanı karakter sınırı[1,5] olmalıdır.");
            RuleFor(c => c.VergiDaire).NotEmpty().WithMessage("Vergi daire alanı boş geçilemez.").Length(1, 50).WithMessage("Vergi daire alanı karakter sınırı[1,50] olmalıdır.");
        }
    }
}
