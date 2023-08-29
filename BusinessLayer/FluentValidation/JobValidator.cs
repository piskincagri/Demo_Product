using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
   public class JobValidator:AbstractValidator<Job>
    {

        public JobValidator()
        {
            RuleFor(x => x.JobName).NotEmpty().WithMessage("Meslek adını boş geçemezsiniz");

            RuleFor(x => x.JobName).MinimumLength(2).WithMessage("Lütfen Meslek adını 2 karakterden fazla yazınız");

            RuleFor(x => x.JobName).NotEmpty().WithMessage("Meslek adını boş geçemezsiniz");

           

        }


    }
}
