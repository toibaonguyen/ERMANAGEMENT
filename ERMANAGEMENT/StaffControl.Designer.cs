namespace ERMANAGEMENT
{
    partial class StaffControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.anh1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.name = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.age = new System.Windows.Forms.Label();
            this.checkradiobutton = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.cmnd = new System.Windows.Forms.Label();
            this.startdatee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.anh1)).BeginInit();
            this.SuspendLayout();
            // 
            // anh1
            // 
            this.anh1.ImageRotate = 0F;
            this.anh1.Location = new System.Drawing.Point(23, 13);
            this.anh1.Name = "anh1";
            this.anh1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.anh1.Size = new System.Drawing.Size(90, 90);
            this.anh1.TabIndex = 0;
            this.anh1.TabStop = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(147, 26);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(44, 16);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Location = new System.Drawing.Point(147, 51);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(55, 16);
            this.position.TabIndex = 2;
            this.position.Text = "Position";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 117);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(596, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 117);
            this.panel2.TabIndex = 4;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(316, 26);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(32, 16);
            this.age.TabIndex = 6;
            this.age.Text = "Age";
            // 
            // checkradiobutton
            // 
            this.checkradiobutton.BackColor = System.Drawing.Color.Transparent;
            this.checkradiobutton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkradiobutton.CheckedState.BorderThickness = 0;
            this.checkradiobutton.CheckedState.FillColor = System.Drawing.Color.Black;
            this.checkradiobutton.CheckedState.InnerColor = System.Drawing.Color.Red;
            this.checkradiobutton.Location = new System.Drawing.Point(560, 13);
            this.checkradiobutton.Name = "checkradiobutton";
            this.checkradiobutton.Size = new System.Drawing.Size(20, 20);
            this.checkradiobutton.TabIndex = 7;
            this.checkradiobutton.Text = "guna2CustomRadioButton1";
            this.checkradiobutton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkradiobutton.UncheckedState.BorderThickness = 2;
            this.checkradiobutton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkradiobutton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.checkradiobutton.CheckedChanged += new System.EventHandler(this.checkradiobutton_CheckedChanged);
            // 
            // cmnd
            // 
            this.cmnd.AutoSize = true;
            this.cmnd.Location = new System.Drawing.Point(147, 87);
            this.cmnd.Name = "cmnd";
            this.cmnd.Size = new System.Drawing.Size(47, 16);
            this.cmnd.TabIndex = 8;
            this.cmnd.Text = "CMND";
            // 
            // startdatee
            // 
            this.startdatee.AutoSize = true;
            this.startdatee.Location = new System.Drawing.Point(319, 51);
            this.startdatee.Name = "startdatee";
            this.startdatee.Size = new System.Drawing.Size(59, 16);
            this.startdatee.TabIndex = 9;
            this.startdatee.Text = "startdate";
            // 
            // StaffControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.startdatee);
            this.Controls.Add(this.cmnd);
            this.Controls.Add(this.checkradiobutton);
            this.Controls.Add(this.age);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.position);
            this.Controls.Add(this.name);
            this.Controls.Add(this.anh1);
            this.Name = "StaffControl";
            this.Size = new System.Drawing.Size(601, 117);
            this.Load += new System.EventHandler(this.StaffControl_Load);
            this.Click += new System.EventHandler(this.StaffControl_Click);
            this.MouseEnter += new System.EventHandler(this.StaffControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.StaffControl_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.anh1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox anh1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label age;
        private Guna.UI2.WinForms.Guna2CustomRadioButton checkradiobutton;
        private System.Windows.Forms.Label cmnd;
        private System.Windows.Forms.Label startdatee;
    }
}
