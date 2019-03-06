﻿using MessagePack;

namespace PdfMakeCSharp
{
    [MessagePackObject]
    public struct PageOrientation
    {
        public const string Landscape = "landscape";
        public const string Portrait = "portrait";
    }
}
