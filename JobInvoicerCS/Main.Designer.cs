using System;

namespace JobInvoicerCS
{
    sealed partial class MainForm
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
            this.OpenFileDiag = new System.Windows.Forms.OpenFileDialog();
            this.DataColumn7 = new System.Data.DataColumn();
            this.dtMedium = new System.Data.DataTable();
            this.DataColumn8 = new System.Data.DataColumn();
            this.DataColumn6 = new System.Data.DataColumn();
            this.DataColumn5 = new System.Data.DataColumn();
            this.dtLight = new System.Data.DataTable();
            this.DataColumn4 = new System.Data.DataColumn();
            this.gbxStructure = new System.Windows.Forms.GroupBox();
            this.nXXXHeavyMin = new System.Windows.Forms.NumericUpDown();
            this.cbXXXHeavy = new System.Windows.Forms.CheckBox();
            this.nXXHeavyMax = new System.Windows.Forms.NumericUpDown();
            this.lblMaximum = new System.Windows.Forms.Label();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.cbXLight = new System.Windows.Forms.CheckBox();
            this.nXLightMax = new System.Windows.Forms.NumericUpDown();
            this.cbLight = new System.Windows.Forms.CheckBox();
            this.nLightMin = new System.Windows.Forms.NumericUpDown();
            this.nLightMax = new System.Windows.Forms.NumericUpDown();
            this.cbMedium = new System.Windows.Forms.CheckBox();
            this.nMediumMin = new System.Windows.Forms.NumericUpDown();
            this.nMediumMax = new System.Windows.Forms.NumericUpDown();
            this.cbHeavy = new System.Windows.Forms.CheckBox();
            this.nHeavyMin = new System.Windows.Forms.NumericUpDown();
            this.nXXHeavyMin = new System.Windows.Forms.NumericUpDown();
            this.nHeavyMax = new System.Windows.Forms.NumericUpDown();
            this.cbXXHeavy = new System.Windows.Forms.CheckBox();
            this.cbXHeavy = new System.Windows.Forms.CheckBox();
            this.nXHeavyMax = new System.Windows.Forms.NumericUpDown();
            this.nXHeavyMin = new System.Windows.Forms.NumericUpDown();
            this.DataColumn3 = new System.Data.DataColumn();
            this.dtExtraLight = new System.Data.DataTable();
            this.DataColumn2 = new System.Data.DataColumn();
            this.DataColumn1 = new System.Data.DataColumn();
            this.dtJob = new System.Data.DataTable();
            this.gbxMiscellaneous = new System.Windows.Forms.GroupBox();
            this.cbSafetyGate = new System.Windows.Forms.CheckBox();
            this.cbFrame = new System.Windows.Forms.CheckBox();
            this.cbStair = new System.Windows.Forms.CheckBox();
            this.cbFloorPlate = new System.Windows.Forms.CheckBox();
            this.cbStairRail = new System.Windows.Forms.CheckBox();
            this.cbCagedLadder = new System.Windows.Forms.CheckBox();
            this.cbHandrail = new System.Windows.Forms.CheckBox();
            this.cbLadder = new System.Windows.Forms.CheckBox();
            this.dsInvoice = new System.Data.DataSet();
            this.dtHeavy = new System.Data.DataTable();
            this.DataColumn9 = new System.Data.DataColumn();
            this.DataColumn10 = new System.Data.DataColumn();
            this.dtXHeavy = new System.Data.DataTable();
            this.DataColumn11 = new System.Data.DataColumn();
            this.DataColumn12 = new System.Data.DataColumn();
            this.dtXXHeavy = new System.Data.DataTable();
            this.dtXXXHeavy = new System.Data.DataTable();
            this.dtFrame = new System.Data.DataTable();
            this.dtStair = new System.Data.DataTable();
            this.dtStairRail = new System.Data.DataTable();
            this.dtHandrail = new System.Data.DataTable();
            this.dtLadder = new System.Data.DataTable();
            this.dtCagedLadder = new System.Data.DataTable();
            this.dtFloorPlate = new System.Data.DataTable();
            this.dtSafetyGate = new System.Data.DataTable();
            this.dtGrating = new System.Data.DataTable();
            this.cmdLoadFile = new System.Windows.Forms.Button();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblJobName = new System.Windows.Forms.Label();
            this.cmdReset = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtMedium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLight)).BeginInit();
            this.gbxStructure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nXXXHeavyMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nXXHeavyMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nXLightMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLightMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLightMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMediumMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMediumMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHeavyMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nXXHeavyMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHeavyMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nXHeavyMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nXHeavyMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtExtraLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtJob)).BeginInit();
            this.gbxMiscellaneous.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHeavy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtXHeavy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtXXHeavy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtXXXHeavy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStairRail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHandrail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLadder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCagedLadder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFloorPlate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSafetyGate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrating)).BeginInit();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFileDiag
            // 
            this.OpenFileDiag.DefaultExt = "bif";
            this.OpenFileDiag.Filter = "BIF files|*.bif|Text Files|*.txt|All Files|*.*";
            this.OpenFileDiag.InitialDirectory = "Environment.GetFolderPath(Environment.SpecialFolder.Desktop)";
            // 
            // DataColumn7
            // 
            this.DataColumn7.ColumnName = "Piecemark";
            // 
            // dtMedium
            // 
            this.dtMedium.Columns.AddRange(new System.Data.DataColumn[] {
            this.DataColumn8,
            this.DataColumn7});
            this.dtMedium.TableName = "Medium";
            // 
            // DataColumn8
            // 
            this.DataColumn8.ColumnName = "Weight";
            // 
            // DataColumn6
            // 
            this.DataColumn6.ColumnName = "Piecemark";
            // 
            // DataColumn5
            // 
            this.DataColumn5.ColumnName = "Weight";
            // 
            // dtLight
            // 
            this.dtLight.Columns.AddRange(new System.Data.DataColumn[] {
            this.DataColumn5,
            this.DataColumn6});
            this.dtLight.TableName = "Light";
            // 
            // DataColumn4
            // 
            this.DataColumn4.ColumnName = "Piecemark";
            // 
            // gbxStructure
            // 
            this.gbxStructure.Controls.Add(this.nXXXHeavyMin);
            this.gbxStructure.Controls.Add(this.cbXXXHeavy);
            this.gbxStructure.Controls.Add(this.nXXHeavyMax);
            this.gbxStructure.Controls.Add(this.lblMaximum);
            this.gbxStructure.Controls.Add(this.lblMinimum);
            this.gbxStructure.Controls.Add(this.cbXLight);
            this.gbxStructure.Controls.Add(this.nXLightMax);
            this.gbxStructure.Controls.Add(this.cbLight);
            this.gbxStructure.Controls.Add(this.nLightMin);
            this.gbxStructure.Controls.Add(this.nLightMax);
            this.gbxStructure.Controls.Add(this.cbMedium);
            this.gbxStructure.Controls.Add(this.nMediumMin);
            this.gbxStructure.Controls.Add(this.nMediumMax);
            this.gbxStructure.Controls.Add(this.cbHeavy);
            this.gbxStructure.Controls.Add(this.nHeavyMin);
            this.gbxStructure.Controls.Add(this.nXXHeavyMin);
            this.gbxStructure.Controls.Add(this.nHeavyMax);
            this.gbxStructure.Controls.Add(this.cbXXHeavy);
            this.gbxStructure.Controls.Add(this.cbXHeavy);
            this.gbxStructure.Controls.Add(this.nXHeavyMax);
            this.gbxStructure.Controls.Add(this.nXHeavyMin);
            this.gbxStructure.Location = new System.Drawing.Point(12, 75);
            this.gbxStructure.Name = "gbxStructure";
            this.gbxStructure.Size = new System.Drawing.Size(252, 234);
            this.gbxStructure.TabIndex = 103;
            this.gbxStructure.TabStop = false;
            this.gbxStructure.Text = "Structure/Pipe Rack";
            // 
            // nXXXHeavyMin
            // 
            this.nXXXHeavyMin.DecimalPlaces = 1;
            this.nXXXHeavyMin.Enabled = false;
            this.nXXXHeavyMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nXXXHeavyMin.Location = new System.Drawing.Point(116, 209);
            this.nXXXHeavyMin.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nXXXHeavyMin.Name = "nXXXHeavyMin";
            this.nXXXHeavyMin.Size = new System.Drawing.Size(56, 20);
            this.nXXXHeavyMin.TabIndex = 22;
            this.nXXXHeavyMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbXXXHeavy
            // 
            this.cbXXXHeavy.AutoSize = true;
            this.cbXXXHeavy.Location = new System.Drawing.Point(15, 209);
            this.cbXXXHeavy.Name = "cbXXXHeavy";
            this.cbXXXHeavy.Size = new System.Drawing.Size(89, 17);
            this.cbXXXHeavy.TabIndex = 21;
            this.cbXXXHeavy.Text = "Triple Heavy:";
            this.cbXXXHeavy.UseVisualStyleBackColor = true;
            this.cbXXXHeavy.CheckedChanged += new System.EventHandler(this.CheckBox_NumericState);
            // 
            // nXXHeavyMax
            // 
            this.nXXHeavyMax.DecimalPlaces = 1;
            this.nXXHeavyMax.Enabled = false;
            this.nXXHeavyMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nXXHeavyMax.Location = new System.Drawing.Point(186, 183);
            this.nXXHeavyMax.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nXXHeavyMax.Name = "nXXHeavyMax";
            this.nXXHeavyMax.Size = new System.Drawing.Size(56, 20);
            this.nXXHeavyMax.TabIndex = 20;
            this.nXXHeavyMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMaximum
            // 
            this.lblMaximum.AutoSize = true;
            this.lblMaximum.Location = new System.Drawing.Point(183, 20);
            this.lblMaximum.Name = "lblMaximum";
            this.lblMaximum.Size = new System.Drawing.Size(51, 13);
            this.lblMaximum.TabIndex = 19;
            this.lblMaximum.Text = "Maximum";
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Location = new System.Drawing.Point(116, 20);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(48, 13);
            this.lblMinimum.TabIndex = 18;
            this.lblMinimum.Text = "Minimum";
            // 
            // cbXLight
            // 
            this.cbXLight.AutoSize = true;
            this.cbXLight.Location = new System.Drawing.Point(15, 38);
            this.cbXLight.Name = "cbXLight";
            this.cbXLight.Size = new System.Drawing.Size(79, 17);
            this.cbXLight.TabIndex = 1;
            this.cbXLight.Text = "Extra Light:";
            this.cbXLight.UseVisualStyleBackColor = true;
            this.cbXLight.CheckedChanged += new System.EventHandler(this.CheckBox_NumericState);
            // 
            // nXLightMax
            // 
            this.nXLightMax.DecimalPlaces = 1;
            this.nXLightMax.Enabled = false;
            this.nXLightMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nXLightMax.Location = new System.Drawing.Point(186, 38);
            this.nXLightMax.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nXLightMax.Name = "nXLightMax";
            this.nXLightMax.Size = new System.Drawing.Size(56, 20);
            this.nXLightMax.TabIndex = 3;
            this.nXLightMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbLight
            // 
            this.cbLight.AutoSize = true;
            this.cbLight.Location = new System.Drawing.Point(15, 67);
            this.cbLight.Name = "cbLight";
            this.cbLight.Size = new System.Drawing.Size(52, 17);
            this.cbLight.TabIndex = 4;
            this.cbLight.Text = "Light:";
            this.cbLight.UseVisualStyleBackColor = true;
            this.cbLight.CheckedChanged += new System.EventHandler(this.CheckBox_NumericState);
            // 
            // nLightMin
            // 
            this.nLightMin.DecimalPlaces = 1;
            this.nLightMin.Enabled = false;
            this.nLightMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nLightMin.Location = new System.Drawing.Point(116, 67);
            this.nLightMin.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nLightMin.Name = "nLightMin";
            this.nLightMin.Size = new System.Drawing.Size(56, 20);
            this.nLightMin.TabIndex = 5;
            this.nLightMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nLightMax
            // 
            this.nLightMax.DecimalPlaces = 1;
            this.nLightMax.Enabled = false;
            this.nLightMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nLightMax.Location = new System.Drawing.Point(186, 67);
            this.nLightMax.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nLightMax.Name = "nLightMax";
            this.nLightMax.Size = new System.Drawing.Size(56, 20);
            this.nLightMax.TabIndex = 6;
            this.nLightMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbMedium
            // 
            this.cbMedium.AutoSize = true;
            this.cbMedium.Location = new System.Drawing.Point(15, 97);
            this.cbMedium.Name = "cbMedium";
            this.cbMedium.Size = new System.Drawing.Size(66, 17);
            this.cbMedium.TabIndex = 7;
            this.cbMedium.Text = "Medium:";
            this.cbMedium.UseVisualStyleBackColor = true;
            this.cbMedium.CheckedChanged += new System.EventHandler(this.CheckBox_NumericState);
            // 
            // nMediumMin
            // 
            this.nMediumMin.DecimalPlaces = 1;
            this.nMediumMin.Enabled = false;
            this.nMediumMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nMediumMin.Location = new System.Drawing.Point(116, 97);
            this.nMediumMin.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nMediumMin.Name = "nMediumMin";
            this.nMediumMin.Size = new System.Drawing.Size(56, 20);
            this.nMediumMin.TabIndex = 8;
            this.nMediumMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nMediumMax
            // 
            this.nMediumMax.DecimalPlaces = 1;
            this.nMediumMax.Enabled = false;
            this.nMediumMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nMediumMax.Location = new System.Drawing.Point(186, 97);
            this.nMediumMax.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nMediumMax.Name = "nMediumMax";
            this.nMediumMax.Size = new System.Drawing.Size(56, 20);
            this.nMediumMax.TabIndex = 9;
            this.nMediumMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbHeavy
            // 
            this.cbHeavy.AutoSize = true;
            this.cbHeavy.Location = new System.Drawing.Point(15, 125);
            this.cbHeavy.Name = "cbHeavy";
            this.cbHeavy.Size = new System.Drawing.Size(60, 17);
            this.cbHeavy.TabIndex = 10;
            this.cbHeavy.Text = "Heavy:";
            this.cbHeavy.UseVisualStyleBackColor = true;
            this.cbHeavy.CheckedChanged += new System.EventHandler(this.CheckBox_NumericState);
            // 
            // nHeavyMin
            // 
            this.nHeavyMin.DecimalPlaces = 1;
            this.nHeavyMin.Enabled = false;
            this.nHeavyMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nHeavyMin.Location = new System.Drawing.Point(116, 125);
            this.nHeavyMin.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nHeavyMin.Name = "nHeavyMin";
            this.nHeavyMin.Size = new System.Drawing.Size(56, 20);
            this.nHeavyMin.TabIndex = 11;
            this.nHeavyMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nXXHeavyMin
            // 
            this.nXXHeavyMin.DecimalPlaces = 1;
            this.nXXHeavyMin.Enabled = false;
            this.nXXHeavyMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nXXHeavyMin.Location = new System.Drawing.Point(116, 183);
            this.nXXHeavyMin.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nXXHeavyMin.Name = "nXXHeavyMin";
            this.nXXHeavyMin.Size = new System.Drawing.Size(56, 20);
            this.nXXHeavyMin.TabIndex = 17;
            this.nXXHeavyMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nHeavyMax
            // 
            this.nHeavyMax.DecimalPlaces = 1;
            this.nHeavyMax.Enabled = false;
            this.nHeavyMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nHeavyMax.Location = new System.Drawing.Point(186, 125);
            this.nHeavyMax.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nHeavyMax.Name = "nHeavyMax";
            this.nHeavyMax.Size = new System.Drawing.Size(56, 20);
            this.nHeavyMax.TabIndex = 12;
            this.nHeavyMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbXXHeavy
            // 
            this.cbXXHeavy.AutoSize = true;
            this.cbXXHeavy.Location = new System.Drawing.Point(15, 183);
            this.cbXXHeavy.Name = "cbXXHeavy";
            this.cbXXHeavy.Size = new System.Drawing.Size(97, 17);
            this.cbXXHeavy.TabIndex = 16;
            this.cbXXHeavy.Text = "Double Heavy:";
            this.cbXXHeavy.UseVisualStyleBackColor = true;
            this.cbXXHeavy.CheckedChanged += new System.EventHandler(this.CheckBox_NumericState);
            // 
            // cbXHeavy
            // 
            this.cbXHeavy.AutoSize = true;
            this.cbXHeavy.Location = new System.Drawing.Point(15, 154);
            this.cbXHeavy.Name = "cbXHeavy";
            this.cbXHeavy.Size = new System.Drawing.Size(87, 17);
            this.cbXHeavy.TabIndex = 13;
            this.cbXHeavy.Text = "Extra Heavy:";
            this.cbXHeavy.UseVisualStyleBackColor = true;
            this.cbXHeavy.CheckedChanged += new System.EventHandler(this.CheckBox_NumericState);
            // 
            // nXHeavyMax
            // 
            this.nXHeavyMax.DecimalPlaces = 1;
            this.nXHeavyMax.Enabled = false;
            this.nXHeavyMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nXHeavyMax.Location = new System.Drawing.Point(186, 154);
            this.nXHeavyMax.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nXHeavyMax.Name = "nXHeavyMax";
            this.nXHeavyMax.Size = new System.Drawing.Size(56, 20);
            this.nXHeavyMax.TabIndex = 15;
            this.nXHeavyMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nXHeavyMin
            // 
            this.nXHeavyMin.DecimalPlaces = 1;
            this.nXHeavyMin.Enabled = false;
            this.nXHeavyMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nXHeavyMin.Location = new System.Drawing.Point(116, 154);
            this.nXHeavyMin.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nXHeavyMin.Name = "nXHeavyMin";
            this.nXHeavyMin.Size = new System.Drawing.Size(56, 20);
            this.nXHeavyMin.TabIndex = 14;
            this.nXHeavyMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DataColumn3
            // 
            this.DataColumn3.ColumnName = "Weight";
            // 
            // dtExtraLight
            // 
            this.dtExtraLight.Columns.AddRange(new System.Data.DataColumn[] {
            this.DataColumn3,
            this.DataColumn4});
            this.dtExtraLight.TableName = "Extra Light";
            // 
            // DataColumn2
            // 
            this.DataColumn2.ColumnName = "GrandTotal";
            // 
            // DataColumn1
            // 
            this.DataColumn1.ColumnName = "Job";
            // 
            // dtJob
            // 
            this.dtJob.Columns.AddRange(new System.Data.DataColumn[] {
            this.DataColumn1,
            this.DataColumn2});
            this.dtJob.TableName = "Job";
            // 
            // gbxMiscellaneous
            // 
            this.gbxMiscellaneous.Controls.Add(this.cbSafetyGate);
            this.gbxMiscellaneous.Controls.Add(this.cbFrame);
            this.gbxMiscellaneous.Controls.Add(this.cbStair);
            this.gbxMiscellaneous.Controls.Add(this.cbFloorPlate);
            this.gbxMiscellaneous.Controls.Add(this.cbStairRail);
            this.gbxMiscellaneous.Controls.Add(this.cbCagedLadder);
            this.gbxMiscellaneous.Controls.Add(this.cbHandrail);
            this.gbxMiscellaneous.Controls.Add(this.cbLadder);
            this.gbxMiscellaneous.Location = new System.Drawing.Point(282, 75);
            this.gbxMiscellaneous.Name = "gbxMiscellaneous";
            this.gbxMiscellaneous.Size = new System.Drawing.Size(242, 155);
            this.gbxMiscellaneous.TabIndex = 104;
            this.gbxMiscellaneous.TabStop = false;
            this.gbxMiscellaneous.Text = "Miscellaneous";
            // 
            // cbSafetyGate
            // 
            this.cbSafetyGate.AutoSize = true;
            this.cbSafetyGate.Location = new System.Drawing.Point(104, 124);
            this.cbSafetyGate.Name = "cbSafetyGate";
            this.cbSafetyGate.Size = new System.Drawing.Size(130, 17);
            this.cbSafetyGate.TabIndex = 29;
            this.cbSafetyGate.Text = "Designed Safety Gate";
            this.cbSafetyGate.UseVisualStyleBackColor = true;
            // 
            // cbFrame
            // 
            this.cbFrame.AutoSize = true;
            this.cbFrame.Checked = true;
            this.cbFrame.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFrame.Location = new System.Drawing.Point(104, 23);
            this.cbFrame.Name = "cbFrame";
            this.cbFrame.Size = new System.Drawing.Size(60, 17);
            this.cbFrame.TabIndex = 19;
            this.cbFrame.Text = "Frames";
            this.cbFrame.UseVisualStyleBackColor = true;
            // 
            // cbStair
            // 
            this.cbStair.AutoSize = true;
            this.cbStair.Checked = true;
            this.cbStair.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStair.Location = new System.Drawing.Point(15, 23);
            this.cbStair.Name = "cbStair";
            this.cbStair.Size = new System.Drawing.Size(52, 17);
            this.cbStair.TabIndex = 20;
            this.cbStair.Text = "Stairs";
            this.cbStair.UseVisualStyleBackColor = true;
            // 
            // cbFloorPlate
            // 
            this.cbFloorPlate.AutoSize = true;
            this.cbFloorPlate.Checked = true;
            this.cbFloorPlate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFloorPlate.Location = new System.Drawing.Point(15, 124);
            this.cbFloorPlate.Name = "cbFloorPlate";
            this.cbFloorPlate.Size = new System.Drawing.Size(76, 17);
            this.cbFloorPlate.TabIndex = 25;
            this.cbFloorPlate.Text = "Floor Plate";
            this.cbFloorPlate.UseVisualStyleBackColor = true;
            // 
            // cbStairRail
            // 
            this.cbStairRail.AutoSize = true;
            this.cbStairRail.Checked = true;
            this.cbStairRail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStairRail.Location = new System.Drawing.Point(15, 57);
            this.cbStairRail.Name = "cbStairRail";
            this.cbStairRail.Size = new System.Drawing.Size(68, 17);
            this.cbStairRail.TabIndex = 21;
            this.cbStairRail.Text = "Stair Rail";
            this.cbStairRail.UseVisualStyleBackColor = true;
            // 
            // cbCagedLadder
            // 
            this.cbCagedLadder.AutoSize = true;
            this.cbCagedLadder.Checked = true;
            this.cbCagedLadder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCagedLadder.Location = new System.Drawing.Point(104, 91);
            this.cbCagedLadder.Name = "cbCagedLadder";
            this.cbCagedLadder.Size = new System.Drawing.Size(93, 17);
            this.cbCagedLadder.TabIndex = 24;
            this.cbCagedLadder.Text = "Caged Ladder";
            this.cbCagedLadder.UseVisualStyleBackColor = true;
            // 
            // cbHandrail
            // 
            this.cbHandrail.AutoSize = true;
            this.cbHandrail.Checked = true;
            this.cbHandrail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHandrail.Location = new System.Drawing.Point(104, 57);
            this.cbHandrail.Name = "cbHandrail";
            this.cbHandrail.Size = new System.Drawing.Size(65, 17);
            this.cbHandrail.TabIndex = 22;
            this.cbHandrail.Text = "Handrail";
            this.cbHandrail.UseVisualStyleBackColor = true;
            // 
            // cbLadder
            // 
            this.cbLadder.AutoSize = true;
            this.cbLadder.Checked = true;
            this.cbLadder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLadder.Location = new System.Drawing.Point(15, 91);
            this.cbLadder.Name = "cbLadder";
            this.cbLadder.Size = new System.Drawing.Size(59, 17);
            this.cbLadder.TabIndex = 23;
            this.cbLadder.Text = "Ladder";
            this.cbLadder.UseVisualStyleBackColor = true;
            // 
            // dsInvoice
            // 
            this.dsInvoice.DataSetName = "dsInvoice";
            this.dsInvoice.Tables.AddRange(new System.Data.DataTable[] {
            this.dtJob,
            this.dtExtraLight,
            this.dtLight,
            this.dtMedium,
            this.dtHeavy,
            this.dtXHeavy,
            this.dtXXHeavy,
            this.dtXXXHeavy,
            this.dtFrame,
            this.dtStair,
            this.dtStairRail,
            this.dtHandrail,
            this.dtLadder,
            this.dtCagedLadder,
            this.dtFloorPlate,
            this.dtSafetyGate,
            this.dtGrating});
            // 
            // dtHeavy
            // 
            this.dtHeavy.Columns.AddRange(new System.Data.DataColumn[] {
            this.DataColumn9,
            this.DataColumn10});
            this.dtHeavy.TableName = "Heavy";
            // 
            // DataColumn9
            // 
            this.DataColumn9.ColumnName = "Weight";
            // 
            // DataColumn10
            // 
            this.DataColumn10.ColumnName = "Piecemark";
            // 
            // dtXHeavy
            // 
            this.dtXHeavy.Columns.AddRange(new System.Data.DataColumn[] {
            this.DataColumn11,
            this.DataColumn12});
            this.dtXHeavy.TableName = "Extra Heavy";
            // 
            // DataColumn11
            // 
            this.DataColumn11.ColumnName = "Weight";
            // 
            // DataColumn12
            // 
            this.DataColumn12.ColumnName = "Piecemark";
            // 
            // dtXXHeavy
            // 
            this.dtXXHeavy.TableName = "Double Heavy";
            // 
            // dtXXXHeavy
            // 
            this.dtXXXHeavy.TableName = "Triple Heavy";
            // 
            // dtFrame
            // 
            this.dtFrame.TableName = "Frame";
            // 
            // dtStair
            // 
            this.dtStair.TableName = "Stair";
            // 
            // dtStairRail
            // 
            this.dtStairRail.TableName = "Stair Rail";
            // 
            // dtHandrail
            // 
            this.dtHandrail.TableName = "Handrail";
            // 
            // dtLadder
            // 
            this.dtLadder.TableName = "Ladder";
            // 
            // dtCagedLadder
            // 
            this.dtCagedLadder.TableName = "Caged Ladder";
            // 
            // dtFloorPlate
            // 
            this.dtFloorPlate.TableName = "Floor Plate";
            // 
            // dtSafetyGate
            // 
            this.dtSafetyGate.TableName = "Safety Gate";
            // 
            // dtGrating
            // 
            this.dtGrating.TableName = "Grating";
            // 
            // cmdLoadFile
            // 
            this.cmdLoadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLoadFile.Location = new System.Drawing.Point(309, 243);
            this.cmdLoadFile.Name = "cmdLoadFile";
            this.cmdLoadFile.Size = new System.Drawing.Size(90, 30);
            this.cmdLoadFile.TabIndex = 108;
            this.cmdLoadFile.Text = "&Load File";
            this.cmdLoadFile.UseVisualStyleBackColor = true;
            this.cmdLoadFile.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "&Help";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.Help_Click);
            // 
            // ResetToolStripMenuItem
            // 
            this.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem";
            this.ResetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.ResetToolStripMenuItem.Text = "&Reset";
            this.ResetToolStripMenuItem.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // lblJobName
            // 
            this.lblJobName.AutoSize = true;
            this.lblJobName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobName.Location = new System.Drawing.Point(25, 47);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(81, 20);
            this.lblJobName.TabIndex = 110;
            this.lblJobName.Text = "Job Name";
            this.lblJobName.Visible = false;
            // 
            // cmdReset
            // 
            this.cmdReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReset.Location = new System.Drawing.Point(309, 279);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(90, 30);
            this.cmdReset.TabIndex = 106;
            this.cmdReset.Text = "&Reset";
            this.cmdReset.UseVisualStyleBackColor = true;
            this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Location = new System.Drawing.Point(405, 279);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(90, 30);
            this.cmdExit.TabIndex = 107;
            this.cmdExit.Text = "E&xit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.ExitToolStripMenuItem.Text = "E&xit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.Enabled = false;
            this.cmdCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCalculate.Location = new System.Drawing.Point(405, 243);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(90, 30);
            this.cmdCalculate.TabIndex = 105;
            this.cmdCalculate.Text = "&Calculate";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadToolStripMenuItem,
            this.CalculateToolStripMenuItem,
            this.ResetToolStripMenuItem,
            this.ExitToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(536, 24);
            this.MenuStrip1.TabIndex = 109;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.LoadToolStripMenuItem.Text = "&Load";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // CalculateToolStripMenuItem
            // 
            this.CalculateToolStripMenuItem.Enabled = false;
            this.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem";
            this.CalculateToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.CalculateToolStripMenuItem.Text = "&Calculate";
            this.CalculateToolStripMenuItem.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 320);
            this.Controls.Add(this.gbxStructure);
            this.Controls.Add(this.gbxMiscellaneous);
            this.Controls.Add(this.cmdLoadFile);
            this.Controls.Add(this.lblJobName);
            this.Controls.Add(this.cmdReset);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdCalculate);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Invoicer";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Click += new System.EventHandler(this.Help_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dtMedium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLight)).EndInit();
            this.gbxStructure.ResumeLayout(false);
            this.gbxStructure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nXXXHeavyMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nXXHeavyMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nXLightMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLightMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLightMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMediumMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMediumMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHeavyMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nXXHeavyMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHeavyMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nXHeavyMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nXHeavyMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtExtraLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtJob)).EndInit();
            this.gbxMiscellaneous.ResumeLayout(false);
            this.gbxMiscellaneous.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHeavy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtXHeavy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtXXHeavy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtXXXHeavy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtStairRail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHandrail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLadder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCagedLadder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFloorPlate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSafetyGate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrating)).EndInit();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.OpenFileDialog OpenFileDiag;
        internal System.Data.DataColumn DataColumn7;
        internal System.Data.DataTable dtMedium;
        internal System.Data.DataColumn DataColumn8;
        internal System.Data.DataColumn DataColumn6;
        internal System.Data.DataColumn DataColumn5;
        internal System.Data.DataTable dtLight;
        internal System.Data.DataColumn DataColumn4;
        internal System.Windows.Forms.GroupBox gbxStructure;
        internal System.Windows.Forms.NumericUpDown nXXXHeavyMin;
        internal System.Windows.Forms.CheckBox cbXXXHeavy;
        internal System.Windows.Forms.NumericUpDown nXXHeavyMax;
        internal System.Windows.Forms.Label lblMaximum;
        internal System.Windows.Forms.Label lblMinimum;
        internal System.Windows.Forms.CheckBox cbXLight;
        internal System.Windows.Forms.NumericUpDown nXLightMax;
        internal System.Windows.Forms.CheckBox cbLight;
        internal System.Windows.Forms.NumericUpDown nLightMin;
        internal System.Windows.Forms.NumericUpDown nLightMax;
        internal System.Windows.Forms.CheckBox cbMedium;
        internal System.Windows.Forms.NumericUpDown nMediumMin;
        internal System.Windows.Forms.NumericUpDown nMediumMax;
        internal System.Windows.Forms.CheckBox cbHeavy;
        internal System.Windows.Forms.NumericUpDown nHeavyMin;
        internal System.Windows.Forms.NumericUpDown nXXHeavyMin;
        internal System.Windows.Forms.NumericUpDown nHeavyMax;
        internal System.Windows.Forms.CheckBox cbXXHeavy;
        internal System.Windows.Forms.CheckBox cbXHeavy;
        internal System.Windows.Forms.NumericUpDown nXHeavyMax;
        internal System.Windows.Forms.NumericUpDown nXHeavyMin;
        internal System.Data.DataColumn DataColumn3;
        internal System.Data.DataTable dtExtraLight;
        internal System.Data.DataColumn DataColumn2;
        internal System.Data.DataColumn DataColumn1;
        internal System.Data.DataTable dtJob;
        internal System.Windows.Forms.GroupBox gbxMiscellaneous;
        internal System.Windows.Forms.CheckBox cbSafetyGate;
        internal System.Windows.Forms.CheckBox cbFrame;
        internal System.Windows.Forms.CheckBox cbStair;
        internal System.Windows.Forms.CheckBox cbFloorPlate;
        internal System.Windows.Forms.CheckBox cbStairRail;
        internal System.Windows.Forms.CheckBox cbCagedLadder;
        internal System.Windows.Forms.CheckBox cbHandrail;
        internal System.Windows.Forms.CheckBox cbLadder;
        internal System.Data.DataSet dsInvoice;
        internal System.Data.DataTable dtHeavy;
        internal System.Data.DataColumn DataColumn9;
        internal System.Data.DataColumn DataColumn10;
        internal System.Data.DataTable dtXHeavy;
        internal System.Data.DataColumn DataColumn11;
        internal System.Data.DataColumn DataColumn12;
        internal System.Data.DataTable dtXXHeavy;
        internal System.Data.DataTable dtXXXHeavy;
        internal System.Data.DataTable dtFrame;
        internal System.Data.DataTable dtStair;
        internal System.Data.DataTable dtStairRail;
        internal System.Data.DataTable dtHandrail;
        internal System.Data.DataTable dtLadder;
        internal System.Data.DataTable dtCagedLadder;
        internal System.Data.DataTable dtFloorPlate;
        internal System.Data.DataTable dtSafetyGate;
        internal System.Data.DataTable dtGrating;
        internal System.Windows.Forms.Button cmdLoadFile;
        internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ResetToolStripMenuItem;
        internal System.Windows.Forms.Label lblJobName;
        internal System.Windows.Forms.Button cmdReset;
        internal System.Windows.Forms.Button cmdExit;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        internal System.Windows.Forms.Button cmdCalculate;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CalculateToolStripMenuItem;
    }
}

