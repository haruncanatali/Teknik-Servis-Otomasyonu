using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.Business.Fluent_Validation
{
    public class PersonelValidator:AbstractValidator<Personel>
    {
        public PersonelValidator()
        {
            RuleFor(c => c.PersonelAd).Length(1, 45).WithMessage("Personel ad alanı karakter sınırı [1,45] olmalıdır.").NotEmpty().WithMessage("Personel ad alanı boş geçilemez.");
            RuleFor(c => c.PersonelSoyad).Length(1, 45).WithMessage("Personel soyad alanı karakter sınırı [1,45] olmalıdır.").NotEmpty().WithMessage("Personel soyad alanı boş geçilemez.");
            RuleFor(c => c.PersonelFotorafBaglantisi).Length(1, 200).WithMessage("Personel fotoğraf bağlatısı  alanı karakter sınırı [1,200] olmalıdır.").NotEmpty().WithMessage("Personel fotoğraf bağlatısı alanı boş geçilemez.");
            RuleFor(c => c.PersonelMail).Length(1, 100).WithMessage("Personel mail alanı karakter sınırı [1,100] olmalıdır.").NotEmpty().WithMessage("Personel mail alanı boş geçilemez.");
            RuleFor(c => c.PersonelTelefon).Length(1, 16).WithMessage("Personel telefon alanı karakter sınırı [1,16] olmalıdır.").NotEmpty().WithMessage("Personel telefon alanı boş geçilemez.");
            RuleFor(c => c.PersonelMaas).NotEmpty().WithMessage("Personel maaş alanı boş geçilemez.");
            RuleFor(c => c.DepartmanId).NotEmpty().WithMessage("Departman Id alanı boş geçilemez.");
        }
    }
}
