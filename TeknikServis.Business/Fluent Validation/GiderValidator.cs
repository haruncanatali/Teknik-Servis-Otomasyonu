using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.Business.Fluent_Validation
{
    public class GiderValidator:AbstractValidator<Gider>
    {
        public GiderValidator()
        {
            RuleFor(c => c.Aciklama).Length(1, 5000).WithMessage("Açıklama alanı karakter sınırı [1,5000] olmalıdır.").NotEmpty().WithMessage("Açıklama alanı boş geçilemez.");
            RuleFor(c => c.Tarih).NotEmpty().WithMessage("Tarih alanı boş geçilemez.");
            RuleFor(c => c.Tutar).NotEmpty().WithMessage("Tutar alanı boş geçilemez.");
        }
    }
}
