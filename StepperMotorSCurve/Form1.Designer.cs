﻿namespace StepperMotorSCurve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.Main = new System.Windows.Forms.TabPage();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExcelDataOutput = new System.Windows.Forms.Button();
            this.groupBoxAccelerationMode = new System.Windows.Forms.GroupBox();
            this.radioButtonSinewave = new System.Windows.Forms.RadioButton();
            this.radioButtonTriangle = new System.Windows.Forms.RadioButton();
            this.buttonCalcuDraw = new System.Windows.Forms.Button();
            this.textBoxStageNum = new System.Windows.Forms.TextBox();
            this.textBoxAngularVelocity = new System.Windows.Forms.TextBox();
            this.textBoxAccelerationSlope = new System.Windows.Forms.TextBox();
            this.textBoxSpeedRiseTime = new System.Windows.Forms.TextBox();
            this.textBoxPWMRolloverMax = new System.Windows.Forms.TextBox();
            this.textBoxPWMRolloverInit = new System.Windows.Forms.TextBox();
            this.textBoxMachineCycle = new System.Windows.Forms.TextBox();
            this.textBoxMachineCycleDivision = new System.Windows.Forms.TextBox();
            this.textBoxCrystalCycle = new System.Windows.Forms.TextBox();
            this.textBoxCrystalFrequency = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxSCurve = new System.Windows.Forms.PictureBox();
            this.Output = new System.Windows.Forms.TabPage();
            this.splitContainerDataOutput = new System.Windows.Forms.SplitContainer();
            this.dataGridViewOutput = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acceleration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PWMCycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PWMCycleVariation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainerDataOutput2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDataOutputPWMCycleChange = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxDataOutputMainRightR = new System.Windows.Forms.TextBox();
            this.dataAnalysis = new System.Windows.Forms.TabPage();
            this.splitContainerDataAnalyse = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDataAnalyseRefresh = new System.Windows.Forms.Button();
            this.buttonDataAnalyseProcess = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonDataAnalyseLoad = new System.Windows.Forms.Button();
            this.pictureBoxDataAnalyse = new System.Windows.Forms.PictureBox();
            this.Help = new System.Windows.Forms.TabPage();
            this.textBoxHelp = new System.Windows.Forms.TextBox();
            this.textBoxDataAnalyse = new System.Windows.Forms.TextBox();
            this.tabControlMain.SuspendLayout();
            this.Main.SuspendLayout();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxAccelerationMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSCurve)).BeginInit();
            this.Output.SuspendLayout();
            this.splitContainerDataOutput.Panel1.SuspendLayout();
            this.splitContainerDataOutput.Panel2.SuspendLayout();
            this.splitContainerDataOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput)).BeginInit();
            this.splitContainerDataOutput2.Panel1.SuspendLayout();
            this.splitContainerDataOutput2.Panel2.SuspendLayout();
            this.splitContainerDataOutput2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.dataAnalysis.SuspendLayout();
            this.splitContainerDataAnalyse.Panel1.SuspendLayout();
            this.splitContainerDataAnalyse.Panel2.SuspendLayout();
            this.splitContainerDataAnalyse.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDataAnalyse)).BeginInit();
            this.Help.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.Main);
            this.tabControlMain.Controls.Add(this.Output);
            this.tabControlMain.Controls.Add(this.dataAnalysis);
            this.tabControlMain.Controls.Add(this.Help);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(882, 583);
            this.tabControlMain.TabIndex = 0;
            // 
            // Main
            // 
            this.Main.Controls.Add(this.splitContainerMain);
            this.Main.Location = new System.Drawing.Point(4, 25);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(3);
            this.Main.Size = new System.Drawing.Size(874, 554);
            this.Main.TabIndex = 0;
            this.Main.Text = "主界面";
            this.Main.UseVisualStyleBackColor = true;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(3, 3);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.panel1);
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxStageNum);
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxAngularVelocity);
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxAccelerationSlope);
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxSpeedRiseTime);
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxPWMRolloverMax);
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxPWMRolloverInit);
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxMachineCycle);
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxMachineCycleDivision);
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxCrystalCycle);
            this.splitContainerMain.Panel1.Controls.Add(this.textBoxCrystalFrequency);
            this.splitContainerMain.Panel1.Controls.Add(this.label11);
            this.splitContainerMain.Panel1.Controls.Add(this.label10);
            this.splitContainerMain.Panel1.Controls.Add(this.label9);
            this.splitContainerMain.Panel1.Controls.Add(this.label8);
            this.splitContainerMain.Panel1.Controls.Add(this.label7);
            this.splitContainerMain.Panel1.Controls.Add(this.label6);
            this.splitContainerMain.Panel1.Controls.Add(this.label5);
            this.splitContainerMain.Panel1.Controls.Add(this.label4);
            this.splitContainerMain.Panel1.Controls.Add(this.label3);
            this.splitContainerMain.Panel1.Controls.Add(this.label2);
            this.splitContainerMain.Panel1.Controls.Add(this.label1);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerMain.Panel2.Controls.Add(this.pictureBoxSCurve);
            this.splitContainerMain.Size = new System.Drawing.Size(868, 548);
            this.splitContainerMain.SplitterDistance = 320;
            this.splitContainerMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonExcelDataOutput);
            this.panel1.Controls.Add(this.groupBoxAccelerationMode);
            this.panel1.Controls.Add(this.buttonCalcuDraw);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 123);
            this.panel1.TabIndex = 25;
            // 
            // buttonExcelDataOutput
            // 
            this.buttonExcelDataOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcelDataOutput.Location = new System.Drawing.Point(160, 70);
            this.buttonExcelDataOutput.Name = "buttonExcelDataOutput";
            this.buttonExcelDataOutput.Size = new System.Drawing.Size(141, 38);
            this.buttonExcelDataOutput.TabIndex = 14;
            this.buttonExcelDataOutput.Text = "Excel数据输出";
            this.buttonExcelDataOutput.UseVisualStyleBackColor = true;
            this.buttonExcelDataOutput.Click += new System.EventHandler(this.buttonExcelDataOutput_Click);
            // 
            // groupBoxAccelerationMode
            // 
            this.groupBoxAccelerationMode.Controls.Add(this.radioButtonSinewave);
            this.groupBoxAccelerationMode.Controls.Add(this.radioButtonTriangle);
            this.groupBoxAccelerationMode.Location = new System.Drawing.Point(13, 11);
            this.groupBoxAccelerationMode.Name = "groupBoxAccelerationMode";
            this.groupBoxAccelerationMode.Size = new System.Drawing.Size(125, 100);
            this.groupBoxAccelerationMode.TabIndex = 11;
            this.groupBoxAccelerationMode.TabStop = false;
            this.groupBoxAccelerationMode.Text = "加速度模式";
            // 
            // radioButtonSinewave
            // 
            this.radioButtonSinewave.AutoSize = true;
            this.radioButtonSinewave.Location = new System.Drawing.Point(14, 62);
            this.radioButtonSinewave.Name = "radioButtonSinewave";
            this.radioButtonSinewave.Size = new System.Drawing.Size(71, 21);
            this.radioButtonSinewave.TabIndex = 1;
            this.radioButtonSinewave.Text = "正弦波";
            this.radioButtonSinewave.UseVisualStyleBackColor = true;
            this.radioButtonSinewave.CheckedChanged += new System.EventHandler(this.radioButtonSinewave_CheckedChanged);
            // 
            // radioButtonTriangle
            // 
            this.radioButtonTriangle.AutoSize = true;
            this.radioButtonTriangle.Checked = true;
            this.radioButtonTriangle.Location = new System.Drawing.Point(14, 29);
            this.radioButtonTriangle.Name = "radioButtonTriangle";
            this.radioButtonTriangle.Size = new System.Drawing.Size(71, 21);
            this.radioButtonTriangle.TabIndex = 0;
            this.radioButtonTriangle.TabStop = true;
            this.radioButtonTriangle.Text = "三角形";
            this.radioButtonTriangle.UseVisualStyleBackColor = true;
            this.radioButtonTriangle.CheckedChanged += new System.EventHandler(this.radioButtonTriangle_CheckedChanged);
            // 
            // buttonCalcuDraw
            // 
            this.buttonCalcuDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalcuDraw.Location = new System.Drawing.Point(160, 14);
            this.buttonCalcuDraw.Name = "buttonCalcuDraw";
            this.buttonCalcuDraw.Size = new System.Drawing.Size(141, 38);
            this.buttonCalcuDraw.TabIndex = 12;
            this.buttonCalcuDraw.Text = "计算及绘图";
            this.buttonCalcuDraw.UseVisualStyleBackColor = true;
            this.buttonCalcuDraw.Click += new System.EventHandler(this.buttonCalcuDraw_Click);
            // 
            // textBoxStageNum
            // 
            this.textBoxStageNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStageNum.Location = new System.Drawing.Point(123, 359);
            this.textBoxStageNum.Name = "textBoxStageNum";
            this.textBoxStageNum.Size = new System.Drawing.Size(176, 22);
            this.textBoxStageNum.TabIndex = 24;
            this.textBoxStageNum.Text = "100";
            this.textBoxStageNum.TextChanged += new System.EventHandler(this.textBoxStageNum_TextChanged);
            // 
            // textBoxAngularVelocity
            // 
            this.textBoxAngularVelocity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAngularVelocity.ForeColor = System.Drawing.Color.Red;
            this.textBoxAngularVelocity.Location = new System.Drawing.Point(123, 329);
            this.textBoxAngularVelocity.Name = "textBoxAngularVelocity";
            this.textBoxAngularVelocity.ReadOnly = true;
            this.textBoxAngularVelocity.Size = new System.Drawing.Size(176, 22);
            this.textBoxAngularVelocity.TabIndex = 23;
            this.textBoxAngularVelocity.Text = "1";
            // 
            // textBoxAccelerationSlope
            // 
            this.textBoxAccelerationSlope.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAccelerationSlope.ForeColor = System.Drawing.Color.Red;
            this.textBoxAccelerationSlope.Location = new System.Drawing.Point(123, 299);
            this.textBoxAccelerationSlope.Name = "textBoxAccelerationSlope";
            this.textBoxAccelerationSlope.ReadOnly = true;
            this.textBoxAccelerationSlope.Size = new System.Drawing.Size(176, 22);
            this.textBoxAccelerationSlope.TabIndex = 22;
            this.textBoxAccelerationSlope.Text = "0.15";
            // 
            // textBoxSpeedRiseTime
            // 
            this.textBoxSpeedRiseTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSpeedRiseTime.Location = new System.Drawing.Point(123, 269);
            this.textBoxSpeedRiseTime.Name = "textBoxSpeedRiseTime";
            this.textBoxSpeedRiseTime.Size = new System.Drawing.Size(176, 22);
            this.textBoxSpeedRiseTime.TabIndex = 21;
            this.textBoxSpeedRiseTime.Text = "200";
            this.textBoxSpeedRiseTime.TextChanged += new System.EventHandler(this.textBoxSpeedRiseTime_TextChanged);
            // 
            // textBoxPWMRolloverMax
            // 
            this.textBoxPWMRolloverMax.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPWMRolloverMax.Location = new System.Drawing.Point(123, 214);
            this.textBoxPWMRolloverMax.Name = "textBoxPWMRolloverMax";
            this.textBoxPWMRolloverMax.Size = new System.Drawing.Size(176, 22);
            this.textBoxPWMRolloverMax.TabIndex = 20;
            this.textBoxPWMRolloverMax.Text = "600";
            this.textBoxPWMRolloverMax.TextChanged += new System.EventHandler(this.textBoxPWMRolloverMax_TextChanged);
            // 
            // textBoxPWMRolloverInit
            // 
            this.textBoxPWMRolloverInit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPWMRolloverInit.Location = new System.Drawing.Point(123, 159);
            this.textBoxPWMRolloverInit.Name = "textBoxPWMRolloverInit";
            this.textBoxPWMRolloverInit.Size = new System.Drawing.Size(176, 22);
            this.textBoxPWMRolloverInit.TabIndex = 19;
            this.textBoxPWMRolloverInit.Text = "6000";
            this.textBoxPWMRolloverInit.TextChanged += new System.EventHandler(this.textBoxPWMRolloverInit_TextChanged);
            // 
            // textBoxMachineCycle
            // 
            this.textBoxMachineCycle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMachineCycle.ForeColor = System.Drawing.Color.Red;
            this.textBoxMachineCycle.Location = new System.Drawing.Point(123, 104);
            this.textBoxMachineCycle.Name = "textBoxMachineCycle";
            this.textBoxMachineCycle.ReadOnly = true;
            this.textBoxMachineCycle.Size = new System.Drawing.Size(176, 22);
            this.textBoxMachineCycle.TabIndex = 18;
            this.textBoxMachineCycle.Text = "1.25E-07";
            // 
            // textBoxMachineCycleDivision
            // 
            this.textBoxMachineCycleDivision.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMachineCycleDivision.Location = new System.Drawing.Point(123, 74);
            this.textBoxMachineCycleDivision.Name = "textBoxMachineCycleDivision";
            this.textBoxMachineCycleDivision.Size = new System.Drawing.Size(176, 22);
            this.textBoxMachineCycleDivision.TabIndex = 17;
            this.textBoxMachineCycleDivision.Text = "1";
            this.textBoxMachineCycleDivision.TextChanged += new System.EventHandler(this.textBoxMachineCycleDivision_TextChanged);
            // 
            // textBoxCrystalCycle
            // 
            this.textBoxCrystalCycle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCrystalCycle.ForeColor = System.Drawing.Color.Red;
            this.textBoxCrystalCycle.Location = new System.Drawing.Point(123, 44);
            this.textBoxCrystalCycle.Name = "textBoxCrystalCycle";
            this.textBoxCrystalCycle.ReadOnly = true;
            this.textBoxCrystalCycle.Size = new System.Drawing.Size(176, 22);
            this.textBoxCrystalCycle.TabIndex = 16;
            this.textBoxCrystalCycle.Text = "1.25E-07";
            // 
            // textBoxCrystalFrequency
            // 
            this.textBoxCrystalFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCrystalFrequency.Location = new System.Drawing.Point(123, 14);
            this.textBoxCrystalFrequency.Name = "textBoxCrystalFrequency";
            this.textBoxCrystalFrequency.Size = new System.Drawing.Size(176, 22);
            this.textBoxCrystalFrequency.TabIndex = 15;
            this.textBoxCrystalFrequency.Text = "8000000";
            this.textBoxCrystalFrequency.TextChanged += new System.EventHandler(this.textBoxCrystalFrequency_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(5, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(230, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "注：每个阶段内部的PWM增量都相同";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(5, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "总阶段数:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "角速度:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "加速度斜率:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "S曲线半周期/速度上升期（毫秒）:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "最高速时PWM翻转周期（机器周期倍数）:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "PWM翻转周期初始值（机器周期倍数）:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "机器周期（秒）:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "机器周期分频:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "晶振周期（秒）:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "晶振频率（HZ）:";
            // 
            // pictureBoxSCurve
            // 
            this.pictureBoxSCurve.BackColor = System.Drawing.Color.White;
            this.pictureBoxSCurve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSCurve.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSCurve.Name = "pictureBoxSCurve";
            this.pictureBoxSCurve.Size = new System.Drawing.Size(544, 548);
            this.pictureBoxSCurve.TabIndex = 0;
            this.pictureBoxSCurve.TabStop = false;
            // 
            // Output
            // 
            this.Output.Controls.Add(this.splitContainerDataOutput);
            this.Output.Location = new System.Drawing.Point(4, 25);
            this.Output.Name = "Output";
            this.Output.Padding = new System.Windows.Forms.Padding(3);
            this.Output.Size = new System.Drawing.Size(874, 554);
            this.Output.TabIndex = 1;
            this.Output.Text = "输出数据";
            this.Output.UseVisualStyleBackColor = true;
            // 
            // splitContainerDataOutput
            // 
            this.splitContainerDataOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDataOutput.Location = new System.Drawing.Point(3, 3);
            this.splitContainerDataOutput.Name = "splitContainerDataOutput";
            // 
            // splitContainerDataOutput.Panel1
            // 
            this.splitContainerDataOutput.Panel1.Controls.Add(this.dataGridViewOutput);
            // 
            // splitContainerDataOutput.Panel2
            // 
            this.splitContainerDataOutput.Panel2.Controls.Add(this.splitContainerDataOutput2);
            this.splitContainerDataOutput.Size = new System.Drawing.Size(868, 548);
            this.splitContainerDataOutput.SplitterDistance = 567;
            this.splitContainerDataOutput.TabIndex = 0;
            // 
            // dataGridViewOutput
            // 
            this.dataGridViewOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Acceleration,
            this.Speed,
            this.PWMCycle,
            this.PWMCycleVariation});
            this.dataGridViewOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutput.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOutput.Name = "dataGridViewOutput";
            this.dataGridViewOutput.RowTemplate.Height = 24;
            this.dataGridViewOutput.Size = new System.Drawing.Size(567, 548);
            this.dataGridViewOutput.TabIndex = 0;
            this.dataGridViewOutput.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewOutput_RowPostPaint);
            // 
            // Time
            // 
            this.Time.HeaderText = "时间";
            this.Time.Name = "Time";
            // 
            // Acceleration
            // 
            this.Acceleration.HeaderText = "加速度";
            this.Acceleration.Name = "Acceleration";
            // 
            // Speed
            // 
            this.Speed.HeaderText = "速度";
            this.Speed.Name = "Speed";
            // 
            // PWMCycle
            // 
            this.PWMCycle.HeaderText = "PWM周期";
            this.PWMCycle.Name = "PWMCycle";
            // 
            // PWMCycleVariation
            // 
            this.PWMCycleVariation.HeaderText = "PWM周期变化量";
            this.PWMCycleVariation.Name = "PWMCycleVariation";
            this.PWMCycleVariation.Width = 140;
            // 
            // splitContainerDataOutput2
            // 
            this.splitContainerDataOutput2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDataOutput2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerDataOutput2.Name = "splitContainerDataOutput2";
            // 
            // splitContainerDataOutput2.Panel1
            // 
            this.splitContainerDataOutput2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainerDataOutput2.Panel2
            // 
            this.splitContainerDataOutput2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainerDataOutput2.Size = new System.Drawing.Size(297, 548);
            this.splitContainerDataOutput2.SplitterDistance = 148;
            this.splitContainerDataOutput2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDataOutputPWMCycleChange);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 548);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PWM周期变化量";
            // 
            // textBoxDataOutputPWMCycleChange
            // 
            this.textBoxDataOutputPWMCycleChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDataOutputPWMCycleChange.Location = new System.Drawing.Point(3, 18);
            this.textBoxDataOutputPWMCycleChange.Multiline = true;
            this.textBoxDataOutputPWMCycleChange.Name = "textBoxDataOutputPWMCycleChange";
            this.textBoxDataOutputPWMCycleChange.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDataOutputPWMCycleChange.Size = new System.Drawing.Size(142, 527);
            this.textBoxDataOutputPWMCycleChange.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxDataOutputMainRightR);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 548);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // textBoxDataOutputMainRightR
            // 
            this.textBoxDataOutputMainRightR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDataOutputMainRightR.Location = new System.Drawing.Point(3, 18);
            this.textBoxDataOutputMainRightR.Multiline = true;
            this.textBoxDataOutputMainRightR.Name = "textBoxDataOutputMainRightR";
            this.textBoxDataOutputMainRightR.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDataOutputMainRightR.Size = new System.Drawing.Size(139, 527);
            this.textBoxDataOutputMainRightR.TabIndex = 1;
            // 
            // dataAnalysis
            // 
            this.dataAnalysis.Controls.Add(this.splitContainerDataAnalyse);
            this.dataAnalysis.Location = new System.Drawing.Point(4, 25);
            this.dataAnalysis.Name = "dataAnalysis";
            this.dataAnalysis.Padding = new System.Windows.Forms.Padding(3);
            this.dataAnalysis.Size = new System.Drawing.Size(874, 554);
            this.dataAnalysis.TabIndex = 3;
            this.dataAnalysis.Text = "数据分析";
            this.dataAnalysis.UseVisualStyleBackColor = true;
            // 
            // splitContainerDataAnalyse
            // 
            this.splitContainerDataAnalyse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDataAnalyse.Location = new System.Drawing.Point(3, 3);
            this.splitContainerDataAnalyse.Name = "splitContainerDataAnalyse";
            // 
            // splitContainerDataAnalyse.Panel1
            // 
            this.splitContainerDataAnalyse.Panel1.Controls.Add(this.groupBox3);
            this.splitContainerDataAnalyse.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainerDataAnalyse.Panel2
            // 
            this.splitContainerDataAnalyse.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainerDataAnalyse.Panel2.Controls.Add(this.pictureBoxDataAnalyse);
            this.splitContainerDataAnalyse.Size = new System.Drawing.Size(868, 548);
            this.splitContainerDataAnalyse.SplitterDistance = 271;
            this.splitContainerDataAnalyse.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxDataAnalyse);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 425);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据预览";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonDataAnalyseRefresh);
            this.panel2.Controls.Add(this.buttonDataAnalyseProcess);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.buttonDataAnalyseLoad);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 425);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 123);
            this.panel2.TabIndex = 25;
            // 
            // buttonDataAnalyseRefresh
            // 
            this.buttonDataAnalyseRefresh.Location = new System.Drawing.Point(20, 52);
            this.buttonDataAnalyseRefresh.Name = "buttonDataAnalyseRefresh";
            this.buttonDataAnalyseRefresh.Size = new System.Drawing.Size(112, 38);
            this.buttonDataAnalyseRefresh.TabIndex = 15;
            this.buttonDataAnalyseRefresh.Text = "刷新数据";
            this.buttonDataAnalyseRefresh.UseVisualStyleBackColor = true;
            this.buttonDataAnalyseRefresh.Click += new System.EventHandler(this.buttonDataAnalyseRefresh_Click);
            // 
            // buttonDataAnalyseProcess
            // 
            this.buttonDataAnalyseProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDataAnalyseProcess.Location = new System.Drawing.Point(155, 8);
            this.buttonDataAnalyseProcess.Name = "buttonDataAnalyseProcess";
            this.buttonDataAnalyseProcess.Size = new System.Drawing.Size(97, 82);
            this.buttonDataAnalyseProcess.TabIndex = 14;
            this.buttonDataAnalyseProcess.Text = "绘制图形";
            this.buttonDataAnalyseProcess.UseVisualStyleBackColor = true;
            this.buttonDataAnalyseProcess.Click += new System.EventHandler(this.buttonDataAnalyseProcess_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(22, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(230, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "注：支持saleae logic单通道导出数据";
            // 
            // buttonDataAnalyseLoad
            // 
            this.buttonDataAnalyseLoad.Location = new System.Drawing.Point(20, 8);
            this.buttonDataAnalyseLoad.Name = "buttonDataAnalyseLoad";
            this.buttonDataAnalyseLoad.Size = new System.Drawing.Size(112, 38);
            this.buttonDataAnalyseLoad.TabIndex = 12;
            this.buttonDataAnalyseLoad.Text = "加载数据";
            this.buttonDataAnalyseLoad.UseVisualStyleBackColor = true;
            this.buttonDataAnalyseLoad.Click += new System.EventHandler(this.buttonDataAnalyseLoad_Click);
            // 
            // pictureBoxDataAnalyse
            // 
            this.pictureBoxDataAnalyse.BackColor = System.Drawing.Color.White;
            this.pictureBoxDataAnalyse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxDataAnalyse.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDataAnalyse.Name = "pictureBoxDataAnalyse";
            this.pictureBoxDataAnalyse.Size = new System.Drawing.Size(593, 548);
            this.pictureBoxDataAnalyse.TabIndex = 0;
            this.pictureBoxDataAnalyse.TabStop = false;
            // 
            // Help
            // 
            this.Help.Controls.Add(this.textBoxHelp);
            this.Help.Location = new System.Drawing.Point(4, 25);
            this.Help.Name = "Help";
            this.Help.Padding = new System.Windows.Forms.Padding(3);
            this.Help.Size = new System.Drawing.Size(874, 554);
            this.Help.TabIndex = 2;
            this.Help.Text = "版本及说明";
            this.Help.UseVisualStyleBackColor = true;
            // 
            // textBoxHelp
            // 
            this.textBoxHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHelp.Location = new System.Drawing.Point(3, 3);
            this.textBoxHelp.Multiline = true;
            this.textBoxHelp.Name = "textBoxHelp";
            this.textBoxHelp.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxHelp.Size = new System.Drawing.Size(868, 548);
            this.textBoxHelp.TabIndex = 1;
            this.textBoxHelp.Text = resources.GetString("textBoxHelp.Text");
            // 
            // textBoxDataAnalyse
            // 
            this.textBoxDataAnalyse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDataAnalyse.Location = new System.Drawing.Point(3, 18);
            this.textBoxDataAnalyse.Multiline = true;
            this.textBoxDataAnalyse.Name = "textBoxDataAnalyse";
            this.textBoxDataAnalyse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDataAnalyse.Size = new System.Drawing.Size(265, 404);
            this.textBoxDataAnalyse.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 583);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "步进电机S曲线生成工具";
            this.tabControlMain.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBoxAccelerationMode.ResumeLayout(false);
            this.groupBoxAccelerationMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSCurve)).EndInit();
            this.Output.ResumeLayout(false);
            this.splitContainerDataOutput.Panel1.ResumeLayout(false);
            this.splitContainerDataOutput.Panel2.ResumeLayout(false);
            this.splitContainerDataOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput)).EndInit();
            this.splitContainerDataOutput2.Panel1.ResumeLayout(false);
            this.splitContainerDataOutput2.Panel2.ResumeLayout(false);
            this.splitContainerDataOutput2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.dataAnalysis.ResumeLayout(false);
            this.splitContainerDataAnalyse.Panel1.ResumeLayout(false);
            this.splitContainerDataAnalyse.Panel2.ResumeLayout(false);
            this.splitContainerDataAnalyse.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDataAnalyse)).EndInit();
            this.Help.ResumeLayout(false);
            this.Help.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage Main;
        private System.Windows.Forms.TabPage Output;
        private System.Windows.Forms.TabPage Help;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.PictureBox pictureBoxSCurve;
        private System.Windows.Forms.TextBox textBoxStageNum;
        private System.Windows.Forms.TextBox textBoxAngularVelocity;
        private System.Windows.Forms.TextBox textBoxAccelerationSlope;
        private System.Windows.Forms.TextBox textBoxSpeedRiseTime;
        private System.Windows.Forms.TextBox textBoxPWMRolloverMax;
        private System.Windows.Forms.TextBox textBoxPWMRolloverInit;
        private System.Windows.Forms.TextBox textBoxMachineCycle;
        private System.Windows.Forms.TextBox textBoxMachineCycleDivision;
        private System.Windows.Forms.TextBox textBoxCrystalCycle;
        private System.Windows.Forms.TextBox textBoxCrystalFrequency;
        private System.Windows.Forms.Button buttonExcelDataOutput;
        private System.Windows.Forms.Button buttonCalcuDraw;
        private System.Windows.Forms.GroupBox groupBoxAccelerationMode;
        private System.Windows.Forms.RadioButton radioButtonSinewave;
        private System.Windows.Forms.RadioButton radioButtonTriangle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainerDataOutput;
        private System.Windows.Forms.SplitContainer splitContainerDataOutput2;
        private System.Windows.Forms.TextBox textBoxDataOutputPWMCycleChange;
        private System.Windows.Forms.TextBox textBoxDataOutputMainRightR;
        private System.Windows.Forms.TextBox textBoxHelp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acceleration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn PWMCycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn PWMCycleVariation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage dataAnalysis;
        private System.Windows.Forms.SplitContainer splitContainerDataAnalyse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonDataAnalyseProcess;
        private System.Windows.Forms.Button buttonDataAnalyseLoad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBoxDataAnalyse;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonDataAnalyseRefresh;
        private System.Windows.Forms.TextBox textBoxDataAnalyse;
    }
}

