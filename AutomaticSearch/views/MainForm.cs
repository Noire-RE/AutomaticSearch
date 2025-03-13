using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebpageTracking.Controllers;

namespace AutomaticSearch
{
    public partial class MainForm : Form
    {
        private SearchUpdata _webScraper;

        public MainForm()
        {
            InitializeComponent();
            _webScraper = new SearchUpdata();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 手動設定位置
            this.StartPosition = FormStartPosition.Manual; 

            //螢幕可用寬度與高度
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;  
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            //取得視窗寬度與高度
            int windowWidth = this.Width;   
            int windowHeight = this.Height; 

            // 設定視窗位置到右下角
            this.Location = new Point(screenWidth - windowWidth, screenHeight - windowHeight);
            this.stTextBoxP1.Text = "0000";
        }

        private void maxNumericP1_ValueChanged(object sender, EventArgs e)
        {
            if (maxNumericP1.Value > 24)
            {
                maxNumericP1.Value = 24;
            }
        }
        private async void checkButton_Click(object sender, EventArgs e)
        {
            checkButton.Enabled = false; // 避免多次點擊

            string result = await _webScraper.CheckForUpdates(); 

            MessageBox.Show(result, "查詢結果", MessageBoxButtons.OK, MessageBoxIcon.Information); 

            checkButton.Enabled = true; 
        }





    }
}
