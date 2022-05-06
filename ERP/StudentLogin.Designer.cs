namespace ERP
{
    partial class StudentLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentLogin));
            this.LoginBT = new Guna.UI2.WinForms.Guna2GradientButton();
            this.passwordTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.idTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.frgtpswdBT = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.BackBT = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ForgotPswdMsg = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.Wrongpsswd = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.CurrentuserID = new Guna.UI2.WinForms.Guna2MessageDialog();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBT
            // 
            this.LoginBT.Animated = true;
            this.LoginBT.AutoRoundedCorners = true;
            this.LoginBT.BackColor = System.Drawing.Color.Transparent;
            this.LoginBT.BorderRadius = 21;
            this.LoginBT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginBT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginBT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginBT.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginBT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginBT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.LoginBT.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.LoginBT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBT.ForeColor = System.Drawing.Color.White;
            this.LoginBT.Location = new System.Drawing.Point(617, 401);
            this.LoginBT.Name = "LoginBT";
            this.LoginBT.PressedColor = System.Drawing.Color.White;
            this.LoginBT.Size = new System.Drawing.Size(160, 45);
            this.LoginBT.TabIndex = 12;
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
            this.passwordTB.Location = new System.Drawing.Point(616, 286);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTB.MaxLength = 8;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '●';
            this.passwordTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.passwordTB.PlaceholderText = "Enter Password";
            this.passwordTB.SelectedText = "";
            this.passwordTB.Size = new System.Drawing.Size(339, 57);
            this.passwordTB.TabIndex = 11;
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
            this.idTB.Location = new System.Drawing.Point(616, 199);
            this.idTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTB.MaxLength = 8;
            this.idTB.Name = "idTB";
            this.idTB.PasswordChar = '\0';
            this.idTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.idTB.PlaceholderText = "Enter Student ID";
            this.idTB.SelectedText = "";
            this.idTB.Size = new System.Drawing.Size(339, 57);
            this.idTB.TabIndex = 10;
            this.idTB.TextOffset = new System.Drawing.Point(7, 0);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(954, 63);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(46, 49);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 7;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1102, 553);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(711, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 52);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sign In";
            // 
            // frgtpswdBT
            // 
            this.frgtpswdBT.AutoSize = true;
            this.frgtpswdBT.BackColor = System.Drawing.Color.White;
            this.frgtpswdBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frgtpswdBT.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frgtpswdBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.frgtpswdBT.Location = new System.Drawing.Point(779, 351);
            this.frgtpswdBT.Name = "frgtpswdBT";
            this.frgtpswdBT.Size = new System.Drawing.Size(180, 22);
            this.frgtpswdBT.TabIndex = 15;
            this.frgtpswdBT.Text = "Forgot Password ?";
            this.frgtpswdBT.Click += new System.EventHandler(this.label2_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
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
            this.BackBT.Location = new System.Drawing.Point(787, 401);
            this.BackBT.Name = "BackBT";
            this.BackBT.Size = new System.Drawing.Size(163, 45);
            this.BackBT.TabIndex = 28;
            this.BackBT.Text = "BACK";
            this.BackBT.UseTransparentBackground = true;
            this.BackBT.Click += new System.EventHandler(this.guna2GradientButton2_Click_1);
            // 
            // ForgotPswdMsg
            // 
            this.ForgotPswdMsg.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.ForgotPswdMsg.Caption = null;
            this.ForgotPswdMsg.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.ForgotPswdMsg.Parent = this;
            this.ForgotPswdMsg.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.ForgotPswdMsg.Text = "Please reach out to your Class Cordinator to Proceed Further.  Thanks !";
            // 
            // Wrongpsswd
            // 
            this.Wrongpsswd.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.Wrongpsswd.Caption = null;
            this.Wrongpsswd.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.Wrongpsswd.Parent = this;
            this.Wrongpsswd.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.Wrongpsswd.Text = "Wrong ID or Password !";
            // 
            // CurrentuserID
            // 
            this.CurrentuserID.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.CurrentuserID.Caption = "Thanks for Using our Service";
            this.CurrentuserID.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.CurrentuserID.Parent = this;
            this.CurrentuserID.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.CurrentuserID.Text = "Current UserID Updated";
            // 
            // StudentLogin
            // 
            this.AcceptButton = this.LoginBT;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BackBT;
            this.ClientSize = new System.Drawing.Size(1102, 553);
            this.Controls.Add(this.BackBT);
            this.Controls.Add(this.frgtpswdBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBT);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.guna2PictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentLogin";
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox idTB;
        private Guna.UI2.WinForms.Guna2TextBox passwordTB;
        private Guna.UI2.WinForms.Guna2GradientButton LoginBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label frgtpswdBT;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientButton BackBT;
        private Guna.UI2.WinForms.Guna2MessageDialog ForgotPswdMsg;
        private Guna.UI2.WinForms.Guna2MessageDialog Wrongpsswd;
        private Guna.UI2.WinForms.Guna2MessageDialog CurrentuserID;
    }
}