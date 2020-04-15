namespace ASM4
{
    partial class frmBookReport
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
            this.components = new System.ComponentModel.Container();
            this.dgvListBook = new System.Windows.Forms.DataGridView();
            this.bsBook = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBook)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListBook
            // 
            this.dgvListBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBook.Location = new System.Drawing.Point(29, 68);
            this.dgvListBook.Name = "dgvListBook";
            this.dgvListBook.RowTemplate.Height = 28;
            this.dgvListBook.Size = new System.Drawing.Size(713, 333);
            this.dgvListBook.TabIndex = 0;
            // 
            // frmBookReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListBook);
            this.Name = "frmBookReport";
            this.Text = "frmBookReport";
            this.Load += new System.EventHandler(this.frmBookReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListBook;
        private System.Windows.Forms.BindingSource bsBook;
    }
}