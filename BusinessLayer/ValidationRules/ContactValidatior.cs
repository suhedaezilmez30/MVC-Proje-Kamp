﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidatior:AbstractValidator<Contact>
    {
        public ContactValidatior() { 
            RuleFor(x=>x.UserMail).NotEmpty().WithMessage("Mail adresini boş geçemezsiniz");

            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu adını boş geçemezsiniz");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("kullanıcı adını  boş geçemezsiniz.");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapın."); 
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapın.");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Lütfen 20 karakterden fazla veri girişi yapmayın");
        }
    }
}
