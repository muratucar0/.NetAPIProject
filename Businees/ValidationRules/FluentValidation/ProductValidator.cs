using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businees.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {


        public ProductValidator()

        {
            RuleFor(P => P.ProductName).MinimumLength(3);
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);

            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);

            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("A Harfi ile başlamaladır"); ;
        }

        private bool StartWithA(string args)
        {
            return args.StartsWith("A");
        }
    }
}
