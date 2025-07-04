namespace _7oras.Application.Validators
{
    public class CategoryAppUpdateDtoValidator : AbstractValidator<CategoryAppUpdateDto>
    {
        public CategoryAppUpdateDtoValidator()
        {
            RuleFor(x => x.Id)
               .NotEmpty();

            RuleFor(x => x.Name)
                .NotEmpty()
                .MaximumLength(100);

            RuleFor(x => x.Description)
                .MaximumLength(500);
        }
    }
}
