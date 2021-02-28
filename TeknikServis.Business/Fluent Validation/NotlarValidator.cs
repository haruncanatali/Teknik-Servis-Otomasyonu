using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.Business.Fluent_Validation
{
    public class NotlarValidator:AbstractValidator<Notlar>
    {
        public NotlarValidator()
        {
            RuleFor(c => c.Baslik).Length(1, 100).WithMessage("Başlık alanı karakter sınırı [1-100] olmalıdır.").NotEmpty().WithMessage("Başlık alanı boş geçilemez.");
            RuleFor(c => c.Icerik).Length(1, 5000).WithMessage("İçerik alanı karakter sınırı [1-5000] olmalıdır.").NotEmpty().WithMessage("İçerik alanı boş geçilemez.");
        }
    }
}
