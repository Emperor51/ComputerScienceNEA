namespace Computer_Science_NEA_FINAL.Resources
{
    partial class BlogForm
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
            this.homeButton = new System.Windows.Forms.Button();
            this.Browser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(23, 16);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(64, 20);
            this.homeButton.TabIndex = 2;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // Browser1
            // 
            this.Browser1.Location = new System.Drawing.Point(10, 45);
            this.Browser1.Name = "Browser1";
            this.Browser1.Size = new System.Drawing.Size(1137, 576);
            this.Browser1.TabIndex = 0;
            this.Browser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Browser1_DocumentCompleted);
            // 
            // BlogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 632);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.Browser1);
            this.Name = "BlogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BlogForm";
            this.Load += new System.EventHandler(this.BlogForm_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.WebBrowser Browser1;
    }
}