using EntityLayer.Concrete;
using FluentValidation;
using System.Text.RegularExpressions;

namespace BusinessLayer.ValidationRules.FluentValidation
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı soyadı kısmı boş geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Password boş geçilemez.")
                .Must(IsPasswordValid).WithMessage("Parolanız en az sekiz karakter, en az bir harf ve bir sayı içermelidir!");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın.");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakterlik isim giriniz.");


        }


        private bool IsPasswordValid(string arg)
        {
            Regex regex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$");
            return regex.IsMatch(arg);
        }
    }
}
