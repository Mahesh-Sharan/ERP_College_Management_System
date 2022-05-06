namespace ERP
{
    partial class StudentRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRegister));
            this.SignupBG = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Rname = new Guna.UI2.WinForms.Guna2TextBox();
            this.Rphone = new Guna.UI2.WinForms.Guna2TextBox();
            this.courseCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BackBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Rpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.femaleRB = new System.Windows.Forms.RadioButton();
            this.maleRB = new System.Windows.Forms.RadioButton();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Rfather = new Guna.UI2.WinForms.Guna2TextBox();
            this.Rmother = new Guna.UI2.WinForms.Guna2TextBox();
            this.Ryear = new Guna.UI2.WinForms.Guna2TextBox();
            this.Rmarks = new Guna.UI2.WinForms.Guna2TextBox();
            this.license_checkbox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.DOB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Rid = new Guna.UI2.WinForms.Guna2TextBox();
            this.successful = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2CirclePictureBox4 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.emailTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.uploadimg = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Openfiledialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.SignupBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // SignupBG
            // 
            this.SignupBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SignupBG.Image = ((System.Drawing.Image)(resources.GetObject("SignupBG.Image")));
            this.SignupBG.ImageRotate = 0F;
            this.SignupBG.Location = new System.Drawing.Point(0, 0);
            this.SignupBG.Name = "SignupBG";
            this.SignupBG.Size = new System.Drawing.Size(1168, 600);
            this.SignupBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SignupBG.TabIndex = 0;
            this.SignupBG.TabStop = false;
            this.SignupBG.Click += new System.EventHandler(this.SignupBG_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.label1.Location = new System.Drawing.Point(724, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 52);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sign Up";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Rname
            // 
            this.Rname.Animated = true;
            this.Rname.AutoRoundedCorners = true;
            this.Rname.BackColor = System.Drawing.Color.Transparent;
            this.Rname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.Rname.BorderRadius = 18;
            this.Rname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Rname.DefaultText = "";
            this.Rname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Rname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Rname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Rname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Rname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Rname.ForeColor = System.Drawing.Color.Black;
            this.Rname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rname.IconLeftOffset = new System.Drawing.Point(15, 0);
            this.Rname.IconLeftSize = new System.Drawing.Size(35, 35);
            this.Rname.Location = new System.Drawing.Point(837, 136);
            this.Rname.Margin = new System.Windows.Forms.Padding(4);
            this.Rname.MaxLength = 8;
            this.Rname.Name = "Rname";
            this.Rname.PasswordChar = '●';
            this.Rname.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.Rname.PlaceholderText = "Name";
            this.Rname.SelectedText = "";
            this.Rname.Size = new System.Drawing.Size(177, 39);
            this.Rname.TabIndex = 18;
            this.Rname.TextOffset = new System.Drawing.Point(3, 0);
            this.Rname.UseSystemPasswordChar = true;
            // 
            // Rphone
            // 
            this.Rphone.Animated = true;
            this.Rphone.AutoRoundedCorners = true;
            this.Rphone.BackColor = System.Drawing.Color.Transparent;
            this.Rphone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.Rphone.BorderRadius = 17;
            this.Rphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Rphone.DefaultText = "";
            this.Rphone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Rphone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Rphone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Rphone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Rphone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rphone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rphone.ForeColor = System.Drawing.Color.Black;
            this.Rphone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rphone.IconLeft = ((System.Drawing.Image)(resources.GetObject("Rphone.IconLeft")));
            this.Rphone.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.Rphone.IconLeftSize = new System.Drawing.Size(25, 25);
            this.Rphone.IconRightSize = new System.Drawing.Size(0, 0);
            this.Rphone.Location = new System.Drawing.Point(833, 183);
            this.Rphone.Margin = new System.Windows.Forms.Padding(4);
            this.Rphone.MaxLength = 11;
            this.Rphone.Name = "Rphone";
            this.Rphone.PasswordChar = '\0';
            this.Rphone.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.Rphone.PlaceholderText = "Phone No.";
            this.Rphone.SelectedText = "";
            this.Rphone.Size = new System.Drawing.Size(177, 36);
            this.Rphone.TabIndex = 19;
            this.Rphone.TextOffset = new System.Drawing.Point(3, 0);
            this.Rphone.TextChanged += new System.EventHandler(this.guna2TextBox4_TextChanged);
            // 
            // courseCB
            // 
            this.courseCB.AutoRoundedCorners = true;
            this.courseCB.BackColor = System.Drawing.Color.Transparent;
            this.courseCB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.courseCB.BorderRadius = 17;
            this.courseCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.courseCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.courseCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.courseCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.courseCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.courseCB.ItemHeight = 30;
            this.courseCB.Items.AddRange(new object[] {
            "B.Tech",
            "B.Pharma",
            "M.Pharma",
            "MBA",
            "BCA",
            "Hospitality & Managmenet"});
            this.courseCB.Location = new System.Drawing.Point(802, 317);
            this.courseCB.Name = "courseCB";
            this.courseCB.Size = new System.Drawing.Size(212, 36);
            this.courseCB.TabIndex = 20;
            this.courseCB.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.label2.Location = new System.Drawing.Point(639, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Gender  :";
            // 
            // BackBtn
            // 
            this.BackBtn.Animated = true;
            this.BackBtn.AutoRoundedCorners = true;
            this.BackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn.BorderColor = System.Drawing.Color.White;
            this.BackBtn.BorderRadius = 16;
            this.BackBtn.BorderThickness = 1;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackBtn.FillColor = System.Drawing.Color.Transparent;
            this.BackBtn.FillColor2 = System.Drawing.Color.Transparent;
            this.BackBtn.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(97, 12);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(40, 35);
            this.BackBtn.TabIndex = 27;
            this.BackBtn.Text = "<";
            this.BackBtn.UseTransparentBackground = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.AutoRoundedCorners = true;
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 21;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(829, 482);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(185, 45);
            this.guna2GradientButton1.TabIndex = 26;
            this.guna2GradientButton1.Text = "REGISTER";
            this.guna2GradientButton1.UseTransparentBackground = true;
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // Rpassword
            // 
            this.Rpassword.Animated = true;
            this.Rpassword.AutoRoundedCorners = true;
            this.Rpassword.BackColor = System.Drawing.Color.Transparent;
            this.Rpassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.Rpassword.BorderRadius = 16;
            this.Rpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Rpassword.DefaultText = "";
            this.Rpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Rpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Rpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Rpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Rpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rpassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rpassword.ForeColor = System.Drawing.Color.Black;
            this.Rpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rpassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("Rpassword.IconLeft")));
            this.Rpassword.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.Rpassword.IconLeftSize = new System.Drawing.Size(25, 25);
            this.Rpassword.Location = new System.Drawing.Point(643, 182);
            this.Rpassword.Margin = new System.Windows.Forms.Padding(4);
            this.Rpassword.MaxLength = 8;
            this.Rpassword.Name = "Rpassword";
            this.Rpassword.PasswordChar = '●';
            this.Rpassword.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.Rpassword.PlaceholderText = "Enter Password";
            this.Rpassword.SelectedText = "";
            this.Rpassword.Size = new System.Drawing.Size(185, 35);
            this.Rpassword.TabIndex = 29;
            this.Rpassword.TextOffset = new System.Drawing.Point(3, 0);
            this.Rpassword.UseSystemPasswordChar = true;
            // 
            // femaleRB
            // 
            this.femaleRB.AutoSize = true;
            this.femaleRB.BackColor = System.Drawing.Color.White;
            this.femaleRB.Location = new System.Drawing.Point(878, 377);
            this.femaleRB.Name = "femaleRB";
            this.femaleRB.Size = new System.Drawing.Size(74, 20);
            this.femaleRB.TabIndex = 25;
            this.femaleRB.TabStop = true;
            this.femaleRB.Text = "Female";
            this.femaleRB.UseVisualStyleBackColor = false;
            // 
            // maleRB
            // 
            this.maleRB.AutoSize = true;
            this.maleRB.BackColor = System.Drawing.Color.White;
            this.maleRB.Location = new System.Drawing.Point(776, 377);
            this.maleRB.Name = "maleRB";
            this.maleRB.Size = new System.Drawing.Size(58, 20);
            this.maleRB.TabIndex = 24;
            this.maleRB.TabStop = true;
            this.maleRB.Text = "Male";
            this.maleRB.UseVisualStyleBackColor = false;
            this.maleRB.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(734, 367);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(36, 34);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 30;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox2.Image")));
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(836, 367);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(36, 34);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox2.TabIndex = 31;
            this.guna2CirclePictureBox2.TabStop = false;
            this.guna2CirclePictureBox2.UseTransparentBackground = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.label3.Location = new System.Drawing.Point(639, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "Choose Course  :";
            // 
            // Rfather
            // 
            this.Rfather.Animated = true;
            this.Rfather.AutoRoundedCorners = true;
            this.Rfather.BackColor = System.Drawing.Color.Transparent;
            this.Rfather.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.Rfather.BorderRadius = 17;
            this.Rfather.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Rfather.DefaultText = "";
            this.Rfather.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Rfather.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Rfather.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Rfather.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Rfather.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rfather.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Rfather.ForeColor = System.Drawing.Color.Black;
            this.Rfather.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rfather.IconLeft = ((System.Drawing.Image)(resources.GetObject("Rfather.IconLeft")));
            this.Rfather.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.Rfather.IconLeftSize = new System.Drawing.Size(25, 25);
            this.Rfather.Location = new System.Drawing.Point(643, 227);
            this.Rfather.Margin = new System.Windows.Forms.Padding(4);
            this.Rfather.MaxLength = 8;
            this.Rfather.Name = "Rfather";
            this.Rfather.PasswordChar = '\0';
            this.Rfather.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.Rfather.PlaceholderText = "Father Name";
            this.Rfather.SelectedText = "";
            this.Rfather.Size = new System.Drawing.Size(185, 36);
            this.Rfather.TabIndex = 34;
            this.Rfather.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // Rmother
            // 
            this.Rmother.Animated = true;
            this.Rmother.AutoRoundedCorners = true;
            this.Rmother.BackColor = System.Drawing.Color.Transparent;
            this.Rmother.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.Rmother.BorderRadius = 17;
            this.Rmother.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Rmother.DefaultText = "";
            this.Rmother.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Rmother.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Rmother.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Rmother.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Rmother.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rmother.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Rmother.ForeColor = System.Drawing.Color.Black;
            this.Rmother.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rmother.IconLeft = ((System.Drawing.Image)(resources.GetObject("Rmother.IconLeft")));
            this.Rmother.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.Rmother.IconLeftSize = new System.Drawing.Size(22, 22);
            this.Rmother.Location = new System.Drawing.Point(833, 227);
            this.Rmother.Margin = new System.Windows.Forms.Padding(4);
            this.Rmother.MaxLength = 8;
            this.Rmother.Name = "Rmother";
            this.Rmother.PasswordChar = '\0';
            this.Rmother.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.Rmother.PlaceholderText = "Mother Name";
            this.Rmother.SelectedText = "";
            this.Rmother.Size = new System.Drawing.Size(177, 36);
            this.Rmother.TabIndex = 33;
            this.Rmother.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // Ryear
            // 
            this.Ryear.Animated = true;
            this.Ryear.AutoRoundedCorners = true;
            this.Ryear.BackColor = System.Drawing.Color.Transparent;
            this.Ryear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.Ryear.BorderRadius = 17;
            this.Ryear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Ryear.DefaultText = "";
            this.Ryear.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Ryear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Ryear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Ryear.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Ryear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Ryear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Ryear.ForeColor = System.Drawing.Color.Black;
            this.Ryear.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Ryear.IconLeftOffset = new System.Drawing.Point(15, 0);
            this.Ryear.IconLeftSize = new System.Drawing.Size(25, 25);
            this.Ryear.Location = new System.Drawing.Point(921, 275);
            this.Ryear.Margin = new System.Windows.Forms.Padding(4);
            this.Ryear.MaxLength = 8;
            this.Ryear.Name = "Ryear";
            this.Ryear.PasswordChar = '\0';
            this.Ryear.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.Ryear.PlaceholderText = "Year ";
            this.Ryear.SelectedText = "";
            this.Ryear.Size = new System.Drawing.Size(89, 36);
            this.Ryear.TabIndex = 35;
            this.Ryear.TextOffset = new System.Drawing.Point(7, 0);
            // 
            // Rmarks
            // 
            this.Rmarks.Animated = true;
            this.Rmarks.AutoRoundedCorners = true;
            this.Rmarks.BackColor = System.Drawing.Color.Transparent;
            this.Rmarks.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.Rmarks.BorderRadius = 17;
            this.Rmarks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Rmarks.DefaultText = "";
            this.Rmarks.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Rmarks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Rmarks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Rmarks.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Rmarks.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rmarks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Rmarks.ForeColor = System.Drawing.Color.Black;
            this.Rmarks.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rmarks.IconLeft = ((System.Drawing.Image)(resources.GetObject("Rmarks.IconLeft")));
            this.Rmarks.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.Rmarks.IconLeftSize = new System.Drawing.Size(15, 15);
            this.Rmarks.Location = new System.Drawing.Point(643, 408);
            this.Rmarks.Margin = new System.Windows.Forms.Padding(4);
            this.Rmarks.MaxLength = 8;
            this.Rmarks.Name = "Rmarks";
            this.Rmarks.PasswordChar = '\0';
            this.Rmarks.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.Rmarks.PlaceholderText = "HighSchool Marks";
            this.Rmarks.SelectedText = "";
            this.Rmarks.Size = new System.Drawing.Size(185, 36);
            this.Rmarks.TabIndex = 37;
            this.Rmarks.TextOffset = new System.Drawing.Point(1, 0);
            // 
            // license_checkbox
            // 
            this.license_checkbox.AutoSize = true;
            this.license_checkbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.license_checkbox.CheckedState.BorderRadius = 0;
            this.license_checkbox.CheckedState.BorderThickness = 0;
            this.license_checkbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.license_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.license_checkbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.license_checkbox.Location = new System.Drawing.Point(643, 454);
            this.license_checkbox.Name = "license_checkbox";
            this.license_checkbox.Size = new System.Drawing.Size(362, 20);
            this.license_checkbox.TabIndex = 38;
            this.license_checkbox.Text = "I have Aceept Terms and Conditions and Privacy  Policy";
            this.license_checkbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.license_checkbox.UncheckedState.BorderRadius = 0;
            this.license_checkbox.UncheckedState.BorderThickness = 1;
            this.license_checkbox.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            // 
            // DOB
            // 
            this.DOB.Animated = true;
            this.DOB.AutoRoundedCorners = true;
            this.DOB.BackColor = System.Drawing.Color.Transparent;
            this.DOB.BorderRadius = 17;
            this.DOB.Checked = true;
            this.DOB.FillColor = System.Drawing.Color.Azure;
            this.DOB.Font = new System.Drawing.Font("Segoe UI Light", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DOB.Location = new System.Drawing.Point(716, 275);
            this.DOB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DOB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(198, 36);
            this.DOB.TabIndex = 42;
            this.DOB.UseTransparentBackground = true;
            this.DOB.Value = new System.DateTime(2022, 4, 4, 20, 46, 22, 977);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.label5.Location = new System.Drawing.Point(643, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 43;
            this.label5.Text = "D.O.B  :";
            // 
            // Rid
            // 
            this.Rid.Animated = true;
            this.Rid.AutoRoundedCorners = true;
            this.Rid.BackColor = System.Drawing.Color.Transparent;
            this.Rid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.Rid.BorderRadius = 17;
            this.Rid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Rid.DefaultText = "";
            this.Rid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Rid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Rid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Rid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Rid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Rid.ForeColor = System.Drawing.Color.Black;
            this.Rid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rid.IconLeft = ((System.Drawing.Image)(resources.GetObject("Rid.IconLeft")));
            this.Rid.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.Rid.IconLeftSize = new System.Drawing.Size(25, 25);
            this.Rid.Location = new System.Drawing.Point(643, 132);
            this.Rid.Margin = new System.Windows.Forms.Padding(4);
            this.Rid.MaxLength = 8;
            this.Rid.Name = "Rid";
            this.Rid.PasswordChar = '\0';
            this.Rid.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.Rid.PlaceholderText = "ID";
            this.Rid.SelectedText = "";
            this.Rid.Size = new System.Drawing.Size(185, 36);
            this.Rid.TabIndex = 44;
            this.Rid.TextOffset = new System.Drawing.Point(7, 0);
            // 
            // successful
            // 
            this.successful.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.successful.Caption = null;
            this.successful.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.successful.Parent = this;
            this.successful.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.successful.Text = "Registration Successful. Login to Proceed Now !";
            // 
            // guna2CirclePictureBox4
            // 
            this.guna2CirclePictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CirclePictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox4.Image")));
            this.guna2CirclePictureBox4.ImageRotate = 0F;
            this.guna2CirclePictureBox4.Location = new System.Drawing.Point(981, 64);
            this.guna2CirclePictureBox4.Name = "guna2CirclePictureBox4";
            this.guna2CirclePictureBox4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox4.Size = new System.Drawing.Size(46, 49);
            this.guna2CirclePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox4.TabIndex = 45;
            this.guna2CirclePictureBox4.TabStop = false;
            this.guna2CirclePictureBox4.UseTransparentBackground = true;
            this.guna2CirclePictureBox4.Click += new System.EventHandler(this.guna2CirclePictureBox4_Click);
            // 
            // emailTB
            // 
            this.emailTB.Animated = true;
            this.emailTB.AutoRoundedCorners = true;
            this.emailTB.BackColor = System.Drawing.Color.Transparent;
            this.emailTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.emailTB.BorderRadius = 17;
            this.emailTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTB.DefaultText = "";
            this.emailTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailTB.ForeColor = System.Drawing.Color.Black;
            this.emailTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTB.IconLeftOffset = new System.Drawing.Point(15, 0);
            this.emailTB.IconLeftSize = new System.Drawing.Size(25, 25);
            this.emailTB.Location = new System.Drawing.Point(837, 408);
            this.emailTB.Margin = new System.Windows.Forms.Padding(4);
            this.emailTB.MaxLength = 100;
            this.emailTB.Name = "emailTB";
            this.emailTB.PasswordChar = '\0';
            this.emailTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.emailTB.PlaceholderText = "Email";
            this.emailTB.SelectedText = "";
            this.emailTB.Size = new System.Drawing.Size(173, 36);
            this.emailTB.TabIndex = 46;
            this.emailTB.TextOffset = new System.Drawing.Point(7, 0);
            // 
            // uploadimg
            // 
            this.uploadimg.Animated = true;
            this.uploadimg.AutoRoundedCorners = true;
            this.uploadimg.BackColor = System.Drawing.Color.Transparent;
            this.uploadimg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.uploadimg.BorderRadius = 21;
            this.uploadimg.BorderThickness = 1;
            this.uploadimg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.uploadimg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.uploadimg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.uploadimg.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.uploadimg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.uploadimg.FillColor = System.Drawing.Color.White;
            this.uploadimg.FillColor2 = System.Drawing.Color.White;
            this.uploadimg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.uploadimg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(97)))));
            this.uploadimg.Location = new System.Drawing.Point(643, 482);
            this.uploadimg.Name = "uploadimg";
            this.uploadimg.Size = new System.Drawing.Size(185, 45);
            this.uploadimg.TabIndex = 47;
            this.uploadimg.Text = "Upload Image";
            this.uploadimg.UseTransparentBackground = true;
            this.uploadimg.Click += new System.EventHandler(this.uploadimg_Click);
            // 
            // StudentRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 600);
            this.ControlBox = false;
            this.Controls.Add(this.uploadimg);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.guna2CirclePictureBox4);
            this.Controls.Add(this.Rid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.license_checkbox);
            this.Controls.Add(this.Rmarks);
            this.Controls.Add(this.Ryear);
            this.Controls.Add(this.Rfather);
            this.Controls.Add(this.Rmother);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2CirclePictureBox2);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.Rpassword);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.femaleRB);
            this.Controls.Add(this.maleRB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.courseCB);
            this.Controls.Add(this.Rphone);
            this.Controls.Add(this.Rname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignupBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentRegister";
            ((System.ComponentModel.ISupportInitialize)(this.SignupBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox SignupBG;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox Rname;
        private Guna.UI2.WinForms.Guna2TextBox Rphone;
        private Guna.UI2.WinForms.Guna2ComboBox courseCB;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton BackBtn;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2TextBox Rpassword;
        private System.Windows.Forms.RadioButton femaleRB;
        private System.Windows.Forms.RadioButton maleRB;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox Rfather;
        private Guna.UI2.WinForms.Guna2TextBox Rmother;
        private Guna.UI2.WinForms.Guna2TextBox Ryear;
        private Guna.UI2.WinForms.Guna2TextBox Rmarks;
        private Guna.UI2.WinForms.Guna2CheckBox license_checkbox;
        private Guna.UI2.WinForms.Guna2DateTimePicker DOB;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox Rid;
        private Guna.UI2.WinForms.Guna2MessageDialog successful;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox4;
        private Guna.UI2.WinForms.Guna2TextBox emailTB;
        private Guna.UI2.WinForms.Guna2GradientButton uploadimg;
        private System.Windows.Forms.OpenFileDialog Openfiledialog;
    }
}