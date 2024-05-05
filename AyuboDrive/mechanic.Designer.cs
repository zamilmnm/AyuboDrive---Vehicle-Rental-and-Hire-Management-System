namespace AyuboDrive
{
    partial class mechanic
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
            this.mechanicdataGridView = new System.Windows.Forms.DataGridView();
            this.mechanicgroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.mechMobBox = new System.Windows.Forms.TextBox();
            this.mechNicBox = new System.Windows.Forms.TextBox();
            this.mechNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mechanicdataGridView)).BeginInit();
            this.mechanicgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mechanicdataGridView
            // 
            this.mechanicdataGridView.AllowUserToAddRows = false;
            this.mechanicdataGridView.AllowUserToDeleteRows = false;
            this.mechanicdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mechanicdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mechanicdataGridView.Location = new System.Drawing.Point(-2, 331);
            this.mechanicdataGridView.Name = "mechanicdataGridView";
            this.mechanicdataGridView.ReadOnly = true;
            this.mechanicdataGridView.RowHeadersWidth = 51;
            this.mechanicdataGridView.RowTemplate.Height = 24;
            this.mechanicdataGridView.Size = new System.Drawing.Size(1485, 473);
            this.mechanicdataGridView.TabIndex = 3;
            this.mechanicdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mechanicdataGridView_CellClick);
            this.mechanicdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mechanicdataGridView_CellContentClick);
            // 
            // mechanicgroupBox
            // 
            this.mechanicgroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mechanicgroupBox.Controls.Add(this.label5);
            this.mechanicgroupBox.Controls.Add(this.clearBtn);
            this.mechanicgroupBox.Controls.Add(this.searchBtn);
            this.mechanicgroupBox.Controls.Add(this.searchBox);
            this.mechanicgroupBox.Controls.Add(this.label11);
            this.mechanicgroupBox.Controls.Add(this.label39);
            this.mechanicgroupBox.Controls.Add(this.pictureBox1);
            this.mechanicgroupBox.Controls.Add(this.deleteBtn);
            this.mechanicgroupBox.Controls.Add(this.updateBtn);
            this.mechanicgroupBox.Controls.Add(this.saveBtn);
            this.mechanicgroupBox.Controls.Add(this.mechMobBox);
            this.mechanicgroupBox.Controls.Add(this.mechNicBox);
            this.mechanicgroupBox.Controls.Add(this.mechNameBox);
            this.mechanicgroupBox.Controls.Add(this.label4);
            this.mechanicgroupBox.Controls.Add(this.label3);
            this.mechanicgroupBox.Controls.Add(this.label2);
            this.mechanicgroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mechanicgroupBox.Location = new System.Drawing.Point(-2, 0);
            this.mechanicgroupBox.Name = "mechanicgroupBox";
            this.mechanicgroupBox.Size = new System.Drawing.Size(1485, 332);
            this.mechanicgroupBox.TabIndex = 2;
            this.mechanicgroupBox.TabStop = false;
            this.mechanicgroupBox.Text = "Mechanic Information";
            this.mechanicgroupBox.Enter += new System.EventHandler(this.mechanicgroupBox_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1439, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 16);
            this.label5.TabIndex = 56;
            this.label5.Text = "z";
            // 
            // clearBtn
            // 
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Location = new System.Drawing.Point(991, 97);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 42);
            this.clearBtn.TabIndex = 55;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(1166, 257);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(85, 40);
            this.searchBtn.TabIndex = 54;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(1194, 208);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(181, 30);
            this.searchBox.TabIndex = 53;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1001, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(187, 25);
            this.label11.TabIndex = 52;
            this.label11.Text = "Search Mechanic:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(106, 260);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(171, 32);
            this.label39.TabIndex = 47;
            this.label39.Text = "AyuboDrive";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AyuboDrive.Properties.Resources.ef3be1656bce03ea85bebb97a8b4254e;
            this.pictureBox1.Location = new System.Drawing.Point(36, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(497, 224);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(90, 60);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(638, 224);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(90, 60);
            this.updateBtn.TabIndex = 9;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(790, 224);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(90, 60);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // mechMobBox
            // 
            this.mechMobBox.Location = new System.Drawing.Point(655, 160);
            this.mechMobBox.Name = "mechMobBox";
            this.mechMobBox.Size = new System.Drawing.Size(290, 30);
            this.mechMobBox.TabIndex = 5;
            this.mechMobBox.TextChanged += new System.EventHandler(this.mechMobBox_TextChanged);
            // 
            // mechNicBox
            // 
            this.mechNicBox.Location = new System.Drawing.Point(655, 97);
            this.mechNicBox.Name = "mechNicBox";
            this.mechNicBox.Size = new System.Drawing.Size(290, 30);
            this.mechNicBox.TabIndex = 6;
            this.mechNicBox.TextChanged += new System.EventHandler(this.mechNicBox_TextChanged);
            // 
            // mechNameBox
            // 
            this.mechNameBox.Location = new System.Drawing.Point(655, 44);
            this.mechNameBox.Name = "mechNameBox";
            this.mechNameBox.Size = new System.Drawing.Size(290, 30);
            this.mechNameBox.TabIndex = 7;
            this.mechNameBox.TextChanged += new System.EventHandler(this.mechNameBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mobile No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nic:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // mechanic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 803);
            this.Controls.Add(this.mechanicdataGridView);
            this.Controls.Add(this.mechanicgroupBox);
            this.Name = "mechanic";
            this.Text = "mechanic";
            this.Load += new System.EventHandler(this.mechanic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mechanicdataGridView)).EndInit();
            this.mechanicgroupBox.ResumeLayout(false);
            this.mechanicgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView mechanicdataGridView;
        private System.Windows.Forms.GroupBox mechanicgroupBox;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox mechMobBox;
        private System.Windows.Forms.TextBox mechNicBox;
        private System.Windows.Forms.TextBox mechNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label5;
    }
}