using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
  public  class CustomerValidator:AbstractValidator<Customer>
    {

        public CustomerValidator()
        {
            RuleFor(x => x.CustomerName).NotEmpty().WithMessage("Müşteri adını boş geçemezsiniz");

            RuleFor(x => x.CustomerName).MinimumLength(2).WithMessage("Lütfen Müşteri adını 2 karakterden fazla yazınız");

            RuleFor(x => x.CustomerCity).NotEmpty().WithMessage("Şehir adını boş geçemezsiniz");

            RuleFor(x => x.CustomerCity).MinimumLength(2).WithMessage("Lütfen Şehir adını 2 karakterden fazla yazınız");

        }
      

    }
}
