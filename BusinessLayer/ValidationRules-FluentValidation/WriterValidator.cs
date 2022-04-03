using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules_FluentValidation
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı boş olamaz");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Soyad boş olmaz");
            RuleFor(x => x.About).NotEmpty().WithMessage("Boş olmaz");
            RuleFor(x => x.WriterSurname).MinimumLength(3).WithMessage("2 den fazla karakter olmalı");
            RuleFor(x => x.WriterSurname).MaximumLength(20).WithMessage("20den fazla karakter girmeyin");
            RuleFor(x => x.WriterTitle).MinimumLength(3).WithMessage("2 den fazla karakter olmalı");
        }
    }
}
