namespace SQLFormDataAdapter
{
    partial class Form1
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
            lstProducts = new ListBox();
            BtnExecute = new Button();
            SuspendLayout();
            // 
            // lstProducts
            // 
            lstProducts.FormattingEnabled = true;
            lstProducts.ItemHeight = 15;
            lstProducts.Location = new Point(593, 12);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(221, 379);
            lstProducts.TabIndex = 0;
            lstProducts.SelectedIndexChanged += lstProducts_SelectedIndexChanged;
            // 
            // BtnExecute
            // 
            BtnExecute.Location = new Point(593, 409);
            BtnExecute.Name = "BtnExecute";
            BtnExecute.Size = new Size(221, 33);
            BtnExecute.TabIndex = 1;
            BtnExecute.Text = "Execute";
            BtnExecute.UseVisualStyleBackColor = true;
            BtnExecute.Click += BtnExecute_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 454);
            Controls.Add(BtnExecute);
            Controls.Add(lstProducts);
            Name = "Form1";
            Text = "FormSqlDataAdaptur";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstProducts;
        private Button BtnExecute;
    }
}
