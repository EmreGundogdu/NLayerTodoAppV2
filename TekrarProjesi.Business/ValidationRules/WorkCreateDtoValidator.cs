﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TekrarProjesi.Dtos.WorkDtos;

namespace TekrarProjesi.Business.ValidationRules
{
    public class WorkCreateDtoValidator : AbstractValidator<WorkCreateDto>
    {
        public WorkCreateDtoValidator()
        {
            RuleFor(x => x.Definition).NotEmpty();
        }        
    }
}