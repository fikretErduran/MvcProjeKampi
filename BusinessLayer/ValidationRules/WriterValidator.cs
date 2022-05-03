using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Writer Name Boş Geçemezsiniz");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Writer SurName Boş Geçemezsiniz");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen En Az 2 Karakter Girişi Yapınız");
            RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("Lütfen 50 Karakterden Fazla Giriş yapmayınız");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Yazar Hakkında Kısmı Boş Geçilemez");
            RuleFor(x => x.WriterAbout).NotEqual("a").WithMessage("Yazar Hakkında a harfi olmalıdır");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Writer Mail Boş Geçilemez");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Writer Title boş geçilemez");
        }
    }
}
