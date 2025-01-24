﻿namespace Mexc.Net.Objects.Models.Spot
{
    /// <summary>
    /// Dust transfer result
    /// </summary>
    public record MexcDustResult
    {
        /// <summary>
        /// Successfully converted
        /// </summary>
        [JsonPropertyName("successList")]
        public IEnumerable<string> Successful { get; set; } = Array.Empty<string>();
        /// <summary>
        /// Failed to convert
        /// </summary>
        [JsonPropertyName("failedList")]
        public IEnumerable<MexcFailedDust> Failed { get; set; } = Array.Empty<MexcFailedDust>();
        /// <summary>
        /// Total converted
        /// </summary>
        [JsonPropertyName("totalConvert")]
        public decimal TotalConverted { get; set; }
        /// <summary>
        /// Convert fee
        /// </summary>
        [JsonPropertyName("convertFee")]
        public decimal ConvertFee { get; set; }
    }

    /// <summary>
    /// Failed dust asset
    /// </summary>
    public record MexcFailedDust
    {
        /// <summary>
        /// Asset name
        /// </summary>
        [JsonPropertyName("asset")]
        public string Asset { get; set; } = string.Empty;
        /// <summary>
        /// Message
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; } = string.Empty;
        /// <summary>
        /// Code
        /// </summary>
        [JsonPropertyName("code")]
        public int Code { get; set; }
    }
}
