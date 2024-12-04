namespace Exam
{
    partial class EditPost
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
            this.Init = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
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
            this.Type_L = new System.Windows.Forms.Label();
            this.Type_C = new System.Windows.Forms.ComboBox();
            this.Nickname_L = new System.Windows.Forms.Label();
            this.Nickname_T = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CloseBT
            // 
            this.CloseBT.Location = new System.Drawing.Point(100, 550);
            this.CloseBT.Name = "CloseBT";
            this.CloseBT.Size = new System.Drawing.Size(75, 25);
            this.CloseBT.TabIndex = 35;
            this.CloseBT.Text = "닫기";
            this.CloseBT.UseVisualStyleBackColor = true;
            this.CloseBT.Click += new System.EventHandler(this.CloseBT_Click);
            // 
            // Init
            // 
            this.Init.Location = new System.Drawing.Point(25, 550);
            this.Init.Name = "Init";
            this.Init.Size = new System.Drawing.Size(75, 25);
            this.Init.TabIndex = 34;
            this.Init.Text = "Init";
            this.Init.UseVisualStyleBackColor = true;
            this.Init.Click += new System.EventHandler(this.Init_Click);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(400, 550);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 25);
            this.Submit.TabIndex = 33;
            this.Submit.Text = "수정완료";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Explanation_T
            // 
            this.Explanation_T.Location = new System.Drawing.Point(50, 300);
            this.Explanation_T.Multiline = true;
            this.Explanation_T.Name = "Explanation_T";
            this.Explanation_T.Size = new System.Drawing.Size(400, 225);
            this.Explanation_T.TabIndex = 32;
            // 
            // Explanation_L
            // 
            this.Explanation_L.AutoSize = true;
            this.Explanation_L.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.Explanation_L.Location = new System.Drawing.Point(200, 260);
            this.Explanation_L.Name = "Explanation_L";
            this.Explanation_L.Size = new System.Drawing.Size(124, 27);
            this.Explanation_L.TabIndex = 31;
            this.Explanation_L.Text = "참고사항";
            // 
            // Time_T
            // 
            this.Time_T.Location = new System.Drawing.Point(100, 220);
            this.Time_T.Name = "Time_T";
            this.Time_T.Size = new System.Drawing.Size(375, 23);
            this.Time_T.TabIndex = 30;
            // 
            // Time_L
            // 
            this.Time_L.AutoSize = true;
            this.Time_L.Location = new System.Drawing.Point(25, 225);
            this.Time_L.Name = "Time_L";
            this.Time_L.Size = new System.Drawing.Size(52, 14);
            this.Time_L.TabIndex = 29;
            this.Time_L.Text = "시간대";
            // 
            // Area_T
            // 
            this.Area_T.Location = new System.Drawing.Point(100, 175);
            this.Area_T.Name = "Area_T";
            this.Area_T.Size = new System.Drawing.Size(375, 23);
            this.Area_T.TabIndex = 28;
            // 
            // Area_L
            // 
            this.Area_L.AutoSize = true;
            this.Area_L.Location = new System.Drawing.Point(25, 180);
            this.Area_L.Name = "Area_L";
            this.Area_L.Size = new System.Drawing.Size(37, 14);
            this.Area_L.TabIndex = 27;
            this.Area_L.Text = "장소";
            // 
            // Price_L
            // 
            this.Price_L.AutoSize = true;
            this.Price_L.Location = new System.Drawing.Point(450, 125);
            this.Price_L.Name = "Price_L";
            this.Price_L.Size = new System.Drawing.Size(22, 14);
            this.Price_L.TabIndex = 26;
            this.Price_L.Text = "원";
            // 
            // Price_T
            // 
            this.Price_T.Location = new System.Drawing.Point(375, 120);
            this.Price_T.Name = "Price_T";
            this.Price_T.Size = new System.Drawing.Size(75, 23);
            this.Price_T.TabIndex = 25;
            this.Price_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Name_T
            // 
            this.Name_T.Location = new System.Drawing.Point(100, 120);
            this.Name_T.Name = "Name_T";
            this.Name_T.Size = new System.Drawing.Size(250, 23);
            this.Name_T.TabIndex = 24;
            // 
            // Name_L
            // 
            this.Name_L.AutoSize = true;
            this.Name_L.Location = new System.Drawing.Point(25, 125);
            this.Name_L.Name = "Name_L";
            this.Name_L.Size = new System.Drawing.Size(58, 14);
            this.Name_L.TabIndex = 23;
            this.Name_L.Text = "글 제목";
            // 
            // Type_L
            // 
            this.Type_L.AutoSize = true;
            this.Type_L.Location = new System.Drawing.Point(375, 50);
            this.Type_L.Name = "Type_L";
            this.Type_L.Size = new System.Drawing.Size(79, 14);
            this.Type_L.TabIndex = 21;
            this.Type_L.Text = "물품 Type";
            // 
            // Type_C
            // 
            this.Type_C.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type_C.FormattingEnabled = true;
            this.Type_C.Items.AddRange(new object[] {
            "IT",
            "Book"});
            this.Type_C.Location = new System.Drawing.Point(350, 75);
            this.Type_C.Name = "Type_C";
            this.Type_C.Size = new System.Drawing.Size(125, 21);
            this.Type_C.TabIndex = 20;
            // 
            // Nickname_L
            // 
            this.Nickname_L.AutoSize = true;
            this.Nickname_L.Location = new System.Drawing.Point(25, 50);
            this.Nickname_L.Name = "Nickname_L";
            this.Nickname_L.Size = new System.Drawing.Size(128, 14);
            this.Nickname_L.TabIndex = 19;
            this.Nickname_L.Text = "작성자 Nickname";
            // 
            // Nickname_T
            // 
            this.Nickname_T.Enabled = false;
            this.Nickname_T.Location = new System.Drawing.Point(25, 75);
            this.Nickname_T.Name = "Nickname_T";
            this.Nickname_T.Size = new System.Drawing.Size(125, 23);
            this.Nickname_T.TabIndex = 18;
            this.Nickname_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EditPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 586);
            this.Controls.Add(this.CloseBT);
            this.Controls.Add(this.Init);
            this.Controls.Add(this.Submit);
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
            this.Controls.Add(this.Type_L);
            this.Controls.Add(this.Type_C);
            this.Controls.Add(this.Nickname_L);
            this.Controls.Add(this.Nickname_T);
            this.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.Name = "EditPost";
            this.Text = "EditPost";
            this.Load += new System.EventHandler(this.EditPost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseBT;
        private System.Windows.Forms.Button Init;
        private System.Windows.Forms.Button Submit;
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
        private System.Windows.Forms.Label Type_L;
        private System.Windows.Forms.ComboBox Type_C;
        private System.Windows.Forms.Label Nickname_L;
        private System.Windows.Forms.TextBox Nickname_T;
    }
}