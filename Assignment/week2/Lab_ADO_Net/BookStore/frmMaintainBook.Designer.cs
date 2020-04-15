namespace BookStore
{
    partial class frmMaintainBook
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
            this.lblBookID = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.txtBookQuantity = new System.Windows.Forms.TextBox();
            this.lblBookQuantity = new System.Windows.Forms.Label();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.lblBookPrice = new System.Windows.Forms.Label();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblEnterTitle = new System.Windows.Forms.Label();
            this.txtTitleEnter = new System.Windows.Forms.TextBox();
            this.lblTotalQuantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Location = new System.Drawing.Point(48, 43);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(63, 20);
            this.lblBookID.TabIndex = 0;
            this.lblBookID.Text = "BookID";
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(184, 40);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(371, 26);
            this.txtBookID.TabIndex = 1;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(184, 95);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(371, 26);
            this.txtBookTitle.TabIndex = 3;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(48, 98);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(75, 20);
            this.lblBookTitle.TabIndex = 2;
            this.lblBookTitle.Text = "BookTitle";
            // 
            // txtBookQuantity
            // 
            this.txtBookQuantity.Location = new System.Drawing.Point(184, 149);
            this.txtBookQuantity.Name = "txtBookQuantity";
            this.txtBookQuantity.Size = new System.Drawing.Size(371, 26);
            this.txtBookQuantity.TabIndex = 5;
            // 
            // lblBookQuantity
            // 
            this.lblBookQuantity.AutoSize = true;
            this.lblBookQuantity.Location = new System.Drawing.Point(48, 152);
            this.lblBookQuantity.Name = "lblBookQuantity";
            this.lblBookQuantity.Size = new System.Drawing.Size(105, 20);
            this.lblBookQuantity.TabIndex = 4;
            this.lblBookQuantity.Text = "BookQuantity";
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Location = new System.Drawing.Point(184, 204);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(371, 26);
            this.txtBookPrice.TabIndex = 7;
            // 
            // lblBookPrice
            // 
            this.lblBookPrice.AutoSize = true;
            this.lblBookPrice.Location = new System.Drawing.Point(48, 207);
            this.lblBookPrice.Name = "lblBookPrice";
            this.lblBookPrice.Size = new System.Drawing.Size(81, 20);
            this.lblBookPrice.TabIndex = 6;
            this.lblBookPrice.Text = "BookPrice";
            // 
            // dgvBookList
            // 
            this.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookList.Location = new System.Drawing.Point(52, 253);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.RowTemplate.Height = 28;
            this.dgvBookList.Size = new System.Drawing.Size(503, 230);
            this.dgvBookList.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(48, 518);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 38);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(167, 518);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 38);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(284, 518);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 38);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(400, 518);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(88, 38);
            this.btnLoad.TabIndex = 12;
            this.btnLoad.Text = "Refresh";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblEnterTitle
            // 
            this.lblEnterTitle.AutoSize = true;
            this.lblEnterTitle.Location = new System.Drawing.Point(48, 587);
            this.lblEnterTitle.Name = "lblEnterTitle";
            this.lblEnterTitle.Size = new System.Drawing.Size(77, 20);
            this.lblEnterTitle.TabIndex = 13;
            this.lblEnterTitle.Text = "EnterTitle";
            // 
            // txtTitleEnter
            // 
            this.txtTitleEnter.Location = new System.Drawing.Point(131, 584);
            this.txtTitleEnter.Name = "txtTitleEnter";
            this.txtTitleEnter.Size = new System.Drawing.Size(262, 26);
            this.txtTitleEnter.TabIndex = 14;
            this.txtTitleEnter.TextChanged += new System.EventHandler(this.txtTitleEnter_TextChanged);
            // 
            // lblTotalQuantity
            // 
            this.lblTotalQuantity.AutoSize = true;
            this.lblTotalQuantity.Location = new System.Drawing.Point(412, 587);
            this.lblTotalQuantity.Name = "lblTotalQuantity";
            this.lblTotalQuantity.Size = new System.Drawing.Size(103, 20);
            this.lblTotalQuantity.TabIndex = 15;
            this.lblTotalQuantity.Text = "TotalQuantity";
            // 
            // frmMaintainBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 657);
            this.Controls.Add(this.lblTotalQuantity);
            this.Controls.Add(this.txtTitleEnter);
            this.Controls.Add(this.lblEnterTitle);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvBookList);
            this.Controls.Add(this.txtBookPrice);
            this.Controls.Add(this.lblBookPrice);
            this.Controls.Add(this.txtBookQuantity);
            this.Controls.Add(this.lblBookQuantity);
            this.Controls.Add(this.txtBookTitle);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.lblBookID);
            this.Name = "frmMaintainBook";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMaintainBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.TextBox txtBookQuantity;
        private System.Windows.Forms.Label lblBookQuantity;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.Label lblBookPrice;
        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblEnterTitle;
        private System.Windows.Forms.TextBox txtTitleEnter;
        private System.Windows.Forms.Label lblTotalQuantity;
    }
}

