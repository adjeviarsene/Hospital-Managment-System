namespace HProgramming
{
    partial class Fingerprint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fingerprint));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.baudratedrop = new System.Windows.Forms.ComboBox();
            this.portcomdrop = new System.Windows.Forms.ComboBox();
            this.fingerscanpict = new System.Windows.Forms.PictureBox();
            this.startscanbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cancelbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fingerscanpict)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.baudratedrop);
            this.bunifuGradientPanel1.Controls.Add(this.portcomdrop);
            this.bunifuGradientPanel1.Controls.Add(this.fingerscanpict);
            this.bunifuGradientPanel1.Controls.Add(this.startscanbtn);
            this.bunifuGradientPanel1.Controls.Add(this.cancelbtn);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.SpringGreen;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(517, 320);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(34, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "BAUD RATE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "COM PORT:";
            // 
            // baudratedrop
            // 
            this.baudratedrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.baudratedrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudratedrop.ForeColor = System.Drawing.SystemColors.Window;
            this.baudratedrop.FormattingEnabled = true;
            this.baudratedrop.Location = new System.Drawing.Point(118, 120);
            this.baudratedrop.Name = "baudratedrop";
            this.baudratedrop.Size = new System.Drawing.Size(121, 21);
            this.baudratedrop.TabIndex = 2;
            // 
            // portcomdrop
            // 
            this.portcomdrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.portcomdrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portcomdrop.ForeColor = System.Drawing.SystemColors.Window;
            this.portcomdrop.FormattingEnabled = true;
            this.portcomdrop.Location = new System.Drawing.Point(118, 55);
            this.portcomdrop.Name = "portcomdrop";
            this.portcomdrop.Size = new System.Drawing.Size(121, 21);
            this.portcomdrop.TabIndex = 2;
            // 
            // fingerscanpict
            // 
            this.fingerscanpict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.fingerscanpict.Image = ((System.Drawing.Image)(resources.GetObject("fingerscanpict.Image")));
            this.fingerscanpict.Location = new System.Drawing.Point(319, 44);
            this.fingerscanpict.Name = "fingerscanpict";
            this.fingerscanpict.Size = new System.Drawing.Size(173, 152);
            this.fingerscanpict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fingerscanpict.TabIndex = 1;
            this.fingerscanpict.TabStop = false;
            // 
            // startscanbtn
            // 
            this.startscanbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.startscanbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.startscanbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startscanbtn.BorderRadius = 0;
            this.startscanbtn.ButtonText = "Start FingerPrintScan";
            this.startscanbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startscanbtn.DisabledColor = System.Drawing.Color.Gray;
            this.startscanbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.startscanbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("startscanbtn.Iconimage")));
            this.startscanbtn.Iconimage_right = null;
            this.startscanbtn.Iconimage_right_Selected = null;
            this.startscanbtn.Iconimage_Selected = null;
            this.startscanbtn.IconMarginLeft = 0;
            this.startscanbtn.IconMarginRight = 0;
            this.startscanbtn.IconRightVisible = true;
            this.startscanbtn.IconRightZoom = 0D;
            this.startscanbtn.IconVisible = true;
            this.startscanbtn.IconZoom = 90D;
            this.startscanbtn.IsTab = false;
            this.startscanbtn.Location = new System.Drawing.Point(319, 223);
            this.startscanbtn.Name = "startscanbtn";
            this.startscanbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.startscanbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startscanbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.startscanbtn.selected = false;
            this.startscanbtn.Size = new System.Drawing.Size(186, 48);
            this.startscanbtn.TabIndex = 0;
            this.startscanbtn.Text = "Start FingerPrintScan";
            this.startscanbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startscanbtn.Textcolor = System.Drawing.Color.White;
            this.startscanbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startscanbtn.Click += new System.EventHandler(this.startscanbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Activecolor = System.Drawing.Color.Teal;
            this.cancelbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.cancelbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelbtn.BorderRadius = 0;
            this.cancelbtn.ButtonText = "Cancel";
            this.cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelbtn.DisabledColor = System.Drawing.Color.Gray;
            this.cancelbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.cancelbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("cancelbtn.Iconimage")));
            this.cancelbtn.Iconimage_right = null;
            this.cancelbtn.Iconimage_right_Selected = null;
            this.cancelbtn.Iconimage_Selected = null;
            this.cancelbtn.IconMarginLeft = 0;
            this.cancelbtn.IconMarginRight = 0;
            this.cancelbtn.IconRightVisible = true;
            this.cancelbtn.IconRightZoom = 0D;
            this.cancelbtn.IconVisible = true;
            this.cancelbtn.IconZoom = 90D;
            this.cancelbtn.IsTab = false;
            this.cancelbtn.Location = new System.Drawing.Point(118, 223);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(3)))), ((int)(((byte)(40)))));
            this.cancelbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.cancelbtn.selected = false;
            this.cancelbtn.Size = new System.Drawing.Size(143, 48);
            this.cancelbtn.TabIndex = 0;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelbtn.Textcolor = System.Drawing.Color.White;
            this.cancelbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Fingerprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 320);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fingerprint";
            this.Text = "Fingerprint";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fingerscanpict)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.ComboBox baudratedrop;
        private System.Windows.Forms.ComboBox portcomdrop;
        private System.Windows.Forms.PictureBox fingerscanpict;
        private Bunifu.Framework.UI.BunifuFlatButton startscanbtn;
        private Bunifu.Framework.UI.BunifuFlatButton cancelbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}