namespace MaybeAssignment
{
    partial class Form1
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
            this.Status_L = new System.Windows.Forms.Label();
            this.Status_T = new System.Windows.Forms.TextBox();
            this.ID_L = new System.Windows.Forms.Label();
            this.Password_L = new System.Windows.Forms.Label();
            this.ID_T = new System.Windows.Forms.TextBox();
            this.Password_T = new System.Windows.Forms.TextBox();
            this.Register = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.Slot1 = new System.Windows.Forms.PictureBox();
            this.Slot1_N = new System.Windows.Forms.TextBox();
            this.Slot1_B = new System.Windows.Forms.Button();
            this.Sell = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.Button();
            this.Interest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Slot1)).BeginInit();
            this.SuspendLayout();
            // 
            // Status_L
            // 
            this.Status_L.AutoSize = true;
            this.Status_L.Location = new System.Drawing.Point(25, 25);
            this.Status_L.Name = "Status_L";
            this.Status_L.Size = new System.Drawing.Size(73, 14);
            this.Status_L.TabIndex = 0;
            this.Status_L.Text = "연결 상태";
            // 
            // Status_T
            // 
            this.Status_T.Enabled = false;
            this.Status_T.Location = new System.Drawing.Point(100, 20);
            this.Status_T.Name = "Status_T";
            this.Status_T.Size = new System.Drawing.Size(125, 23);
            this.Status_T.TabIndex = 1;
            this.Status_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Status_T.UseWaitCursor = true;
            // 
            // ID_L
            // 
            this.ID_L.AutoSize = true;
            this.ID_L.Location = new System.Drawing.Point(525, 25);
            this.ID_L.Name = "ID_L";
            this.ID_L.Size = new System.Drawing.Size(22, 14);
            this.ID_L.TabIndex = 2;
            this.ID_L.Text = "ID";
            // 
            // Password_L
            // 
            this.Password_L.AutoSize = true;
            this.Password_L.Location = new System.Drawing.Point(500, 80);
            this.Password_L.Name = "Password_L";
            this.Password_L.Size = new System.Drawing.Size(67, 14);
            this.Password_L.TabIndex = 3;
            this.Password_L.Text = "비밀번호";
            // 
            // ID_T
            // 
            this.ID_T.Location = new System.Drawing.Point(575, 20);
            this.ID_T.Name = "ID_T";
            this.ID_T.Size = new System.Drawing.Size(200, 23);
            this.ID_T.TabIndex = 4;
            // 
            // Password_T
            // 
            this.Password_T.Location = new System.Drawing.Point(575, 75);
            this.Password_T.Name = "Password_T";
            this.Password_T.Size = new System.Drawing.Size(200, 23);
            this.Password_T.TabIndex = 5;
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(500, 125);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(100, 25);
            this.Register.TabIndex = 6;
            this.Register.Text = "회원가입";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(650, 125);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(100, 25);
            this.Login.TabIndex = 7;
            this.Login.Text = "로그인";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(225, 19);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(100, 25);
            this.Logout.TabIndex = 8;
            this.Logout.Text = "로그아웃";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Slot1
            // 
            this.Slot1.Location = new System.Drawing.Point(25, 100);
            this.Slot1.Name = "Slot1";
            this.Slot1.Size = new System.Drawing.Size(125, 125);
            this.Slot1.TabIndex = 0;
            this.Slot1.TabStop = false;
            // 
            // Slot1_N
            // 
            this.Slot1_N.Enabled = false;
            this.Slot1_N.Location = new System.Drawing.Point(25, 240);
            this.Slot1_N.Name = "Slot1_N";
            this.Slot1_N.Size = new System.Drawing.Size(125, 23);
            this.Slot1_N.TabIndex = 9;
            this.Slot1_N.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Slot1_B
            // 
            this.Slot1_B.Location = new System.Drawing.Point(25, 275);
            this.Slot1_B.Name = "Slot1_B";
            this.Slot1_B.Size = new System.Drawing.Size(125, 50);
            this.Slot1_B.TabIndex = 10;
            this.Slot1_B.UseVisualStyleBackColor = true;
            // 
            // Sell
            // 
            this.Sell.Location = new System.Drawing.Point(25, 50);
            this.Sell.Name = "Sell";
            this.Sell.Size = new System.Drawing.Size(100, 25);
            this.Sell.TabIndex = 11;
            this.Sell.Text = "상품 등록";
            this.Sell.UseVisualStyleBackColor = true;
            this.Sell.Click += new System.EventHandler(this.Sell_Click);
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(125, 50);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(100, 25);
            this.Status.TabIndex = 12;
            this.Status.Text = "등록 현황";
            this.Status.UseVisualStyleBackColor = true;
            this.Status.Click += new System.EventHandler(this.Status_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 100;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Items.AddRange(new object[] {
            "중고책",
            "분류B",
            "",
            "작품 만들면서",
            "생각나는 종류들",
            "추가할 예정"});
            this.comboBox1.Location = new System.Drawing.Point(350, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(350, 50);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(125, 25);
            this.Search.TabIndex = 15;
            this.Search.Text = "위 종류 검색";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // Interest
            // 
            this.Interest.Location = new System.Drawing.Point(225, 50);
            this.Interest.Name = "Interest";
            this.Interest.Size = new System.Drawing.Size(100, 25);
            this.Interest.TabIndex = 13;
            this.Interest.Text = "관심 목록";
            this.Interest.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Interest);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Sell);
            this.Controls.Add(this.Slot1_B);
            this.Controls.Add(this.Slot1_N);
            this.Controls.Add(this.Slot1);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Password_T);
            this.Controls.Add(this.ID_T);
            this.Controls.Add(this.Password_L);
            this.Controls.Add(this.ID_L);
            this.Controls.Add(this.Status_T);
            this.Controls.Add(this.Status_L);
            this.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.Name = "Form1";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Slot1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Status_L;
        private System.Windows.Forms.TextBox Status_T;
        private System.Windows.Forms.Label ID_L;
        private System.Windows.Forms.Label Password_L;
        private System.Windows.Forms.TextBox ID_T;
        private System.Windows.Forms.TextBox Password_T;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.PictureBox Slot1;
        private System.Windows.Forms.TextBox Slot1_N;
        private System.Windows.Forms.Button Slot1_B;
        private System.Windows.Forms.Button Sell;
        private System.Windows.Forms.Button Status;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Interest;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

