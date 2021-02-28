using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.Business.Fluent_Validation
{
    public class KategoriValidator:AbstractValidator<Kategori>
    {
        public KategoriValidator()
        {
            RuleFor(c => c.KategoriAd).Length(1, 100).WithMessage("Kategori adı alanı karakter sınırı [1-100] olmalıdır.").NotEmpty().WithMessage("Kategori adı alanı boş geçilemez.");
        }
    }
}
