namespace Exam
{
    partial class Main
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
            this.NickNem_T = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.판매등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.내등록정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로고침ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.게시글관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NickNem_L = new System.Windows.Forms.Label();
            this.AllProduct = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Products = new System.Windows.Forms.Label();
            this.CloseBT = new System.Windows.Forms.Button();
            this.MemberStat = new System.Windows.Forms.TextBox();
            this.Type_T = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // NickNem_T
            // 
            this.NickNem_T.Enabled = false;
            this.NickNem_T.Location = new System.Drawing.Point(525, 45);
            this.NickNem_T.Name = "NickNem_T";
            this.NickNem_T.Size = new System.Drawing.Size(200, 23);
            this.NickNem_T.TabIndex = 0;
            this.NickNem_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem,
            this.ProductToolStripMenuItem,
            this.새로고침ToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iTToolStripMenuItem,
            this.bookToolStripMenuItem,
            this.allToolStripMenuItem});
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(82, 23);
            this.categoryToolStripMenuItem.Text = "Category";
            // 
            // iTToolStripMenuItem
            // 
            this.iTToolStripMenuItem.Name = "iTToolStripMenuItem";
            this.iTToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.iTToolStripMenuItem.Text = "IT";
            this.iTToolStripMenuItem.Click += new System.EventHandler(this.iTToolStripMenuItem_Click);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.bookToolStripMenuItem.Text = "Book";
            this.bookToolStripMenuItem.Click += new System.EventHandler(this.bookToolStripMenuItem_Click);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // ProductToolStripMenuItem
            // 
            this.ProductToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.판매등록ToolStripMenuItem,
            this.내등록정보ToolStripMenuItem});
            this.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem";
            this.ProductToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.ProductToolStripMenuItem.Text = "Product";
            // 
            // 판매등록ToolStripMenuItem
            // 
            this.판매등록ToolStripMenuItem.Name = "판매등록ToolStripMenuItem";
            this.판매등록ToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.판매등록ToolStripMenuItem.Text = "판매 등록";
            this.판매등록ToolStripMenuItem.Click += new System.EventHandler(this.판매등록ToolStripMenuItem_Click);
            // 
            // 내등록정보ToolStripMenuItem
            // 
            this.내등록정보ToolStripMenuItem.Name = "내등록정보ToolStripMenuItem";
            this.내등록정보ToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.내등록정보ToolStripMenuItem.Text = "내 등록 정보";
            this.내등록정보ToolStripMenuItem.Click += new System.EventHandler(this.내등록정보ToolStripMenuItem_Click);
            // 
            // 새로고침ToolStripMenuItem
            // 
            this.새로고침ToolStripMenuItem.Name = "새로고침ToolStripMenuItem";
            this.새로고침ToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.새로고침ToolStripMenuItem.Text = "새로고침";
            this.새로고침ToolStripMenuItem.Click += new System.EventHandler(this.새로고침ToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.회원관리ToolStripMenuItem,
            this.게시글관리ToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(66, 23);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // 회원관리ToolStripMenuItem
            // 
            this.회원관리ToolStripMenuItem.Name = "회원관리ToolStripMenuItem";
            this.회원관리ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.회원관리ToolStripMenuItem.Text = "회원 관리";
            this.회원관리ToolStripMenuItem.Click += new System.EventHandler(this.회원관리ToolStripMenuItem_Click);
            // 
            // 게시글관리ToolStripMenuItem
            // 
            this.게시글관리ToolStripMenuItem.Name = "게시글관리ToolStripMenuItem";
            this.게시글관리ToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.게시글관리ToolStripMenuItem.Text = "게시글 관리";
            this.게시글관리ToolStripMenuItem.Click += new System.EventHandler(this.게시글관리ToolStripMenuItem_Click);
            // 
            // NickNem_L
            // 
            this.NickNem_L.AutoSize = true;
            this.NickNem_L.Location = new System.Drawing.Point(450, 50);
            this.NickNem_L.Name = "NickNem_L";
            this.NickNem_L.Size = new System.Drawing.Size(77, 14);
            this.NickNem_L.TabIndex = 3;
            this.NickNem_L.Text = "Nickname";
            // 
            // AllProduct
            // 
            this.AllProduct.AllowUserToAddRows = false;
            this.AllProduct.AllowUserToDeleteRows = false;
            this.AllProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.Owner,
            this.ProductType,
            this.PostName,
            this.Price,
            this.CreateDate});
            this.AllProduct.Location = new System.Drawing.Point(25, 125);
            this.AllProduct.Name = "AllProduct";
            this.AllProduct.ReadOnly = true;
            this.AllProduct.RowHeadersWidth = 25;
            this.AllProduct.RowTemplate.Height = 23;
            this.AllProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllProduct.Size = new System.Drawing.Size(675, 275);
            this.AllProduct.TabIndex = 4;
            this.AllProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllProduct_CellDoubleClick);
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "글번호";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 75;
            // 
            // Owner
            // 
            this.Owner.HeaderText = "작성자";
            this.Owner.Name = "Owner";
            this.Owner.ReadOnly = true;
            this.Owner.Width = 125;
            // 
            // ProductType
            // 
            this.ProductType.HeaderText = "카테고리";
            this.ProductType.Name = "ProductType";
            this.ProductType.ReadOnly = true;
            // 
            // PostName
            // 
            this.PostName.HeaderText = "글 제목";
            this.PostName.Name = "PostName";
            this.PostName.ReadOnly = true;
            this.PostName.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "가격";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 80;
            // 
            // CreateDate
            // 
            this.CreateDate.HeaderText = "작성일";
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            this.CreateDate.Width = 125;
            // 
            // Products
            // 
            this.Products.AutoSize = true;
            this.Products.Location = new System.Drawing.Point(25, 100);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(139, 14);
            this.Products.TabIndex = 5;
            this.Products.Text = "현재 등록된 거래글";
            // 
            // CloseBT
            // 
            this.CloseBT.Location = new System.Drawing.Point(625, 425);
            this.CloseBT.Name = "CloseBT";
            this.CloseBT.Size = new System.Drawing.Size(100, 25);
            this.CloseBT.TabIndex = 6;
            this.CloseBT.Text = "로그아웃";
            this.CloseBT.UseVisualStyleBackColor = true;
            this.CloseBT.Click += new System.EventHandler(this.CloseBT_Click);
            // 
            // MemberStat
            // 
            this.MemberStat.Enabled = false;
            this.MemberStat.Location = new System.Drawing.Point(525, 75);
            this.MemberStat.Name = "MemberStat";
            this.MemberStat.Size = new System.Drawing.Size(200, 23);
            this.MemberStat.TabIndex = 7;
            this.MemberStat.Text = "이용 제한된 계정입니다";
            this.MemberStat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MemberStat.Visible = false;
            // 
            // Type_T
            // 
            this.Type_T.Enabled = false;
            this.Type_T.Location = new System.Drawing.Point(175, 95);
            this.Type_T.Name = "Type_T";
            this.Type_T.Size = new System.Drawing.Size(150, 23);
            this.Type_T.TabIndex = 8;
            this.Type_T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.Type_T);
            this.Controls.Add(this.MemberStat);
            this.Controls.Add(this.CloseBT);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.AllProduct);
            this.Controls.Add(this.NickNem_T);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.NickNem_L);
            this.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NickNem_T;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.Label NickNem_L;
        private System.Windows.Forms.DataGridView AllProduct;
        private System.Windows.Forms.ToolStripMenuItem 판매등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 내등록정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 게시글관리ToolStripMenuItem;
        private System.Windows.Forms.Label Products;
        private System.Windows.Forms.Button CloseBT;
        private System.Windows.Forms.ToolStripMenuItem 새로고침ToolStripMenuItem;
        private System.Windows.Forms.TextBox MemberStat;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.TextBox Type_T;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
    }
}