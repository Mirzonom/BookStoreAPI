using BookStore.API.Models;
using FluentValidation;

namespace BookStore.API.Validators;

public class BookValidator : AbstractValidator<Book>
{
    public BookValidator()
    {
        // выключил валидацию id так как при создание у нас автоматом создаётся id
        //RuleFor(x => x.Id).NotEmpty().WithMessage("Укажите id книги"); 
        RuleFor(x => x.Title).NotEmpty().WithMessage("Укажите название книги");
        RuleFor(x => x.Price).NotEmpty().WithMessage("Укажите цену книги");
        RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Укажите изоброжение книги");
        RuleFor(x => x.Category).NotEmpty().WithMessage("Укажите категорию книги");
        RuleFor(x => x.Authors).NotEmpty().WithMessage("Укажите автора-ов книги");
        
    }
}