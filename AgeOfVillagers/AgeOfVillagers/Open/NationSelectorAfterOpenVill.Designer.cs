﻿namespace AgeOfVillagers
{
    partial class NationSelectorAfterOpenVill
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
            this.OkButton = new System.Windows.Forms.Button();
            this.NationSelectorAfterOpen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(222, 261);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(66, 31);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // NationSelectorAfterOpen
            // 
            this.NationSelectorAfterOpen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NationSelectorAfterOpen.FormattingEnabled = true;
            this.NationSelectorAfterOpen.Items.AddRange(new object[] {
            "Arab Bedouins",
            "Bangladeshi Farmers",
            "Egyptian Kings",
            "Inuit Hunters"});
            this.NationSelectorAfterOpen.Location = new System.Drawing.Point(168, 120);
            this.NationSelectorAfterOpen.Name = "NationSelectorAfterOpen";
            this.NationSelectorAfterOpen.Size = new System.Drawing.Size(192, 28);
            this.NationSelectorAfterOpen.TabIndex = 1;
            this.NationSelectorAfterOpen.SelectedIndexChanged += new System.EventHandler(this.NationSelectorAfterOpen_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(168, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose a nation!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Originally saved as:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // NationSelectorAfterOpenVill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 317);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NationSelectorAfterOpen);
            this.Controls.Add(this.OkButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NationSelectorAfterOpenVill";
            this.Text = "NationSelectorAfterOpenVill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.ComboBox NationSelectorAfterOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}