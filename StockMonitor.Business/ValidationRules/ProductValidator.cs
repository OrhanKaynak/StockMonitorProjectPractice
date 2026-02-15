using FluentValidation;
using StockMonitor.Entities;

namespace StockMonitor.Business.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator() 
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün adı boş geçilemez!");
            RuleFor(p => p.ProductName).MinimumLength(2).WithMessage("Ürün adı en az 2 karakter olmalıdır!");

            RuleFor(p => p.Price).GreaterThan(0).WithMessage("Ürün fiyatı 0'dan büyük olmalıdır!");
            RuleFor(p => p.Stock).GreaterThanOrEqualTo(0).WithMessage("Ürün stoğu 0 ya da daha büyük bir sayı olmalıdır!");
        }
    }
}
