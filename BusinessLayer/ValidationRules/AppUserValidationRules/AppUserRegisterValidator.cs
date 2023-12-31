﻿using DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Alanı Boş Geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad Alanı Boş Geçilemez");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı Adı Alanı Boş Geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail Alanı Boş Geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre Alanı Boş Geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre Tekrar Alanı Boş Geçilemez");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen En Fazla 30 Karakter Girişi Yapın");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lütfen En Az 2 Karakter Veri Girişi Yapın");
            RuleFor(x=>x.ConfirmPassword).Equal(y=> y.Password).WithMessage("Parolalarınız Eşleşmiyor");//Equal methodu sağ ve solda ki değerlerin eşleşip eşleşmediğini kontrol ediyor
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen Geçerli Bir Mail Adresi Giriniz");
            
        }
    }
}
