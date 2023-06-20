using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer.ValidationRules
{
    public class Messagevalidator:AbstractValidator<Message>
    {
        public Messagevalidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı adresini boş geçemezsiniz");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu boş geçemezsiniz");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesajı  boş geçemezsiniz");
            RuleFor(x => x.Subject).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın.");
            RuleFor(x => x.Subject).MaximumLength(2).WithMessage("Lütfen 100 karakterden fazla giriş yapmayın.");
        }
    }
}
