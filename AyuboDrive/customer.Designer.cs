namespace AyuboDrive
{
    partial class customer
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
            this.customerdataGridView = new System.Windows.Forms.DataGridView();
            this.customergroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.custAddressBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.custLicBox = new System.Windows.Forms.TextBox();
            this.custMobBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.custNameBox = new System.Windows.Forms.TextBox();
            this.customername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerdataGridView)).BeginInit();
            this.customergroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerdataGridView
            // 
            this.customerdataGridView.AllowUserToAddRows = false;
            this.customerdataGridView.AllowUserToDeleteRows = false;
            this.customerdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerdataGridView.Location = new System.Drawing.Point(4, 316);
            this.customerdataGridView.Name = "customerdataGridView";
            this.customerdataGridView.ReadOnly = true;
            this.customerdataGridView.RowHeadersWidth = 51;
            this.customerdataGridView.RowTemplate.Height = 24;
            this.customerdataGridView.Size = new System.Drawing.Size(1493, 531);
            this.customerdataGridView.TabIndex = 3;
            this.customerdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerdataGridView_CellClick);
            this.customerdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerdataGridView_CellContentClick);
            // 
            // customergroupBox
            // 
            this.customergroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.customergroupBox.Controls.Add(this.label5);
            this.customergroupBox.Controls.Add(this.clearBtn);
            this.customergroupBox.Controls.Add(this.button1);
            this.customergroupBox.Controls.Add(this.searchBox);
            this.customergroupBox.Controls.Add(this.label1);
            this.customergroupBox.Controls.Add(this.label39);
            this.customergroupBox.Controls.Add(this.pictureBox1);
            this.customergroupBox.Controls.Add(this.deleteBtn);
            this.customergroupBox.Controls.Add(this.updateBtn);
            this.customergroupBox.Controls.Add(this.saveBtn);
            this.customergroupBox.Controls.Add(this.custAddressBox);
            this.customergroupBox.Controls.Add(this.label4);
            this.customergroupBox.Controls.Add(this.custLicBox);
            this.customergroupBox.Controls.Add(this.custMobBox);
            this.customergroupBox.Controls.Add(this.label2);
            this.customergroupBox.Controls.Add(this.label3);
            this.customergroupBox.Controls.Add(this.custNameBox);
            this.customergroupBox.Controls.Add(this.customername);
            this.customergroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customergroupBox.Location = new System.Drawing.Point(4, -3);
            this.customergroupBox.Name = "customergroupBox";
            this.customergroupBox.Size = new System.Drawing.Size(1493, 313);
            this.customergroupBox.TabIndex = 2;
            this.customergroupBox.TabStop = false;
            this.customergroupBox.Text = "Customer Information";
            this.customergroupBox.Enter += new System.EventHandler(this.customergroupBox_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1459, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "z";
            // 
            // clearBtn
            // 
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Location = new System.Drawing.Point(1031, 82);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 42);
            this.clearBtn.TabIndex = 49;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1234, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 40);
            this.button1.TabIndex = 48;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(1262, 187);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(181, 30);
            this.searchBox.TabIndex = 47;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1069, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Search Customer:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(100, 259);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(171, 32);
            this.label39.TabIndex = 45;
            this.label39.Text = "AyuboDrive";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AyuboDrive.Properties.Resources.ef3be1656bce03ea85bebb97a8b4254e;
            this.pictureBox1.Location = new System.Drawing.Point(38, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(474, 236);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(90, 60);
            this.deleteBtn.TabIndex = 10;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(670, 236);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(90, 60);
            this.updateBtn.TabIndex = 11;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(847, 236);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(90, 60);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // custAddressBox
            // 
            this.custAddressBox.Location = new System.Drawing.Point(622, 178);
            this.custAddressBox.Name = "custAddressBox";
            this.custAddressBox.Size = new System.Drawing.Size(342, 30);
            this.custAddressBox.TabIndex = 6;
            this.custAddressBox.TextChanged += new System.EventHandler(this.custAddressBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Address:";
            // 
            // custLicBox
            // 
            this.custLicBox.Location = new System.Drawing.Point(622, 73);
            this.custLicBox.Name = "custLicBox";
            this.custLicBox.Size = new System.Drawing.Size(342, 30);
            this.custLicBox.TabIndex = 7;
            this.custLicBox.TextChanged += new System.EventHandler(this.custLicBox_TextChanged);
            // 
            // custMobBox
            // 
            this.custMobBox.Location = new System.Drawing.Point(622, 131);
            this.custMobBox.Name = "custMobBox";
            this.custMobBox.Size = new System.Drawing.Size(342, 30);
            this.custMobBox.TabIndex = 8;
            this.custMobBox.TextChanged += new System.EventHandler(this.custMobBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Licence No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mobile:";
            // 
            // custNameBox
            // 
            this.custNameBox.Location = new System.Drawing.Point(622, 22);
            this.custNameBox.Name = "custNameBox";
            this.custNameBox.Size = new System.Drawing.Size(342, 30);
            this.custNameBox.TabIndex = 9;
            this.custNameBox.TextChanged += new System.EventHandler(this.custNameBox_TextChanged);
            // 
            // customername
            // 
            this.customername.AutoSize = true;
            this.customername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customername.Location = new System.Drawing.Point(456, 22);
            this.customername.Name = "customername";
            this.customername.Size = new System.Drawing.Size(84, 29);
            this.customername.TabIndex = 5;
            this.customername.Text = "Name:";
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 850);
            this.Controls.Add(this.customerdataGridView);
            this.Controls.Add(this.customergroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerdataGridView)).EndInit();
            this.customergroupBox.ResumeLayout(false);
            this.customergroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView customerdataGridView;
        private System.Windows.Forms.GroupBox customergroupBox;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox custAddressBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox custLicBox;
        private System.Windows.Forms.TextBox custMobBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox custNameBox;
        private System.Windows.Forms.Label customername;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label5;
    }
}