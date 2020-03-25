﻿using JetBrains.Annotations;
using Lykke.Service.PartnerManagement.Client.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Lykke.Service.Campaign.Client.Models.BonusType
{
    /// <summary>
    /// Represent a Bonus Type Edit model
    /// </summary>
    [PublicAPI]
    public class BonusTypeEditModel
    {
        /// <summary>
        /// Represents Name of the Bonus Type
        /// Required field (3-64 characters)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Represents Display Name of the Bonus Type
        /// Required field (3-200 characters)
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Represents Availability of the Bonus Type
        /// </summary>
        public bool IsAvailable { get; set; }
        
        /// <summary>
        /// Vertical to which Bonus Type belongs
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public Vertical? Vertical { set; get; }
        
        /// <summary>
        /// Does the Bonus Type allow infinite repetitions
        /// </summary>
        public bool AllowInfinite { set; get; }
        
        /// <summary>
        /// Does the Bonus Type allow percentage
        /// </summary>
        public bool AllowPercentage { set; get; }

        /// <summary>
        /// Does the Bonus Type allow conversion rate
        /// </summary>
        public bool AllowConversionRate { set; get; }

        /// <summary>
        /// Indicates if the bonus type can be stakeable
        /// </summary>
        public bool IsStakeable { get; set; }

        /// <summary>
        /// Indicates if the bonus type should be hidden
        /// </summary>
        public bool IsHidden { get; set; }

        /// <summary>
        /// Indicates bonus type's list order
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Indicates if the bonus type has ratio
        /// </summary>
        public bool RewardHasRatio { get; set; }
    }
}
