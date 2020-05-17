namespace HProgramming
{
    partial class DepartmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentForm));
            this.departmentheadpanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.departslidepanel = new System.Windows.Forms.Panel();
            this.createnewdepbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.hematdepabtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.infectiondisdepabtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.oncologydepbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.toxicolgydepbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.chirurgydeptbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nuerologydepbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.departmentinfopanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.currentmachine = new System.Windows.Forms.Label();
            this.roomnumber = new System.Windows.Forms.Label();
            this.floornum = new System.Windows.Forms.Label();
            this.depname = new System.Windows.Forms.Label();
            this.depaaddress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.patientnumlabel = new System.Windows.Forms.Label();
            this.nursenum = new System.Windows.Forms.Label();
            this.doctornumlabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.departmentheadpanel.SuspendLayout();
            this.departslidepanel.SuspendLayout();
            this.departmentinfopanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // departmentheadpanel
            // 
            this.departmentheadpanel.Controls.Add(this.label4);
            this.departmentheadpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.departmentheadpanel.Location = new System.Drawing.Point(0, 0);
            this.departmentheadpanel.Name = "departmentheadpanel";
            this.departmentheadpanel.Size = new System.Drawing.Size(873, 71);
            this.departmentheadpanel.TabIndex = 1;
            this.departmentheadpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.departmentheadpanel_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("RomanT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(180, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(509, 39);
            this.label4.TabIndex = 1;
            this.label4.Text = " Department\'s General View";
            // 
            // departslidepanel
            // 
            this.departslidepanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.departslidepanel.Controls.Add(this.createnewdepbtn);
            this.departslidepanel.Controls.Add(this.hematdepabtn);
            this.departslidepanel.Controls.Add(this.infectiondisdepabtn);
            this.departslidepanel.Controls.Add(this.oncologydepbtn);
            this.departslidepanel.Controls.Add(this.toxicolgydepbtn);
            this.departslidepanel.Controls.Add(this.chirurgydeptbtn);
            this.departslidepanel.Controls.Add(this.nuerologydepbtn);
            this.departslidepanel.Location = new System.Drawing.Point(0, 71);
            this.departslidepanel.Name = "departslidepanel";
            this.departslidepanel.Size = new System.Drawing.Size(487, 515);
            this.departslidepanel.TabIndex = 2;
            this.departslidepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.departslidepanel_Paint);
            // 
            // createnewdepbtn
            // 
            this.createnewdepbtn.Activecolor = System.Drawing.Color.Teal;
            this.createnewdepbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createnewdepbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.createnewdepbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createnewdepbtn.BorderRadius = 0;
            this.createnewdepbtn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.createnewdepbtn.ButtonText = "Create New Department";
            this.createnewdepbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createnewdepbtn.DisabledColor = System.Drawing.Color.Gray;
            this.createnewdepbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createnewdepbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.createnewdepbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("createnewdepbtn.Iconimage")));
            this.createnewdepbtn.Iconimage_right = null;
            this.createnewdepbtn.Iconimage_right_Selected = null;
            this.createnewdepbtn.Iconimage_Selected = null;
            this.createnewdepbtn.IconMarginLeft = 0;
            this.createnewdepbtn.IconMarginRight = 0;
            this.createnewdepbtn.IconRightVisible = true;
            this.createnewdepbtn.IconRightZoom = 0D;
            this.createnewdepbtn.IconVisible = true;
            this.createnewdepbtn.IconZoom = 90D;
            this.createnewdepbtn.IsTab = false;
            this.createnewdepbtn.Location = new System.Drawing.Point(335, 453);
            this.createnewdepbtn.Name = "createnewdepbtn";
            this.createnewdepbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.createnewdepbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createnewdepbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.createnewdepbtn.selected = false;
            this.createnewdepbtn.Size = new System.Drawing.Size(146, 50);
            this.createnewdepbtn.TabIndex = 4;
            this.createnewdepbtn.Text = "Create New Department";
            this.createnewdepbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createnewdepbtn.Textcolor = System.Drawing.Color.White;
            this.createnewdepbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // hematdepabtn
            // 
            this.hematdepabtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hematdepabtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hematdepabtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.hematdepabtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hematdepabtn.BorderRadius = 0;
            this.hematdepabtn.ButtonText = "Hematology ";
            this.hematdepabtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hematdepabtn.DisabledColor = System.Drawing.Color.Gray;
            this.hematdepabtn.Iconcolor = System.Drawing.Color.Transparent;
            this.hematdepabtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("hematdepabtn.Iconimage")));
            this.hematdepabtn.Iconimage_right = null;
            this.hematdepabtn.Iconimage_right_Selected = null;
            this.hematdepabtn.Iconimage_Selected = null;
            this.hematdepabtn.IconMarginLeft = 0;
            this.hematdepabtn.IconMarginRight = 0;
            this.hematdepabtn.IconRightVisible = true;
            this.hematdepabtn.IconRightZoom = 0D;
            this.hematdepabtn.IconVisible = true;
            this.hematdepabtn.IconZoom = 90D;
            this.hematdepabtn.IsTab = false;
            this.hematdepabtn.Location = new System.Drawing.Point(275, 306);
            this.hematdepabtn.Name = "hematdepabtn";
            this.hematdepabtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.hematdepabtn.OnHovercolor = System.Drawing.Color.Teal;
            this.hematdepabtn.OnHoverTextColor = System.Drawing.Color.White;
            this.hematdepabtn.selected = false;
            this.hematdepabtn.Size = new System.Drawing.Size(144, 48);
            this.hematdepabtn.TabIndex = 3;
            this.hematdepabtn.Text = "Hematology ";
            this.hematdepabtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hematdepabtn.Textcolor = System.Drawing.Color.White;
            this.hematdepabtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hematdepabtn.Click += new System.EventHandler(this.hematdepabtn_Click);
            // 
            // infectiondisdepabtn
            // 
            this.infectiondisdepabtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.infectiondisdepabtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.infectiondisdepabtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.infectiondisdepabtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infectiondisdepabtn.BorderRadius = 0;
            this.infectiondisdepabtn.ButtonText = "Infections Diseases";
            this.infectiondisdepabtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infectiondisdepabtn.DisabledColor = System.Drawing.Color.Gray;
            this.infectiondisdepabtn.Iconcolor = System.Drawing.Color.Transparent;
            this.infectiondisdepabtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("infectiondisdepabtn.Iconimage")));
            this.infectiondisdepabtn.Iconimage_right = null;
            this.infectiondisdepabtn.Iconimage_right_Selected = null;
            this.infectiondisdepabtn.Iconimage_Selected = null;
            this.infectiondisdepabtn.IconMarginLeft = 0;
            this.infectiondisdepabtn.IconMarginRight = 0;
            this.infectiondisdepabtn.IconRightVisible = true;
            this.infectiondisdepabtn.IconRightZoom = 0D;
            this.infectiondisdepabtn.IconVisible = true;
            this.infectiondisdepabtn.IconZoom = 90D;
            this.infectiondisdepabtn.IsTab = false;
            this.infectiondisdepabtn.Location = new System.Drawing.Point(0, 306);
            this.infectiondisdepabtn.Name = "infectiondisdepabtn";
            this.infectiondisdepabtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.infectiondisdepabtn.OnHovercolor = System.Drawing.Color.Teal;
            this.infectiondisdepabtn.OnHoverTextColor = System.Drawing.Color.White;
            this.infectiondisdepabtn.selected = false;
            this.infectiondisdepabtn.Size = new System.Drawing.Size(144, 48);
            this.infectiondisdepabtn.TabIndex = 3;
            this.infectiondisdepabtn.Text = "Infections Diseases";
            this.infectiondisdepabtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.infectiondisdepabtn.Textcolor = System.Drawing.Color.White;
            this.infectiondisdepabtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infectiondisdepabtn.Click += new System.EventHandler(this.infectiondisdepabtn_Click);
            // 
            // oncologydepbtn
            // 
            this.oncologydepbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.oncologydepbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oncologydepbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.oncologydepbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.oncologydepbtn.BorderRadius = 0;
            this.oncologydepbtn.ButtonText = "Oncology Department";
            this.oncologydepbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oncologydepbtn.DisabledColor = System.Drawing.Color.Gray;
            this.oncologydepbtn.Font = new System.Drawing.Font("RomanT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oncologydepbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.oncologydepbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.oncologydepbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("oncologydepbtn.Iconimage")));
            this.oncologydepbtn.Iconimage_right = null;
            this.oncologydepbtn.Iconimage_right_Selected = null;
            this.oncologydepbtn.Iconimage_Selected = null;
            this.oncologydepbtn.IconMarginLeft = 0;
            this.oncologydepbtn.IconMarginRight = 0;
            this.oncologydepbtn.IconRightVisible = true;
            this.oncologydepbtn.IconRightZoom = 0D;
            this.oncologydepbtn.IconVisible = true;
            this.oncologydepbtn.IconZoom = 90D;
            this.oncologydepbtn.IsTab = false;
            this.oncologydepbtn.Location = new System.Drawing.Point(4, 74);
            this.oncologydepbtn.Margin = new System.Windows.Forms.Padding(5);
            this.oncologydepbtn.Name = "oncologydepbtn";
            this.oncologydepbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.oncologydepbtn.OnHovercolor = System.Drawing.Color.Teal;
            this.oncologydepbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.oncologydepbtn.selected = false;
            this.oncologydepbtn.Size = new System.Drawing.Size(144, 58);
            this.oncologydepbtn.TabIndex = 2;
            this.oncologydepbtn.Text = "Oncology Department";
            this.oncologydepbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.oncologydepbtn.Textcolor = System.Drawing.Color.White;
            this.oncologydepbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oncologydepbtn.Click += new System.EventHandler(this.oncologydepbtn_Click);
            // 
            // toxicolgydepbtn
            // 
            this.toxicolgydepbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toxicolgydepbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toxicolgydepbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.toxicolgydepbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toxicolgydepbtn.BorderRadius = 0;
            this.toxicolgydepbtn.ButtonText = "Toxicology Department";
            this.toxicolgydepbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toxicolgydepbtn.DisabledColor = System.Drawing.Color.Gray;
            this.toxicolgydepbtn.Font = new System.Drawing.Font("RomanT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toxicolgydepbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toxicolgydepbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.toxicolgydepbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("toxicolgydepbtn.Iconimage")));
            this.toxicolgydepbtn.Iconimage_right = null;
            this.toxicolgydepbtn.Iconimage_right_Selected = null;
            this.toxicolgydepbtn.Iconimage_Selected = null;
            this.toxicolgydepbtn.IconMarginLeft = 0;
            this.toxicolgydepbtn.IconMarginRight = 0;
            this.toxicolgydepbtn.IconRightVisible = true;
            this.toxicolgydepbtn.IconRightZoom = 0D;
            this.toxicolgydepbtn.IconVisible = true;
            this.toxicolgydepbtn.IconZoom = 90D;
            this.toxicolgydepbtn.IsTab = false;
            this.toxicolgydepbtn.Location = new System.Drawing.Point(4, 188);
            this.toxicolgydepbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toxicolgydepbtn.Name = "toxicolgydepbtn";
            this.toxicolgydepbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.toxicolgydepbtn.OnHovercolor = System.Drawing.Color.Teal;
            this.toxicolgydepbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.toxicolgydepbtn.selected = false;
            this.toxicolgydepbtn.Size = new System.Drawing.Size(144, 58);
            this.toxicolgydepbtn.TabIndex = 2;
            this.toxicolgydepbtn.Text = "Toxicology Department";
            this.toxicolgydepbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toxicolgydepbtn.Textcolor = System.Drawing.Color.White;
            this.toxicolgydepbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toxicolgydepbtn.Click += new System.EventHandler(this.toxicolgydepbtn_Click);
            // 
            // chirurgydeptbtn
            // 
            this.chirurgydeptbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chirurgydeptbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chirurgydeptbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.chirurgydeptbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chirurgydeptbtn.BorderRadius = 0;
            this.chirurgydeptbtn.ButtonText = "Chirurgy Department";
            this.chirurgydeptbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chirurgydeptbtn.DisabledColor = System.Drawing.Color.Gray;
            this.chirurgydeptbtn.Font = new System.Drawing.Font("RomanT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chirurgydeptbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chirurgydeptbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.chirurgydeptbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("chirurgydeptbtn.Iconimage")));
            this.chirurgydeptbtn.Iconimage_right = null;
            this.chirurgydeptbtn.Iconimage_right_Selected = null;
            this.chirurgydeptbtn.Iconimage_Selected = null;
            this.chirurgydeptbtn.IconMarginLeft = 0;
            this.chirurgydeptbtn.IconMarginRight = 0;
            this.chirurgydeptbtn.IconRightVisible = true;
            this.chirurgydeptbtn.IconRightZoom = 0D;
            this.chirurgydeptbtn.IconVisible = true;
            this.chirurgydeptbtn.IconZoom = 90D;
            this.chirurgydeptbtn.IsTab = false;
            this.chirurgydeptbtn.Location = new System.Drawing.Point(275, 188);
            this.chirurgydeptbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chirurgydeptbtn.Name = "chirurgydeptbtn";
            this.chirurgydeptbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.chirurgydeptbtn.OnHovercolor = System.Drawing.Color.Teal;
            this.chirurgydeptbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.chirurgydeptbtn.selected = false;
            this.chirurgydeptbtn.Size = new System.Drawing.Size(144, 58);
            this.chirurgydeptbtn.TabIndex = 2;
            this.chirurgydeptbtn.Text = "Chirurgy Department";
            this.chirurgydeptbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chirurgydeptbtn.Textcolor = System.Drawing.Color.White;
            this.chirurgydeptbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chirurgydeptbtn.Click += new System.EventHandler(this.chirurgydeptbtn_Click);
            // 
            // nuerologydepbtn
            // 
            this.nuerologydepbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nuerologydepbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nuerologydepbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.nuerologydepbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nuerologydepbtn.BorderRadius = 0;
            this.nuerologydepbtn.ButtonText = "Neurolgy Department";
            this.nuerologydepbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nuerologydepbtn.DisabledColor = System.Drawing.Color.Gray;
            this.nuerologydepbtn.Font = new System.Drawing.Font("RomanT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nuerologydepbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nuerologydepbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.nuerologydepbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("nuerologydepbtn.Iconimage")));
            this.nuerologydepbtn.Iconimage_right = null;
            this.nuerologydepbtn.Iconimage_right_Selected = null;
            this.nuerologydepbtn.Iconimage_Selected = null;
            this.nuerologydepbtn.IconMarginLeft = 0;
            this.nuerologydepbtn.IconMarginRight = 0;
            this.nuerologydepbtn.IconRightVisible = true;
            this.nuerologydepbtn.IconRightZoom = 0D;
            this.nuerologydepbtn.IconVisible = true;
            this.nuerologydepbtn.IconZoom = 90D;
            this.nuerologydepbtn.IsTab = false;
            this.nuerologydepbtn.Location = new System.Drawing.Point(275, 74);
            this.nuerologydepbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nuerologydepbtn.Name = "nuerologydepbtn";
            this.nuerologydepbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.nuerologydepbtn.OnHovercolor = System.Drawing.Color.Teal;
            this.nuerologydepbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.nuerologydepbtn.selected = false;
            this.nuerologydepbtn.Size = new System.Drawing.Size(144, 58);
            this.nuerologydepbtn.TabIndex = 2;
            this.nuerologydepbtn.Text = "Neurolgy Department";
            this.nuerologydepbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuerologydepbtn.Textcolor = System.Drawing.Color.White;
            this.nuerologydepbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuerologydepbtn.Click += new System.EventHandler(this.nuerologydepbtn_Click);
            // 
            // departmentinfopanel
            // 
            this.departmentinfopanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentinfopanel.Controls.Add(this.groupBox1);
            this.departmentinfopanel.Controls.Add(this.groupBox2);
            this.departmentinfopanel.Location = new System.Drawing.Point(487, 71);
            this.departmentinfopanel.Name = "departmentinfopanel";
            this.departmentinfopanel.Size = new System.Drawing.Size(386, 515);
            this.departmentinfopanel.TabIndex = 3;
            this.departmentinfopanel.Paint += new System.Windows.Forms.PaintEventHandler(this.departmentinfopanel_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.currentmachine);
            this.groupBox1.Controls.Add(this.roomnumber);
            this.groupBox1.Controls.Add(this.floornum);
            this.groupBox1.Controls.Add(this.depname);
            this.groupBox1.Controls.Add(this.depaaddress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Department İnfo";
            // 
            // currentmachine
            // 
            this.currentmachine.AutoSize = true;
            this.currentmachine.Location = new System.Drawing.Point(152, 166);
            this.currentmachine.Name = "currentmachine";
            this.currentmachine.Size = new System.Drawing.Size(101, 16);
            this.currentmachine.TabIndex = 1;
            this.currentmachine.Text = "CurrentMachine";
            // 
            // roomnumber
            // 
            this.roomnumber.AutoSize = true;
            this.roomnumber.Location = new System.Drawing.Point(106, 121);
            this.roomnumber.Name = "roomnumber";
            this.roomnumber.Size = new System.Drawing.Size(70, 16);
            this.roomnumber.TabIndex = 1;
            this.roomnumber.Text = "Roomnum";
            // 
            // floornum
            // 
            this.floornum.AutoSize = true;
            this.floornum.Location = new System.Drawing.Point(106, 78);
            this.floornum.Name = "floornum";
            this.floornum.Size = new System.Drawing.Size(64, 16);
            this.floornum.TabIndex = 1;
            this.floornum.Text = "Floornum";
            // 
            // depname
            // 
            this.depname.AutoSize = true;
            this.depname.Location = new System.Drawing.Point(106, 22);
            this.depname.Name = "depname";
            this.depname.Size = new System.Drawing.Size(68, 16);
            this.depname.TabIndex = 1;
            this.depname.Text = "Depname";
            // 
            // depaaddress
            // 
            this.depaaddress.AutoSize = true;
            this.depaaddress.Location = new System.Drawing.Point(106, 44);
            this.depaaddress.Name = "depaaddress";
            this.depaaddress.Size = new System.Drawing.Size(84, 16);
            this.depaaddress.TabIndex = 1;
            this.depaaddress.Text = "Depaddress";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Active Machine:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Room Number:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Floor:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Addres:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.patientnumlabel);
            this.groupBox2.Controls.Add(this.nursenum);
            this.groupBox2.Controls.Add(this.doctornumlabel);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 163);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel\'s İnformations";
            // 
            // patientnumlabel
            // 
            this.patientnumlabel.AutoSize = true;
            this.patientnumlabel.Location = new System.Drawing.Point(135, 84);
            this.patientnumlabel.Name = "patientnumlabel";
            this.patientnumlabel.Size = new System.Drawing.Size(81, 16);
            this.patientnumlabel.TabIndex = 1;
            this.patientnumlabel.Text = "Patientsnum";
            // 
            // nursenum
            // 
            this.nursenum.AutoSize = true;
            this.nursenum.Location = new System.Drawing.Point(135, 55);
            this.nursenum.Name = "nursenum";
            this.nursenum.Size = new System.Drawing.Size(69, 16);
            this.nursenum.TabIndex = 1;
            this.nursenum.Text = "Nursenum";
            // 
            // doctornumlabel
            // 
            this.doctornumlabel.AutoSize = true;
            this.doctornumlabel.Location = new System.Drawing.Point(135, 30);
            this.doctornumlabel.Name = "doctornumlabel";
            this.doctornumlabel.Size = new System.Drawing.Size(73, 16);
            this.doctornumlabel.TabIndex = 1;
            this.doctornumlabel.Text = "Doctornum";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Number of Patients:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Number of Doctor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Number Of Nurse:";
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(873, 586);
            this.Controls.Add(this.departmentinfopanel);
            this.Controls.Add(this.departslidepanel);
            this.Controls.Add(this.departmentheadpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(642, 362);
            this.Name = "DepartmentForm";
            this.Text = "DepartmentForm";
            this.departmentheadpanel.ResumeLayout(false);
            this.departmentheadpanel.PerformLayout();
            this.departslidepanel.ResumeLayout(false);
            this.departmentinfopanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel departmentheadpanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel departslidepanel;
        private System.Windows.Forms.Panel departmentinfopanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuFlatButton oncologydepbtn;
        private Bunifu.Framework.UI.BunifuFlatButton toxicolgydepbtn;
        private Bunifu.Framework.UI.BunifuFlatButton chirurgydeptbtn;
        private Bunifu.Framework.UI.BunifuFlatButton nuerologydepbtn;
        private Bunifu.Framework.UI.BunifuFlatButton hematdepabtn;
        private Bunifu.Framework.UI.BunifuFlatButton infectiondisdepabtn;
        private System.Windows.Forms.Label patientnumlabel;
        private System.Windows.Forms.Label nursenum;
        private System.Windows.Forms.Label doctornumlabel;
        private Bunifu.Framework.UI.BunifuFlatButton createnewdepbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label roomnumber;
        private System.Windows.Forms.Label floornum;
        private System.Windows.Forms.Label depname;
        private System.Windows.Forms.Label depaaddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label currentmachine;
        private System.Windows.Forms.Label label1;
    }
}