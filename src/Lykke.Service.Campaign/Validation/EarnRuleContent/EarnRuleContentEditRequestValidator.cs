﻿using FluentValidation;
using Lykke.Service.Campaign.Client.Models.EarnRuleContent;
using Lykke.Service.Campaign.Client.Models.Enums;

namespace Lykke.Service.Campaign.Validation.EarnRuleContent
{
    public class EarnRuleContentEditRequestValidator 
        : AbstractValidator<EarnRuleContentEditRequest>
    {
        public EarnRuleContentEditRequestValidator()
        {
            RuleFor(c => c.Value)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(50)
                .When(c => c.RuleContentType == RuleContentType.Title);

            RuleFor(c => c.Value)
                .MinimumLength(3)
                .MaximumLength(1000)
                .When(c => c.RuleContentType == RuleContentType.Description);
        }
    }
}
