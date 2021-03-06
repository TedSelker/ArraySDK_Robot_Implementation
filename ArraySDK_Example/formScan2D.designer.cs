﻿using System.Drawing;
using System.Windows.Forms;

namespace SDK_Example
{
    partial class formScan2D
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formScan2D));
            this.labelImaging = new System.Windows.Forms.Label();
            this.labelTgc = new System.Windows.Forms.Label();
            this.textRadius = new System.Windows.Forms.TextBox();
            this.labelDepth = new System.Windows.Forms.Label();
            this.labelFrequency = new System.Windows.Forms.Label();
            this.labelRobotSpeed = new System.Windows.Forms.Label();
            this.labelMainGain = new System.Windows.Forms.Label();
            this.labelHighVolt = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFpga = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelDynamic = new System.Windows.Forms.Label();
            this.labelTgc3 = new System.Windows.Forms.Label();
            this.labelTgc2 = new System.Windows.Forms.Label();
            this.labelTgc1 = new System.Windows.Forms.Label();
            this.labelFocus = new System.Windows.Forms.Label();
            this.butCfmMode = new System.Windows.Forms.Button();
            this.buttonProbe2 = new System.Windows.Forms.Button();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelSaveReview = new System.Windows.Forms.Label();
            this.labelRobotCtrls = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveScreenshot = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCompound = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDoubler = new System.Windows.Forms.ToolStripMenuItem();
            this.presetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWebsite = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ankleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kneeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elbowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ultraScanButton = new System.Windows.Forms.PictureBox();
            this.buttonRobotScan = new System.Windows.Forms.PictureBox();
            this.butManRev = new System.Windows.Forms.PictureBox();
            this.protoButManFwd = new System.Windows.Forms.PictureBox();
            this.buttonLoad = new System.Windows.Forms.PictureBox();
            this.buttonSaveCine = new System.Windows.Forms.PictureBox();
            this.buttonPrevious = new System.Windows.Forms.PictureBox();
            this.buttonCine = new System.Windows.Forms.PictureBox();
            this.buttonNext = new System.Windows.Forms.PictureBox();
            this.robotStateIndicator = new System.Windows.Forms.PictureBox();
            this.protoTBarTgc1 = new TrackBar.Dotnetrix.Controls.TrackBar();
            this.protoTBarTgc2 = new TrackBar.Dotnetrix.Controls.TrackBar();
            this.protoTBarTgc3 = new TrackBar.Dotnetrix.Controls.TrackBar();
            this.protoTrackBarRobotSpeed = new TrackBar.Dotnetrix.Controls.TrackBar();
            this.protoTrackBarCine = new TrackBar.Dotnetrix.Controls.TrackBar();
            this.labelRobotState = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFileName = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.protoUCtrlPMDynamic = new SDK_Example.UserControlPlusMinus();
            this.protoUCtrlPMGalGain = new SDK_Example.UserControlPlusMinus();
            this.protoUCtrlPMHighVoltage = new SDK_Example.UserControlPlusMinus();
            this.protoUCtrlPMFocus = new SDK_Example.UserControlPlusMinus();
            this.protoUCtrlPMFrequency = new SDK_Example.UserControlPlusMinus();
            this.protoUCtrlPMDepth = new SDK_Example.UserControlPlusMinus();
            this.userControlDepth1 = new SDK_Example.UserControlDepth();
            this.uctrlGrayScale = new SDK_Example.UserControlGrayScale();
            this.uctrlScan = new SDK_Example.UserControlScan();
            this.uctrlDepth = new SDK_Example.UserControlDepth();
            this.achillesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plantersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLoadPresetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraScanButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRobotScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.butManRev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.protoButManFwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSaveCine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robotStateIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.protoTBarTgc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.protoTBarTgc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.protoTBarTgc3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.protoTrackBarRobotSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.protoTrackBarCine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelImaging
            // 
            this.labelImaging.AutoSize = true;
            this.labelImaging.BackColor = System.Drawing.Color.Transparent;
            this.labelImaging.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImaging.ForeColor = System.Drawing.Color.White;
            this.labelImaging.Location = new System.Drawing.Point(225, 515);
            this.labelImaging.Name = "labelImaging";
            this.labelImaging.Size = new System.Drawing.Size(71, 16);
            this.labelImaging.TabIndex = 54;
            this.labelImaging.Text = "IMAGING";
            this.labelImaging.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelImaging.Click += new System.EventHandler(this.LabelImaging_Click);
            // 
            // labelTgc
            // 
            this.labelTgc.AutoSize = true;
            this.labelTgc.BackColor = System.Drawing.Color.Transparent;
            this.labelTgc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTgc.ForeColor = System.Drawing.Color.White;
            this.labelTgc.Location = new System.Drawing.Point(765, 502);
            this.labelTgc.Name = "labelTgc";
            this.labelTgc.Size = new System.Drawing.Size(208, 16);
            this.labelTgc.TabIndex = 54;
            this.labelTgc.Text = "TIME GAIN COMPENSATION";
            this.labelTgc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTgc.Click += new System.EventHandler(this.LabelTgc_Click);
            // 
            // textRadius
            // 
            this.textRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRadius.ForeColor = System.Drawing.Color.DimGray;
            this.textRadius.Location = new System.Drawing.Point(952, 53);
            this.textRadius.Name = "textRadius";
            this.textRadius.Size = new System.Drawing.Size(123, 22);
            this.textRadius.TabIndex = 0;
            this.textRadius.Text = "Enter Radius(cm)";
            this.textRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textRadius.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextRadius_MouseClick);
            this.textRadius.Leave += new System.EventHandler(this.TextRadius_Leave);
            // 
            // labelDepth
            // 
            this.labelDepth.BackColor = System.Drawing.Color.Transparent;
            this.labelDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepth.ForeColor = System.Drawing.Color.White;
            this.labelDepth.Location = new System.Drawing.Point(237, 660);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(60, 16);
            this.labelDepth.TabIndex = 26;
            this.labelDepth.Text = "Depth";
            this.labelDepth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFrequency
            // 
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.BackColor = System.Drawing.Color.Transparent;
            this.labelFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrequency.ForeColor = System.Drawing.Color.White;
            this.labelFrequency.Location = new System.Drawing.Point(312, 660);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(72, 16);
            this.labelFrequency.TabIndex = 27;
            this.labelFrequency.Text = "Frequency";
            this.labelFrequency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRobotSpeed
            // 
            this.labelRobotSpeed.AutoSize = true;
            this.labelRobotSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labelRobotSpeed.ForeColor = System.Drawing.Color.White;
            this.labelRobotSpeed.Location = new System.Drawing.Point(917, 201);
            this.labelRobotSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRobotSpeed.Name = "labelRobotSpeed";
            this.labelRobotSpeed.Size = new System.Drawing.Size(70, 13);
            this.labelRobotSpeed.TabIndex = 57;
            this.labelRobotSpeed.Text = "Robot Speed";
            // 
            // labelMainGain
            // 
            this.labelMainGain.BackColor = System.Drawing.Color.Transparent;
            this.labelMainGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainGain.ForeColor = System.Drawing.Color.White;
            this.labelMainGain.Location = new System.Drawing.Point(550, 660);
            this.labelMainGain.Name = "labelMainGain";
            this.labelMainGain.Size = new System.Drawing.Size(73, 16);
            this.labelMainGain.TabIndex = 32;
            this.labelMainGain.Text = "MainGain";
            this.labelMainGain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHighVolt
            // 
            this.labelHighVolt.AutoSize = true;
            this.labelHighVolt.BackColor = System.Drawing.Color.Transparent;
            this.labelHighVolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighVolt.ForeColor = System.Drawing.Color.White;
            this.labelHighVolt.Location = new System.Drawing.Point(474, 660);
            this.labelHighVolt.Name = "labelHighVolt";
            this.labelHighVolt.Size = new System.Drawing.Size(62, 16);
            this.labelHighVolt.TabIndex = 34;
            this.labelHighVolt.Text = "High Volt";
            this.labelHighVolt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.LightSteelBlue;
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabelFpga});
            this.statusStrip.Location = new System.Drawing.Point(0, 679);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1170, 22);
            this.statusStrip.TabIndex = 35;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(114, 17);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel";
            // 
            // toolStripStatusLabelFpga
            // 
            this.toolStripStatusLabelFpga.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStripStatusLabelFpga.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabelFpga.Name = "toolStripStatusLabelFpga";
            this.toolStripStatusLabelFpga.Size = new System.Drawing.Size(140, 17);
            this.toolStripStatusLabelFpga.Text = "toolStripStatusLabelFpga";
            // 
            // labelDynamic
            // 
            this.labelDynamic.AutoSize = true;
            this.labelDynamic.BackColor = System.Drawing.Color.Transparent;
            this.labelDynamic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDynamic.ForeColor = System.Drawing.Color.White;
            this.labelDynamic.Location = new System.Drawing.Point(635, 660);
            this.labelDynamic.Name = "labelDynamic";
            this.labelDynamic.Size = new System.Drawing.Size(61, 16);
            this.labelDynamic.TabIndex = 44;
            this.labelDynamic.Text = "Dynamic";
            this.labelDynamic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDynamic.Click += new System.EventHandler(this.LabelDynamic_Click);
            // 
            // labelTgc3
            // 
            this.labelTgc3.AutoSize = true;
            this.labelTgc3.BackColor = System.Drawing.Color.Transparent;
            this.labelTgc3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTgc3.ForeColor = System.Drawing.Color.White;
            this.labelTgc3.Location = new System.Drawing.Point(1109, 619);
            this.labelTgc3.Name = "labelTgc3";
            this.labelTgc3.Size = new System.Drawing.Size(22, 13);
            this.labelTgc3.TabIndex = 56;
            this.labelTgc3.Text = "Far";
            // 
            // labelTgc2
            // 
            this.labelTgc2.AutoSize = true;
            this.labelTgc2.BackColor = System.Drawing.Color.Transparent;
            this.labelTgc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTgc2.ForeColor = System.Drawing.Color.White;
            this.labelTgc2.Location = new System.Drawing.Point(1094, 565);
            this.labelTgc2.Name = "labelTgc2";
            this.labelTgc2.Size = new System.Drawing.Size(38, 13);
            this.labelTgc2.TabIndex = 55;
            this.labelTgc2.Text = "Middle";
            // 
            // labelTgc1
            // 
            this.labelTgc1.AutoSize = true;
            this.labelTgc1.BackColor = System.Drawing.Color.Transparent;
            this.labelTgc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTgc1.ForeColor = System.Drawing.Color.White;
            this.labelTgc1.Location = new System.Drawing.Point(1102, 511);
            this.labelTgc1.Name = "labelTgc1";
            this.labelTgc1.Size = new System.Drawing.Size(30, 13);
            this.labelTgc1.TabIndex = 54;
            this.labelTgc1.Text = "Near";
            this.labelTgc1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFocus
            // 
            this.labelFocus.AutoSize = true;
            this.labelFocus.BackColor = System.Drawing.Color.Transparent;
            this.labelFocus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFocus.ForeColor = System.Drawing.Color.White;
            this.labelFocus.Location = new System.Drawing.Point(404, 660);
            this.labelFocus.Name = "labelFocus";
            this.labelFocus.Size = new System.Drawing.Size(45, 16);
            this.labelFocus.TabIndex = 46;
            this.labelFocus.Text = "Focus";
            this.labelFocus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butCfmMode
            // 
            this.butCfmMode.BackColor = System.Drawing.Color.LightSteelBlue;
            this.butCfmMode.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCfmMode.ForeColor = System.Drawing.Color.Black;
            this.butCfmMode.Location = new System.Drawing.Point(671, -211);
            this.butCfmMode.Name = "butCfmMode";
            this.butCfmMode.Size = new System.Drawing.Size(131, 26);
            this.butCfmMode.TabIndex = 53;
            this.butCfmMode.Text = "CFM";
            this.butCfmMode.UseVisualStyleBackColor = false;
            this.butCfmMode.Click += new System.EventHandler(this.butCfmMode_Click);
            // 
            // buttonProbe2
            // 
            this.buttonProbe2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonProbe2.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProbe2.ForeColor = System.Drawing.Color.Black;
            this.buttonProbe2.Location = new System.Drawing.Point(9, 51);
            this.buttonProbe2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonProbe2.Name = "buttonProbe2";
            this.buttonProbe2.Size = new System.Drawing.Size(196, 40);
            this.buttonProbe2.TabIndex = 48;
            this.buttonProbe2.Text = "Probe2";
            this.buttonProbe2.UseVisualStyleBackColor = false;
            this.buttonProbe2.Click += new System.EventHandler(this.buttonProbe2_Click);
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.BackColor = System.Drawing.Color.Transparent;
            this.labelPosition.ForeColor = System.Drawing.Color.White;
            this.labelPosition.Location = new System.Drawing.Point(1002, 136);
            this.labelPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(44, 13);
            this.labelPosition.TabIndex = 2;
            this.labelPosition.Text = "Position";
            this.labelPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPosition.Click += new System.EventHandler(this.LabelPosition_Click);
            // 
            // labelSaveReview
            // 
            this.labelSaveReview.AutoSize = true;
            this.labelSaveReview.BackColor = System.Drawing.Color.Transparent;
            this.labelSaveReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaveReview.ForeColor = System.Drawing.Color.White;
            this.labelSaveReview.Location = new System.Drawing.Point(765, 267);
            this.labelSaveReview.Name = "labelSaveReview";
            this.labelSaveReview.Size = new System.Drawing.Size(112, 16);
            this.labelSaveReview.TabIndex = 58;
            this.labelSaveReview.Text = "SAVE/REVIEW";
            this.labelSaveReview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSaveReview.Click += new System.EventHandler(this.LabelSaveReview_Click);
            // 
            // labelRobotCtrls
            // 
            this.labelRobotCtrls.AutoSize = true;
            this.labelRobotCtrls.BackColor = System.Drawing.Color.Transparent;
            this.labelRobotCtrls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRobotCtrls.ForeColor = System.Drawing.Color.White;
            this.labelRobotCtrls.Location = new System.Drawing.Point(765, 33);
            this.labelRobotCtrls.Name = "labelRobotCtrls";
            this.labelRobotCtrls.Size = new System.Drawing.Size(147, 16);
            this.labelRobotCtrls.TabIndex = 59;
            this.labelRobotCtrls.Text = "ROBOT CONTROLS";
            this.labelRobotCtrls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRobotCtrls.Click += new System.EventHandler(this.LabelRobotCtrls_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.referenceImagesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1170, 24);
            this.menuStrip1.TabIndex = 62;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSave,
            this.menuLoad,
            this.menuSaveScreenshot});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(159, 22);
            this.menuSave.Text = "Save";
            this.menuSave.Click += new System.EventHandler(this.MenuSave_Click);
            // 
            // menuLoad
            // 
            this.menuLoad.Name = "menuLoad";
            this.menuLoad.Size = new System.Drawing.Size(159, 22);
            this.menuLoad.Text = "Load";
            this.menuLoad.Click += new System.EventHandler(this.MenuLoad_Click);
            // 
            // menuSaveScreenshot
            // 
            this.menuSaveScreenshot.Name = "menuSaveScreenshot";
            this.menuSaveScreenshot.Size = new System.Drawing.Size(159, 22);
            this.menuSaveScreenshot.Text = "Save Screenshot";
            this.menuSaveScreenshot.Click += new System.EventHandler(this.MenuSaveScreenshot_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCompound,
            this.menuDoubler,
            this.presetsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // menuCompound
            // 
            this.menuCompound.Name = "menuCompound";
            this.menuCompound.Size = new System.Drawing.Size(180, 22);
            this.menuCompound.Text = "Compound";
            this.menuCompound.Click += new System.EventHandler(this.MenuCompound_Click);
            // 
            // menuDoubler
            // 
            this.menuDoubler.Checked = true;
            this.menuDoubler.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuDoubler.Name = "menuDoubler";
            this.menuDoubler.Size = new System.Drawing.Size(180, 22);
            this.menuDoubler.Text = "Doubler";
            this.menuDoubler.Click += new System.EventHandler(this.MenuDoubler_Click);
            // 
            // presetsToolStripMenuItem
            // 
            this.presetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maxedToolStripMenuItem,
            this.achillesToolStripMenuItem,
            this.plantersToolStripMenuItem,
            this.saveLoadPresetsToolStripMenuItem});
            this.presetsToolStripMenuItem.Name = "presetsToolStripMenuItem";
            this.presetsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.presetsToolStripMenuItem.Text = "Presets";
            // 
            // maxedToolStripMenuItem
            // 
            this.maxedToolStripMenuItem.Name = "maxedToolStripMenuItem";
            this.maxedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maxedToolStripMenuItem.Text = "Maxed";
            this.maxedToolStripMenuItem.Click += new System.EventHandler(this.MaxedToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuWebsite});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // menuWebsite
            // 
            this.menuWebsite.Name = "menuWebsite";
            this.menuWebsite.Size = new System.Drawing.Size(116, 22);
            this.menuWebsite.Text = "Website";
            this.menuWebsite.Click += new System.EventHandler(this.MenuWebsite_Click);
            // 
            // referenceImagesToolStripMenuItem
            // 
            this.referenceImagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ankleToolStripMenuItem,
            this.kneeToolStripMenuItem,
            this.elbowToolStripMenuItem});
            this.referenceImagesToolStripMenuItem.Name = "referenceImagesToolStripMenuItem";
            this.referenceImagesToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.referenceImagesToolStripMenuItem.Text = "Reference Images";
            // 
            // ankleToolStripMenuItem
            // 
            this.ankleToolStripMenuItem.Name = "ankleToolStripMenuItem";
            this.ankleToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.ankleToolStripMenuItem.Text = "Foot";
            this.ankleToolStripMenuItem.Click += new System.EventHandler(this.AnkleToolStripMenuItem_Click);
            // 
            // kneeToolStripMenuItem
            // 
            this.kneeToolStripMenuItem.Name = "kneeToolStripMenuItem";
            this.kneeToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.kneeToolStripMenuItem.Text = "Knee";
            this.kneeToolStripMenuItem.Click += new System.EventHandler(this.KneeToolStripMenuItem_Click);
            // 
            // elbowToolStripMenuItem
            // 
            this.elbowToolStripMenuItem.Name = "elbowToolStripMenuItem";
            this.elbowToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.elbowToolStripMenuItem.Text = "Elbow";
            this.elbowToolStripMenuItem.Click += new System.EventHandler(this.ElbowToolStripMenuItem_Click);
            // 
            // ultraScanButton
            // 
            this.ultraScanButton.BackColor = System.Drawing.Color.Transparent;
            this.ultraScanButton.Image = ((System.Drawing.Image)(resources.GetObject("ultraScanButton.Image")));
            this.ultraScanButton.Location = new System.Drawing.Point(69, 520);
            this.ultraScanButton.Name = "ultraScanButton";
            this.ultraScanButton.Size = new System.Drawing.Size(147, 149);
            this.ultraScanButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ultraScanButton.TabIndex = 1;
            this.ultraScanButton.TabStop = false;
            this.ultraScanButton.Click += new System.EventHandler(this.UltraScanButton_Click);
            this.ultraScanButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UltraScanButton_MouseDown);
            this.ultraScanButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UltraScanButton_MouseUp);
            // 
            // buttonRobotScan
            // 
            this.buttonRobotScan.BackColor = System.Drawing.Color.Transparent;
            this.buttonRobotScan.Image = ((System.Drawing.Image)(resources.GetObject("buttonRobotScan.Image")));
            this.buttonRobotScan.Location = new System.Drawing.Point(768, 53);
            this.buttonRobotScan.Name = "buttonRobotScan";
            this.buttonRobotScan.Size = new System.Drawing.Size(128, 160);
            this.buttonRobotScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.buttonRobotScan.TabIndex = 64;
            this.buttonRobotScan.TabStop = false;
            this.buttonRobotScan.Click += new System.EventHandler(this.ProtoButtonRobotScan_Click);
            this.buttonRobotScan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProtoButtonRobotScan_MouseDown);
            this.buttonRobotScan.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProtoButtonRobotScan_MouseUp);
            // 
            // butManRev
            // 
            this.butManRev.BackColor = System.Drawing.Color.Transparent;
            this.butManRev.Image = ((System.Drawing.Image)(resources.GetObject("butManRev.Image")));
            this.butManRev.Location = new System.Drawing.Point(906, 99);
            this.butManRev.Name = "butManRev";
            this.butManRev.Size = new System.Drawing.Size(78, 90);
            this.butManRev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.butManRev.TabIndex = 65;
            this.butManRev.TabStop = false;
            this.butManRev.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProtoButManRev_MouseDown);
            this.butManRev.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProtoButManRev_MouseUp);
            // 
            // protoButManFwd
            // 
            this.protoButManFwd.BackColor = System.Drawing.Color.Transparent;
            this.protoButManFwd.Image = ((System.Drawing.Image)(resources.GetObject("protoButManFwd.Image")));
            this.protoButManFwd.Location = new System.Drawing.Point(1049, 99);
            this.protoButManFwd.Name = "protoButManFwd";
            this.protoButManFwd.Size = new System.Drawing.Size(78, 90);
            this.protoButManFwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.protoButManFwd.TabIndex = 66;
            this.protoButManFwd.TabStop = false;
            this.protoButManFwd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProtoButManFwd_MouseDown);
            this.protoButManFwd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProtoButManFwd_MouseUp);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.Transparent;
            this.buttonLoad.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoad.Image")));
            this.buttonLoad.Location = new System.Drawing.Point(768, 287);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(178, 70);
            this.buttonLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.buttonLoad.TabIndex = 67;
            this.buttonLoad.TabStop = false;
            this.buttonLoad.Click += new System.EventHandler(this.ProtoButtonLoad_Click);
            this.buttonLoad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProtoButtonLoad_MouseDown);
            this.buttonLoad.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProtoButtonLoad_MouseUp);
            // 
            // buttonSaveCine
            // 
            this.buttonSaveCine.BackColor = System.Drawing.Color.Transparent;
            this.buttonSaveCine.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveCine.Image")));
            this.buttonSaveCine.Location = new System.Drawing.Point(952, 287);
            this.buttonSaveCine.Name = "buttonSaveCine";
            this.buttonSaveCine.Size = new System.Drawing.Size(178, 70);
            this.buttonSaveCine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.buttonSaveCine.TabIndex = 68;
            this.buttonSaveCine.TabStop = false;
            this.buttonSaveCine.Click += new System.EventHandler(this.ProtoButtonSaveCine_Click);
            this.buttonSaveCine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProtoButtonSaveCine_MouseDown);
            this.buttonSaveCine.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProtoButtonSaveCine_MouseUp);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrevious.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrevious.Image")));
            this.buttonPrevious.Location = new System.Drawing.Point(768, 363);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(118, 70);
            this.buttonPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.buttonPrevious.TabIndex = 69;
            this.buttonPrevious.TabStop = false;
            this.buttonPrevious.Click += new System.EventHandler(this.ProtoButtonPrevious_Click);
            this.buttonPrevious.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProtoButtonPrevious_MouseDown);
            this.buttonPrevious.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProtoButtonPrevious_MouseUp);
            // 
            // buttonCine
            // 
            this.buttonCine.BackColor = System.Drawing.Color.Transparent;
            this.buttonCine.Image = ((System.Drawing.Image)(resources.GetObject("buttonCine.Image")));
            this.buttonCine.Location = new System.Drawing.Point(890, 363);
            this.buttonCine.Name = "buttonCine";
            this.buttonCine.Size = new System.Drawing.Size(118, 70);
            this.buttonCine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.buttonCine.TabIndex = 70;
            this.buttonCine.TabStop = false;
            this.buttonCine.Click += new System.EventHandler(this.ProtoButtonCine_Click);
            this.buttonCine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProtoButtonCine_MouseDown);
            this.buttonCine.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProtoButtonCine_MouseUp);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.Transparent;
            this.buttonNext.Image = ((System.Drawing.Image)(resources.GetObject("buttonNext.Image")));
            this.buttonNext.Location = new System.Drawing.Point(1012, 363);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(118, 70);
            this.buttonNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.buttonNext.TabIndex = 71;
            this.buttonNext.TabStop = false;
            this.buttonNext.Click += new System.EventHandler(this.ProtoButtonNext_Click);
            this.buttonNext.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProtoButtonNext_MouseDown);
            this.buttonNext.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProtoButtonNext_MouseUp);
            // 
            // robotStateIndicator
            // 
            this.robotStateIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(240)))));
            this.robotStateIndicator.Image = ((System.Drawing.Image)(resources.GetObject("robotStateIndicator.Image")));
            this.robotStateIndicator.Location = new System.Drawing.Point(779, 161);
            this.robotStateIndicator.Name = "robotStateIndicator";
            this.robotStateIndicator.Size = new System.Drawing.Size(38, 38);
            this.robotStateIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.robotStateIndicator.TabIndex = 78;
            this.robotStateIndicator.TabStop = false;
            // 
            // protoTBarTgc1
            // 
            this.protoTBarTgc1.BackColor = System.Drawing.Color.Transparent;
            this.protoTBarTgc1.Location = new System.Drawing.Point(767, 522);
            this.protoTBarTgc1.Maximum = 15;
            this.protoTBarTgc1.Minimum = -15;
            this.protoTBarTgc1.Name = "protoTBarTgc1";
            this.protoTBarTgc1.Size = new System.Drawing.Size(370, 45);
            this.protoTBarTgc1.TabIndex = 79;
            this.protoTBarTgc1.Scroll += new System.EventHandler(this.ProtoTBarTgc1_Scroll_1);
            // 
            // protoTBarTgc2
            // 
            this.protoTBarTgc2.BackColor = System.Drawing.Color.Transparent;
            this.protoTBarTgc2.Location = new System.Drawing.Point(767, 576);
            this.protoTBarTgc2.Maximum = 15;
            this.protoTBarTgc2.Minimum = -15;
            this.protoTBarTgc2.Name = "protoTBarTgc2";
            this.protoTBarTgc2.Size = new System.Drawing.Size(370, 45);
            this.protoTBarTgc2.TabIndex = 80;
            this.protoTBarTgc2.Scroll += new System.EventHandler(this.ProtoTBarTgc2_Scroll_1);
            // 
            // protoTBarTgc3
            // 
            this.protoTBarTgc3.BackColor = System.Drawing.Color.Transparent;
            this.protoTBarTgc3.Location = new System.Drawing.Point(767, 630);
            this.protoTBarTgc3.Maximum = 15;
            this.protoTBarTgc3.Minimum = -15;
            this.protoTBarTgc3.Name = "protoTBarTgc3";
            this.protoTBarTgc3.Size = new System.Drawing.Size(370, 45);
            this.protoTBarTgc3.TabIndex = 81;
            this.protoTBarTgc3.Scroll += new System.EventHandler(this.ProtoTBarTgc3_Scroll_1);
            // 
            // protoTrackBarRobotSpeed
            // 
            this.protoTrackBarRobotSpeed.BackColor = System.Drawing.Color.Transparent;
            this.protoTrackBarRobotSpeed.Location = new System.Drawing.Point(767, 217);
            this.protoTrackBarRobotSpeed.Maximum = 100;
            this.protoTrackBarRobotSpeed.Name = "protoTrackBarRobotSpeed";
            this.protoTrackBarRobotSpeed.Size = new System.Drawing.Size(370, 45);
            this.protoTrackBarRobotSpeed.TabIndex = 82;
            this.protoTrackBarRobotSpeed.TickFrequency = 5;
            this.protoTrackBarRobotSpeed.Scroll += new System.EventHandler(this.ProtoTrackBarRobotSpeed_Scroll);
            // 
            // protoTrackBarCine
            // 
            this.protoTrackBarCine.BackColor = System.Drawing.Color.Transparent;
            this.protoTrackBarCine.Location = new System.Drawing.Point(767, 436);
            this.protoTrackBarCine.Maximum = 512;
            this.protoTrackBarCine.Name = "protoTrackBarCine";
            this.protoTrackBarCine.Size = new System.Drawing.Size(370, 45);
            this.protoTrackBarCine.TabIndex = 83;
            this.protoTrackBarCine.Scroll += new System.EventHandler(this.ProtoTrackBarCine_Scroll);
            // 
            // labelRobotState
            // 
            this.labelRobotState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(240)))));
            this.labelRobotState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRobotState.ForeColor = System.Drawing.Color.White;
            this.labelRobotState.Location = new System.Drawing.Point(776, 109);
            this.labelRobotState.Name = "labelRobotState";
            this.labelRobotState.Size = new System.Drawing.Size(110, 40);
            this.labelRobotState.TabIndex = 84;
            this.labelRobotState.Text = "No Robot";
            this.labelRobotState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(903, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 85;
            this.label1.Text = "Image Control";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(986, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "Radius (cm)";
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.BackColor = System.Drawing.Color.Transparent;
            this.labelFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileName.ForeColor = System.Drawing.Color.White;
            this.labelFileName.Location = new System.Drawing.Point(208, 28);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(75, 16);
            this.labelFileName.TabIndex = 39;
            this.labelFileName.Text = "FileName";
            this.labelFileName.Visible = false;
            this.labelFileName.Click += new System.EventHandler(this.LabelFileName_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(63, 30);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(640, 480);
            this.axWindowsMediaPlayer1.TabIndex = 87;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // protoUCtrlPMDynamic
            // 
            this.protoUCtrlPMDynamic.BackColor = System.Drawing.Color.Transparent;
            this.protoUCtrlPMDynamic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("protoUCtrlPMDynamic.BackgroundImage")));
            this.protoUCtrlPMDynamic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.protoUCtrlPMDynamic.ForeColor = System.Drawing.Color.Black;
            this.protoUCtrlPMDynamic.Location = new System.Drawing.Point(628, 534);
            this.protoUCtrlPMDynamic.Margin = new System.Windows.Forms.Padding(0);
            this.protoUCtrlPMDynamic.Name = "protoUCtrlPMDynamic";
            this.protoUCtrlPMDynamic.Size = new System.Drawing.Size(75, 128);
            this.protoUCtrlPMDynamic.TabIndex = 77;
            // 
            // protoUCtrlPMGalGain
            // 
            this.protoUCtrlPMGalGain.BackColor = System.Drawing.Color.Transparent;
            this.protoUCtrlPMGalGain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("protoUCtrlPMGalGain.BackgroundImage")));
            this.protoUCtrlPMGalGain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.protoUCtrlPMGalGain.ForeColor = System.Drawing.Color.Black;
            this.protoUCtrlPMGalGain.Location = new System.Drawing.Point(548, 534);
            this.protoUCtrlPMGalGain.Margin = new System.Windows.Forms.Padding(0);
            this.protoUCtrlPMGalGain.Name = "protoUCtrlPMGalGain";
            this.protoUCtrlPMGalGain.Size = new System.Drawing.Size(75, 128);
            this.protoUCtrlPMGalGain.TabIndex = 76;
            // 
            // protoUCtrlPMHighVoltage
            // 
            this.protoUCtrlPMHighVoltage.BackColor = System.Drawing.Color.Transparent;
            this.protoUCtrlPMHighVoltage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("protoUCtrlPMHighVoltage.BackgroundImage")));
            this.protoUCtrlPMHighVoltage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.protoUCtrlPMHighVoltage.ForeColor = System.Drawing.Color.Black;
            this.protoUCtrlPMHighVoltage.Location = new System.Drawing.Point(468, 534);
            this.protoUCtrlPMHighVoltage.Margin = new System.Windows.Forms.Padding(0);
            this.protoUCtrlPMHighVoltage.Name = "protoUCtrlPMHighVoltage";
            this.protoUCtrlPMHighVoltage.Size = new System.Drawing.Size(75, 128);
            this.protoUCtrlPMHighVoltage.TabIndex = 75;
            // 
            // protoUCtrlPMFocus
            // 
            this.protoUCtrlPMFocus.BackColor = System.Drawing.Color.Transparent;
            this.protoUCtrlPMFocus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("protoUCtrlPMFocus.BackgroundImage")));
            this.protoUCtrlPMFocus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.protoUCtrlPMFocus.ForeColor = System.Drawing.Color.Black;
            this.protoUCtrlPMFocus.Location = new System.Drawing.Point(388, 534);
            this.protoUCtrlPMFocus.Margin = new System.Windows.Forms.Padding(0);
            this.protoUCtrlPMFocus.Name = "protoUCtrlPMFocus";
            this.protoUCtrlPMFocus.Size = new System.Drawing.Size(75, 128);
            this.protoUCtrlPMFocus.TabIndex = 74;
            // 
            // protoUCtrlPMFrequency
            // 
            this.protoUCtrlPMFrequency.BackColor = System.Drawing.Color.Transparent;
            this.protoUCtrlPMFrequency.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("protoUCtrlPMFrequency.BackgroundImage")));
            this.protoUCtrlPMFrequency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.protoUCtrlPMFrequency.ForeColor = System.Drawing.Color.Black;
            this.protoUCtrlPMFrequency.Location = new System.Drawing.Point(308, 534);
            this.protoUCtrlPMFrequency.Margin = new System.Windows.Forms.Padding(0);
            this.protoUCtrlPMFrequency.Name = "protoUCtrlPMFrequency";
            this.protoUCtrlPMFrequency.Size = new System.Drawing.Size(75, 128);
            this.protoUCtrlPMFrequency.TabIndex = 73;
            // 
            // protoUCtrlPMDepth
            // 
            this.protoUCtrlPMDepth.BackColor = System.Drawing.Color.Transparent;
            this.protoUCtrlPMDepth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("protoUCtrlPMDepth.BackgroundImage")));
            this.protoUCtrlPMDepth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.protoUCtrlPMDepth.ForeColor = System.Drawing.Color.Black;
            this.protoUCtrlPMDepth.Location = new System.Drawing.Point(228, 534);
            this.protoUCtrlPMDepth.Margin = new System.Windows.Forms.Padding(0);
            this.protoUCtrlPMDepth.Name = "protoUCtrlPMDepth";
            this.protoUCtrlPMDepth.Size = new System.Drawing.Size(75, 128);
            this.protoUCtrlPMDepth.TabIndex = 72;
            // 
            // userControlDepth1
            // 
            this.userControlDepth1.BackColor = System.Drawing.Color.White;
            this.userControlDepth1.Location = new System.Drawing.Point(566, 0);
            this.userControlDepth1.Name = "userControlDepth1";
            this.userControlDepth1.Size = new System.Drawing.Size(8, 8);
            this.userControlDepth1.TabIndex = 63;
            // 
            // uctrlGrayScale
            // 
            this.uctrlGrayScale.BackColor = System.Drawing.Color.Transparent;
            this.uctrlGrayScale.Enabled = false;
            this.uctrlGrayScale.Location = new System.Drawing.Point(577, 83);
            this.uctrlGrayScale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uctrlGrayScale.Name = "uctrlGrayScale";
            this.uctrlGrayScale.Size = new System.Drawing.Size(8, 512);
            this.uctrlGrayScale.TabIndex = 36;
            this.uctrlGrayScale.Visible = false;
            this.uctrlGrayScale.Paint += new System.Windows.Forms.PaintEventHandler(this.uctrlGrayScale_Paint);
            // 
            // uctrlScan
            // 
            this.uctrlScan.BackColor = System.Drawing.Color.Transparent;
            this.uctrlScan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uctrlScan.ForeColor = System.Drawing.Color.Transparent;
            this.uctrlScan.Location = new System.Drawing.Point(63, 30);
            this.uctrlScan.Name = "uctrlScan";
            this.uctrlScan.Size = new System.Drawing.Size(640, 480);
            this.uctrlScan.TabIndex = 9;
            this.uctrlScan.Visible = false;
            this.uctrlScan.Paint += new System.Windows.Forms.PaintEventHandler(this.uctrlScan_Paint);
            this.uctrlScan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uctrlScan_MouseClick);
            this.uctrlScan.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.uctrlScan_MouseDoubleClick);
            this.uctrlScan.MouseMove += new System.Windows.Forms.MouseEventHandler(this.uctrlScan_MouseMove);
            // 
            // uctrlDepth
            // 
            this.uctrlDepth.BackColor = System.Drawing.Color.Transparent;
            this.uctrlDepth.Location = new System.Drawing.Point(33, 73);
            this.uctrlDepth.Name = "uctrlDepth";
            this.uctrlDepth.Size = new System.Drawing.Size(30, 522);
            this.uctrlDepth.TabIndex = 13;
            this.uctrlDepth.Paint += new System.Windows.Forms.PaintEventHandler(this.uctrlDepth_Paint);
            // 
            // achillesToolStripMenuItem
            // 
            this.achillesToolStripMenuItem.Name = "achillesToolStripMenuItem";
            this.achillesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.achillesToolStripMenuItem.Text = "Achilles";
            // 
            // plantersToolStripMenuItem
            // 
            this.plantersToolStripMenuItem.Name = "plantersToolStripMenuItem";
            this.plantersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.plantersToolStripMenuItem.Text = "Planters";
            // 
            // saveLoadPresetsToolStripMenuItem
            // 
            this.saveLoadPresetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.saveLoadPresetsToolStripMenuItem.Name = "saveLoadPresetsToolStripMenuItem";
            this.saveLoadPresetsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveLoadPresetsToolStripMenuItem.Text = "Save/Load Presets";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // formScan2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1170, 701);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRobotState);
            this.Controls.Add(this.protoTrackBarCine);
            this.Controls.Add(this.protoTrackBarRobotSpeed);
            this.Controls.Add(this.protoTBarTgc3);
            this.Controls.Add(this.robotStateIndicator);
            this.Controls.Add(this.protoUCtrlPMDynamic);
            this.Controls.Add(this.protoUCtrlPMGalGain);
            this.Controls.Add(this.protoUCtrlPMHighVoltage);
            this.Controls.Add(this.protoUCtrlPMFocus);
            this.Controls.Add(this.protoUCtrlPMFrequency);
            this.Controls.Add(this.protoUCtrlPMDepth);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonCine);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonSaveCine);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.protoButManFwd);
            this.Controls.Add(this.butManRev);
            this.Controls.Add(this.buttonRobotScan);
            this.Controls.Add(this.userControlDepth1);
            this.Controls.Add(this.ultraScanButton);
            this.Controls.Add(this.labelRobotCtrls);
            this.Controls.Add(this.labelSaveReview);
            this.Controls.Add(this.labelImaging);
            this.Controls.Add(this.labelTgc);
            this.Controls.Add(this.textRadius);
            this.Controls.Add(this.butCfmMode);
            this.Controls.Add(this.labelFocus);
            this.Controls.Add(this.labelDynamic);
            this.Controls.Add(this.labelMainGain);
            this.Controls.Add(this.labelHighVolt);
            this.Controls.Add(this.labelRobotSpeed);
            this.Controls.Add(this.labelFrequency);
            this.Controls.Add(this.labelDepth);
            this.Controls.Add(this.labelTgc3);
            this.Controls.Add(this.labelTgc2);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelTgc1);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.uctrlGrayScale);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.uctrlScan);
            this.Controls.Add(this.protoTBarTgc1);
            this.Controls.Add(this.protoTBarTgc2);
            this.Controls.Add(this.uctrlDepth);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2046, 1272);
            this.MinimumSize = new System.Drawing.Size(510, 491);
            this.Name = "formScan2D";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SDK_Scan2D";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formScan2D_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formScan2D_FormClosed);
            this.Load += new System.EventHandler(this.formScan2D_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.formScan2D_Paint);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraScanButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRobotScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.butManRev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.protoButManFwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSaveCine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robotStateIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.protoTBarTgc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.protoTBarTgc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.protoTBarTgc3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.protoTrackBarRobotSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.protoTrackBarCine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlScan uctrlScan;
        private UserControlDepth uctrlDepth;
        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.Label labelFrequency;
        // private System.Windows.Forms.Label labelImagesPer;
        private System.Windows.Forms.Label labelMainGain;
        private System.Windows.Forms.Label labelHighVolt;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Label labelDynamic;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFpga;
        private System.Windows.Forms.Label labelTgc2;
        private System.Windows.Forms.Label labelTgc1;
        private System.Windows.Forms.Label labelTgc3;
        private UserControlGrayScale uctrlGrayScale;
        // public System.Windows.Forms.Button buttonProbe1;
        private System.Windows.Forms.Label labelFocus;
        // private UserControlPlusMinus uctrlPMSteering;
        // public System.Windows.Forms.Button butRFMode;
        public System.Windows.Forms.Button butCfmMode;
        private System.Windows.Forms.Label labelRobotSpeed;
        public System.Windows.Forms.Button buttonProbe2; //not used
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.TextBox textRadius;
        private System.Windows.Forms.Label labelTgc;
        private System.Windows.Forms.Label labelImaging;
        private System.Windows.Forms.Label labelSaveReview;
        private System.Windows.Forms.Label labelRobotCtrls;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem menuSave;
        private ToolStripMenuItem menuLoad;
        private ToolStripMenuItem menuSaveScreenshot;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem menuCompound;
        private ToolStripMenuItem menuDoubler;
        private PictureBox ultraScanButton;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem menuWebsite;
        private PictureBox buttonRobotScan;
        private PictureBox butManRev;
        private PictureBox protoButManFwd;
        private PictureBox buttonLoad;
        private PictureBox buttonSaveCine;
        protected PictureBox buttonPrevious;
        private PictureBox buttonCine;
        private PictureBox buttonNext;
        private UserControlDepth userControlDepth1;
        private UserControlPlusMinus protoUCtrlPMDepth;
        private UserControlPlusMinus protoUCtrlPMFrequency;
        private UserControlPlusMinus protoUCtrlPMFocus;
        private UserControlPlusMinus protoUCtrlPMHighVoltage;
        private UserControlPlusMinus protoUCtrlPMGalGain;
        private UserControlPlusMinus protoUCtrlPMDynamic;
        private ToolStripMenuItem referenceImagesToolStripMenuItem;
        private ToolStripMenuItem ankleToolStripMenuItem;
        private PictureBox robotStateIndicator;
        private TrackBar.Dotnetrix.Controls.TrackBar protoTBarTgc1;
        private TrackBar.Dotnetrix.Controls.TrackBar protoTBarTgc2;
        private TrackBar.Dotnetrix.Controls.TrackBar protoTBarTgc3;
        private TrackBar.Dotnetrix.Controls.TrackBar protoTrackBarRobotSpeed;
        private TrackBar.Dotnetrix.Controls.TrackBar protoTrackBarCine;
        private Label labelRobotState;
        private Label label1;
        private Label label2;
        private Label labelFileName;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private ToolStripMenuItem kneeToolStripMenuItem;
        private ToolStripMenuItem elbowToolStripMenuItem;
        private ToolStripMenuItem presetsToolStripMenuItem;
        private ToolStripMenuItem maxedToolStripMenuItem;
        private ToolStripMenuItem achillesToolStripMenuItem;
        private ToolStripMenuItem plantersToolStripMenuItem;
        private ToolStripMenuItem saveLoadPresetsToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
    }
}

