namespace Computer_Science_NEA_FINAL
{
    partial class Camp_Editor
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
            this.label1 = new System.Windows.Forms.Label();
            this.campNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.applyCampEdits = new System.Windows.Forms.Button();
            this.locationURLTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camp Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // campNameTextBox
            // 
            this.campNameTextBox.Location = new System.Drawing.Point(152, 37);
            this.campNameTextBox.Name = "campNameTextBox";
            this.campNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.campNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Location";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(152, 66);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(100, 23);
            this.locationTextBox.TabIndex = 1;
            // 
            // applyCampEdits
            // 
            this.applyCampEdits.Location = new System.Drawing.Point(713, 415);
            this.applyCampEdits.Name = "applyCampEdits";
            this.applyCampEdits.Size = new System.Drawing.Size(75, 23);
            this.applyCampEdits.TabIndex = 3;
            this.applyCampEdits.Text = "Apply";
            this.applyCampEdits.UseVisualStyleBackColor = true;
            this.applyCampEdits.Click += new System.EventHandler(this.applyCampEdits_Click);
            // 
            // locationURLTextBox
            // 
            this.locationURLTextBox.Location = new System.Drawing.Point(152, 95);
            this.locationURLTextBox.Name = "locationURLTextBox";
            this.locationURLTextBox.Size = new System.Drawing.Size(329, 23);
            this.locationURLTextBox.TabIndex = 4;
            this.locationURLTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Location URL";
            // 
            // Camp_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.locationURLTextBox);
            this.Controls.Add(this.applyCampEdits);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.campNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Camp_Editor";
            this.Text = "Camp_Editor";
            this.Load += new System.EventHandler(this.Camp_Editor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox campNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Button applyCampEdits;
        private System.Windows.Forms.TextBox locationURLTextBox;
        private System.Windows.Forms.Label label3;
    }
}