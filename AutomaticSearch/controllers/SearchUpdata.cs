using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using HtmlAgilityPack;

namespace WebpageTracking.Controllers
{
    internal class SearchUpdata
    {
        private static readonly string url = "https://www.nhi.gov.tw/ch/cp-5622-8092a-2466-1.html"; // 目標網站
        private static readonly string xpath1 = "//div[@class='contentbox']/article[@class='cpArticle']/p"; // 資料筆數 XPath
        private static readonly string xpath2 = "//div[@class='contentbox']/section[@class='pubInfo']//dt[text()='更新日期']/following-sibling::dd/time"; // 更新日期 XPath
        private static readonly string logFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Records.log");
        private static readonly string errorLogFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Error.log");

        public async Task<string> CheckForUpdates()
        {
            try
            {
                string targetText = await FetchTargetText();
                string oldText = File.Exists(logFile) ? File.ReadLines(logFile).LastOrDefault() : "";

                if (targetText != oldText)
                {
                    File.AppendAllText(logFile, targetText + Environment.NewLine);
                    return "更新發現: " + targetText;
                }
                else
                {
                    return "沒有新的更新。";
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(errorLogFile, $"{DateTime.Now}: {ex.Message}\n");
                return "檢查時發生錯誤：" + ex.Message;
            }
        }

        private async Task<string> FetchTargetText()
        {
            using (HttpClient client = new HttpClient())
            {
                string html = await client.GetStringAsync(url);
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);

                HtmlNode node1 = doc.DocumentNode.SelectSingleNode(xpath1);
                HtmlNode node2 = doc.DocumentNode.SelectSingleNode(xpath2);

                if (node1 == null || node2 == null)
                {
                    throw new Exception("找不到目標標籤，請檢查 XPath 是否正確");
                }

                string text1 = node1.InnerText.Trim();
                Match match = Regex.Match(text1, @"資料筆數共計([\d,]+筆)");

                if (!match.Success)
                {
                    throw new Exception("找不到資料筆數");
                }

                string text2 = node2.InnerText.Trim();
                return match.Value + "，更新日期: " + text2;
            }
        }
    }
}
