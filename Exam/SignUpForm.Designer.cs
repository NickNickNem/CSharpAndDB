namespace Exam
{
    partial class SignUpForm
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
            this.ID_L = new System.Windows.Forms.Label();
            this.ID_T = new System.Windows.Forms.TextBox();
            this.Verify = new System.Windows.Forms.Button();
            this.PW_T = new System.Windows.Forms.TextBox();
            this.PW_L = new System.Windows.Forms.Label();
            this.NickNem_T = new System.Windows.Forms.TextBox();
            this.NickNem_L = new System.Windows.Forms.Label();
            this.Area_T = new System.Windows.Forms.TextBox();
            this.Area_L = new System.Windows.Forms.Label();
            this.Init = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ID_L
            // 
            this.ID_L.AutoSize = true;
            this.ID_L.Location = new System.Drawing.Point(25, 25);
            this.ID_L.Name = "ID_L";
            this.ID_L.Size = new System.Drawing.Size(22, 14);
            this.ID_L.TabIndex = 0;
            this.ID_L.Text = "ID";
            // 
            // ID_T
            // 
            this.ID_T.Location = new System.Drawing.Point(100, 20);
            this.ID_T.Name = "ID_T";
            this.ID_T.Size = new System.Drawing.Size(200, 23);
            this.ID_T.TabIndex = 1;
            // 
            // Verify
            // 
            this.Verify.Location = new System.Drawing.Point(300, 20);
            this.Verify.Name = "Verify";
            this.Verify.Size = new System.Drawing.Size(75, 25);
            this.Verify.TabIndex = 2;
            this.Verify.Text = "Check";
            this.Verify.UseVisualStyleBackColor = true;
            this.Verify.Click += new System.EventHandler(this.Verify_Click);
            // 
            // PW_T
            // 
            this.PW_T.Location = new System.Drawing.Point(100, 75);
            this.PW_T.Name = "PW_T";
            this.PW_T.Size = new System.Drawing.Size(200, 23);
            this.PW_T.TabIndex = 4;
            // 
            // PW_L
            // 
            this.PW_L.AutoSize = true;
            this.PW_L.Location = new System.Drawing.Point(25, 80);
            this.PW_L.Name = "PW_L";
            this.PW_L.Size = new System.Drawing.Size(67, 14);
            this.PW_L.TabIndex = 3;
            this.PW_L.Text = "비밀번호";
            // 
            // NickNem_T
            // 
            this.NickNem_T.Location = new System.Drawing.Point(100, 120);
            this.NickNem_T.Name = "NickNem_T";
            this.NickNem_T.Size = new System.Drawing.Size(200, 23);
            this.NickNem_T.TabIndex = 6;
            // 
            // NickNem_L
            // 
            this.NickNem_L.AutoSize = true;
            this.NickNem_L.Location = new System.Drawing.Point(25, 125);
            this.NickNem_L.Name = "NickNem_L";
            this.NickNem_L.Size = new System.Drawing.Size(77, 14);
            this.NickNem_L.TabIndex = 5;
            this.NickNem_L.Text = "Nickname";
            // 
            // Area_T
            // 
            this.Area_T.Location = new System.Drawing.Point(100, 175);
            this.Area_T.Name = "Area_T";
            this.Area_T.Size = new System.Drawing.Size(200, 23);
            this.Area_T.TabIndex = 8;
            // 
            // Area_L
            // 
            this.Area_L.AutoSize = true;
            this.Area_L.Location = new System.Drawing.Point(25, 180);
            this.Area_L.Name = "Area_L";
            this.Area_L.Size = new System.Drawing.Size(52, 14);
            this.Area_L.TabIndex = 7;
            this.Area_L.Text = "활동지";
            // 
            // Init
            // 
            this.Init.Location = new System.Drawing.Point(300, 175);
            this.Init.Name = "Init";
            this.Init.Size = new System.Drawing.Size(75, 25);
            this.Init.TabIndex = 9;
            this.Init.Text = "Init";
            this.Init.UseVisualStyleBackColor = true;
            this.Init.Click += new System.EventHandler(this.Init_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(300, 80);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 50);
            this.Create.TabIndex = 10;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Init);
            this.Controls.Add(this.Area_T);
            this.Controls.Add(this.Area_L);
            this.Controls.Add(this.NickNem_T);
            this.Controls.Add(this.NickNem_L);
            this.Controls.Add(this.PW_T);
            this.Controls.Add(this.PW_L);
            this.Controls.Add(this.Verify);
            this.Controls.Add(this.ID_T);
            this.Controls.Add(this.ID_L);
            this.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID_L;
        private System.Windows.Forms.TextBox ID_T;
        private System.Windows.Forms.Button Verify;
        private System.Windows.Forms.TextBox PW_T;
        private System.Windows.Forms.Label PW_L;
        private System.Windows.Forms.TextBox NickNem_T;
        private System.Windows.Forms.Label NickNem_L;
        private System.Windows.Forms.TextBox Area_T;
        private System.Windows.Forms.Label Area_L;
        private System.Windows.Forms.Button Init;
        private System.Windows.Forms.Button Create;
    }
}