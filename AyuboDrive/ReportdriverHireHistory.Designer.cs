﻿namespace AyuboDrive
{
    partial class ReportdriverHireHistory
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
            this.driverHireHistorydataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label39 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.findBtn = new System.Windows.Forms.Button();
            this.driverIDBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.driverHireHistorydataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // driverHireHistorydataGridView
            // 
            this.driverHireHistorydataGridView.AllowUserToAddRows = false;
            this.driverHireHistorydataGridView.AllowUserToDeleteRows = false;
            this.driverHireHistorydataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.driverHireHistorydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.driverHireHistorydataGridView.Location = new System.Drawing.Point(2, 270);
            this.driverHireHistorydataGridView.Name = "driverHireHistorydataGridView";
            this.driverHireHistorydataGridView.ReadOnly = true;
            this.driverHireHistorydataGridView.RowHeadersWidth = 51;
            this.driverHireHistorydataGridView.RowTemplate.Height = 24;
            this.driverHireHistorydataGridView.Size = new System.Drawing.Size(1478, 528);
            this.driverHireHistorydataGridView.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label39);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.findBtn);
            this.groupBox1.Controls.Add(this.driverIDBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1478, 270);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FInd Involved Drivers in Hire ";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(89, 213);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(171, 32);
            this.label39.TabIndex = 47;
            this.label39.Text = "AyuboDrive";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AyuboDrive.Properties.Resources.ef3be1656bce03ea85bebb97a8b4254e;
            this.pictureBox1.Location = new System.Drawing.Point(24, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // findBtn
            // 
            this.findBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findBtn.Location = new System.Drawing.Point(934, 105);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(75, 40);
            this.findBtn.TabIndex = 2;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // driverIDBox
            // 
            this.driverIDBox.Location = new System.Drawing.Point(645, 113);
            this.driverIDBox.Name = "driverIDBox";
            this.driverIDBox.Size = new System.Drawing.Size(183, 27);
            this.driverIDBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Driver ID:";
            // 
            // ReportdriverHireHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 803);
            this.Controls.Add(this.driverHireHistorydataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReportdriverHireHistory";
            this.Text = "ReportdriverHireHistory";
            ((System.ComponentModel.ISupportInitialize)(this.driverHireHistorydataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView driverHireHistorydataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.TextBox driverIDBox;
        private System.Windows.Forms.Label label1;
    }
}