namespace Computer_Science_NEA_FINAL
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.parentLoginButton = new System.Windows.Forms.Button();
            this.leaderLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Scout Main Menu.png");
            // 
            // parentLoginButton
            // 
            this.parentLoginButton.Font = new System.Drawing.Font("Yu Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.parentLoginButton.Location = new System.Drawing.Point(971, 376);
            this.parentLoginButton.Name = "parentLoginButton";
            this.parentLoginButton.Size = new System.Drawing.Size(215, 85);
            this.parentLoginButton.TabIndex = 1;
            this.parentLoginButton.Text = "Parent";
            this.parentLoginButton.UseVisualStyleBackColor = true;
            this.parentLoginButton.Click += new System.EventHandler(this.parentLoginButton_Click);
            // 
            // leaderLoginButton
            // 
            this.leaderLoginButton.Font = new System.Drawing.Font("Yu Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.leaderLoginButton.Location = new System.Drawing.Point(629, 376);
            this.leaderLoginButton.Name = "leaderLoginButton";
            this.leaderLoginButton.Size = new System.Drawing.Size(215, 85);
            this.leaderLoginButton.TabIndex = 1;
            this.leaderLoginButton.Text = "Leader";
            this.leaderLoginButton.UseVisualStyleBackColor = true;
            this.leaderLoginButton.Click += new System.EventHandler(this.leaderLoginButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1350, 600);
            this.Controls.Add(this.leaderLoginButton);
            this.Controls.Add(this.parentLoginButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.Text = "1st Liss Scout Camp Portal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button parentLoginButton;
        private System.Windows.Forms.Button leaderLoginButton;
    }
}

