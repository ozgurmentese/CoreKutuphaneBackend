using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Business.ValidationRules.FluentValidation
{
    public class OgrenciValidator : AbstractValidator<Ogrenci>
    {
        public OgrenciValidator()
        {
            RuleFor(o => o.Adi).NotEmpty().WithMessage("Ad alanı boş geçilemez");
            RuleFor(o => o.Adi).Length(3, 20).WithMessage("Ad minimum 3 maksimum 30 karakterde olmalı");
            RuleFor(o => TurkishCharacterReplace(o.Adi)).Must(IsLetter).WithMessage("Ad alanı sadece harf içermek zorundadır");
            RuleFor(o => o.Soyadi).NotEmpty().WithMessage("Soyad alanı boş geçilemez");
            RuleFor(o => o.Soyadi).MinimumLength(2).WithMessage(" Soyad minimum 3 karakterde olmalı");
            RuleFor(o => TurkishCharacterReplace(o.Soyadi)).Must(IsLetter).WithMessage("Soyadi alanı sadece harf içermek zorundadır");
            RuleFor(o => o.Cinsiyet).NotEmpty();
            RuleFor(o => o.Cinsiyet).Length(1).WithMessage("Cinsiyeti (E/K) şeklinde yazınız");
            RuleFor(o => o.Sinif).NotEmpty().WithMessage("Sınıfı boş olamaz");
            RuleFor(o => o.Sinif).NotEmpty().MaximumLength(3).WithMessage("Sınıf maksimum 3 karakterli olmalı");

            RuleFor(o => o.DogumTarihi).NotEmpty();

        }

        private bool IsLetter(string arg)
        {
            Regex regex = new Regex(@"^[a-zA-Z]+$");
            return regex.IsMatch(arg);
        }

        private string TurkishCharacterReplace(string metin)
        {
            metin = metin.Replace("ı", "i");
            metin = metin.Replace("ö", "o");
            metin = metin.Replace("ü", "u");
            metin = metin.Replace("ğ", "g");
            metin = metin.Replace("ç", "c");
            metin = metin.Replace("ş", "s");
            metin = metin.Replace("Ü", "U");
            metin = metin.Replace("İ", "I");
            metin = metin.Replace("Ö", "O");
            metin = metin.Replace("Ğ", "G");
            metin = metin.Replace("Ç", "C");
            metin = metin.Replace("Ş", "S");
            metin = metin.Replace(" ", "");
            return metin;
        }
    }
}
