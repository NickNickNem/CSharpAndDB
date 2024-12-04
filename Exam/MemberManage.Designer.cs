namespace Exam
{
    partial class MemberManage
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
            this.Members = new System.Windows.Forms.Label();
            this.AllMember = new System.Windows.Forms.DataGridView();
            this.MID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Access = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NickNem_L = new System.Windows.Forms.Label();
            this.NickNem_T = new System.Windows.Forms.TextBox();
            this.Numbering_C = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllMember)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseBT
            // 
            this.CloseBT.Location = new System.Drawing.Point(625, 425);
            this.CloseBT.Name = "CloseBT";
            this.CloseBT.Size = new System.Drawing.Size(100, 25);
            this.CloseBT.TabIndex = 14;
            this.CloseBT.Text = "닫기";
            this.CloseBT.UseVisualStyleBackColor = true;
            this.CloseBT.Click += new System.EventHandler(this.CloseBT_Click);
            // 
            // Members
            // 
            this.Members.AutoSize = true;
            this.Members.Location = new System.Drawing.Point(25, 100);
            this.Members.Name = "Members";
            this.Members.Size = new System.Drawing.Size(139, 14);
            this.Members.TabIndex = 13;
            this.Members.Text = "현재 등록된 회원들";
            // 
            // AllMember
            // 
            this.AllMember.AllowUserToAddRows = false;
            this.AllMember.AllowUserToDeleteRows = false;
            this.AllMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MID,
            this.Nickname,
            this.Date,
            this.Access});
            this.AllMember.Location = new System.Drawing.Point(25, 125);
            this.AllMember.Name = "AllMember";
            this.AllMember.ReadOnly = true;
            this.AllMember.RowHeadersWidth = 25;
            this.AllMember.RowTemplate.Height = 23;
            this.AllMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllMember.Size = new System.Drawing.Size(500, 275);
            this.AllMember.TabIndex = 12;
            // 
            // MID
            // 
            this.MID.HeaderText = "회원ID";
            this.MID.Name = "MID";
            this.MID.ReadOnly = true;
            // 
            // Nickname
            // 
            this.Nickname.HeaderText = "회원명";
            this.Nickname.Name = "Nickname";
            this.Nickname.ReadOnly = true;
            this.Nickname.Width = 125;
            // 
            // Date
            // 
            this.Date.HeaderText = "생성일";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 125;
            // 
            // Access
            // 
            this.Access.HeaderText = "권한";
            this.Access.Name = "Access";
            this.Access.ReadOnly = true;
            this.Access.Width = 60;
            // 
            // NickNem_L
            // 
            this.NickNem_L.AutoSize = true;
            this.NickNem_L.Location = new System.Drawing.Point(450, 50);
            this.NickNem_L.Name = "NickNem_L";
            this.NickNem_L.Size = new System.Drawing.Size(77, 14);
            this.NickNem_L.TabIndex = 11;
            this.NickNem_L.Text = "Nickname";
            // 
            // NickNem_T
            // 
            this.NickNem_T.Enabled = false;
            this.NickNem_T.Location = new System.Drawing.Point(525, 45);
            this.NickNem_T.Name = "NickNem_T";
            this.NickNem_T.Size = new System.Drawing.Size(200, 23);
            this.NickNem_T.TabIndex = 9;
            this.NickNem_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Numbering_C
            // 
            this.Numbering_C.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Numbering_C.FormattingEnabled = true;
            this.Numbering_C.Items.AddRange(new object[] {
            "0 - 이용 제한",
            "1 - 일반 사용자",
            "5 - 최고 관리자"});
            this.Numbering_C.Location = new System.Drawing.Point(600, 125);
            this.Numbering_C.MaxDropDownItems = 5;
            this.Numbering_C.Name = "Numbering_C";
            this.Numbering_C.Size = new System.Drawing.Size(125, 21);
            this.Numbering_C.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "권한 변경";
            // 
            // UpdateBT
            // 
            this.UpdateBT.Location = new System.Drawing.Point(525, 150);
            this.UpdateBT.Name = "UpdateBT";
            this.UpdateBT.Size = new System.Drawing.Size(200, 25);
            this.UpdateBT.TabIndex = 17;
            this.UpdateBT.Text = "적용";
            this.UpdateBT.UseVisualStyleBackColor = true;
            this.UpdateBT.Click += new System.EventHandler(this.UpdateBT_Click);
            // 
            // MemberManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.UpdateBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Numbering_C);
            this.Controls.Add(this.CloseBT);
            this.Controls.Add(this.Members);
            this.Controls.Add(this.AllMember);
            this.Controls.Add(this.NickNem_T);
            this.Controls.Add(this.NickNem_L);
            this.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.Name = "MemberManage";
            this.Text = "MemberManage";
            this.Load += new System.EventHandler(this.MemberManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CloseBT;
        private System.Windows.Forms.Label Members;
        private System.Windows.Forms.DataGridView AllMember;
        private System.Windows.Forms.Label NickNem_L;
        private System.Windows.Forms.TextBox NickNem_T;
        private System.Windows.Forms.DataGridViewTextBoxColumn MID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Access;
        private System.Windows.Forms.ComboBox Numbering_C;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateBT;
    }
}