namespace FormCommand
{
    partial class formCommand
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExecute = new Button();
            txtProduct = new Label();
            cmbProductIDs = new ComboBox();
            productLst = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(653, 392);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(123, 34);
            btnExecute.TabIndex = 0;
            btnExecute.Text = "Execute";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click;
            // 
            // txtProduct
            // 
            txtProduct.AutoSize = true;
            txtProduct.Location = new Point(41, 90);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(84, 15);
            txtProduct.TabIndex = 1;
            txtProduct.Text = "Product Name";
            // 
            // cmbProductIDs
            // 
            cmbProductIDs.FormattingEnabled = true;
            cmbProductIDs.Location = new Point(151, 33);
            cmbProductIDs.Name = "cmbProductIDs";
            cmbProductIDs.Size = new Size(241, 23);
            cmbProductIDs.TabIndex = 2;
            // 
            // productLst
            // 
            productLst.AutoSize = true;
            productLst.Location = new Point(41, 33);
            productLst.Name = "productLst";
            productLst.Size = new Size(70, 15);
            productLst.TabIndex = 1;
            productLst.Text = "Product List";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(151, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 23);
            textBox1.TabIndex = 3;
            // 
            // formCommand
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(cmbProductIDs);
            Controls.Add(productLst);
            Controls.Add(txtProduct);
            Controls.Add(btnExecute);
            Name = "formCommand";
            Text = "FormCommand";
            Load += formCommand_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExecute;
        private Label txtProduct;
        private ComboBox cmbProductIDs;
        private Label productLst;
        private TextBox textBox1;
    }
}
