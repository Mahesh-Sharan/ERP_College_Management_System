namespace ERP
{
    partial class AdminLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.BackBT = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginBT = new Guna.UI2.WinForms.Guna2GradientButton();
            this.passwordTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.idTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Wrongpsswd = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1084, 550);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // BackBT
            // 
            this.BackBT.Animated = true;
            this.BackBT.AutoRoundedCorners = true;
            this.BackBT.BackColor = System.Drawing.Color.Transparent;
            this.BackBT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.BackBT.BorderRadius = 21;
            this.BackBT.BorderThickness = 1;
            this.BackBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackBT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackBT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackBT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackBT.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackBT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackBT.FillColor = System.Drawing.Color.Transparent;
            this.BackBT.FillColor2 = System.Drawing.Color.Transparent;
            this.BackBT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BackBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.BackBT.Location = new System.Drawing.Point(779, 401);
            this.BackBT.Name = "BackBT";
            this.BackBT.Size = new System.Drawing.Size(163, 45);
            this.BackBT.TabIndex = 34;
            this.BackBT.Text = "BACK";
            this.BackBT.UseTransparentBackground = true;
            this.BackBT.Click += new System.EventHandler(this.BackBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(684, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 52);
            this.label1.TabIndex = 33;
            this.label1.Text = " Sign In";
            // 
            // LoginBT
            // 
            this.LoginBT.Animated = true;
            this.LoginBT.AutoRoundedCorners = true;
            this.LoginBT.BackColor = System.Drawing.Color.Transparent;
            this.LoginBT.BorderRadius = 21;
            this.LoginBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginBT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginBT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginBT.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginBT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginBT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.LoginBT.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.LoginBT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBT.ForeColor = System.Drawing.Color.White;
            this.LoginBT.Location = new System.Drawing.Point(609, 401);
            this.LoginBT.Name = "LoginBT";
            this.LoginBT.Size = new System.Drawing.Size(160, 45);
            this.LoginBT.TabIndex = 32;
            this.LoginBT.Text = "LOGIN";
            this.LoginBT.UseTransparentBackground = true;
            this.LoginBT.Click += new System.EventHandler(this.LoginBT_Click);
            // 
            // passwordTB
            // 
            this.passwordTB.Animated = true;
            this.passwordTB.AutoRoundedCorners = true;
            this.passwordTB.BackColor = System.Drawing.Color.Transparent;
            this.passwordTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.passwordTB.BorderRadius = 27;
            this.passwordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTB.DefaultText = "";
            this.passwordTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.passwordTB.ForeColor = System.Drawing.Color.Black;
            this.passwordTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTB.IconLeft = ((System.Drawing.Image)(resources.GetObject("passwordTB.IconLeft")));
            this.passwordTB.IconLeftOffset = new System.Drawing.Point(15, 0);
            this.passwordTB.IconLeftSize = new System.Drawing.Size(35, 35);
            this.passwordTB.Location = new System.Drawing.Point(608, 286);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTB.MaxLength = 8;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '●';
            this.passwordTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.passwordTB.PlaceholderText = "Enter Password";
            this.passwordTB.SelectedText = "";
            this.passwordTB.Size = new System.Drawing.Size(339, 57);
            this.passwordTB.TabIndex = 31;
            this.passwordTB.TextOffset = new System.Drawing.Point(7, 0);
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // idTB
            // 
            this.idTB.Animated = true;
            this.idTB.AutoRoundedCorners = true;
            this.idTB.BackColor = System.Drawing.Color.Transparent;
            this.idTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.idTB.BorderRadius = 27;
            this.idTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idTB.DefaultText = "";
            this.idTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.idTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.idTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idTB.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.idTB.ForeColor = System.Drawing.Color.Black;
            this.idTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idTB.IconLeft = ((System.Drawing.Image)(resources.GetObject("idTB.IconLeft")));
            this.idTB.IconLeftOffset = new System.Drawing.Point(15, 0);
            this.idTB.IconLeftSize = new System.Drawing.Size(35, 35);
            this.idTB.Location = new System.Drawing.Point(608, 199);
            this.idTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTB.MaxLength = 8;
            this.idTB.Name = "idTB";
            this.idTB.PasswordChar = '\0';
            this.idTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.idTB.PlaceholderText = "Enter Username";
            this.idTB.SelectedText = "";
            this.idTB.Size = new System.Drawing.Size(339, 57);
            this.idTB.TabIndex = 30;
            this.idTB.TextOffset = new System.Drawing.Point(7, 0);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(941, 60);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(46, 49);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 29;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // Wrongpsswd
            // 
            this.Wrongpsswd.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.Wrongpsswd.Caption = null;
            this.Wrongpsswd.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.Wrongpsswd.Parent = null;
            this.Wrongpsswd.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.Wrongpsswd.Text = "Wrong ID or Password !";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.8D;
            this.guna2DragControl1.DragStartTransparencyValue = 0.5D;
            this.guna2DragControl1.TargetControl = this.guna2PictureBox1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 550);
            this.Controls.Add(this.BackBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBT);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton BackBT;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton LoginBT;
        private Guna.UI2.WinForms.Guna2TextBox passwordTB;
        private Guna.UI2.WinForms.Guna2TextBox idTB;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2MessageDialog Wrongpsswd;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}