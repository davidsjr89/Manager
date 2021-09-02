using Domain.Entities;
using FluentValidation;
namespace Domain.Validators
{
    public class UserValidator: AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x)
                .NotEmpty().WithMessage("A entidade n�o pode ser vazia.")
                .NotNull().WithMessage("A entidade n�o pode ser nula.");

            RuleFor(x => x.Name)
                .NotNull().WithMessage("O nome n�o pode ser nulo.")
                .NotEmpty().WithMessage("O nome n�o pode ser vazio.")
                .MinimumLength(3).WithMessage("O nome deve ter no m�nimo 3 caracteres")
                .MaximumLength(80).WithMessage("O nome deve ter no m�ximo 80 caracteres");

            RuleFor(x => x.Email)
                .NotNull().WithMessage("O email n�o pode ser nulo.")
                .NotEmpty().WithMessage("O email n�o pode ser vazio.")
                .MinimumLength(5).WithMessage("O nome deve ter no m�nimo 5 caracteres")
                .MaximumLength(180).WithMessage("O nome deve ter no m�ximo 180 caracteres")
                .Matches(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
                .WithMessage("O email informado n�o � v�lido.");
        }    
    }
}