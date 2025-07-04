namespace _7oras.Application.Validators
{
    public class CategoryAppCreateDtoValidator : AbstractValidator<CategoryAppCreateDto>
    {
        public CategoryAppCreateDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .MaximumLength(50)
                .WithMessage("Name cannot exceed 50 characters");

            RuleFor(x => x.Description)
                .MaximumLength(1000)
                .WithMessage("Description cannot exceed 1000 characters")
                .When(x => x.Description != null);
        }
    }
}
