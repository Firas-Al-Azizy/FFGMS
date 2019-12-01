﻿namespace FFGMS
{
    partial class Trainer_Dashboard
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trainer_Dashboard));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.title_trans = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.exit_btn = new System.Windows.Forms.Button();
            this.menu_trans = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_trans
            // 
            this.title_trans.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.title_trans.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.title_trans.DefaultAnimation = animation1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Controls.Add(this.bunifuFlatButton6);
            this.panel1.Controls.Add(this.bunifuFlatButton5);
            this.panel1.Controls.Add(this.bunifuFlatButton4);
            this.panel1.Controls.Add(this.bunifuFlatButton2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.menu_trans.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.title_trans.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(-1, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 528);
            this.panel1.TabIndex = 37;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Program";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_trans.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.title_trans.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::FFGMS.Properties.Resources.icons8_personal_trainer_100_2;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 70D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 312);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(225, 51);
            this.bunifuFlatButton1.TabIndex = 41;
            this.bunifuFlatButton1.Text = "Program";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "Group";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_trans.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.title_trans.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = global::FFGMS.Properties.Resources.icons8_personal_trainer_100_2;
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 70D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(0, 255);
            this.bunifuFlatButton6.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(225, 51);
            this.bunifuFlatButton6.TabIndex = 40;
            this.bunifuFlatButton6.Text = "Group";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "Workouts";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_trans.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.title_trans.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = global::FFGMS.Properties.Resources.icons8_personal_trainer_100_2;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 70D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(0, 201);
            this.bunifuFlatButton5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(225, 51);
            this.bunifuFlatButton5.TabIndex = 38;
            this.bunifuFlatButton5.Text = "Workouts";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Macheins";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_trans.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.title_trans.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = global::FFGMS.Properties.Resources.icons8_personal_trainer_100_2;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 70D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(0, 150);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(225, 51);
            this.bunifuFlatButton4.TabIndex = 37;
            this.bunifuFlatButton4.Text = "Macheins";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Trainees";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_trans.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.title_trans.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::FFGMS.Properties.Resources.icons8_personal_trainer_100_2;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 70D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 93);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(225, 51);
            this.bunifuFlatButton2.TabIndex = 36;
            this.bunifuFlatButton2.Text = "Trainees";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.title_trans.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.menu_trans.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.label3.Location = new System.Drawing.Point(11, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Trainer Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.title_trans.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.menu_trans.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::FFGMS.Properties.Resources.icons8_menu_50_4;
            this.pictureBox1.InitialImage = global::FFGMS.Properties.Resources.icons8_menu_50_3;
            this.pictureBox1.Location = new System.Drawing.Point(189, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // back_btn
            // 
            this.title_trans.SetDecoration(this.back_btn, BunifuAnimatorNS.DecorationType.None);
            this.menu_trans.SetDecoration(this.back_btn, BunifuAnimatorNS.DecorationType.None);
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Forte", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.back_btn.Location = new System.Drawing.Point(682, 0);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(46, 33);
            this.back_btn.TabIndex = 29;
            this.back_btn.Text = "<";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.title_trans.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.menu_trans.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.label2.Location = new System.Drawing.Point(2, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 32);
            this.label2.TabIndex = 28;
            this.label2.Text = "FitFat";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel3.Controls.Add(this.back_btn);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.exit_btn);
            this.menu_trans.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.title_trans.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(771, 33);
            this.panel3.TabIndex = 38;
            // 
            // exit_btn
            // 
            this.title_trans.SetDecoration(this.exit_btn, BunifuAnimatorNS.DecorationType.None);
            this.menu_trans.SetDecoration(this.exit_btn, BunifuAnimatorNS.DecorationType.None);
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Forte", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.exit_btn.Location = new System.Drawing.Point(725, 0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(46, 33);
            this.exit_btn.TabIndex = 1;
            this.exit_btn.Text = "X";
            this.exit_btn.UseVisualStyleBackColor = true;
            // 
            // menu_trans
            // 
            this.menu_trans.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.menu_trans.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.menu_trans.DefaultAnimation = animation2;
            // 
            // Trainer_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.title_trans.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.menu_trans.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Trainer_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trainer_Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuAnimatorNS.BunifuTransition title_trans;
        private BunifuAnimatorNS.BunifuTransition menu_trans;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button exit_btn;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}