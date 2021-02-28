using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.Business.Fluent_Validation
{
    public class AdminValidator:AbstractValidator<Admin>
    {
        public AdminValidator()
        {
            RuleFor(c => c.KullaniciAdi).Length(1, 8).WithMessage("Kullanıcı adı karakter aralığı [1-8] olmalıdır.").NotEmpty().WithMessage("Kullanıcı adı girilmelidir.");
            RuleFor(c => c.KullaniciSifre).Length(1, 8).WithMessage("Kullanıcı şifresi karakter aralığı [1-8] olmalıdır.").NotEmpty().WithMessage("Kullanıcı şifresi girilmelidir.");
        }
    }
}
