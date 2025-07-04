using _7oras.Application.Shared.Dtos.Request.SubCategory;

namespace _7oras.Application.Validators
{
    public class SubCategoryAppUpdateValidator : AbstractValidator<SubCategoryAppUpdateDto>
    {
        public SubCategoryAppUpdateValidator()
        {
            RuleFor(x => x.Id)
            .NotEmpty();

            RuleFor(x => x.Name)
             .NotEmpty()
             .MaximumLength(100);

            RuleFor(x => x.Description)
             .MaximumLength(500);

            RuleFor(x => x.CategoryId)
             .NotEmpty();
        }
    }
}
