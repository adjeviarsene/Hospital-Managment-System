namespace HProgramming
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.logopanel = new System.Windows.Forms.Panel();
            this.loadingpanel = new System.Windows.Forms.Panel();
            this.circleprogressloading = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.loading = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.loginbyfingerprint = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernametextbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.passwordtextbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.circleprogress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.gradientpanellog = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelload = new System.Windows.Forms.Panel();
            this.logopanel.SuspendLayout();
            this.loadingpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.gradientpanellog.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelload.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.gradientpanellog;
            this.bunifuDragControl1.Vertical = true;
            // 
            // logopanel
            // 
            this.logopanel.Controls.Add(this.loadingpanel);
            this.logopanel.Controls.Add(this.pictureBox3);
            this.logopanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.logopanel.Location = new System.Drawing.Point(0, 0);
            this.logopanel.Name = "logopanel";
            this.logopanel.Size = new System.Drawing.Size(208, 440);
            this.logopanel.TabIndex = 5;
            // 
            // loadingpanel
            // 
            this.loadingpanel.Controls.Add(this.circleprogressloading);
            this.loadingpanel.Controls.Add(this.loading);
            this.loadingpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loadingpanel.Location = new System.Drawing.Point(0, 283);
            this.loadingpanel.Name = "loadingpanel";
            this.loadingpanel.Size = new System.Drawing.Size(208, 157);
            this.loadingpanel.TabIndex = 5;
            // 
            // circleprogressloading
            // 
            this.circleprogressloading.animated = true;
            this.circleprogressloading.animationIterval = 5;
            this.circleprogressloading.animationSpeed = 300;
            this.circleprogressloading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.circleprogressloading.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circleprogressloading.BackgroundImage")));
            this.circleprogressloading.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.circleprogressloading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.circleprogressloading.LabelVisible = true;
            this.circleprogressloading.LineProgressThickness = 5;
            this.circleprogressloading.LineThickness = 2;
            this.circleprogressloading.Location = new System.Drawing.Point(50, 9);
            this.circleprogressloading.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.circleprogressloading.MaxValue = 100;
            this.circleprogressloading.Name = "circleprogressloading";
            this.circleprogressloading.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.circleprogressloading.ProgressColor = System.Drawing.Color.Lime;
            this.circleprogressloading.Size = new System.Drawing.Size(96, 96);
            this.circleprogressloading.TabIndex = 0;
            this.circleprogressloading.Value = 5;
            // 
            // loading
            // 
            this.loading.AutoSize = true;
            this.loading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loading.Location = new System.Drawing.Point(46, 114);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(110, 20);
            this.loading.TabIndex = 2;
            this.loading.Text = "Loading...........";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 85);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(205, 154);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(372, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(372, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // loginbutton
            // 
            this.loginbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.loginbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginbutton.BorderRadius = 0;
            this.loginbutton.ButtonText = "Login";
            this.loginbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbutton.DisabledColor = System.Drawing.Color.Gray;
            this.loginbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.loginbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("loginbutton.Iconimage")));
            this.loginbutton.Iconimage_right = null;
            this.loginbutton.Iconimage_right_Selected = null;
            this.loginbutton.Iconimage_Selected = null;
            this.loginbutton.IconMarginLeft = 0;
            this.loginbutton.IconMarginRight = 0;
            this.loginbutton.IconRightVisible = true;
            this.loginbutton.IconRightZoom = 0D;
            this.loginbutton.IconVisible = true;
            this.loginbutton.IconZoom = 90D;
            this.loginbutton.IsTab = false;
            this.loginbutton.Location = new System.Drawing.Point(345, 242);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.loginbutton.OnHovercolor = System.Drawing.Color.Teal;
            this.loginbutton.OnHoverTextColor = System.Drawing.Color.White;
            this.loginbutton.selected = false;
            this.loginbutton.Size = new System.Drawing.Size(177, 48);
            this.loginbutton.TabIndex = 0;
            this.loginbutton.Text = "Login";
            this.loginbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginbutton.Textcolor = System.Drawing.Color.White;
            this.loginbutton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Exit";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(567, 242);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Teal;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(177, 48);
            this.bunifuFlatButton2.TabIndex = 0;
            this.bunifuFlatButton2.Text = "Exit";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // loginbyfingerprint
            // 
            this.loginbyfingerprint.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginbyfingerprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.loginbyfingerprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginbyfingerprint.BorderRadius = 0;
            this.loginbyfingerprint.ButtonText = "Login By Fingerprint Scan";
            this.loginbyfingerprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbyfingerprint.DisabledColor = System.Drawing.Color.Gray;
            this.loginbyfingerprint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginbyfingerprint.Iconcolor = System.Drawing.Color.Transparent;
            this.loginbyfingerprint.Iconimage = ((System.Drawing.Image)(resources.GetObject("loginbyfingerprint.Iconimage")));
            this.loginbyfingerprint.Iconimage_right = null;
            this.loginbyfingerprint.Iconimage_right_Selected = null;
            this.loginbyfingerprint.Iconimage_Selected = null;
            this.loginbyfingerprint.IconMarginLeft = 0;
            this.loginbyfingerprint.IconMarginRight = 0;
            this.loginbyfingerprint.IconRightVisible = true;
            this.loginbyfingerprint.IconRightZoom = 0D;
            this.loginbyfingerprint.IconVisible = true;
            this.loginbyfingerprint.IconZoom = 90D;
            this.loginbyfingerprint.IsTab = false;
            this.loginbyfingerprint.Location = new System.Drawing.Point(417, 343);
            this.loginbyfingerprint.Name = "loginbyfingerprint";
            this.loginbyfingerprint.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.loginbyfingerprint.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginbyfingerprint.OnHoverTextColor = System.Drawing.Color.White;
            this.loginbyfingerprint.selected = false;
            this.loginbyfingerprint.Size = new System.Drawing.Size(214, 48);
            this.loginbyfingerprint.TabIndex = 0;
            this.loginbyfingerprint.Text = "Login By Fingerprint Scan";
            this.loginbyfingerprint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginbyfingerprint.Textcolor = System.Drawing.Color.White;
            this.loginbyfingerprint.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbyfingerprint.Click += new System.EventHandler(this.loginbyfingerprint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(240, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(245, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // usernametextbox
            // 
            this.usernametextbox.BorderColorFocused = System.Drawing.Color.Gray;
            this.usernametextbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.usernametextbox.BorderColorMouseHover = System.Drawing.Color.Teal;
            this.usernametextbox.BorderThickness = 3;
            this.usernametextbox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.usernametextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.usernametextbox.ForeColor = System.Drawing.Color.White;
            this.usernametextbox.isPassword = false;
            this.usernametextbox.Location = new System.Drawing.Point(417, 40);
            this.usernametextbox.Margin = new System.Windows.Forms.Padding(4);
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.Size = new System.Drawing.Size(294, 44);
            this.usernametextbox.TabIndex = 3;
            this.usernametextbox.Text = "Username";
            this.usernametextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernametextbox.UseWaitCursor = true;
            this.usernametextbox.Enter += new System.EventHandler(this.usernametextbox_Enter);
            this.usernametextbox.Leave += new System.EventHandler(this.usernametextbox_Leave);
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.BorderColorFocused = System.Drawing.Color.SlateGray;
            this.passwordtextbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passwordtextbox.BorderColorMouseHover = System.Drawing.Color.Teal;
            this.passwordtextbox.BorderThickness = 3;
            this.passwordtextbox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.passwordtextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwordtextbox.ForeColor = System.Drawing.Color.White;
            this.passwordtextbox.isPassword = true;
            this.passwordtextbox.Location = new System.Drawing.Point(417, 160);
            this.passwordtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.Size = new System.Drawing.Size(294, 44);
            this.passwordtextbox.TabIndex = 3;
            this.passwordtextbox.Text = "Password";
            this.passwordtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordtextbox.UseWaitCursor = true;
            this.passwordtextbox.Enter += new System.EventHandler(this.passwordtextbox_Enter);
            this.passwordtextbox.Leave += new System.EventHandler(this.passwordtextbox_Leave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 128);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(185, 141);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // circleprogress
            // 
            this.circleprogress.animated = true;
            this.circleprogress.animationIterval = 5;
            this.circleprogress.animationSpeed = 300;
            this.circleprogress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.circleprogress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circleprogress.BackgroundImage")));
            this.circleprogress.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.circleprogress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.circleprogress.LabelVisible = true;
            this.circleprogress.LineProgressThickness = 8;
            this.circleprogress.LineThickness = 5;
            this.circleprogress.Location = new System.Drawing.Point(49, 7);
            this.circleprogress.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.circleprogress.MaxValue = 100;
            this.circleprogress.Name = "circleprogress";
            this.circleprogress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.circleprogress.ProgressColor = System.Drawing.Color.Lime;
            this.circleprogress.Size = new System.Drawing.Size(94, 94);
            this.circleprogress.TabIndex = 0;
            this.circleprogress.Value = 0;
            // 
            // gradientpanellog
            // 
            this.gradientpanellog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradientpanellog.BackgroundImage")));
            this.gradientpanellog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientpanellog.Controls.Add(this.panel1);
            this.gradientpanellog.Controls.Add(this.passwordtextbox);
            this.gradientpanellog.Controls.Add(this.usernametextbox);
            this.gradientpanellog.Controls.Add(this.label2);
            this.gradientpanellog.Controls.Add(this.label1);
            this.gradientpanellog.Controls.Add(this.loginbyfingerprint);
            this.gradientpanellog.Controls.Add(this.bunifuFlatButton2);
            this.gradientpanellog.Controls.Add(this.loginbutton);
            this.gradientpanellog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientpanellog.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.gradientpanellog.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.gradientpanellog.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.gradientpanellog.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gradientpanellog.Location = new System.Drawing.Point(0, 0);
            this.gradientpanellog.Name = "gradientpanellog";
            this.gradientpanellog.Quality = 10;
            this.gradientpanellog.Size = new System.Drawing.Size(820, 440);
            this.gradientpanellog.TabIndex = 0;
            this.gradientpanellog.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientpanellog_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelload);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 440);
            this.panel1.TabIndex = 4;
            // 
            // panelload
            // 
            this.panelload.Controls.Add(this.circleprogress);
            this.panelload.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelload.Location = new System.Drawing.Point(0, 330);
            this.panelload.Name = "panelload";
            this.panelload.Size = new System.Drawing.Size(184, 110);
            this.panelload.TabIndex = 1;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(820, 440);
            this.Controls.Add(this.gradientpanellog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.logopanel.ResumeLayout(false);
            this.loadingpanel.ResumeLayout(false);
            this.loadingpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.gradientpanellog.ResumeLayout(false);
            this.gradientpanellog.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelload.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel logopanel;
        private System.Windows.Forms.Panel loadingpanel;
        private Bunifu.Framework.UI.BunifuCircleProgressbar circleprogressloading;
        private System.Windows.Forms.Label loading;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuGradientPanel gradientpanellog;
        private Bunifu.Framework.UI.BunifuCircleProgressbar circleprogress;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.Framework.UI.BunifuMetroTextbox passwordtextbox;
        private Bunifu.Framework.UI.BunifuMetroTextbox usernametextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton loginbyfingerprint;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton loginbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelload;
    }
}