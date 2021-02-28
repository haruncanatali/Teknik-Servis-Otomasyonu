using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.Business.Fluent_Validation
{
    public class DepartmanValidator:AbstractValidator<Departman>
    {
        public DepartmanValidator()
        {
            RuleFor(c => c.DepartmanAd).Length(1, 250).WithMessage("Departman alanı karakter sınırı [1-250] olmalıdır.").NotEmpty().WithMessage("Departman alanı boş geçilemez.");
            RuleFor(c => c.DepartmanAciklama).Length(1, 250).WithMessage("Departman açıklama alanı karakter sınırı [1-500] olmalıdır.");
        }
    }
}
