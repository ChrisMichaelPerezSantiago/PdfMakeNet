﻿using Newtonsoft.Json;

namespace PdfMakeNet
{
    public class PdfMakeTable<T> : PdfMakeStyle
    {
        /// <summary>
        /// Adds a layout ot the table
        /// Available table layouts: noBorders, headerLineOnly, lightHorizontalLines. You can do table layouts as well
        /// <see cref="https://pdfmake.github.io/docs/document-definition-object/tables/"/>
        /// </summary>
        [JsonProperty("layout")]
        public string Layout { get; set; }
        /// <summary>
        /// Adds a table
        /// </summary>
        [JsonProperty("table")]
        public PdfMakeTableBody<T> TableBody { get; set; }
    }
}
