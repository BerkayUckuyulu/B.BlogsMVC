using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules_FluentValidation
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adı Boş Olamaz");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklama Boş Olamaz");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("3 den fazla karakter olmalı");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("20den fazla karakter girmeyin");

        }
    }
}
