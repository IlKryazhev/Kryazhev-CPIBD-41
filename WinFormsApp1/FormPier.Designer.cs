﻿
namespace WinFormsLiner
{
    partial class FormPier
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
            this.pictureBoxPier = new System.Windows.Forms.PictureBox();
            this.buttonSetLiner = new System.Windows.Forms.Button();
            this.buttonSetPremiumLiner = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPickUp = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPier)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPier
            // 
            this.pictureBoxPier.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxPier.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPier.Name = "pictureBoxPier";
            this.pictureBoxPier.Size = new System.Drawing.Size(803, 630);
            this.pictureBoxPier.TabIndex = 0;
            this.pictureBoxPier.TabStop = false;
            // 
            // buttonSetLiner
            // 
            this.buttonSetLiner.Location = new System.Drawing.Point(865, 26);
            this.buttonSetLiner.Name = "buttonSetLiner";
            this.buttonSetLiner.Size = new System.Drawing.Size(134, 79);
            this.buttonSetLiner.TabIndex = 1;
            this.buttonSetLiner.Text = "Park liner";
            this.buttonSetLiner.UseVisualStyleBackColor = true;
            this.buttonSetLiner.Click += new System.EventHandler(this.buttonSetLiner_Click);
            // 
            // buttonSetPremiumLiner
            // 
            this.buttonSetPremiumLiner.Location = new System.Drawing.Point(865, 131);
            this.buttonSetPremiumLiner.Name = "buttonSetPremiumLiner";
            this.buttonSetPremiumLiner.Size = new System.Drawing.Size(134, 79);
            this.buttonSetPremiumLiner.TabIndex = 2;
            this.buttonSetPremiumLiner.Text = "Park premium liner";
            this.buttonSetPremiumLiner.UseVisualStyleBackColor = true;
            this.buttonSetPremiumLiner.Click += new System.EventHandler(this.buttonSetPremiumLiner_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPickUp);
            this.groupBox1.Controls.Add(this.maskedTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(836, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 204);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pick up liner";
            // 
            // buttonPickUp
            // 
            this.buttonPickUp.Location = new System.Drawing.Point(29, 130);
            this.buttonPickUp.Name = "buttonPickUp";
            this.buttonPickUp.Size = new System.Drawing.Size(134, 34);
            this.buttonPickUp.TabIndex = 2;
            this.buttonPickUp.Text = "Pick up";
            this.buttonPickUp.UseVisualStyleBackColor = true;
            this.buttonPickUp.Click += new System.EventHandler(this.buttonPickUp_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(95, 63);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(68, 31);
            this.maskedTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Place";
            // 
            // FormPier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 630);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSetPremiumLiner);
            this.Controls.Add(this.buttonSetLiner);
            this.Controls.Add(this.pictureBoxPier);
            this.Name = "FormPier";
            this.Text = "Pier";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPier)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPier;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSetPremiumLiner;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSetLiner;
        private System.Windows.Forms.Button buttonPickUp;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
    }
}