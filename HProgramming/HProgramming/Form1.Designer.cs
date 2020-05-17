namespace HProgramming
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.headpanel = new System.Windows.Forms.Panel();
            this.titlepanel = new System.Windows.Forms.Label();
            this.hiddenbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.minimazormximazbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.closebtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.logopanel = new System.Windows.Forms.Panel();
            this.Resetpicture = new System.Windows.Forms.PictureBox();
            this.dashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.patientsbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.departmentbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.appointmentbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.slidepanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.showcurrentuserpanel = new System.Windows.Forms.Panel();
            this.myemail = new System.Windows.Forms.Label();
            this.myname = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.settingbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.emploiyeesbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.centralpanal = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.headpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hiddenbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimazormximazbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).BeginInit();
            this.logopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resetpicture)).BeginInit();
            this.slidepanel.SuspendLayout();
            this.showcurrentuserpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.centralpanal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // headpanel
            // 
            this.headpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.headpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(76)))));
            this.headpanel.Controls.Add(this.titlepanel);
            this.headpanel.Controls.Add(this.hiddenbtn);
            this.headpanel.Controls.Add(this.minimazormximazbtn);
            this.headpanel.Controls.Add(this.closebtn);
            this.headpanel.Location = new System.Drawing.Point(172, 0);
            this.headpanel.Name = "headpanel";
            this.headpanel.Size = new System.Drawing.Size(879, 35);
            this.headpanel.TabIndex = 1;
            this.headpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headpanel_MouseDown);
            // 
            // titlepanel
            // 
            this.titlepanel.AutoSize = true;
            this.titlepanel.Font = new System.Drawing.Font("RomanT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.titlepanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.titlepanel.Location = new System.Drawing.Point(6, 2);
            this.titlepanel.Name = "titlepanel";
            this.titlepanel.Size = new System.Drawing.Size(298, 23);
            this.titlepanel.TabIndex = 5;
            this.titlepanel.Text = "Hospital Managment System";
            // 
            // hiddenbtn
            // 
            this.hiddenbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hiddenbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.hiddenbtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hiddenbtn.Image = ((System.Drawing.Image)(resources.GetObject("hiddenbtn.Image")));
            this.hiddenbtn.ImageActive = null;
            this.hiddenbtn.Location = new System.Drawing.Point(763, 2);
            this.hiddenbtn.Name = "hiddenbtn";
            this.hiddenbtn.Size = new System.Drawing.Size(31, 30);
            this.hiddenbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hiddenbtn.TabIndex = 4;
            this.hiddenbtn.TabStop = false;
            this.hiddenbtn.Zoom = 10;
            this.hiddenbtn.Click += new System.EventHandler(this.hiddenbtn_Click);
            // 
            // minimazormximazbtn
            // 
            this.minimazormximazbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimazormximazbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.minimazormximazbtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minimazormximazbtn.Image = ((System.Drawing.Image)(resources.GetObject("minimazormximazbtn.Image")));
            this.minimazormximazbtn.ImageActive = null;
            this.minimazormximazbtn.Location = new System.Drawing.Point(800, 2);
            this.minimazormximazbtn.Name = "minimazormximazbtn";
            this.minimazormximazbtn.Size = new System.Drawing.Size(37, 30);
            this.minimazormximazbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimazormximazbtn.TabIndex = 4;
            this.minimazormximazbtn.TabStop = false;
            this.minimazormximazbtn.Zoom = 10;
            this.minimazormximazbtn.Click += new System.EventHandler(this.minimazormximazbtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.closebtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.closebtn.Image = ((System.Drawing.Image)(resources.GetObject("closebtn.Image")));
            this.closebtn.ImageActive = null;
            this.closebtn.InitialImage = ((System.Drawing.Image)(resources.GetObject("closebtn.InitialImage")));
            this.closebtn.Location = new System.Drawing.Point(843, 1);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(33, 32);
            this.closebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closebtn.TabIndex = 4;
            this.closebtn.TabStop = false;
            this.closebtn.Zoom = 10;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // logopanel
            // 
            this.logopanel.Controls.Add(this.Resetpicture);
            this.logopanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logopanel.Location = new System.Drawing.Point(0, 0);
            this.logopanel.Name = "logopanel";
            this.logopanel.Size = new System.Drawing.Size(172, 71);
            this.logopanel.TabIndex = 2;
            // 
            // Resetpicture
            // 
            this.Resetpicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.Resetpicture.Image = ((System.Drawing.Image)(resources.GetObject("Resetpicture.Image")));
            this.Resetpicture.Location = new System.Drawing.Point(0, 0);
            this.Resetpicture.Name = "Resetpicture";
            this.Resetpicture.Size = new System.Drawing.Size(172, 75);
            this.Resetpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Resetpicture.TabIndex = 0;
            this.Resetpicture.TabStop = false;
            // 
            // dashboard
            // 
            this.dashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(9)))), ((int)(((byte)(62)))));
            this.dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboard.BorderRadius = 0;
            this.dashboard.ButtonText = "Dashboard";
            this.dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard.DisabledColor = System.Drawing.Color.Gray;
            this.dashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.dashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("dashboard.Iconimage")));
            this.dashboard.Iconimage_right = null;
            this.dashboard.Iconimage_right_Selected = null;
            this.dashboard.Iconimage_Selected = null;
            this.dashboard.IconMarginLeft = 0;
            this.dashboard.IconMarginRight = 0;
            this.dashboard.IconRightVisible = true;
            this.dashboard.IconRightZoom = 0D;
            this.dashboard.IconVisible = true;
            this.dashboard.IconZoom = 90D;
            this.dashboard.IsTab = false;
            this.dashboard.Location = new System.Drawing.Point(0, 90);
            this.dashboard.Name = "dashboard";
            this.dashboard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.dashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(31)))), ((int)(((byte)(150)))));
            this.dashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.dashboard.selected = false;
            this.dashboard.Size = new System.Drawing.Size(178, 48);
            this.dashboard.TabIndex = 3;
            this.dashboard.Text = "Dashboard";
            this.dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard.Textcolor = System.Drawing.Color.White;
            this.dashboard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // patientsbtn
            // 
            this.patientsbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(9)))), ((int)(((byte)(62)))));
            this.patientsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.patientsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.patientsbtn.BorderRadius = 0;
            this.patientsbtn.ButtonText = "Patients";
            this.patientsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patientsbtn.DisabledColor = System.Drawing.Color.Gray;
            this.patientsbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.patientsbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("patientsbtn.Iconimage")));
            this.patientsbtn.Iconimage_right = null;
            this.patientsbtn.Iconimage_right_Selected = null;
            this.patientsbtn.Iconimage_Selected = null;
            this.patientsbtn.IconMarginLeft = 0;
            this.patientsbtn.IconMarginRight = 0;
            this.patientsbtn.IconRightVisible = true;
            this.patientsbtn.IconRightZoom = 0D;
            this.patientsbtn.IconVisible = true;
            this.patientsbtn.IconZoom = 90D;
            this.patientsbtn.IsTab = false;
            this.patientsbtn.Location = new System.Drawing.Point(0, 154);
            this.patientsbtn.Name = "patientsbtn";
            this.patientsbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.patientsbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(81)))), ((int)(((byte)(55)))));
            this.patientsbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.patientsbtn.selected = false;
            this.patientsbtn.Size = new System.Drawing.Size(178, 45);
            this.patientsbtn.TabIndex = 3;
            this.patientsbtn.Text = "Patients";
            this.patientsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientsbtn.Textcolor = System.Drawing.Color.White;
            this.patientsbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientsbtn.Click += new System.EventHandler(this.patientsbtn_Click);
            // 
            // departmentbtn
            // 
            this.departmentbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(9)))), ((int)(((byte)(62)))));
            this.departmentbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.departmentbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.departmentbtn.BorderRadius = 0;
            this.departmentbtn.ButtonText = "Departments";
            this.departmentbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.departmentbtn.DisabledColor = System.Drawing.Color.Gray;
            this.departmentbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.departmentbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("departmentbtn.Iconimage")));
            this.departmentbtn.Iconimage_right = null;
            this.departmentbtn.Iconimage_right_Selected = null;
            this.departmentbtn.Iconimage_Selected = null;
            this.departmentbtn.IconMarginLeft = 0;
            this.departmentbtn.IconMarginRight = 0;
            this.departmentbtn.IconRightVisible = true;
            this.departmentbtn.IconRightZoom = 0D;
            this.departmentbtn.IconVisible = true;
            this.departmentbtn.IconZoom = 90D;
            this.departmentbtn.IsTab = false;
            this.departmentbtn.Location = new System.Drawing.Point(0, 288);
            this.departmentbtn.Name = "departmentbtn";
            this.departmentbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.departmentbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(125)))), ((int)(((byte)(9)))));
            this.departmentbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.departmentbtn.selected = false;
            this.departmentbtn.Size = new System.Drawing.Size(178, 48);
            this.departmentbtn.TabIndex = 3;
            this.departmentbtn.Text = "Departments";
            this.departmentbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.departmentbtn.Textcolor = System.Drawing.Color.White;
            this.departmentbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentbtn.Click += new System.EventHandler(this.departmentbtn_Click);
            // 
            // appointmentbtn
            // 
            this.appointmentbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(9)))), ((int)(((byte)(62)))));
            this.appointmentbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.appointmentbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.appointmentbtn.BorderRadius = 0;
            this.appointmentbtn.ButtonText = "Appointments";
            this.appointmentbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appointmentbtn.DisabledColor = System.Drawing.Color.Gray;
            this.appointmentbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.appointmentbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("appointmentbtn.Iconimage")));
            this.appointmentbtn.Iconimage_right = null;
            this.appointmentbtn.Iconimage_right_Selected = null;
            this.appointmentbtn.Iconimage_Selected = null;
            this.appointmentbtn.IconMarginLeft = 0;
            this.appointmentbtn.IconMarginRight = 0;
            this.appointmentbtn.IconRightVisible = true;
            this.appointmentbtn.IconRightZoom = 0D;
            this.appointmentbtn.IconVisible = true;
            this.appointmentbtn.IconZoom = 90D;
            this.appointmentbtn.IsTab = false;
            this.appointmentbtn.Location = new System.Drawing.Point(0, 219);
            this.appointmentbtn.Name = "appointmentbtn";
            this.appointmentbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.appointmentbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(9)))), ((int)(((byte)(22)))));
            this.appointmentbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.appointmentbtn.selected = false;
            this.appointmentbtn.Size = new System.Drawing.Size(178, 48);
            this.appointmentbtn.TabIndex = 3;
            this.appointmentbtn.Text = "Appointments";
            this.appointmentbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.appointmentbtn.Textcolor = System.Drawing.Color.White;
            this.appointmentbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentbtn.Click += new System.EventHandler(this.appointmentbtn_Click);
            // 
            // slidepanel
            // 
            this.slidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.slidepanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slidepanel.BackgroundImage")));
            this.slidepanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.slidepanel.Controls.Add(this.showcurrentuserpanel);
            this.slidepanel.Controls.Add(this.settingbtn);
            this.slidepanel.Controls.Add(this.logopanel);
            this.slidepanel.Controls.Add(this.dashboard);
            this.slidepanel.Controls.Add(this.emploiyeesbtn);
            this.slidepanel.Controls.Add(this.departmentbtn);
            this.slidepanel.Controls.Add(this.appointmentbtn);
            this.slidepanel.Controls.Add(this.patientsbtn);
            this.slidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidepanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.slidepanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.slidepanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.slidepanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(11)))), ((int)(((byte)(8)))));
            this.slidepanel.Location = new System.Drawing.Point(0, 0);
            this.slidepanel.Name = "slidepanel";
            this.slidepanel.Quality = 10;
            this.slidepanel.Size = new System.Drawing.Size(172, 586);
            this.slidepanel.TabIndex = 4;
            // 
            // showcurrentuserpanel
            // 
            this.showcurrentuserpanel.Controls.Add(this.myemail);
            this.showcurrentuserpanel.Controls.Add(this.myname);
            this.showcurrentuserpanel.Controls.Add(this.pictureBox2);
            this.showcurrentuserpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.showcurrentuserpanel.Location = new System.Drawing.Point(0, 527);
            this.showcurrentuserpanel.Name = "showcurrentuserpanel";
            this.showcurrentuserpanel.Size = new System.Drawing.Size(172, 59);
            this.showcurrentuserpanel.TabIndex = 5;
            // 
            // myemail
            // 
            this.myemail.AutoSize = true;
            this.myemail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.myemail.Location = new System.Drawing.Point(74, 37);
            this.myemail.Name = "myemail";
            this.myemail.Size = new System.Drawing.Size(32, 13);
            this.myemail.TabIndex = 6;
            this.myemail.Text = "Email";
            // 
            // myname
            // 
            this.myname.AutoSize = true;
            this.myname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.myname.Location = new System.Drawing.Point(74, 10);
            this.myname.Name = "myname";
            this.myname.Size = new System.Drawing.Size(35, 13);
            this.myname.TabIndex = 6;
            this.myname.Text = "Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // settingbtn
            // 
            this.settingbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(9)))), ((int)(((byte)(62)))));
            this.settingbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.settingbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingbtn.BorderRadius = 0;
            this.settingbtn.ButtonText = "Setting";
            this.settingbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingbtn.DisabledColor = System.Drawing.Color.Gray;
            this.settingbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.settingbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("settingbtn.Iconimage")));
            this.settingbtn.Iconimage_right = null;
            this.settingbtn.Iconimage_right_Selected = null;
            this.settingbtn.Iconimage_Selected = null;
            this.settingbtn.IconMarginLeft = 0;
            this.settingbtn.IconMarginRight = 0;
            this.settingbtn.IconRightVisible = true;
            this.settingbtn.IconRightZoom = 0D;
            this.settingbtn.IconVisible = true;
            this.settingbtn.IconZoom = 90D;
            this.settingbtn.IsTab = false;
            this.settingbtn.Location = new System.Drawing.Point(0, 437);
            this.settingbtn.Name = "settingbtn";
            this.settingbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.settingbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(10)))), ((int)(((byte)(6)))));
            this.settingbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.settingbtn.selected = false;
            this.settingbtn.Size = new System.Drawing.Size(178, 48);
            this.settingbtn.TabIndex = 4;
            this.settingbtn.Text = "Setting";
            this.settingbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingbtn.Textcolor = System.Drawing.Color.White;
            this.settingbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // emploiyeesbtn
            // 
            this.emploiyeesbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(9)))), ((int)(((byte)(62)))));
            this.emploiyeesbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.emploiyeesbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.emploiyeesbtn.BorderRadius = 0;
            this.emploiyeesbtn.ButtonText = "Employees";
            this.emploiyeesbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emploiyeesbtn.DisabledColor = System.Drawing.Color.Gray;
            this.emploiyeesbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.emploiyeesbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("emploiyeesbtn.Iconimage")));
            this.emploiyeesbtn.Iconimage_right = null;
            this.emploiyeesbtn.Iconimage_right_Selected = null;
            this.emploiyeesbtn.Iconimage_Selected = null;
            this.emploiyeesbtn.IconMarginLeft = 0;
            this.emploiyeesbtn.IconMarginRight = 0;
            this.emploiyeesbtn.IconRightVisible = true;
            this.emploiyeesbtn.IconRightZoom = 0D;
            this.emploiyeesbtn.IconVisible = true;
            this.emploiyeesbtn.IconZoom = 90D;
            this.emploiyeesbtn.IsTab = false;
            this.emploiyeesbtn.Location = new System.Drawing.Point(0, 364);
            this.emploiyeesbtn.Name = "emploiyeesbtn";
            this.emploiyeesbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.emploiyeesbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.emploiyeesbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.emploiyeesbtn.selected = false;
            this.emploiyeesbtn.Size = new System.Drawing.Size(178, 48);
            this.emploiyeesbtn.TabIndex = 3;
            this.emploiyeesbtn.Text = "Employees";
            this.emploiyeesbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emploiyeesbtn.Textcolor = System.Drawing.Color.White;
            this.emploiyeesbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emploiyeesbtn.Click += new System.EventHandler(this.emploiyeesbtn_Click);
            // 
            // centralpanal
            // 
            this.centralpanal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.centralpanal.Controls.Add(this.pictureBox1);
            this.centralpanal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centralpanal.Location = new System.Drawing.Point(172, 0);
            this.centralpanal.Name = "centralpanal";
            this.centralpanal.Size = new System.Drawing.Size(879, 586);
            this.centralpanal.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(247, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 313);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 586);
            this.Controls.Add(this.headpanel);
            this.Controls.Add(this.centralpanal);
            this.Controls.Add(this.slidepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(820, 420);
            this.Name = "Form1";
            this.Text = "Form1";
            this.headpanel.ResumeLayout(false);
            this.headpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hiddenbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimazormximazbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).EndInit();
            this.logopanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Resetpicture)).EndInit();
            this.slidepanel.ResumeLayout(false);
            this.showcurrentuserpanel.ResumeLayout(false);
            this.showcurrentuserpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.centralpanal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headpanel;
        private Bunifu.Framework.UI.BunifuImageButton hiddenbtn;
        private Bunifu.Framework.UI.BunifuImageButton minimazormximazbtn;
        private Bunifu.Framework.UI.BunifuImageButton closebtn;
        private System.Windows.Forms.Panel logopanel;
        private System.Windows.Forms.PictureBox Resetpicture;
        private Bunifu.Framework.UI.BunifuFlatButton dashboard;
        private Bunifu.Framework.UI.BunifuFlatButton patientsbtn;
        private Bunifu.Framework.UI.BunifuFlatButton departmentbtn;
        private Bunifu.Framework.UI.BunifuFlatButton appointmentbtn;
        private Bunifu.Framework.UI.BunifuGradientPanel slidepanel;
        private Bunifu.Framework.UI.BunifuFlatButton emploiyeesbtn;
        private System.Windows.Forms.Label titlepanel;
        private Bunifu.Framework.UI.BunifuFlatButton settingbtn;
        private System.Windows.Forms.Panel centralpanal;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel showcurrentuserpanel;
        private System.Windows.Forms.Label myemail;
        private System.Windows.Forms.Label myname;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

