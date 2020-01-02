﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public class PdfMakeUnorderedList<T> : PdfMakeStyle
    {
        /// <summary>
        /// Add unordered list
        /// </summary>
        [JsonProperty("ul")]
        public IList<T> Ul { get; set; }
    }
}
