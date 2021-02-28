using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServis.Entities.Concrete;

namespace TeknikServis.Business.Fluent_Validation
{
    public class MusteriValidator:AbstractValidator<Musteri>
    {
        public MusteriValidator()
        {
            RuleFor(c => c.MusteriAd).Length(1, 40).WithMessage("Müşteri adı alanı karakter sınırı [1-40] olmalıdır.").NotEmpty().WithMessage("Müşteri adı alanı boş geçilemez.");
            RuleFor(c => c.MusteriSoyad).Length(1, 40).WithMessage("Müşteri soyad alanı karakter sınırı [1-40] olmalıdır.").NotEmpty().WithMessage("Müşteri soyad alanı boş geçilemez.");
            RuleFor(c => c.MusteriTelefon).Length(1, 16).WithMessage("Müşteri telefon alanı karakter sınırı [1-16] olmalıdır.").NotEmpty().WithMessage("Müşteri telefon alanı boş geçilemez.");
            RuleFor(c => c.MusteriMail).Length(1, 100).WithMessage("Müşteri soyad alanı karakter sınırı [1-100] olmalıdır.").NotEmpty().WithMessage("Müşteri mail alanı boş geçilemez.");
            RuleFor(c => c.MusteriBanka).Length(1, 100).WithMessage("Müşteri banka alanı karakter sınırı [1-100] olmalıdır.").NotEmpty().WithMessage("Müşteri banka alanı boş geçilemez.");
            RuleFor(c => c.MusteriVergiDaire).Length(1, 100).WithMessage("Müşteri vergi dairesi alanı karakter sınırı [1-100] olmalıdır.").NotEmpty().WithMessage("Müşteri vergi dairesi alanı boş geçilemez.");
            RuleFor(c => c.MusteriVergiNo).Length(1, 10).WithMessage("Müşteri vergi no alanı karakter sınırı [1-10] olmalıdır.").NotEmpty().WithMessage("Müşteri vergi no alanı boş geçilemez.");
            RuleFor(c => c.MusteriStatu).Length(1, 100).WithMessage("Müşteri statü alanı karakter sınırı [1-100] olmalıdır.").NotEmpty().WithMessage("Müşteri statü alanı boş geçilemez.");
            RuleFor(c => c.MusteriIl).Length(1, 35).WithMessage("Müşteri il alanı karakter sınırı [1-35] olmalıdır.").NotEmpty().WithMessage("Müşteri il alanı boş geçilemez.");
            RuleFor(c => c.MusteriIlce).Length(1, 35).WithMessage("Müşteri ilçe alanı karakter sınırı [1-35] olmalıdır.").NotEmpty().WithMessage("Müşteri ilçe alanı boş geçilemez.");
            RuleFor(c => c.MusteriAcikAdres).Length(1, 250).WithMessage("Müşteri statü alanı karakter sınırı [1-250] olmalıdır.").NotEmpty().WithMessage("Müşteri açık adres alanı boş geçilemez.");
        }
    }
}
