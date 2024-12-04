namespace Exam
{
    partial class LogInForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.PW = new System.Windows.Forms.TextBox();
            this.SignUp = new System.Windows.Forms.Button();
            this.OffLine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(150, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "PW";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(125, 75);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(150, 23);
            this.ID.TabIndex = 3;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(300, 80);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 50);
            this.Login.TabIndex = 5;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // PW
            // 
            this.PW.Location = new System.Drawing.Point(125, 120);
            this.PW.Name = "PW";
            this.PW.Size = new System.Drawing.Size(150, 23);
            this.PW.TabIndex = 4;
            // 
            // SignUp
            // 
            this.SignUp.Location = new System.Drawing.Point(300, 175);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(75, 25);
            this.SignUp.TabIndex = 6;
            this.SignUp.Text = "Sign up";
            this.SignUp.UseVisualStyleBackColor = true;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // OffLine
            // 
            this.OffLine.Location = new System.Drawing.Point(75, 175);
            this.OffLine.Name = "OffLine";
            this.OffLine.Size = new System.Drawing.Size(200, 25);
            this.OffLine.TabIndex = 7;
            this.OffLine.Text = "비회원으로 구경하기";
            this.OffLine.UseVisualStyleBackColor = true;
            this.OffLine.Click += new System.EventHandler(this.OffLine_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.OffLine);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.PW);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.Name = "LogInForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox PW;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.Button OffLine;
    }
}

