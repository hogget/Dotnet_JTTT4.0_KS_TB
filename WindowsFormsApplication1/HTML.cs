using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace WindowsFormsApplication1
{
    class Html
    {
        public string GetPageHtml(String url)
        {
            using (var wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                var html = WebUtility.HtmlDecode(wc.DownloadString(url));
                return html;
            }
        }

        public List<string> GetImagesFromPageWithKey(string url, string key)
        {
            var doc = new HtmlAgilityPack.HtmlDocument();
            var pageHtml = GetPageHtml(url);
            doc.LoadHtml(pageHtml);
            var nodes = doc.DocumentNode.Descendants("img");
            List<string> output = new List<string>();
            foreach (var node in nodes)
            {
                var value1 = node.GetAttributeValue("alt", "");
                bool znalezionoObrazekZSzukanymKluczem = value1.Substring(0, value1.Length).Contains(key);

                if (znalezionoObrazekZSzukanymKluczem)
                    output.Add(node.GetAttributeValue("src", ""));
            }
            return output;
        }
    }
}
