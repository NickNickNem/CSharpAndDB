namespace Exam
{
    partial class ProductPost
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
            this.CloseBT = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.Chat_BT = new System.Windows.Forms.Button();
            this.Explanation_T = new System.Windows.Forms.TextBox();
            this.Explanation_L = new System.Windows.Forms.Label();
            this.Time_T = new System.Windows.Forms.TextBox();
            this.Time_L = new System.Windows.Forms.Label();
            this.Area_T = new System.Windows.Forms.TextBox();
            this.Area_L = new System.Windows.Forms.Label();
            this.Price_L = new System.Windows.Forms.Label();
            this.Price_T = new System.Windows.Forms.TextBox();
            this.Name_T = new System.Windows.Forms.TextBox();
            this.Name_L = new System.Windows.Forms.Label();
            this.Nickname_T = new System.Windows.Forms.TextBox();
            this.Trade_T = new System.Windows.Forms.TextBox();
            this.Trade_L = new System.Windows.Forms.Label();
            this.Trust_L = new System.Windows.Forms.Label();
            this.Trust_T = new System.Windows.Forms.TextBox();
            this.MemDate_L = new System.Windows.Forms.Label();
            this.MemDate_T = new System.Windows.Forms.TextBox();
            this.Nickname_L = new System.Windows.Forms.Label();
            this.Chat_G = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chat_L = new System.Windows.Forms.Label();
            this.Date_T = new System.Windows.Forms.TextBox();
            this.Date_L = new System.Windows.Forms.Label();
            this.Chat_T = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.게시글ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Chat_G)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseBT
            // 
            this.CloseBT.Location = new System.Drawing.Point(400, 925);
            this.CloseBT.Name = "CloseBT";
            this.CloseBT.Size = new System.Drawing.Size(75, 25);
            this.CloseBT.TabIndex = 35;
            this.CloseBT.Text = "닫기";
            this.CloseBT.UseVisualStyleBackColor = true;
            this.CloseBT.Click += new System.EventHandler(this.CloseBT_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(20, 925);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 25);
            this.Refresh.TabIndex = 34;
            this.Refresh.Text = "새로고침";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Chat_BT
            // 
            this.Chat_BT.Location = new System.Drawing.Point(400, 875);
            this.Chat_BT.Name = "Chat_BT";
            this.Chat_BT.Size = new System.Drawing.Size(75, 25);
            this.Chat_BT.TabIndex = 33;
            this.Chat_BT.Text = "댓글등록";
            this.Chat_BT.UseVisualStyleBackColor = true;
            this.Chat_BT.Click += new System.EventHandler(this.Chat_BT_Click);
            // 
            // Explanation_T
            // 
            this.Explanation_T.Enabled = false;
            this.Explanation_T.Location = new System.Drawing.Point(50, 275);
            this.Explanation_T.Multiline = true;
            this.Explanation_T.Name = "Explanation_T";
            this.Explanation_T.Size = new System.Drawing.Size(400, 225);
            this.Explanation_T.TabIndex = 32;
            // 
            // Explanation_L
            // 
            this.Explanation_L.AutoSize = true;
            this.Explanation_L.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.Explanation_L.Location = new System.Drawing.Point(200, 240);
            this.Explanation_L.Name = "Explanation_L";
            this.Explanation_L.Size = new System.Drawing.Size(124, 27);
            this.Explanation_L.TabIndex = 31;
            this.Explanation_L.Text = "참고사항";
            // 
            // Time_T
            // 
            this.Time_T.Enabled = false;
            this.Time_T.Location = new System.Drawing.Point(100, 200);
            this.Time_T.Name = "Time_T";
            this.Time_T.Size = new System.Drawing.Size(375, 23);
            this.Time_T.TabIndex = 30;
            // 
            // Time_L
            // 
            this.Time_L.AutoSize = true;
            this.Time_L.Location = new System.Drawing.Point(20, 205);
            this.Time_L.Name = "Time_L";
            this.Time_L.Size = new System.Drawing.Size(52, 14);
            this.Time_L.TabIndex = 29;
            this.Time_L.Text = "시간대";
            // 
            // Area_T
            // 
            this.Area_T.Enabled = false;
            this.Area_T.Location = new System.Drawing.Point(100, 150);
            this.Area_T.Name = "Area_T";
            this.Area_T.Size = new System.Drawing.Size(375, 23);
            this.Area_T.TabIndex = 28;
            // 
            // Area_L
            // 
            this.Area_L.AutoSize = true;
            this.Area_L.Location = new System.Drawing.Point(20, 155);
            this.Area_L.Name = "Area_L";
            this.Area_L.Size = new System.Drawing.Size(37, 14);
            this.Area_L.TabIndex = 27;
            this.Area_L.Text = "장소";
            // 
            // Price_L
            // 
            this.Price_L.AutoSize = true;
            this.Price_L.Location = new System.Drawing.Point(450, 105);
            this.Price_L.Name = "Price_L";
            this.Price_L.Size = new System.Drawing.Size(22, 14);
            this.Price_L.TabIndex = 26;
            this.Price_L.Text = "원";
            // 
            // Price_T
            // 
            this.Price_T.Enabled = false;
            this.Price_T.Location = new System.Drawing.Point(375, 100);
            this.Price_T.Name = "Price_T";
            this.Price_T.Size = new System.Drawing.Size(75, 23);
            this.Price_T.TabIndex = 25;
            this.Price_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Name_T
            // 
            this.Name_T.Enabled = false;
            this.Name_T.Location = new System.Drawing.Point(100, 100);
            this.Name_T.Name = "Name_T";
            this.Name_T.Size = new System.Drawing.Size(250, 23);
            this.Name_T.TabIndex = 24;
            // 
            // Name_L
            // 
            this.Name_L.AutoSize = true;
            this.Name_L.Location = new System.Drawing.Point(20, 105);
            this.Name_L.Name = "Name_L";
            this.Name_L.Size = new System.Drawing.Size(58, 14);
            this.Name_L.TabIndex = 23;
            this.Name_L.Text = "글 제목";
            // 
            // Nickname_T
            // 
            this.Nickname_T.Enabled = false;
            this.Nickname_T.Location = new System.Drawing.Point(20, 50);
            this.Nickname_T.Name = "Nickname_T";
            this.Nickname_T.Size = new System.Drawing.Size(125, 23);
            this.Nickname_T.TabIndex = 18;
            this.Nickname_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Trade_T
            // 
            this.Trade_T.Enabled = false;
            this.Trade_T.Location = new System.Drawing.Point(175, 50);
            this.Trade_T.Name = "Trade_T";
            this.Trade_T.Size = new System.Drawing.Size(75, 23);
            this.Trade_T.TabIndex = 36;
            this.Trade_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Trade_L
            // 
            this.Trade_L.AutoSize = true;
            this.Trade_L.Location = new System.Drawing.Point(175, 25);
            this.Trade_L.Name = "Trade_L";
            this.Trade_L.Size = new System.Drawing.Size(73, 14);
            this.Trade_L.TabIndex = 37;
            this.Trade_L.Text = "거래 횟수";
            // 
            // Trust_L
            // 
            this.Trust_L.AutoSize = true;
            this.Trust_L.Location = new System.Drawing.Point(275, 25);
            this.Trust_L.Name = "Trust_L";
            this.Trust_L.Size = new System.Drawing.Size(73, 14);
            this.Trust_L.TabIndex = 39;
            this.Trust_L.Text = "신용 수치";
            // 
            // Trust_T
            // 
            this.Trust_T.Enabled = false;
            this.Trust_T.Location = new System.Drawing.Point(275, 50);
            this.Trust_T.Name = "Trust_T";
            this.Trust_T.Size = new System.Drawing.Size(75, 23);
            this.Trust_T.TabIndex = 38;
            this.Trust_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MemDate_L
            // 
            this.MemDate_L.AutoSize = true;
            this.MemDate_L.Location = new System.Drawing.Point(380, 25);
            this.MemDate_L.Name = "MemDate_L";
            this.MemDate_L.Size = new System.Drawing.Size(88, 14);
            this.MemDate_L.TabIndex = 41;
            this.MemDate_L.Text = "계정 생성일";
            // 
            // MemDate_T
            // 
            this.MemDate_T.Enabled = false;
            this.MemDate_T.Location = new System.Drawing.Point(360, 50);
            this.MemDate_T.Name = "MemDate_T";
            this.MemDate_T.Size = new System.Drawing.Size(125, 23);
            this.MemDate_T.TabIndex = 40;
            this.MemDate_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Nickname_L
            // 
            this.Nickname_L.AutoSize = true;
            this.Nickname_L.Location = new System.Drawing.Point(20, 25);
            this.Nickname_L.Name = "Nickname_L";
            this.Nickname_L.Size = new System.Drawing.Size(128, 14);
            this.Nickname_L.TabIndex = 42;
            this.Nickname_L.Text = "작성자 Nickname";
            // 
            // Chat_G
            // 
            this.Chat_G.AllowUserToAddRows = false;
            this.Chat_G.AllowUserToDeleteRows = false;
            this.Chat_G.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Chat_G.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.Chat_G.Location = new System.Drawing.Point(20, 550);
            this.Chat_G.Name = "Chat_G";
            this.Chat_G.ReadOnly = true;
            this.Chat_G.RowHeadersWidth = 25;
            this.Chat_G.RowTemplate.Height = 23;
            this.Chat_G.Size = new System.Drawing.Size(450, 300);
            this.Chat_G.TabIndex = 43;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nickname";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "내용";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "작성일";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Chat_L
            // 
            this.Chat_L.AutoSize = true;
            this.Chat_L.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.Chat_L.Location = new System.Drawing.Point(20, 510);
            this.Chat_L.Name = "Chat_L";
            this.Chat_L.Size = new System.Drawing.Size(68, 27);
            this.Chat_L.TabIndex = 44;
            this.Chat_L.Text = "댓글";
            // 
            // Date_T
            // 
            this.Date_T.Enabled = false;
            this.Date_T.Location = new System.Drawing.Point(350, 510);
            this.Date_T.Name = "Date_T";
            this.Date_T.Size = new System.Drawing.Size(125, 23);
            this.Date_T.TabIndex = 45;
            this.Date_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Date_L
            // 
            this.Date_L.AutoSize = true;
            this.Date_L.Location = new System.Drawing.Point(275, 515);
            this.Date_L.Name = "Date_L";
            this.Date_L.Size = new System.Drawing.Size(73, 14);
            this.Date_L.TabIndex = 46;
            this.Date_L.Text = "글 작성일";
            // 
            // Chat_T
            // 
            this.Chat_T.Location = new System.Drawing.Point(20, 875);
            this.Chat_T.Name = "Chat_T";
            this.Chat_T.Size = new System.Drawing.Size(375, 23);
            this.Chat_T.TabIndex = 47;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.게시글ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(485, 27);
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 게시글ToolStripMenuItem
            // 
            this.게시글ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.수정ToolStripMenuItem,
            this.삭제ToolStripMenuItem});
            this.게시글ToolStripMenuItem.Name = "게시글ToolStripMenuItem";
            this.게시글ToolStripMenuItem.Size = new System.Drawing.Size(63, 23);
            this.게시글ToolStripMenuItem.Text = "게시글";
            // 
            // 수정ToolStripMenuItem
            // 
            this.수정ToolStripMenuItem.Name = "수정ToolStripMenuItem";
            this.수정ToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.수정ToolStripMenuItem.Text = "수정";
            this.수정ToolStripMenuItem.Click += new System.EventHandler(this.수정ToolStripMenuItem_Click);
            // 
            // 삭제ToolStripMenuItem
            // 
            this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.삭제ToolStripMenuItem.Text = "삭제";
            this.삭제ToolStripMenuItem.Click += new System.EventHandler(this.삭제ToolStripMenuItem_Click);
            // 
            // ProductPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(484, 961);
            this.Controls.Add(this.Chat_T);
            this.Controls.Add(this.Date_L);
            this.Controls.Add(this.Date_T);
            this.Controls.Add(this.Chat_L);
            this.Controls.Add(this.Chat_G);
            this.Controls.Add(this.Nickname_L);
            this.Controls.Add(this.MemDate_L);
            this.Controls.Add(this.MemDate_T);
            this.Controls.Add(this.Trust_L);
            this.Controls.Add(this.Trust_T);
            this.Controls.Add(this.Trade_L);
            this.Controls.Add(this.Trade_T);
            this.Controls.Add(this.CloseBT);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Chat_BT);
            this.Controls.Add(this.Explanation_T);
            this.Controls.Add(this.Explanation_L);
            this.Controls.Add(this.Time_T);
            this.Controls.Add(this.Time_L);
            this.Controls.Add(this.Area_T);
            this.Controls.Add(this.Area_L);
            this.Controls.Add(this.Price_L);
            this.Controls.Add(this.Price_T);
            this.Controls.Add(this.Name_T);
            this.Controls.Add(this.Name_L);
            this.Controls.Add(this.Nickname_T);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProductPost";
            this.Text = "ProductPost";
            this.Load += new System.EventHandler(this.ProductPost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chat_G)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseBT;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Chat_BT;
        private System.Windows.Forms.TextBox Explanation_T;
        private System.Windows.Forms.Label Explanation_L;
        private System.Windows.Forms.TextBox Time_T;
        private System.Windows.Forms.Label Time_L;
        private System.Windows.Forms.TextBox Area_T;
        private System.Windows.Forms.Label Area_L;
        private System.Windows.Forms.Label Price_L;
        private System.Windows.Forms.TextBox Price_T;
        private System.Windows.Forms.TextBox Name_T;
        private System.Windows.Forms.Label Name_L;
        private System.Windows.Forms.TextBox Nickname_T;
        private System.Windows.Forms.TextBox Trade_T;
        private System.Windows.Forms.Label Trade_L;
        private System.Windows.Forms.Label Trust_L;
        private System.Windows.Forms.TextBox Trust_T;
        private System.Windows.Forms.Label MemDate_L;
        private System.Windows.Forms.TextBox MemDate_T;
        private System.Windows.Forms.Label Nickname_L;
        private System.Windows.Forms.DataGridView Chat_G;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label Chat_L;
        private System.Windows.Forms.TextBox Date_T;
        private System.Windows.Forms.Label Date_L;
        private System.Windows.Forms.TextBox Chat_T;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 게시글ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
    }
}