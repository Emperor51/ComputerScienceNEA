using System.ComponentModel;

namespace Computer_Science_NEA_FINAL
{
    partial class AddIncident
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.addIncidentLabel = new System.Windows.Forms.Label();
            this.injuredNameLabel = new System.Windows.Forms.Label();
            this.recorderNameLabel = new System.Windows.Forms.Label();
            this.dateIncidentLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.howRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.injuredOption = new System.Windows.Forms.ComboBox();
            this.recorderOption = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addToListButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.materialList = new System.Windows.Forms.Label();
            this.materialOption = new System.Windows.Forms.ComboBox();
            this.materialsLabel = new System.Windows.Forms.Label();
            this.dateIncidentPicker = new System.Windows.Forms.DateTimePicker();
            this.addMaterialFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addIncidentLabel
            // 
            this.addIncidentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.addIncidentLabel.Location = new System.Drawing.Point(156, 27);
            this.addIncidentLabel.Name = "addIncidentLabel";
            this.addIncidentLabel.Size = new System.Drawing.Size(224, 48);
            this.addIncidentLabel.TabIndex = 0;
            this.addIncidentLabel.Text = "Add Incident";
            // 
            // injuredNameLabel
            // 
            this.injuredNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.injuredNameLabel.Location = new System.Drawing.Point(34, 120);
            this.injuredNameLabel.Name = "injuredNameLabel";
            this.injuredNameLabel.Size = new System.Drawing.Size(193, 26);
            this.injuredNameLabel.TabIndex = 1;
            this.injuredNameLabel.Text = "Name of Injured Person";
            // 
            // recorderNameLabel
            // 
            this.recorderNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.recorderNameLabel.Location = new System.Drawing.Point(34, 155);
            this.recorderNameLabel.Name = "recorderNameLabel";
            this.recorderNameLabel.Size = new System.Drawing.Size(193, 26);
            this.recorderNameLabel.TabIndex = 2;
            this.recorderNameLabel.Text = "Name of Recording Person";
            // 
            // dateIncidentLabel
            // 
            this.dateIncidentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dateIncidentLabel.Location = new System.Drawing.Point(34, 191);
            this.dateIncidentLabel.Name = "dateIncidentLabel";
            this.dateIncidentLabel.Size = new System.Drawing.Size(193, 26);
            this.dateIncidentLabel.TabIndex = 3;
            this.dateIncidentLabel.Text = "Date of Incident";
            this.dateIncidentLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(34, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Time of Incident (24h)";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(34, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Location of Incident";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(275, 229);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(212, 20);
            this.timeTextBox.TabIndex = 9;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(275, 267);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(212, 20);
            this.locationTextBox.TabIndex = 10;
            // 
            // howRichTextBox
            // 
            this.howRichTextBox.Location = new System.Drawing.Point(275, 306);
            this.howRichTextBox.Name = "howRichTextBox";
            this.howRichTextBox.Size = new System.Drawing.Size(212, 53);
            this.howRichTextBox.TabIndex = 11;
            this.howRichTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(34, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "How did the incident happen?";
            // 
            // injuredOption
            // 
            this.injuredOption.FormattingEnabled = true;
            this.injuredOption.Location = new System.Drawing.Point(275, 121);
            this.injuredOption.Name = "injuredOption";
            this.injuredOption.Size = new System.Drawing.Size(212, 21);
            this.injuredOption.TabIndex = 13;
            // 
            // recorderOption
            // 
            this.recorderOption.FormattingEnabled = true;
            this.recorderOption.Location = new System.Drawing.Point(275, 156);
            this.recorderOption.Name = "recorderOption";
            this.recorderOption.Size = new System.Drawing.Size(212, 21);
            this.recorderOption.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(34, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Materials Used";
            // 
            // addToListButton
            // 
            this.addToListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.addToListButton.Location = new System.Drawing.Point(466, 376);
            this.addToListButton.Name = "addToListButton";
            this.addToListButton.Size = new System.Drawing.Size(21, 21);
            this.addToListButton.TabIndex = 17;
            this.addToListButton.Text = "✓";
            this.addToListButton.UseVisualStyleBackColor = true;
            this.addToListButton.Click += new System.EventHandler(this.addToListButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.submitButton.Location = new System.Drawing.Point(206, 495);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(125, 42);
            this.submitButton.TabIndex = 18;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // materialList
            // 
            this.materialList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.materialList.Location = new System.Drawing.Point(275, 400);
            this.materialList.Name = "materialList";
            this.materialList.Size = new System.Drawing.Size(212, 26);
            this.materialList.TabIndex = 19;
            // 
            // materialOption
            // 
            this.materialOption.FormattingEnabled = true;
            this.materialOption.Location = new System.Drawing.Point(302, 376);
            this.materialOption.Name = "materialOption";
            this.materialOption.Size = new System.Drawing.Size(158, 21);
            this.materialOption.TabIndex = 20;
            this.materialOption.DropDown += new System.EventHandler(this.materialOption_DropDown);
            // 
            // materialsLabel
            // 
            this.materialsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.materialsLabel.Location = new System.Drawing.Point(275, 400);
            this.materialsLabel.Name = "materialsLabel";
            this.materialsLabel.Size = new System.Drawing.Size(212, 75);
            this.materialsLabel.TabIndex = 21;
            // 
            // dateIncidentPicker
            // 
            this.dateIncidentPicker.Location = new System.Drawing.Point(275, 189);
            this.dateIncidentPicker.Name = "dateIncidentPicker";
            this.dateIncidentPicker.Size = new System.Drawing.Size(212, 20);
            this.dateIncidentPicker.TabIndex = 22;
            // 
            // addMaterialFormButton
            // 
            this.addMaterialFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.addMaterialFormButton.Location = new System.Drawing.Point(275, 376);
            this.addMaterialFormButton.Name = "addMaterialFormButton";
            this.addMaterialFormButton.Size = new System.Drawing.Size(21, 21);
            this.addMaterialFormButton.TabIndex = 23;
            this.addMaterialFormButton.Text = "+";
            this.addMaterialFormButton.UseVisualStyleBackColor = true;
            this.addMaterialFormButton.Click += new System.EventHandler(this.addMaterialFormButton_Click);
            // 
            // AddIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 549);
            this.Controls.Add(this.addMaterialFormButton);
            this.Controls.Add(this.dateIncidentPicker);
            this.Controls.Add(this.materialsLabel);
            this.Controls.Add(this.materialOption);
            this.Controls.Add(this.materialList);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.addToListButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.recorderOption);
            this.Controls.Add(this.injuredOption);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.howRichTextBox);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateIncidentLabel);
            this.Controls.Add(this.recorderNameLabel);
            this.Controls.Add(this.injuredNameLabel);
            this.Controls.Add(this.addIncidentLabel);
            this.Name = "AddIncident";
            this.Text = "AddIncident";
            this.Load += new System.EventHandler(this.AddIncident_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button addMaterialFormButton;

        private System.Windows.Forms.DateTimePicker dateIncidentPicker;

        private System.Windows.Forms.ComboBox materialOption;
        private System.Windows.Forms.Label materialsLabel;

        private System.Windows.Forms.Label materialList;

        private System.Windows.Forms.Button submitButton;

        private System.Windows.Forms.Button addToListButton;
        private System.Windows.Forms.ComboBox injuredOption;
        private System.Windows.Forms.ComboBox recorderOption;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox howRichTextBox;

        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox locationTextBox;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label dateIncidentLabel;
        private System.Windows.Forms.Label recorderNameLabel;

        private System.Windows.Forms.Label injuredNameLabel;

        private System.Windows.Forms.Label addIncidentLabel;

        #endregion
    }
}