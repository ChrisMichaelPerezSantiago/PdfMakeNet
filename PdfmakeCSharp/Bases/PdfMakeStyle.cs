﻿using MessagePack;
using System.Collections.Generic;

namespace PdfMakeCSharp
{
    [MessagePackObject]
    public abstract class PdfMakeStyle
    {
        [Key("fontSize")]
        public int FontSize { get; set; }
        [Key("bold")]
        public bool Bold { get; set; }
        [Key("italics")]
        public bool Italics { get; set; }
        [Key("Color")]
        public string Color { get; set; }
        //margin: [left, top, right, bottom] OR margin: [horizontal, vertical] OR margin: equalLeftTopRightBottom
        [Key("margin")]
        public object Margin { get; set; }
        [Key("columnGap")]
        public int ColumnGap { get; set; }
        [Key("width")]
        public int Width { get; set; }
        [Key("height")]
        public int Height { get; set; }
        [Key("opacity")]
        public double Opacity { get; set; }
        [Key("fit")]
        public List<int> Fit { get; set; }
        [Key("tocItem")]
        public object TocItem { get; set; }
        [Key("pageBreak")]
        public PageBreak PageBreak { get; set; }
        [Key("alignment")]
        public TextAlingment Alignment { get; set; }
        [Key("pageOrientation")]
        public PageOrientation PageOrientation { get; set; }

    }
}
