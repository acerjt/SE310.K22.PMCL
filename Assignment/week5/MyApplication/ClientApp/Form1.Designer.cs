namespace ClientApp
{
    partial class Form1
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHello = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdHttpBinding = new System.Windows.Forms.RadioButton();
            this.rdTcpBinding = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(171, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(296, 26);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter name";
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(171, 133);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(92, 33);
            this.btnHello.TabIndex = 2;
            this.btnHello.Text = "Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(77, 201);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(55, 20);
            this.lbResult.TabIndex = 3;
            this.lbResult.Text = "Result";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdHttpBinding);
            this.groupBox1.Controls.Add(this.rdTcpBinding);
            this.groupBox1.Location = new System.Drawing.Point(507, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 136);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Binding option";
            // 
            // rdHttpBinding
            // 
            this.rdHttpBinding.AutoSize = true;
            this.rdHttpBinding.Location = new System.Drawing.Point(20, 76);
            this.rdHttpBinding.Name = "rdHttpBinding";
            this.rdHttpBinding.Size = new System.Drawing.Size(65, 24);
            this.rdHttpBinding.TabIndex = 1;
            this.rdHttpBinding.Text = "Http";
            this.rdHttpBinding.UseVisualStyleBackColor = true;
            // 
            // rdTcpBinding
            // 
            this.rdTcpBinding.AutoSize = true;
            this.rdTcpBinding.Checked = true;
            this.rdTcpBinding.Location = new System.Drawing.Point(20, 37);
            this.rdTcpBinding.Name = "rdTcpBinding";
            this.rdTcpBinding.Size = new System.Drawing.Size(60, 24);
            this.rdTcpBinding.TabIndex = 0;
            this.rdTcpBinding.TabStop = true;
            this.rdTcpBinding.Text = "Tcp";
            this.rdTcpBinding.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdHttpBinding;
        private System.Windows.Forms.RadioButton rdTcpBinding;
    }
}

