﻿using System;

namespace Lykke.Service.Campaign.Domain.Models
{
    public class CampaignDto
    {
        public Guid Id { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsEnabled { get; set; }
    }
}
