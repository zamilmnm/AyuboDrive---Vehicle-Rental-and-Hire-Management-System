namespace AyuboDrive
{
    partial class vehicle
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
            this.vehiclesdataGridView = new System.Windows.Forms.DataGridView();
            this.vehiclesgroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.vehicRegNoBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label39 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vehicNameBox = new System.Windows.Forms.TextBox();
            this.vehicomboBox = new System.Windows.Forms.ComboBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesdataGridView)).BeginInit();
            this.vehiclesgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // vehiclesdataGridView
            // 
            this.vehiclesdataGridView.AllowUserToAddRows = false;
            this.vehiclesdataGridView.AllowUserToDeleteRows = false;
            this.vehiclesdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vehiclesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehiclesdataGridView.Location = new System.Drawing.Point(-1, 432);
            this.vehiclesdataGridView.Name = "vehiclesdataGridView";
            this.vehiclesdataGridView.ReadOnly = true;
            this.vehiclesdataGridView.RowHeadersWidth = 51;
            this.vehiclesdataGridView.RowTemplate.Height = 24;
            this.vehiclesdataGridView.Size = new System.Drawing.Size(1483, 371);
            this.vehiclesdataGridView.TabIndex = 3;
            this.vehiclesdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vehiclesdataGridView_CellClick);
            this.vehiclesdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vehiclesdataGridView_CellContentClick);
            // 
            // vehiclesgroupBox
            // 
            this.vehiclesgroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.vehiclesgroupBox.Controls.Add(this.label5);
            this.vehiclesgroupBox.Controls.Add(this.clearBtn);
            this.vehiclesgroupBox.Controls.Add(this.vehicRegNoBox);
            this.vehiclesgroupBox.Controls.Add(this.label1);
            this.vehiclesgroupBox.Controls.Add(this.button1);
            this.vehiclesgroupBox.Controls.Add(this.label39);
            this.vehiclesgroupBox.Controls.Add(this.searchBox);
            this.vehiclesgroupBox.Controls.Add(this.label11);
            this.vehiclesgroupBox.Controls.Add(this.pictureBox1);
            this.vehiclesgroupBox.Controls.Add(this.vehicNameBox);
            this.vehiclesgroupBox.Controls.Add(this.vehicomboBox);
            this.vehiclesgroupBox.Controls.Add(this.deleteBtn);
            this.vehiclesgroupBox.Controls.Add(this.updateBtn);
            this.vehiclesgroupBox.Controls.Add(this.saveBtn);
            this.vehiclesgroupBox.Controls.Add(this.label3);
            this.vehiclesgroupBox.Controls.Add(this.label2);
            this.vehiclesgroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehiclesgroupBox.Location = new System.Drawing.Point(-1, -2);
            this.vehiclesgroupBox.Name = "vehiclesgroupBox";
            this.vehiclesgroupBox.Size = new System.Drawing.Size(1483, 436);
            this.vehiclesgroupBox.TabIndex = 2;
            this.vehiclesgroupBox.TabStop = false;
            this.vehiclesgroupBox.Text = "vehicles Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1439, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 16);
            this.label5.TabIndex = 59;
            this.label5.Text = "z";
            // 
            // clearBtn
            // 
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Location = new System.Drawing.Point(1009, 114);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 42);
            this.clearBtn.TabIndex = 58;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // vehicRegNoBox
            // 
            this.vehicRegNoBox.Location = new System.Drawing.Point(636, 64);
            this.vehicRegNoBox.Name = "vehicRegNoBox";
            this.vehicRegNoBox.Size = new System.Drawing.Size(295, 30);
            this.vehicRegNoBox.TabIndex = 57;
            this.vehicRegNoBox.TextChanged += new System.EventHandler(this.vehicRegNoBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 56;
            this.label1.Text = "Register No:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1217, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 40);
            this.button1.TabIndex = 54;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(115, 290);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(171, 32);
            this.label39.TabIndex = 47;
            this.label39.Text = "AyuboDrive";
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(1245, 261);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(181, 30);
            this.searchBox.TabIndex = 53;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1094, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 25);
            this.label11.TabIndex = 52;
            this.label11.Text = "Search Hire:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AyuboDrive.Properties.Resources.ef3be1656bce03ea85bebb97a8b4254e;
            this.pictureBox1.Location = new System.Drawing.Point(45, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // vehicNameBox
            // 
            this.vehicNameBox.Location = new System.Drawing.Point(636, 181);
            this.vehicNameBox.Name = "vehicNameBox";
            this.vehicNameBox.Size = new System.Drawing.Size(295, 30);
            this.vehicNameBox.TabIndex = 13;
            this.vehicNameBox.TextChanged += new System.EventHandler(this.vehicNameBox_TextChanged);
            // 
            // vehicomboBox
            // 
            this.vehicomboBox.FormattingEnabled = true;
            this.vehicomboBox.Location = new System.Drawing.Point(636, 123);
            this.vehicomboBox.Name = "vehicomboBox";
            this.vehicomboBox.Size = new System.Drawing.Size(295, 33);
            this.vehicomboBox.TabIndex = 12;
            this.vehicomboBox.SelectedIndexChanged += new System.EventHandler(this.vehicomboBox_SelectedIndexChanged);
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(436, 300);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(90, 60);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(627, 300);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(90, 60);
            this.updateBtn.TabIndex = 10;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(817, 300);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(90, 60);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(411, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vehicle Catogery:";
            // 
            // vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 803);
            this.Controls.Add(this.vehiclesdataGridView);
            this.Controls.Add(this.vehiclesgroupBox);
            this.Name = "vehicle";
            this.Text = "vehicle";
            this.Load += new System.EventHandler(this.vehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesdataGridView)).EndInit();
            this.vehiclesgroupBox.ResumeLayout(false);
            this.vehiclesgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView vehiclesdataGridView;
        private System.Windows.Forms.GroupBox vehiclesgroupBox;
        private System.Windows.Forms.TextBox vehicNameBox;
        private System.Windows.Forms.ComboBox vehicomboBox;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox vehicRegNoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label5;
    }
}