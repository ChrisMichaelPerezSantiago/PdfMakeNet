﻿using MessagePack;

namespace PdfMakeCSharp
{
    [MessagePackObject]
    public struct EccLevel
    {
        public const string L = "L";
        public const string M = "M";
        public const string Q = "Q";
        public const string H = "H";
    }
}
