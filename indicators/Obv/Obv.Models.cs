﻿using System;

namespace Skender.Stock.Indicators
{
    [Serializable]
    public class ObvResult : ResultBase
    {
        public decimal Obv { get; set; }
        public decimal? Sma { get; set; }
    }
}
