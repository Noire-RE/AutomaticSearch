namespace AutomaticSearch
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.maxNumericP1 = new System.Windows.Forms.NumericUpDown();
            this.repNumericP1 = new System.Windows.Forms.NumericUpDown();
            this.dayNumericP1 = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stTextBoxP1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumericP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNumericP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayNumericP1)).BeginInit();
            this.SuspendLayout();
            // 
            // maxNumericP1
            // 
            this.maxNumericP1.Location = new System.Drawing.Point(163, 160);
            this.maxNumericP1.Name = "maxNumericP1";
            this.maxNumericP1.Size = new System.Drawing.Size(57, 29);
            this.maxNumericP1.TabIndex = 44;
            this.maxNumericP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxNumericP1.ValueChanged += new System.EventHandler(this.maxNumericP1_ValueChanged);
            // 
            // repNumericP1
            // 
            this.repNumericP1.Location = new System.Drawing.Point(130, 111);
            this.repNumericP1.Name = "repNumericP1";
            this.repNumericP1.Size = new System.Drawing.Size(57, 29);
            this.repNumericP1.TabIndex = 43;
            this.repNumericP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dayNumericP1
            // 
            this.dayNumericP1.Location = new System.Drawing.Point(67, 21);
            this.dayNumericP1.Name = "dayNumericP1";
            this.dayNumericP1.Size = new System.Drawing.Size(57, 29);
            this.dayNumericP1.TabIndex = 41;
            this.dayNumericP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 20);
            this.label15.TabIndex = 53;
            this.label15.Text = "工作執行時間大於";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 20);
            this.label13.TabIndex = 51;
            this.label13.Text = "重複工作每隔";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "時段";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "小時";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "小時即停止";
            // 
            // stTextBoxP1
            // 
            this.stTextBoxP1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stTextBoxP1.Location = new System.Drawing.Point(147, 66);
            this.stTextBoxP1.Mask = "90:00";
            this.stTextBoxP1.Name = "stTextBoxP1";
            this.stTextBoxP1.Size = new System.Drawing.Size(57, 29);
            this.stTextBoxP1.TabIndex = 42;
            this.stTextBoxP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stTextBoxP1.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "每日排程開始於";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "天執行排程";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "每隔";
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.okButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.okButton.Location = new System.Drawing.Point(332, 76);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(117, 50);
            this.okButton.TabIndex = 58;
            this.okButton.Text = "排程開始";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Location = new System.Drawing.Point(332, 139);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(117, 50);
            this.exitButton.TabIndex = 57;
            this.exitButton.TabStop = false;
            this.exitButton.Text = "排程取消";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(387, 167);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 20);
            this.label14.TabIndex = 56;
            // 
            // checkButton
            // 
            this.checkButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkButton.Location = new System.Drawing.Point(332, 16);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(117, 50);
            this.checkButton.TabIndex = 59;
            this.checkButton.Text = "手動查詢";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 211);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.maxNumericP1);
            this.Controls.Add(this.repNumericP1);
            this.Controls.Add(this.dayNumericP1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stTextBoxP1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "自動排程查詢健保網頁";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maxNumericP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repNumericP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayNumericP1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown maxNumericP1;
        private System.Windows.Forms.NumericUpDown repNumericP1;
        private System.Windows.Forms.NumericUpDown dayNumericP1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox stTextBoxP1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button checkButton;
    }
}

