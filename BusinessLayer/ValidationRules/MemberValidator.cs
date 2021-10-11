using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MemberValidator : AbstractValidator<Member>
    {
        public MemberValidator()
        {
            RuleFor(x => x.MemberName).NotEmpty().WithMessage("İsim kısmı boş geçilemez.");
            RuleFor(x => x.MemberMail).NotEmpty().WithMessage("Mail kısmı boş geçilemez.");
            RuleFor(x => x.MemberPassword).NotEmpty().WithMessage("Şifre kısmı boş geçilemez.");
            RuleFor(x => x.MemberName).Length(2,15).WithMessage("En az 2 karakter giriniz.");
            //RuleFor(x => x.MemberName).MaximumLength(15).WithMessage("En fazla 15 karakter giriniz.");
            RuleFor(x => x.MemberMail).EmailAddress().WithMessage("Geçerli bir mail adresi girin.");
            RuleFor(x => x.MemberPassword).Equal(x=>x.PasswordConfirm).WithMessage("Şifreleri doğru girin.");

        }
    }
}
