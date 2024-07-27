namespace WinFormsApp1
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
            btnOpen = new Button();
            btnClose = new Button();
            btnChangeDb = new Button();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(28, 402);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(689, 402);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnChangeDb
            // 
            btnChangeDb.Location = new Point(339, 402);
            btnChangeDb.Name = "btnChangeDb";
            btnChangeDb.Size = new Size(75, 23);
            btnChangeDb.TabIndex = 2;
            btnChangeDb.Text = "Change DB";
            btnChangeDb.UseVisualStyleBackColor = true;
            btnChangeDb.Click += btnChangeDb_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnChangeDb);
            Controls.Add(btnClose);
            Controls.Add(btnOpen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpen;
        private Button btnClose;
        private Button btnChangeDb;
    }
}
