﻿using JetBrains.Annotations;

namespace Lykke.Service.Campaign.Client.Models.Enums
{
    /// <summary>
    /// Represents Campaign status
    /// </summary>
    [PublicAPI]
    public enum CampaignStatus
    {
        /// <summary>
        /// Represents status of the Campaign that has not begin yet
        /// </summary>
        Pending,

        /// <summary>
        /// Represents status of the Campaign that is currently Active
        /// </summary>
        Active,

        /// <summary>
        /// Represents status of the Campaign that is already Completed
        /// </summary>
        Completed,

        /// <summary>
        /// Represents status of the Campaign that has been manually deleted
        /// </summary>
        Inactive
    }
}
