using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Quotify
{
    /// <summary>
    /// A part of a Skype message.
    /// </summary>
    class SkypeMessageFragment
    {
        public SkypeMessageFragment()
        {
            Author = "";
            Message = "";
            Time = DateTime.Now;
        }

        /// <summary>
        /// Gets or sets the message author.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets the message contents.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the message time.
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// Creates a message fragment from an XML string.
        /// </summary>
        /// <param name="xml">The XML string to parse.</param>
        /// <returns>The message fragment.</returns>
        public static SkypeMessageFragment FromXML(string xml)
        {
            var result = new SkypeMessageFragment();
            var doc = XDocument.Parse(xml, LoadOptions.PreserveWhitespace);
            var quote = doc.Element("quote");

            if (quote.Attribute("authorname") != null)
                result.Author = quote.Attribute("authorname").Value;

            if (quote.Attribute("timestamp") != null)
                result.Time = UnixTime.ToDateTime(long.Parse(quote.Attribute("timestamp").Value));

            // Concatenate all of the text nodes in the quote element, ignoring nodes such as <legacyquote>
            result.Message = quote.Nodes()
                .Where(n => n.NodeType == XmlNodeType.Text || n.NodeType == XmlNodeType.Whitespace || n.NodeType == XmlNodeType.SignificantWhitespace)
                .Aggregate("", (r, n) => r += WebUtility.HtmlDecode(n.ToString()));

            return result;
        }

        /// <summary>
        /// Creates an XML string from the message fragment.
        /// </summary>
        /// <returns>The XML string.</returns>
        public string ToXML()
        {
            return string.Format("<quote authorname=\"{0}\" timestamp=\"{1}\"><legacyquote>[{2}] {3}: </legacyquote>{4}<legacyquote>\n\n&lt;&lt;&lt; </legacyquote></quote>",
                WebUtility.HtmlEncode(Author),
                UnixTime.FromDateTime(Time),
                Time.ToLocalTime().ToString("h:mm:ss tt"),
                WebUtility.HtmlEncode(Author),
                WebUtility.HtmlEncode(Message));
        }

        /// <summary>
        /// Creates a plaintext string from the message fragment.
        /// </summary>
        /// <returns>The plaintext string.</returns>
        public string ToPlainText()
        {
            return string.Format("[{0}] {1}: {2}",
                Time.ToLocalTime().ToString("h:mm:ss tt"),
                Author,
                Message);
        }
    }
}
