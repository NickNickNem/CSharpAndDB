namespace MaybeAssignment
{
    partial class SignUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.ID_L = new System.Windows.Forms.Label();
            this.ID_T = new System.Windows.Forms.TextBox();
            this.ID_B = new System.Windows.Forms.Button();
            this.Password_T = new System.Windows.Forms.TextBox();
            this.Password_L = new System.Windows.Forms.Label();
            this.Nickname_T = new System.Windows.Forms.TextBox();
            this.Nickname_L = new System.Windows.Forms.Label();
            this.ActivityArea_T = new System.Windows.Forms.TextBox();
            this.ActivityArea_L = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(125, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Account";
            // 
            // ID_L
            // 
            this.ID_L.AutoSize = true;
            this.ID_L.Location = new System.Drawing.Point(50, 100);
            this.ID_L.Name = "ID_L";
            this.ID_L.Size = new System.Drawing.Size(22, 14);
            this.ID_L.TabIndex = 1;
            this.ID_L.Text = "ID";
            // 
            // ID_T
            // 
            this.ID_T.Location = new System.Drawing.Point(125, 95);
            this.ID_T.Name = "ID_T";
            this.ID_T.Size = new System.Drawing.Size(200, 23);
            this.ID_T.TabIndex = 2;
            // 
            // ID_B
            // 
            this.ID_B.Location = new System.Drawing.Point(375, 95);
            this.ID_B.Name = "ID_B";
            this.ID_B.Size = new System.Drawing.Size(100, 25);
            this.ID_B.TabIndex = 3;
            this.ID_B.Text = "중복 확인";
            this.ID_B.UseVisualStyleBackColor = true;
            // 
            // Password_T
            // 
            this.Password_T.Location = new System.Drawing.Point(125, 145);
            this.Password_T.Name = "Password_T";
            this.Password_T.Size = new System.Drawing.Size(200, 23);
            this.Password_T.TabIndex = 5;
            // 
            // Password_L
            // 
            this.Password_L.AutoSize = true;
            this.Password_L.Location = new System.Drawing.Point(25, 150);
            this.Password_L.Name = "Password_L";
            this.Password_L.Size = new System.Drawing.Size(80, 14);
            this.Password_L.TabIndex = 4;
            this.Password_L.Text = "Password";
            // 
            // Nickname_T
            // 
            this.Nickname_T.Location = new System.Drawing.Point(125, 195);
            this.Nickname_T.Name = "Nickname_T";
            this.Nickname_T.Size = new System.Drawing.Size(200, 23);
            this.Nickname_T.TabIndex = 7;
            // 
            // Nickname_L
            // 
            this.Nickname_L.AutoSize = true;
            this.Nickname_L.Location = new System.Drawing.Point(25, 200);
            this.Nickname_L.Name = "Nickname_L";
            this.Nickname_L.Size = new System.Drawing.Size(77, 14);
            this.Nickname_L.TabIndex = 6;
            this.Nickname_L.Text = "Nickname";
            // 
            // ActivityArea_T
            // 
            this.ActivityArea_T.Location = new System.Drawing.Point(125, 245);
            this.ActivityArea_T.Name = "ActivityArea_T";
            this.ActivityArea_T.Size = new System.Drawing.Size(200, 23);
            this.ActivityArea_T.TabIndex = 9;
            // 
            // ActivityArea_L
            // 
            this.ActivityArea_L.AutoSize = true;
            this.ActivityArea_L.Location = new System.Drawing.Point(40, 250);
            this.ActivityArea_L.Name = "ActivityArea_L";
            this.ActivityArea_L.Size = new System.Drawing.Size(52, 14);
            this.ActivityArea_L.TabIndex = 8;
            this.ActivityArea_L.Text = "활동지";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(375, 145);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(100, 125);
            this.Submit.TabIndex = 10;
            this.Submit.Text = "제출";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.ActivityArea_T);
            this.Controls.Add(this.ActivityArea_L);
            this.Controls.Add(this.Nickname_T);
            this.Controls.Add(this.Nickname_L);
            this.Controls.Add(this.Password_T);
            this.Controls.Add(this.Password_L);
            this.Controls.Add(this.ID_B);
            this.Controls.Add(this.ID_T);
            this.Controls.Add(this.ID_L);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ID_L;
        private System.Windows.Forms.TextBox ID_T;
        private System.Windows.Forms.Button ID_B;
        private System.Windows.Forms.TextBox Password_T;
        private System.Windows.Forms.Label Password_L;
        private System.Windows.Forms.TextBox Nickname_T;
        private System.Windows.Forms.Label Nickname_L;
        private System.Windows.Forms.TextBox ActivityArea_T;
        private System.Windows.Forms.Label ActivityArea_L;
        private System.Windows.Forms.Button Submit;
    }
}