using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quotify
{
    /// <summary>
    /// Provides methods for dealing with Skype's clipboard data.
    /// </summary>
    static class SkypeClipboard
    {
        private const string MessageFragmentFormat = "SkypeMessageFragment";

        /// <summary>
        /// Retrieves the message fragment that is currently on the clipboard, if any.
        /// </summary>
        /// <returns>The message fragment, or <c>null</c> if no fragment is available on the clipboard.</returns>
        public static SkypeMessageFragment GetMessage()
        {
            if (Clipboard.ContainsData(MessageFragmentFormat))
            {
                var clipboardData = Clipboard.GetData(MessageFragmentFormat) as Stream;
                if (clipboardData != null)
                {
                    string fragmentXml;
                    using (var reader = new StreamReader(clipboardData))
                        fragmentXml = reader.ReadToEnd();
                    return SkypeMessageFragment.FromXML(fragmentXml);
                }
            }
            return null;
        }

        /// <summary>
        /// Clears the clipboard and copies a message fragment onto it.
        /// </summary>
        /// <param name="message">The message fragment to copy.</param>
        public static void SetMessage(SkypeMessageFragment message)
        {
            var xml = message.ToXML();
            var xmlBytes = Encoding.ASCII.GetBytes(xml);
            using (var xmlData = new MemoryStream(xmlBytes))
            {
                var localeBytes = BitConverter.GetBytes(CultureInfo.CurrentCulture.LCID);
                using (var localeData = new MemoryStream(localeBytes))
                {
                    var data = new DataObject();
                    var plainText = message.ToPlainText();
                    data.SetData(DataFormats.StringFormat, plainText);
                    data.SetData(DataFormats.UnicodeText, plainText);
                    data.SetData(DataFormats.OemText, plainText);
                    data.SetData(DataFormats.Text, plainText);
                    data.SetData(MessageFragmentFormat, xmlData);
                    data.SetData(DataFormats.Locale, localeData);
                    Clipboard.SetDataObject(data, true);
                }
            }
        }
    }
}
