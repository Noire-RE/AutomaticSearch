using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomaticSearch
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 如果命令列參數包含 "--silent"，則不顯示 UI，直接執行爬蟲
            if (args.Contains("--silent"))
            {
                //Console.WriteLine("[排程執行] 背景模式，無 UI");
                TaskSchedulerHelper.RunBackgroundTask();
            }
            else
            {
                //Console.WriteLine("[手動執行] 顯示 UI");
                Application.Run(new MainForm());
            }
        }
    }
}
