namespace ERMANAGEMENT.AdminScreens
{
    partial class Formaddstaff
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
            this.anh = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.ten = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmnd = new Guna.UI2.WinForms.Guna2TextBox();
            this.position = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.birthday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.anh)).BeginInit();
            this.SuspendLayout();
            // 
            // anh
            // 
            this.anh.ImageRotate = 0F;
            this.anh.Location = new System.Drawing.Point(62, 35);
            this.anh.Name = "anh";
            this.anh.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.anh.Size = new System.Drawing.Size(151, 151);
            this.anh.TabIndex = 0;
            this.anh.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Black;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(62, 199);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(151, 45);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Choose an image";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // ten
            // 
            this.ten.AutoRoundedCorners = true;
            this.ten.BorderRadius = 17;
            this.ten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ten.DefaultText = "";
            this.ten.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ten.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ten.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ten.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ten.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ten.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ten.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ten.Location = new System.Drawing.Point(370, 49);
            this.ten.Name = "ten";
            this.ten.PasswordChar = '\0';
            this.ten.PlaceholderText = "john e.g...";
            this.ten.SelectedText = "";
            this.ten.Size = new System.Drawing.Size(200, 36);
            this.ten.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // cmnd
            // 
            this.cmnd.AutoRoundedCorners = true;
            this.cmnd.BorderRadius = 17;
            this.cmnd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cmnd.DefaultText = "";
            this.cmnd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cmnd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cmnd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cmnd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cmnd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmnd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmnd.Location = new System.Drawing.Point(370, 101);
            this.cmnd.Name = "cmnd";
            this.cmnd.PasswordChar = '\0';
            this.cmnd.PlaceholderText = "0918248141...";
            this.cmnd.SelectedText = "";
            this.cmnd.Size = new System.Drawing.Size(200, 36);
            this.cmnd.TabIndex = 4;
            // 
            // position
            // 
            this.position.BackColor = System.Drawing.Color.Transparent;
            this.position.BorderRadius = 10;
            this.position.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.position.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.position.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.position.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.position.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.position.ItemHeight = 30;
            this.position.Items.AddRange(new object[] {
            "Chief",
            "Waiter"});
            this.position.Location = new System.Drawing.Point(654, 49);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(140, 36);
            this.position.TabIndex = 5;
            this.position.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(583, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Identification";
            // 
            // startdate
            // 
            this.startdate.AutoRoundedCorners = true;
            this.startdate.BorderRadius = 17;
            this.startdate.Checked = true;
            this.startdate.FillColor = System.Drawing.Color.White;
            this.startdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.startdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startdate.Location = new System.Drawing.Point(370, 150);
            this.startdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.startdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(212, 36);
            this.startdate.TabIndex = 8;
            this.startdate.Value = new System.DateTime(2022, 4, 12, 9, 6, 51, 143);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Start date";
            // 
            // birthday
            // 
            this.birthday.AutoRoundedCorners = true;
            this.birthday.BorderRadius = 17;
            this.birthday.Checked = true;
            this.birthday.FillColor = System.Drawing.Color.White;
            this.birthday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthday.Location = new System.Drawing.Point(370, 192);
            this.birthday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.birthday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(212, 36);
            this.birthday.TabIndex = 10;
            this.birthday.Value = new System.DateTime(2022, 4, 12, 9, 6, 51, 143);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Birthday";
            // 
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BorderRadius = 21;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Black;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(631, 323);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(151, 45);
            this.guna2Button2.TabIndex = 12;
            this.guna2Button2.Text = "Add";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // Formaddstaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 445);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.position);
            this.Controls.Add(this.cmnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.anh);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(845, 492);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(845, 492);
            this.Name = "Formaddstaff";
            this.Text = "Add Staff";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Formaddstaff_FormClosing);
            this.Load += new System.EventHandler(this.Formaddstaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox anh;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox ten;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox cmnd;
        private Guna.UI2.WinForms.Guna2ComboBox position;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker startdate;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker birthday;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}