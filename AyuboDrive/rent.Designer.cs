namespace AyuboDrive
{
    partial class rent
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
            this.rentdataGridView = new System.Windows.Forms.DataGridView();
            this.rentgroupBox = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.vehicIDcomboBox = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rentEnddateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rentStartdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.custIDcomboBox = new System.Windows.Forms.ComboBox();
            this.driverIDcomboBox = new System.Windows.Forms.ComboBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.totalOdometerBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startOdometerBox = new System.Windows.Forms.TextBox();
            this.endOdometerBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rentDaysBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rentdataGridView)).BeginInit();
            this.rentgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rentdataGridView
            // 
            this.rentdataGridView.AllowUserToAddRows = false;
            this.rentdataGridView.AllowUserToDeleteRows = false;
            this.rentdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rentdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentdataGridView.Location = new System.Drawing.Point(-1, 514);
            this.rentdataGridView.Name = "rentdataGridView";
            this.rentdataGridView.ReadOnly = true;
            this.rentdataGridView.RowHeadersWidth = 51;
            this.rentdataGridView.RowTemplate.Height = 24;
            this.rentdataGridView.Size = new System.Drawing.Size(1483, 288);
            this.rentdataGridView.TabIndex = 3;
            this.rentdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rentdataGridView_CellClick);
            this.rentdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rentdataGridView_CellContentClick);
            // 
            // rentgroupBox
            // 
            this.rentgroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rentgroupBox.Controls.Add(this.label10);
            this.rentgroupBox.Controls.Add(this.clearBtn);
            this.rentgroupBox.Controls.Add(this.vehicIDcomboBox);
            this.rentgroupBox.Controls.Add(this.searchBtn);
            this.rentgroupBox.Controls.Add(this.searchBox);
            this.rentgroupBox.Controls.Add(this.label11);
            this.rentgroupBox.Controls.Add(this.label39);
            this.rentgroupBox.Controls.Add(this.pictureBox1);
            this.rentgroupBox.Controls.Add(this.rentEnddateTimePicker);
            this.rentgroupBox.Controls.Add(this.rentStartdateTimePicker);
            this.rentgroupBox.Controls.Add(this.custIDcomboBox);
            this.rentgroupBox.Controls.Add(this.driverIDcomboBox);
            this.rentgroupBox.Controls.Add(this.deleteBtn);
            this.rentgroupBox.Controls.Add(this.updateBtn);
            this.rentgroupBox.Controls.Add(this.saveBtn);
            this.rentgroupBox.Controls.Add(this.totalOdometerBox);
            this.rentgroupBox.Controls.Add(this.label9);
            this.rentgroupBox.Controls.Add(this.label8);
            this.rentgroupBox.Controls.Add(this.label4);
            this.rentgroupBox.Controls.Add(this.startOdometerBox);
            this.rentgroupBox.Controls.Add(this.endOdometerBox);
            this.rentgroupBox.Controls.Add(this.label7);
            this.rentgroupBox.Controls.Add(this.label6);
            this.rentgroupBox.Controls.Add(this.label2);
            this.rentgroupBox.Controls.Add(this.rentDaysBox);
            this.rentgroupBox.Controls.Add(this.label3);
            this.rentgroupBox.Controls.Add(this.label5);
            this.rentgroupBox.Controls.Add(this.label1);
            this.rentgroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentgroupBox.Location = new System.Drawing.Point(-1, 1);
            this.rentgroupBox.Name = "rentgroupBox";
            this.rentgroupBox.Size = new System.Drawing.Size(1483, 516);
            this.rentgroupBox.TabIndex = 2;
            this.rentgroupBox.TabStop = false;
            this.rentgroupBox.Text = "Rent Information";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1439, 485);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 16);
            this.label10.TabIndex = 60;
            this.label10.Text = "z";
            // 
            // clearBtn
            // 
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Location = new System.Drawing.Point(1073, 179);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 42);
            this.clearBtn.TabIndex = 59;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // vehicIDcomboBox
            // 
            this.vehicIDcomboBox.FormattingEnabled = true;
            this.vehicIDcomboBox.Location = new System.Drawing.Point(714, 17);
            this.vehicIDcomboBox.Name = "vehicIDcomboBox";
            this.vehicIDcomboBox.Size = new System.Drawing.Size(271, 33);
            this.vehicIDcomboBox.TabIndex = 58;
            this.vehicIDcomboBox.SelectedIndexChanged += new System.EventHandler(this.vehicIDcomboBox_SelectedIndexChanged_1);
            // 
            // searchBtn
            // 
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(1223, 405);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(85, 40);
            this.searchBtn.TabIndex = 57;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(1251, 356);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(181, 30);
            this.searchBox.TabIndex = 56;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1091, 361);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 25);
            this.label11.TabIndex = 55;
            this.label11.Text = "Search Rent:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(103, 286);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(171, 32);
            this.label39.TabIndex = 47;
            this.label39.Text = "AyuboDrive";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AyuboDrive.Properties.Resources.ef3be1656bce03ea85bebb97a8b4254e;
            this.pictureBox1.Location = new System.Drawing.Point(33, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rentEnddateTimePicker
            // 
            this.rentEnddateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.rentEnddateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rentEnddateTimePicker.Location = new System.Drawing.Point(714, 162);
            this.rentEnddateTimePicker.Name = "rentEnddateTimePicker";
            this.rentEnddateTimePicker.Size = new System.Drawing.Size(271, 30);
            this.rentEnddateTimePicker.TabIndex = 5;
            this.rentEnddateTimePicker.ValueChanged += new System.EventHandler(this.rentEnddateTimePicker_ValueChanged);
            // 
            // rentStartdateTimePicker
            // 
            this.rentStartdateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.rentStartdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rentStartdateTimePicker.Location = new System.Drawing.Point(714, 112);
            this.rentStartdateTimePicker.Name = "rentStartdateTimePicker";
            this.rentStartdateTimePicker.Size = new System.Drawing.Size(271, 30);
            this.rentStartdateTimePicker.TabIndex = 6;
            this.rentStartdateTimePicker.ValueChanged += new System.EventHandler(this.rentStartdateTimePicker_ValueChanged);
            // 
            // custIDcomboBox
            // 
            this.custIDcomboBox.FormattingEnabled = true;
            this.custIDcomboBox.Location = new System.Drawing.Point(714, 391);
            this.custIDcomboBox.Name = "custIDcomboBox";
            this.custIDcomboBox.Size = new System.Drawing.Size(271, 33);
            this.custIDcomboBox.TabIndex = 3;
            this.custIDcomboBox.SelectedIndexChanged += new System.EventHandler(this.custIDcomboBox_SelectedIndexChanged);
            // 
            // driverIDcomboBox
            // 
            this.driverIDcomboBox.FormattingEnabled = true;
            this.driverIDcomboBox.Location = new System.Drawing.Point(714, 64);
            this.driverIDcomboBox.Name = "driverIDcomboBox";
            this.driverIDcomboBox.Size = new System.Drawing.Size(271, 33);
            this.driverIDcomboBox.TabIndex = 3;
            this.driverIDcomboBox.SelectedIndexChanged += new System.EventHandler(this.driverIDcomboBox_SelectedIndexChanged);
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(440, 441);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(90, 60);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(655, 441);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(90, 60);
            this.updateBtn.TabIndex = 2;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(882, 441);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(90, 60);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // totalOdometerBox
            // 
            this.totalOdometerBox.Location = new System.Drawing.Point(714, 339);
            this.totalOdometerBox.Name = "totalOdometerBox";
            this.totalOdometerBox.Size = new System.Drawing.Size(271, 30);
            this.totalOdometerBox.TabIndex = 1;
            this.totalOdometerBox.TextChanged += new System.EventHandler(this.totalOdometerBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(427, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Customer:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(427, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total Odometer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(427, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Rent End Date:";
            // 
            // startOdometerBox
            // 
            this.startOdometerBox.Location = new System.Drawing.Point(714, 248);
            this.startOdometerBox.Name = "startOdometerBox";
            this.startOdometerBox.Size = new System.Drawing.Size(271, 30);
            this.startOdometerBox.TabIndex = 1;
            this.startOdometerBox.TextChanged += new System.EventHandler(this.startOdometerBox_TextChanged);
            // 
            // endOdometerBox
            // 
            this.endOdometerBox.Location = new System.Drawing.Point(714, 294);
            this.endOdometerBox.Name = "endOdometerBox";
            this.endOdometerBox.Size = new System.Drawing.Size(271, 30);
            this.endOdometerBox.TabIndex = 1;
            this.endOdometerBox.TextChanged += new System.EventHandler(this.endOdometerBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(427, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Start Odometer:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(427, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "End Odometer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Driver:";
            // 
            // rentDaysBox
            // 
            this.rentDaysBox.Location = new System.Drawing.Point(714, 203);
            this.rentDaysBox.Name = "rentDaysBox";
            this.rentDaysBox.Size = new System.Drawing.Size(271, 30);
            this.rentDaysBox.TabIndex = 1;
            this.rentDaysBox.TextChanged += new System.EventHandler(this.rentDaysBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(427, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rent Start Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(427, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rent Days:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle:";
            // 
            // rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 803);
            this.Controls.Add(this.rentdataGridView);
            this.Controls.Add(this.rentgroupBox);
            this.Name = "rent";
            this.Text = "rent";
            this.Load += new System.EventHandler(this.rent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentdataGridView)).EndInit();
            this.rentgroupBox.ResumeLayout(false);
            this.rentgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView rentdataGridView;
        private System.Windows.Forms.GroupBox rentgroupBox;
        private System.Windows.Forms.ComboBox custIDcomboBox;
        private System.Windows.Forms.ComboBox driverIDcomboBox;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox totalOdometerBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox startOdometerBox;
        private System.Windows.Forms.TextBox endOdometerBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rentDaysBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker rentStartdateTimePicker;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox vehicIDcomboBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.DateTimePicker rentEnddateTimePicker;
        private System.Windows.Forms.Label label10;
    }
}