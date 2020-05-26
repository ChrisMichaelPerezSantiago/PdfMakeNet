﻿using Newtonsoft.Json;
using PdfMakeNet.Extensions;
using System.Collections.Generic;

namespace PdfMakeNet
{
    public class PdfMake : IPdfMake
    {
        /// <summary>
        /// The header section
        /// </summary>
        [JsonProperty("header")]
        public IList<object> Header { get; set; }
        /// <summary>
        /// The footer section
        /// </summary>
        [JsonProperty("footer")]
        public IList<object> Footer { get; set; }
        /// <summary>
        /// The body section
        /// </summary>
        [JsonProperty("content")]
        public IList<object> Body { get; set; }
        /// <summary>
        /// The background color section
        /// </summary>
        [JsonProperty("background")]
        public object Background { get; set; }
        /// <summary>
        /// The images section
        /// </summary>
        [JsonProperty("images")]
        public object Images { get; set; }
        /// <summary>
        /// The default style section
        /// </summary>
        [JsonProperty("defaultStyle")]
        public PdfMakeStyle DefaultStyle { get; set; }
        /// <summary>
        /// The style section
        /// </summary>
        [JsonProperty("styles")]
        public object Styles { get; set; }
        /// <summary>
        /// The page size option
        /// </summary>
        [JsonProperty("pageSize")]
        [JsonConverter(typeof(ToStringJsonConverter))]
        public PageSize PageSize { get; set; }
        /// <summary>
        /// The page margins option
        /// </summary>
        [JsonProperty("pageMargins")]
        public IList<int> PageMargins { get; set; }
        /// <summary>
        /// The page orientation option
        /// </summary>
        [JsonProperty("pageOrientation")]
        [JsonConverter(typeof(ToStringJsonConverter))]
        public PageOrientation PageOrientation { get; set; }
        /// <summary>
        /// The compression option
        /// </summary>
        [JsonProperty("compress")]
        public bool Compress { get; set; }
        /// <summary>
        /// The user password option
        /// </summary>
        [JsonProperty("userPassword")]
        public string UserPassword { get; set; }
        /// <summary>
        /// The owner password option
        /// </summary>
        [JsonProperty("ownerPassword")]
        public string OwnerPassword { get; set; }
        /// <summary>
        /// The permissions section
        /// </summary>
        [JsonProperty("permissions")]
        [JsonConverter(typeof(ToStringJsonConverter))]
        public PdfMakePermissions Permissions { get; set; }
        /// <summary>
        /// Default constuctor
        /// </summary>
        public PdfMake()
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
        }
        /// <summary>
        /// Overload constructor
        /// </summary>
        /// <param name="pageSize"></param>
        public PdfMake(PageSize pageSize)
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
            PageSize = pageSize;
        }
        /// <summary>
        /// Overload constructor
        /// </summary>
        /// <param name="compress"></param>
        public PdfMake(bool compress)
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
            Compress = compress;
        }
        /// <summary>
        /// Overload constructor
        /// </summary>
        /// <param name="userPassword"></param>
        /// <param name="ownerPassword"></param>
        public PdfMake(string userPassword, string ownerPassword)
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
            UserPassword = userPassword;
            OwnerPassword = ownerPassword;
        }
        /// <summary>
        /// Overload constructor
        /// </summary>
        /// <param name="permissions"></param>
        public PdfMake(PdfMakePermissions permissions)
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
            Permissions = permissions;
        }
        /// <summary>
        /// Overload constructor
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="compress"></param>
        public PdfMake(PageSize pageSize, bool compress)
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
            PageSize = pageSize;
            Compress = compress;
        }
        /// <summary>
        /// Overload constructor
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="compress"></param>
        /// <param name="userPassword"></param>
        /// <param name="ownerPassword"></param>
        public PdfMake(PageSize pageSize, bool compress, string userPassword, string ownerPassword)
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
            PageSize = pageSize;
            Compress = compress;
            UserPassword = userPassword;
            OwnerPassword = ownerPassword;
        }
        /// <summary>
        /// Overload constructor
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="compress"></param>
        /// <param name="userPassword"></param>
        /// <param name="ownerPassword"></param>
        /// <param name="permissions"></param>
        public PdfMake(PageSize pageSize, bool compress, string userPassword, string ownerPassword, PdfMakePermissions permissions)
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
            PageSize = pageSize;
            Compress = compress;
            UserPassword = userPassword;
            OwnerPassword = ownerPassword;
            Permissions = permissions;
        }
        /// <summary>
        /// Overload constructor
        /// </summary>
        /// <param name="compress"></param>
        /// <param name="userPassword"></param>
        /// <param name="ownerPassword"></param>
        public PdfMake(bool compress, string userPassword, string ownerPassword)
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
            Compress = compress;
            UserPassword = userPassword;
            OwnerPassword = ownerPassword;
        }
        /// <summary>
        /// Overload constructor
        /// </summary>
        /// <param name="compress"></param>
        /// <param name="userPassword"></param>
        /// <param name="ownerPassword"></param>
        /// <param name="permissions"></param>
        public PdfMake(bool compress, string userPassword, string ownerPassword, PdfMakePermissions permissions)
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
            Compress = compress;
            UserPassword = userPassword;
            OwnerPassword = ownerPassword;
            Permissions = permissions;
        }
        /// <summary>
        /// Overload constructor
        /// </summary>
        /// <param name="userPassword"></param>
        /// <param name="ownerPassword"></param>
        /// <param name="permissions"></param>
        public PdfMake(string userPassword, string ownerPassword, PdfMakePermissions permissions)
        {
            Body = new List<object>();
            Header = new List<object>();
            Footer = new List<object>();
            UserPassword = userPassword;
            OwnerPassword = ownerPassword;
            Permissions = permissions;
        }
        /// <summary>
        /// Adds a qr code to the body section
        /// </summary>
        /// <param name="qRCode"></param>
        public void AddBodyQRCode(IPdfMakeQRCode qRCode)
        {
            Body.Add(qRCode);
        }
        /// <summary>
        /// Adds a text to the body section
        /// </summary>
        /// <param name="PdfMakeText"></param>
        public void AddBodyText(IPdfMakeText PdfMakeText)
        {
            Body.Add(PdfMakeText);
        }
        /// <summary>
        /// Add a IList of texts to the body section
        /// </summary>
        /// <param name="PdfMakeTexts"></param>
        public void AddBodyText(IEnumerable<IPdfMakeText> PdfMakeTexts)
        {
            Body.Add(new { text = PdfMakeTexts });
        }
        /// <summary>
        /// Adds columns to the body section
        /// </summary>
        /// <param name="Columns"></param>
        public void AddBodyColumns<T>(IPdfMakeColumns<T> Columns)
        {
            Body.Add(Columns);
        }
        /// <summary>
        /// Adds a table to the body section
        /// </summary>
        /// <param name="pdfMakeTable"></param>
        public void AddBodyTable<T>(IPdfMakeTable<T> pdfMakeTable)
        {
            Body.Add(pdfMakeTable);
        }
        /// <summary>
        ///  Adds a ordered IList to the body section
        /// </summary>
        /// <param name="pdfMakeOrderedList"></param>
        public void AddBodyOrderedList<T>(IPdfMakeOrderedList<T> pdfMakeOrderedList)
        {
            Body.Add(pdfMakeOrderedList);
        }
        /// <summary>
        /// Adds a unordered IList to the body section
        /// </summary>
        /// <param name="pdfMakeUnorderedList"></param>
        public void AddBodyUnorderedList<T>(IPdfMakeUnorderedList<T> pdfMakeUnorderedList)
        {
            Body.Add(pdfMakeUnorderedList);
        }
        /// <summary>
        /// Adds a stack to the body section
        /// </summary>
        /// <param name="pdfMakeStacks"></param>
        public void AddBodyStack<T>(IPdfMakeStack<T> pdfMakeStacks)
        {
            Body.Add(new { pdfMakeStacks });
        }
        /// <summary>
        /// Adds an image to the body section
        /// </summary>
        /// <param name="pdfMakeImage"></param>
        public void AddBodyImage(IPdfMakeImage pdfMakeImage)
        {
            Body.Add(pdfMakeImage);
        }
        /// <summary>
        /// Adds a link to the body section
        /// </summary>
        /// <param name="pdfMakeLink"></param>
        public void AddBodyLink(IPdfMakeLink pdfMakeLink)
        {
            Body.Add(pdfMakeLink);
        }
        /// <summary>
        /// Adds a table of content to the body section
        /// </summary>
        /// <param name="pdfMakeTableOfContent"></param>
        public void AddTableOfContent(IPdfMakeTableOfContent pdfMakeTableOfContent)
        {
            Body.Add(pdfMakeTableOfContent);
        }
        /// <summary>
        /// Adds a qr code to the header section
        /// </summary>
        /// <param name="qRCode"></param>
        public void AddHeaderQRCode(IPdfMakeQRCode qRCode)
        {
            Header.Add(qRCode);
        }
        /// <summary>
        /// Adds a text to the header section
        /// </summary>
        /// <param name="PdfMakeText"></param>
        public void AddHeaderText(IPdfMakeText PdfMakeText)
        {
            Header.Add(PdfMakeText);
        }
        /// <summary>
        /// Adds IList of texts to the header section
        /// </summary>
        /// <param name="PdfMakeText"></param>
        public void AddHeaderText(IEnumerable<IPdfMakeText> PdfMakeTexts)
        {
            Header.Add(new { text = PdfMakeTexts });
        }
        /// <summary>
        ///  Adds text to the header section
        /// </summary>
        /// <param name="Columns"></param>
        public void AddHeaderColumns<T>(IPdfMakeColumns<T> Columns)
        {
            Header.Add(Columns);
        }
        /// <summary>
        /// Adds a table to the header section
        /// </summary>
        /// <param name="pdfMakeTable"></param>
        public void AddHeaderTable<T>(IPdfMakeTable<T> pdfMakeTable)
        {
            Header.Add(pdfMakeTable);
        }
        /// <summary>
        /// Adds a ordered IList to the header section
        /// </summary>
        /// <param name="pdfMakeOrderedList"></param>
        public void AddHeaderOrderedList<T>(IPdfMakeOrderedList<T> pdfMakeOrderedList)
        {
            Header.Add(pdfMakeOrderedList);
        }
        /// <summary>
        /// Adds a unordered IList to the header section
        /// </summary>
        /// <param name="pdfMakeUnorderedList"></param>
        public void AddHeaderUnorderedList<T>(IPdfMakeUnorderedList<T> pdfMakeUnorderedList)
        {
            Header.Add(pdfMakeUnorderedList);
        }
        /// <summary>
        /// Adds a stack to the header section
        /// </summary>
        /// <param name="pdfMakeStacks"></param>
        public void AddHeaderStack<T>(IPdfMakeStack<T> pdfMakeStacks)
        {
            Header.Add(new { pdfMakeStacks });
        }
        /// <summary>
        /// Adds an image to the header section
        /// </summary>
        /// <param name="pdfMakeImage"></param>
        public void AddHeaderImage(IPdfMakeImage pdfMakeImage)
        {
            Header.Add(pdfMakeImage);
        }
        /// <summary>
        /// Adds a link to the header section
        /// </summary>
        /// <param name="pdfMakeLink"></param>
        public void AddHeaderLink(IPdfMakeLink pdfMakeLink)
        {
            Header.Add(pdfMakeLink);
        }
        /// <summary>
        /// Adds a qr code to the footer section
        /// </summary>
        /// <param name="qRCode"></param>
        public void AddFooterQRCode(IPdfMakeQRCode qRCode)
        {
            Footer.Add(qRCode);
        }
        /// <summary>
        /// Adds a text to the footer section
        /// </summary>
        /// <param name="PdfMakeText"></param>
        public void AddFooterText(IPdfMakeText PdfMakeText)
        {
            Footer.Add(PdfMakeText);
        }
        /// <summary>
        /// Adds a IList of texts to the footer section
        /// </summary>
        /// <param name="PdfMakeTexts"></param>
        public void AddFooterText(IEnumerable<IPdfMakeText> PdfMakeTexts)
        {
            Footer.Add(new { text = PdfMakeTexts });
        }
        /// <summary>
        /// Adds a columns to the footer section
        /// </summary>
        /// <param name="Columns"></param>
        public void AddFooterColumns<T>(IPdfMakeColumns<T> Columns)
        {
            Footer.Add(Columns);
        }
        /// <summary>
        /// Adds a table to the footer section
        /// </summary>
        /// <param name="pdfMakeTable"></param>
        public void AddFooterTable<T>(IPdfMakeTable<T> pdfMakeTable)
        {
            Footer.Add(pdfMakeTable);
        }
        /// <summary>
        /// Adds a ordered IList to the footer section
        /// </summary>
        /// <param name="pdfMakeOrderedList"></param>
        public void AddFooterOrderedList<T>(IPdfMakeOrderedList<T> pdfMakeOrderedList)
        {
            Footer.Add(pdfMakeOrderedList);
        }
        /// <summary>
        /// Adds a unordered IList to the footer section
        /// </summary>
        /// <param name="pdfMakeUnorderedList"></param>
        public void AddFooterUnorderedList<T>(IPdfMakeUnorderedList<T> pdfMakeUnorderedList)
        {
            Footer.Add(pdfMakeUnorderedList);
        }
        /// <summary>
        /// Adds a stack to the footer section
        /// </summary>
        /// <param name="pdfMakeStacks"></param>
        public void AddFooterStack<T>(IPdfMakeStack<T> pdfMakeStacks)
        {
            Footer.Add(new { pdfMakeStacks });
        }
        /// <summary>
        /// Adds an image to the footer section
        /// </summary>
        /// <param name="pdfMakeImage"></param>
        public void AddFooterImage(IPdfMakeImage pdfMakeImage)
        {
            Footer.Add(pdfMakeImage);
        }
        /// <summary>
        /// Adds a link to the footer section
        /// </summary>
        /// <param name="pdfMakeLink"></param>
        public void AddFooterLink(IPdfMakeLink pdfMakeLink)
        {
            Footer.Add(pdfMakeLink);
        }
    }
}
