using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
 public   class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {

            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün adını boş geçemezsiniz");

            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage("Lütfen ürün adını 2 karakterden fazla yazınız");

            RuleFor(x => x.Stock).NotEmpty().WithMessage("Stok adeti boş geçilemez");
            RuleFor(x=> x.Price).NotEmpty().WithMessage("Fiyat boş geçilemez");



        }

    }
}
