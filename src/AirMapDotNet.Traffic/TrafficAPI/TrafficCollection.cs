using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AirMapDotNet.Entities.TrafficAPI
{
    /// <summary>
    /// Describes an collection of <see cref="TrafficAPI.Traffic"/> entities.
    /// </summary>
    internal sealed class TrafficCollection
    {
        [JsonProperty("traffic")]
        internal Traffic[] Traffic { get; set; }
    }
}