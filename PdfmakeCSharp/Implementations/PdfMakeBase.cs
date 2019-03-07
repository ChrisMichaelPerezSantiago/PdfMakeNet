﻿using MessagePack;
using System.Collections.Generic;

namespace PdfMakeCSharp
{
    [MessagePackObject]
    public abstract class PdfMakeBase : IPdfMakeBase<object>
    {
        #region Fields
        [Key("header")]
        public List<object> Header { get; set; }
        [Key("footer")]
        public List<object> Footer { get; set; }
        [Key("content")]
        public List<object> Body { get; set; }
        [Key("background")]
        public object Background { get; set; }
        [Key("images")]
        public object Images { get; set; }
        [Key("defaultStyle")]
        public PdfMakeStyle DefaultStyle { get; set; }
        [Key("styles")]
        public object Styles { get; set; }
        [Key("pageSize")]
        public string PageSize { get; set; }
        [Key("pageMargins")]
        public List<int> PageMargins { get; set; }
        [Key("pageOrientation")]
        public string PageOrientation { get; set; }
        [Key("compress")]
        public bool Compress { get; set; }
        [Key("userPassword")]
        public string UserPassword { get; set; }
        [Key("ownerPassword")]
        public string OwnerPassword { get; set; }
        [Key("permissions")]
        public PdfMakePermissions Permissions { get; set; }
        #endregion

        #region Constructor
        public PdfMakeBase()
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
            PageSize = PdfMakeCSharp.PageSize.LETTER;
        }
        #endregion

        #region Body
        public void AddQRCode(PdfMakeQRCode qRCode)
        {
            Body.Add(qRCode);
        }

        public void AddText(PdfMakeText PdfMakeText)
        {
            Body.Add(PdfMakeText);
        }

        public void AddText(IEnumerable<PdfMakeText> PdfMakeTexts)
        {
            Body.Add(new { text = PdfMakeTexts });
        }

        public void AddColumns(PdfMakeColumns<object> Columns)
        {
            Body.Add(new { Columns });
        }

        public void AddTable(PdfMakeTable<object> pdfMakeTable)
        {
            Body.Add(pdfMakeTable);
        }

        public void AddOrderedList(PdfMakeOrderedList<object> pdfMakeOrderedList)
        {
            Body.Add(pdfMakeOrderedList);
        }

        public void AddUnorderedList(PdfMakeUnorderedList<object> pdfMakeUnorderedList)
        {
            Body.Add(pdfMakeUnorderedList);
        }

        public void AddStack(PdfMakeStack<object> pdfMakeStacks)
        {
            Body.Add(new { pdfMakeStacks });
        }

        public void AddImage(PdfMakeImage pdfMakeImage)
        {
            Body.Add(pdfMakeImage);
        }

        public void AddLink(PdfMakeLink pdfMakeLink)
        {
            Body.Add(pdfMakeLink);
        }

        public void AddTableOfContent(PdfMakeTableOfContent pdfMakeTableOfContent)
        {
            Body.Add(pdfMakeTableOfContent);
        }
        #endregion

        #region Header
        public void AddHeaderQRCode(PdfMakeQRCode qRCode)
        {
            Header.Add(qRCode);
        }

        public void AddHeaderText(PdfMakeText PdfMakeText)
        {
            Header.Add(PdfMakeText);
        }

        public void AddHeaderText(IEnumerable<PdfMakeText> PdfMakeTexts)
        {
            Header.Add(new { text = PdfMakeTexts });
        }

        public void AddHeaderColumns(PdfMakeColumns<object> Columns)
        {
            Header.Add(new { Columns });
        }

        public void AddHeaderTable(PdfMakeTable<object> pdfMakeTable)
        {
            Header.Add(pdfMakeTable);
        }

        public void AddHeaderOrderedList(PdfMakeOrderedList<object> pdfMakeOrderedList)
        {
            Header.Add(pdfMakeOrderedList);
        }

        public void AddHeaderUnorderedList(PdfMakeUnorderedList<object> pdfMakeUnorderedList)
        {
            Header.Add(pdfMakeUnorderedList);
        }

        public void AddHeaderStack(PdfMakeStack<object> pdfMakeStacks)
        {
            Header.Add(new { pdfMakeStacks });
        }

        public void AddHeaderImage(PdfMakeImage pdfMakeImage)
        {
            Header.Add(pdfMakeImage);
        }

        public void AddHeaderLink(PdfMakeLink pdfMakeLink)
        {
            Header.Add(pdfMakeLink);
        }
        #endregion

        #region Footer
        public void AddFooterQRCode(PdfMakeQRCode qRCode)
        {
            Footer.Add(qRCode);
        }

        public void AddFooterText(PdfMakeText PdfMakeText)
        {
            Footer.Add(PdfMakeText);
        }

        public void AddFooterText(IEnumerable<PdfMakeText> PdfMakeTexts)
        {
            Footer.Add(new { text = PdfMakeTexts });
        }

        public void AddFooterColumns(PdfMakeColumns<object> Columns)
        {
            Footer.Add(new { Columns });
        }

        public void AddFooterTable(PdfMakeTable<object> pdfMakeTable)
        {
            Footer.Add(pdfMakeTable);
        }

        public void AddFooterOrderedList(PdfMakeOrderedList<object> pdfMakeOrderedList)
        {
            Footer.Add(pdfMakeOrderedList);
        }

        public void AddFooterUnorderedList(PdfMakeUnorderedList<object> pdfMakeUnorderedList)
        {
            Footer.Add(pdfMakeUnorderedList);
        }

        public void AddFooterStack(PdfMakeStack<object> pdfMakeStacks)
        {
            Footer.Add(new { pdfMakeStacks });
        }

        public void AddFooterImage(PdfMakeImage pdfMakeImage)
        {
            Footer.Add(pdfMakeImage);
        }

        public void AddFooterLink(PdfMakeLink pdfMakeLink)
        {
            Footer.Add(pdfMakeLink);
        }
        #endregion
    }
}
