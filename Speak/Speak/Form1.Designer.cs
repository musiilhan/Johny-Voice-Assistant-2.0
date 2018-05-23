namespace Speak
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ForwardBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.MaximizeBtn = new System.Windows.Forms.Button();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.ConvertedText = new System.Windows.Forms.TextBox();
            this.MyPC = new System.Windows.Forms.Button();
            this.PlayerBtn = new System.Windows.Forms.Button();
            this.WeatherBtn = new System.Windows.Forms.Button();
            this.NewsBtn = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(72, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(72, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchBox.ForeColor = System.Drawing.Color.LavenderBlush;
            this.SearchBox.Location = new System.Drawing.Point(121, 64);
            this.SearchBox.Multiline = true;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(1003, 40);
            this.SearchBox.TabIndex = 2;
            this.SearchBox.Text = "https://";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackBtn.ForeColor = System.Drawing.Color.Crimson;
            this.BackBtn.Location = new System.Drawing.Point(12, 64);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(49, 40);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "<";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ForwardBtn
            // 
            this.ForwardBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ForwardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForwardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForwardBtn.ForeColor = System.Drawing.Color.Crimson;
            this.ForwardBtn.Location = new System.Drawing.Point(67, 64);
            this.ForwardBtn.Name = "ForwardBtn";
            this.ForwardBtn.Size = new System.Drawing.Size(48, 40);
            this.ForwardBtn.TabIndex = 4;
            this.ForwardBtn.Text = ">";
            this.ForwardBtn.UseVisualStyleBackColor = false;
            this.ForwardBtn.Click += new System.EventHandler(this.ForwardBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchBtn.ForeColor = System.Drawing.Color.Crimson;
            this.SearchBtn.Location = new System.Drawing.Point(1130, 61);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(112, 40);
            this.SearchBtn.TabIndex = 5;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBtn.ForeColor = System.Drawing.Color.Crimson;
            this.CloseBtn.Location = new System.Drawing.Point(1242, 12);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(43, 37);
            this.CloseBtn.TabIndex = 6;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MaximizeBtn
            // 
            this.MaximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBtn.ForeColor = System.Drawing.Color.Crimson;
            this.MaximizeBtn.Location = new System.Drawing.Point(1194, 12);
            this.MaximizeBtn.Name = "MaximizeBtn";
            this.MaximizeBtn.Size = new System.Drawing.Size(42, 37);
            this.MaximizeBtn.TabIndex = 7;
            this.MaximizeBtn.Text = "[ ]";
            this.MaximizeBtn.UseVisualStyleBackColor = false;
            this.MaximizeBtn.Click += new System.EventHandler(this.MaximizeBtn_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.ForeColor = System.Drawing.Color.Crimson;
            this.MinimizeBtn.Location = new System.Drawing.Point(1148, 12);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(40, 37);
            this.MinimizeBtn.TabIndex = 8;
            this.MinimizeBtn.Text = "__";
            this.MinimizeBtn.UseVisualStyleBackColor = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(10, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(10, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date:";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(12, 156);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1112, 429);
            this.webBrowser1.TabIndex = 11;
            this.webBrowser1.Url = new System.Uri("https://www.google.com/", System.UriKind.Absolute);
            // 
            // ReadBtn
            // 
            this.ReadBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ReadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadBtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadBtn.ForeColor = System.Drawing.Color.Crimson;
            this.ReadBtn.Location = new System.Drawing.Point(12, 110);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(101, 40);
            this.ReadBtn.TabIndex = 12;
            this.ReadBtn.Text = "Read";
            this.ReadBtn.UseVisualStyleBackColor = false;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // PauseBtn
            // 
            this.PauseBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PauseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PauseBtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PauseBtn.ForeColor = System.Drawing.Color.Crimson;
            this.PauseBtn.Location = new System.Drawing.Point(121, 110);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(101, 40);
            this.PauseBtn.TabIndex = 13;
            this.PauseBtn.Text = "Pause";
            this.PauseBtn.UseVisualStyleBackColor = false;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopBtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopBtn.ForeColor = System.Drawing.Color.Crimson;
            this.StopBtn.Location = new System.Drawing.Point(228, 110);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(101, 40);
            this.StopBtn.TabIndex = 14;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = false;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // ConvertedText
            // 
            this.ConvertedText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConvertedText.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ConvertedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConvertedText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConvertedText.Location = new System.Drawing.Point(12, 591);
            this.ConvertedText.Multiline = true;
            this.ConvertedText.Name = "ConvertedText";
            this.ConvertedText.Size = new System.Drawing.Size(1112, 63);
            this.ConvertedText.TabIndex = 15;
            this.ConvertedText.Text = "Converted Text:";
            // 
            // MyPC
            // 
            this.MyPC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MyPC.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MyPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyPC.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyPC.ForeColor = System.Drawing.Color.Crimson;
            this.MyPC.Location = new System.Drawing.Point(1014, 110);
            this.MyPC.Name = "MyPC";
            this.MyPC.Size = new System.Drawing.Size(110, 40);
            this.MyPC.TabIndex = 17;
            this.MyPC.Text = "My PC";
            this.MyPC.UseVisualStyleBackColor = false;
            this.MyPC.Click += new System.EventHandler(this.MyPC_Click);
            // 
            // PlayerBtn
            // 
            this.PlayerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayerBtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerBtn.ForeColor = System.Drawing.Color.Crimson;
            this.PlayerBtn.Location = new System.Drawing.Point(887, 110);
            this.PlayerBtn.Name = "PlayerBtn";
            this.PlayerBtn.Size = new System.Drawing.Size(112, 40);
            this.PlayerBtn.TabIndex = 18;
            this.PlayerBtn.Text = "Player";
            this.PlayerBtn.UseVisualStyleBackColor = false;
            this.PlayerBtn.Click += new System.EventHandler(this.PlayerBtn_Click);
            // 
            // WeatherBtn
            // 
            this.WeatherBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WeatherBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WeatherBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeatherBtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeatherBtn.ForeColor = System.Drawing.Color.Crimson;
            this.WeatherBtn.Location = new System.Drawing.Point(759, 110);
            this.WeatherBtn.Name = "WeatherBtn";
            this.WeatherBtn.Size = new System.Drawing.Size(112, 40);
            this.WeatherBtn.TabIndex = 19;
            this.WeatherBtn.Text = "Weather";
            this.WeatherBtn.UseVisualStyleBackColor = false;
            this.WeatherBtn.Click += new System.EventHandler(this.WeatherBtn_Click);
            // 
            // NewsBtn
            // 
            this.NewsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewsBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NewsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewsBtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewsBtn.ForeColor = System.Drawing.Color.Crimson;
            this.NewsBtn.Location = new System.Drawing.Point(629, 110);
            this.NewsBtn.Name = "NewsBtn";
            this.NewsBtn.Size = new System.Drawing.Size(112, 40);
            this.NewsBtn.TabIndex = 21;
            this.NewsBtn.Text = "News";
            this.NewsBtn.UseVisualStyleBackColor = false;
            this.NewsBtn.Click += new System.EventHandler(this.NewsBtn_Click);
            // 
            // info
            // 
            this.info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.info.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.ForeColor = System.Drawing.Color.Snow;
            this.info.Location = new System.Drawing.Point(1130, 301);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(155, 353);
            this.info.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(189, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Day:";
            // 
            // day
            // 
            this.day.AutoSize = true;
            this.day.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.day.ForeColor = System.Drawing.Color.Snow;
            this.day.Location = new System.Drawing.Point(248, 3);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(62, 25);
            this.day.TabIndex = 26;
            this.day.Text = "Time:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1155, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 44);
            this.label6.TabIndex = 27;
            this.label6.Text = "Day:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(1155, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 29);
            this.label7.TabIndex = 28;
            this.label7.Text = "Battery";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImage = global::Speak.Properties.Resources._4k_abstract_red_background_animation_loop_ekxbi_n5__F0000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1297, 661);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.day);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.info);
            this.Controls.Add(this.NewsBtn);
            this.Controls.Add(this.WeatherBtn);
            this.Controls.Add(this.PlayerBtn);
            this.Controls.Add(this.MyPC);
            this.Controls.Add(this.ConvertedText);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.PauseBtn);
            this.Controls.Add(this.ReadBtn);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MinimizeBtn);
            this.Controls.Add(this.MaximizeBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.ForwardBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Assistant Johny ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button ForwardBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button MaximizeBtn;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.TextBox ConvertedText;
        private System.Windows.Forms.Button MyPC;
        private System.Windows.Forms.Button PlayerBtn;
        private System.Windows.Forms.Button WeatherBtn;
        private System.Windows.Forms.Button NewsBtn;
        private System.Windows.Forms.TextBox info;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label day;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

