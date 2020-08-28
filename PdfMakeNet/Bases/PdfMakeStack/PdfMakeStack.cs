﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public class PdfMakeStack<T> : PdfMakeStyle, IPdfMakeStyle, IPdfMakeStack<T>
    {
        /// <summary>
        /// Adds a stack
        /// </summary>
        [JsonProperty("stack")]
        public IList<T> Stack { get; set; }
    }
}
