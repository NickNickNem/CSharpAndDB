namespace Exam
{
    partial class AddProduct
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
            this.ID_T = new System.Windows.Forms.TextBox();
            this.ID_L = new System.Windows.Forms.Label();
            this.Type_C = new System.Windows.Forms.ComboBox();
            this.Type_L = new System.Windows.Forms.Label();
            this.Form = new System.Windows.Forms.Label();
            this.Name_L = new System.Windows.Forms.Label();
            this.Name_T = new System.Windows.Forms.TextBox();
            this.Price_T = new System.Windows.Forms.TextBox();
            this.Price_L = new System.Windows.Forms.Label();
            this.Area_L = new System.Windows.Forms.Label();
            this.Area_T = new System.Windows.Forms.TextBox();
            this.Time_L = new System.Windows.Forms.Label();
            this.Time_T = new System.Windows.Forms.TextBox();
            this.Explanation_L = new System.Windows.Forms.Label();
            this.Explanation_T = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Init = new System.Windows.Forms.Button();
            this.CloseBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ID_T
            // 
            this.ID_T.Enabled = false;
            this.ID_T.Location = new System.Drawing.Point(25, 75);
            this.ID_T.Name = "ID_T";
            this.ID_T.Size = new System.Drawing.Size(125, 23);
            this.ID_T.TabIndex = 0;
            this.ID_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ID_L
            // 
            this.ID_L.AutoSize = true;
            this.ID_L.Location = new System.Drawing.Point(75, 50);
            this.ID_L.Name = "ID_L";
            this.ID_L.Size = new System.Drawing.Size(22, 14);
            this.ID_L.TabIndex = 1;
            this.ID_L.Text = "ID";
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
            this.Type_C.TabIndex = 2;
            // 
            // Type_L
            // 
            this.Type_L.AutoSize = true;
            this.Type_L.Location = new System.Drawing.Point(375, 50);
            this.Type_L.Name = "Type_L";
            this.Type_L.Size = new System.Drawing.Size(79, 14);
            this.Type_L.TabIndex = 3;
            this.Type_L.Text = "물품 Type";
            // 
            // Form
            // 
            this.Form.AutoSize = true;
            this.Form.Font = new System.Drawing.Font("굴림", 25F, System.Drawing.FontStyle.Bold);
            this.Form.Location = new System.Drawing.Point(175, 40);
            this.Form.Name = "Form";
            this.Form.Size = new System.Drawing.Size(167, 34);
            this.Form.TabIndex = 4;
            this.Form.Text = "등록 양식";
            // 
            // Name_L
            // 
            this.Name_L.AutoSize = true;
            this.Name_L.Location = new System.Drawing.Point(25, 125);
            this.Name_L.Name = "Name_L";
            this.Name_L.Size = new System.Drawing.Size(58, 14);
            this.Name_L.TabIndex = 5;
            this.Name_L.Text = "글 제목";
            // 
            // Name_T
            // 
            this.Name_T.Location = new System.Drawing.Point(100, 120);
            this.Name_T.Name = "Name_T";
            this.Name_T.Size = new System.Drawing.Size(250, 23);
            this.Name_T.TabIndex = 6;
            // 
            // Price_T
            // 
            this.Price_T.Location = new System.Drawing.Point(375, 120);
            this.Price_T.Name = "Price_T";
            this.Price_T.Size = new System.Drawing.Size(75, 23);
            this.Price_T.TabIndex = 7;
            this.Price_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Price_L
            // 
            this.Price_L.AutoSize = true;
            this.Price_L.Location = new System.Drawing.Point(450, 125);
            this.Price_L.Name = "Price_L";
            this.Price_L.Size = new System.Drawing.Size(22, 14);
            this.Price_L.TabIndex = 8;
            this.Price_L.Text = "원";
            // 
            // Area_L
            // 
            this.Area_L.AutoSize = true;
            this.Area_L.Location = new System.Drawing.Point(25, 180);
            this.Area_L.Name = "Area_L";
            this.Area_L.Size = new System.Drawing.Size(37, 14);
            this.Area_L.TabIndex = 9;
            this.Area_L.Text = "장소";
            // 
            // Area_T
            // 
            this.Area_T.Location = new System.Drawing.Point(100, 175);
            this.Area_T.Name = "Area_T";
            this.Area_T.Size = new System.Drawing.Size(375, 23);
            this.Area_T.TabIndex = 10;
            // 
            // Time_L
            // 
            this.Time_L.AutoSize = true;
            this.Time_L.Location = new System.Drawing.Point(25, 225);
            this.Time_L.Name = "Time_L";
            this.Time_L.Size = new System.Drawing.Size(52, 14);
            this.Time_L.TabIndex = 11;
            this.Time_L.Text = "시간대";
            // 
            // Time_T
            // 
            this.Time_T.Location = new System.Drawing.Point(100, 220);
            this.Time_T.Name = "Time_T";
            this.Time_T.Size = new System.Drawing.Size(375, 23);
            this.Time_T.TabIndex = 12;
            // 
            // Explanation_L
            // 
            this.Explanation_L.AutoSize = true;
            this.Explanation_L.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.Explanation_L.Location = new System.Drawing.Point(200, 260);
            this.Explanation_L.Name = "Explanation_L";
            this.Explanation_L.Size = new System.Drawing.Size(124, 27);
            this.Explanation_L.TabIndex = 13;
            this.Explanation_L.Text = "참고사항";
            // 
            // Explanation_T
            // 
            this.Explanation_T.Location = new System.Drawing.Point(50, 300);
            this.Explanation_T.Multiline = true;
            this.Explanation_T.Name = "Explanation_T";
            this.Explanation_T.Size = new System.Drawing.Size(400, 225);
            this.Explanation_T.TabIndex = 14;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(400, 550);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 25);
            this.Submit.TabIndex = 15;
            this.Submit.Text = "등록하기";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Init
            // 
            this.Init.Location = new System.Drawing.Point(25, 550);
            this.Init.Name = "Init";
            this.Init.Size = new System.Drawing.Size(75, 25);
            this.Init.TabIndex = 16;
            this.Init.Text = "Init";
            this.Init.UseVisualStyleBackColor = true;
            this.Init.Click += new System.EventHandler(this.Init_Click);
            // 
            // CloseBT
            // 
            this.CloseBT.Location = new System.Drawing.Point(100, 550);
            this.CloseBT.Name = "CloseBT";
            this.CloseBT.Size = new System.Drawing.Size(75, 25);
            this.CloseBT.TabIndex = 17;
            this.CloseBT.Text = "닫기";
            this.CloseBT.UseVisualStyleBackColor = true;
            this.CloseBT.Click += new System.EventHandler(this.CloseBT_Click);
            // 
            // AddProduct
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
            this.Controls.Add(this.Form);
            this.Controls.Add(this.Type_L);
            this.Controls.Add(this.Type_C);
            this.Controls.Add(this.ID_L);
            this.Controls.Add(this.ID_T);
            this.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_T;
        private System.Windows.Forms.Label ID_L;
        private System.Windows.Forms.ComboBox Type_C;
        private System.Windows.Forms.Label Type_L;
        private System.Windows.Forms.Label Form;
        private System.Windows.Forms.Label Name_L;
        private System.Windows.Forms.TextBox Name_T;
        private System.Windows.Forms.TextBox Price_T;
        private System.Windows.Forms.Label Price_L;
        private System.Windows.Forms.Label Area_L;
        private System.Windows.Forms.TextBox Area_T;
        private System.Windows.Forms.Label Time_L;
        private System.Windows.Forms.TextBox Time_T;
        private System.Windows.Forms.Label Explanation_L;
        private System.Windows.Forms.TextBox Explanation_T;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Init;
        private System.Windows.Forms.Button CloseBT;
    }
}