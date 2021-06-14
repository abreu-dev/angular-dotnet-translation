﻿using FluentValidation;
using Supply.Core.Domain.Validators;
using Supply.Domain.Commands.VehicleCommands;

namespace Supply.Domain.Validators.VehicleValidators
{
    class AddVehicleCommandValidator : CommandValidator<AddVehicleCommand>
    {
        public AddVehicleCommandValidator()
        {
            RuleFor(x => x.Plate)
                .NotEmpty()
                .WithMessage(DomainMessages.RequiredField.Format("Plate").Message);

            RuleFor(x => x.Plate)
                .Matches("^[A-Z]{3}[0-9][A-Z0-9][0-9]{2}$")
                .WithMessage(DomainMessages.InvalidFormat.Format("Plate").Message)
                .When(x => !string.IsNullOrEmpty(x.Plate));
        }
    }
}
