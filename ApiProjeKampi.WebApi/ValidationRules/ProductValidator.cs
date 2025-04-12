using ApiProjeKampi.WebApi.Entities;
using FluentValidation;

namespace ApiProjeKampi.WebApi.ValidationRules
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün Adını Boş Geçmeyin");
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage("En az 2 karakter girişi yapınız!");
            RuleFor(x => x.ProductName).MaximumLength(50).WithMessage("En Fazla 50 karakter girişi yapabilirsiniz!");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Ürün Fiyatı Boş Geçilemez!").GreaterThan(0).WithMessage("Ürün fiyatı negatif olamaz!")
                .LessThan(1000).WithMessage("Ürün Fiyatı bu kadar yüksek olamaz, girdiğiniz değeri kontrol ediniz!");

            RuleFor(x => x.ProductDescription).NotEmpty().WithMessage("Ürün Açıklaması Boş Geçilemez!");
        }
    }
}
