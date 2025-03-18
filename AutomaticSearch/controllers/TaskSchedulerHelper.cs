using Microsoft.Win32.TaskScheduler;
using System;
using System.IO;
using System.Windows.Forms;
using WebpageTracking.Controllers;
public class TaskSchedulerHelper
{
    private static string taskName = "MyWebCrawlerTask"; // Windows 工作排程器的名稱

    public static void CreateTask(int daysInterval, string startTime, int repeatHours)
    {
        try
        {
            using (TaskService ts = new TaskService())
            {
                string exePath = Application.ExecutablePath;

                Task existingTask = ts.FindTask(taskName);
                if (existingTask != null)
                {
                    ts.RootFolder.DeleteTask(taskName);
                }

                TaskDefinition td = ts.NewTask();
                td.RegistrationInfo.Description = "定時執行 Web Crawler 應用程式";
                td.Principal.RunLevel = TaskRunLevel.Highest; // 以最高權限執行

                // 解析 UI 輸入的時間
                string[] timeParts = startTime.Split(':');
                if (timeParts.Length != 2 ||
                    !int.TryParse(timeParts[0], out int startHour) ||
                    !int.TryParse(timeParts[1], out int startMinute))
                {
                    MessageBox.Show("時間格式錯誤，請輸入 HH:mm", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 設定使用者選擇的時間作為排程執行時間
                DailyTrigger trigger = new DailyTrigger
                {
                    StartBoundary = DateTime.Today.AddHours(startHour).AddMinutes(startMinute),
                    DaysInterval = (short)daysInterval // 每 X 天執行一次
                };
                td.Triggers.Add(trigger);

                // 設定重複執行間隔
                if (repeatHours > 0)
                {
                    TimeTrigger repeatTrigger = new TimeTrigger
                    {
                        StartBoundary = DateTime.Today.AddHours(startHour).AddMinutes(startMinute),
                        Repetition = new RepetitionPattern(TimeSpan.FromHours(repeatHours), TimeSpan.Zero)
                    };
                    td.Triggers.Add(repeatTrigger);
                }

                // 設定執行 .exe，加上 --silent 參數讓它不顯示 UI
                td.Actions.Add(new ExecAction(exePath, "--silent", Path.GetDirectoryName(exePath)));

                // 註冊排程
                ts.RootFolder.RegisterTaskDefinition(taskName, td);
            }

            MessageBox.Show("Windows 排程已建立！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"建立 Windows 排程時發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Console.WriteLine(ex);
        }
    }



    public static void DeleteTask()
    {
        try
        {
            using (TaskService ts = new TaskService())
            {
                Task existingTask = ts.FindTask(taskName);
                if (existingTask != null)
                {
                    ts.RootFolder.DeleteTask(taskName);
                    MessageBox.Show("Windows 排程已刪除！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("找不到指定的排程！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"刪除 Windows 排程時發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static void RunBackgroundTask()
    {
        try
        {
            SearchUpdata webScraper = new SearchUpdata();
            string result = webScraper.CheckForUpdates().Result; // 直接執行爬蟲

            // 記錄到 Log，避免 UI 顯示
            File.AppendAllText("TaskLog.txt", $"{DateTime.Now}: {result}\n");
        }
        catch (Exception ex)
        {
            File.AppendAllText("TaskLog.txt", $"{DateTime.Now}: 錯誤 - {ex.Message}\n");
        }
    }
}
