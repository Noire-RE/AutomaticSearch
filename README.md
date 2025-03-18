# AutomaticSearch

AutomaticSearch 是一個 Windows 桌面應用程式，支援自動爬取特定網頁並定期檢查更新。該應用程式透過 Windows 工作排程器 (Task Scheduler) 來實現定時執行。

---

## 功能 Features
- 網頁爬蟲：自動爬取特定網頁資料，並記錄更新資訊
- 自訂排程：使用者可以設定執行時間、間隔等條件
- 背景執行：透過 `--silent` 模式讓程式執行時不顯示 UI
- Windows 工作排程器整合：使用 `Task Scheduler` 自動執行爬蟲
- 錯誤記錄：當爬取過程發生錯誤時，會自動記錄錯誤資訊

---

### 執行應用程式


1. 手動執行
   - 直接雙擊 `AutomaticSearch.exe`
   - 進入 UI 設定 **執行時間**、**間隔**
   - 點擊 `確定` 建立 Windows 排程

2. 在背景執行
   - 手動在命令提示字元 (CMD) 輸入：
    
