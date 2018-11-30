namespace JobInvoicerCS
{
    partial class Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.lblJob = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lbXXXHeavy = new System.Windows.Forms.Label();
            this.txbXXXHeavy = new System.Windows.Forms.TextBox();
            this.PrintDoc = new System.Drawing.Printing.PrintDocument();
            this.lblGrating = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.tbxGrating = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbGrandTotal = new System.Windows.Forms.Label();
            this.txbGrandTotal = new System.Windows.Forms.TextBox();
            this.PrintPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.lbSafetyGate = new System.Windows.Forms.Label();
            this.txbSafetyGate = new System.Windows.Forms.TextBox();
            this.lbFloorPlate = new System.Windows.Forms.Label();
            this.cblPiecemarks = new System.Windows.Forms.CheckedListBox();
            this.txbFloorPlate = new System.Windows.Forms.TextBox();
            this.lbCagedLadder = new System.Windows.Forms.Label();
            this.txbCagedLadder = new System.Windows.Forms.TextBox();
            this.lbLadder = new System.Windows.Forms.Label();
            this.cmdPrintInvoice = new System.Windows.Forms.Button();
            this.txbLadder = new System.Windows.Forms.TextBox();
            this.lbHandrail = new System.Windows.Forms.Label();
            this.txbHandrail = new System.Windows.Forms.TextBox();
            this.lbStairRail = new System.Windows.Forms.Label();
            this.txbStairRail = new System.Windows.Forms.TextBox();
            this.lbStairs = new System.Windows.Forms.Label();
            this.txbStairs = new System.Windows.Forms.TextBox();
            this.panWeights = new System.Windows.Forms.Panel();
            this.lbFames = new System.Windows.Forms.Label();
            this.txbFrames = new System.Windows.Forms.TextBox();
            this.lbXXHeavy = new System.Windows.Forms.Label();
            this.txbXXHeavy = new System.Windows.Forms.TextBox();
            this.lbXHeavy = new System.Windows.Forms.Label();
            this.txbXHeavy = new System.Windows.Forms.TextBox();
            this.lbHeavy = new System.Windows.Forms.Label();
            this.txbMedium = new System.Windows.Forms.TextBox();
            this.lbMedium = new System.Windows.Forms.Label();
            this.txbLight = new System.Windows.Forms.TextBox();
            this.lbLight = new System.Windows.Forms.Label();
            this.txbHeavy = new System.Windows.Forms.TextBox();
            this.lbXLight = new System.Windows.Forms.Label();
            this.txbXLight = new System.Windows.Forms.TextBox();
            this.btnShowPiecemarks = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.panWeights.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.Location = new System.Drawing.Point(8, 18);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(30, 20);
            this.lblJob.TabIndex = 99;
            this.lblJob.Text = "Lbl";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lblJob);
            this.GroupBox1.Location = new System.Drawing.Point(8, 5);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(265, 53);
            this.GroupBox1.TabIndex = 100;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Invoice For";
            // 
            // lbXXXHeavy
            // 
            this.lbXXXHeavy.AutoSize = true;
            this.lbXXXHeavy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXXXHeavy.Location = new System.Drawing.Point(85, 247);
            this.lbXXXHeavy.Name = "lbXXXHeavy";
            this.lbXXXHeavy.Size = new System.Drawing.Size(99, 20);
            this.lbXXXHeavy.TabIndex = 71;
            this.lbXXXHeavy.Text = "Triple Heavy:";
            // 
            // txbXXXHeavy
            // 
            this.txbXXXHeavy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbXXXHeavy.Location = new System.Drawing.Point(200, 244);
            this.txbXXXHeavy.Name = "txbXXXHeavy";
            this.txbXXXHeavy.ReadOnly = true;
            this.txbXXXHeavy.Size = new System.Drawing.Size(98, 26);
            this.txbXXXHeavy.TabIndex = 72;
            this.txbXXXHeavy.TabStop = false;
            this.txbXXXHeavy.Text = "0";
            this.txbXXXHeavy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbXXXHeavy.WordWrap = false;
            // 
            // PrintDoc
            // 
            this.PrintDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintPage);
            // 
            // lblGrating
            // 
            this.lblGrating.AutoSize = true;
            this.lblGrating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrating.Location = new System.Drawing.Point(118, 517);
            this.lblGrating.Name = "lblGrating";
            this.lblGrating.Size = new System.Drawing.Size(66, 20);
            this.lblGrating.TabIndex = 68;
            this.lblGrating.Text = "Grating:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(334, 37);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(92, 13);
            this.Label2.TabIndex = 118;
            this.Label2.Text = "Show Piecemarks";
            // 
            // tbxGrating
            // 
            this.tbxGrating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGrating.Location = new System.Drawing.Point(199, 514);
            this.tbxGrating.Name = "tbxGrating";
            this.tbxGrating.ReadOnly = true;
            this.tbxGrating.Size = new System.Drawing.Size(98, 26);
            this.tbxGrating.TabIndex = 69;
            this.tbxGrating.TabStop = false;
            this.tbxGrating.Text = "0";
            this.tbxGrating.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxGrating.WordWrap = false;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(346, 506);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 30);
            this.btnExit.TabIndex = 117;
            this.btnExit.Text = "Ex&it";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbGrandTotal
            // 
            this.lbGrandTotal.AutoSize = true;
            this.lbGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrandTotal.Location = new System.Drawing.Point(86, 549);
            this.lbGrandTotal.Name = "lbGrandTotal";
            this.lbGrandTotal.Size = new System.Drawing.Size(102, 20);
            this.lbGrandTotal.TabIndex = 52;
            this.lbGrandTotal.Text = "Total Weight:";
            // 
            // txbGrandTotal
            // 
            this.txbGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGrandTotal.Location = new System.Drawing.Point(199, 546);
            this.txbGrandTotal.Name = "txbGrandTotal";
            this.txbGrandTotal.ReadOnly = true;
            this.txbGrandTotal.Size = new System.Drawing.Size(98, 26);
            this.txbGrandTotal.TabIndex = 53;
            this.txbGrandTotal.TabStop = false;
            this.txbGrandTotal.Text = "0";
            this.txbGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbGrandTotal.WordWrap = false;
            // 
            // PrintPreview
            // 
            this.PrintPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreview.Enabled = true;
            this.PrintPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreview.Icon")));
            this.PrintPreview.Name = "PrintPreview";
            this.PrintPreview.Visible = false;
            // 
            // lbSafetyGate
            // 
            this.lbSafetyGate.AutoSize = true;
            this.lbSafetyGate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSafetyGate.Location = new System.Drawing.Point(13, 487);
            this.lbSafetyGate.Name = "lbSafetyGate";
            this.lbSafetyGate.Size = new System.Drawing.Size(171, 20);
            this.lbSafetyGate.TabIndex = 36;
            this.lbSafetyGate.Text = "Designed Safety Gate:";
            // 
            // txbSafetyGate
            // 
            this.txbSafetyGate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSafetyGate.Location = new System.Drawing.Point(200, 484);
            this.txbSafetyGate.Name = "txbSafetyGate";
            this.txbSafetyGate.ReadOnly = true;
            this.txbSafetyGate.Size = new System.Drawing.Size(98, 26);
            this.txbSafetyGate.TabIndex = 51;
            this.txbSafetyGate.TabStop = false;
            this.txbSafetyGate.Text = "0";
            this.txbSafetyGate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbSafetyGate.WordWrap = false;
            // 
            // lbFloorPlate
            // 
            this.lbFloorPlate.AutoSize = true;
            this.lbFloorPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFloorPlate.Location = new System.Drawing.Point(95, 457);
            this.lbFloorPlate.Name = "lbFloorPlate";
            this.lbFloorPlate.Size = new System.Drawing.Size(89, 20);
            this.lbFloorPlate.TabIndex = 28;
            this.lbFloorPlate.Text = "Floor Plate:";
            // 
            // cblPiecemarks
            // 
            this.cblPiecemarks.FormattingEnabled = true;
            this.cblPiecemarks.Items.AddRange(new object[] {
            "XLight",
            "Light",
            "Medium",
            "Heavy",
            "XHeavy",
            "XXHeavy",
            "XXXHeavy",
            "Frames",
            "Stairs",
            "Stair Rails",
            "Handrails",
            "Ladders",
            "Caged Ladders",
            "Floor Plates",
            "Safety Gates"});
            this.cblPiecemarks.Location = new System.Drawing.Point(334, 53);
            this.cblPiecemarks.Name = "cblPiecemarks";
            this.cblPiecemarks.Size = new System.Drawing.Size(101, 229);
            this.cblPiecemarks.TabIndex = 119;
            this.cblPiecemarks.SelectedIndexChanged += new System.EventHandler(this.cblPiecemarks_SelectedIndexChanged);
            // 
            // txbFloorPlate
            // 
            this.txbFloorPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFloorPlate.Location = new System.Drawing.Point(200, 454);
            this.txbFloorPlate.Name = "txbFloorPlate";
            this.txbFloorPlate.ReadOnly = true;
            this.txbFloorPlate.Size = new System.Drawing.Size(98, 26);
            this.txbFloorPlate.TabIndex = 47;
            this.txbFloorPlate.TabStop = false;
            this.txbFloorPlate.Text = "0";
            this.txbFloorPlate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbFloorPlate.WordWrap = false;
            // 
            // lbCagedLadder
            // 
            this.lbCagedLadder.AutoSize = true;
            this.lbCagedLadder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCagedLadder.Location = new System.Drawing.Point(70, 427);
            this.lbCagedLadder.Name = "lbCagedLadder";
            this.lbCagedLadder.Size = new System.Drawing.Size(114, 20);
            this.lbCagedLadder.TabIndex = 26;
            this.lbCagedLadder.Text = "Caged Ladder:";
            // 
            // txbCagedLadder
            // 
            this.txbCagedLadder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCagedLadder.Location = new System.Drawing.Point(200, 424);
            this.txbCagedLadder.Name = "txbCagedLadder";
            this.txbCagedLadder.ReadOnly = true;
            this.txbCagedLadder.Size = new System.Drawing.Size(98, 26);
            this.txbCagedLadder.TabIndex = 46;
            this.txbCagedLadder.TabStop = false;
            this.txbCagedLadder.Text = "0";
            this.txbCagedLadder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbCagedLadder.WordWrap = false;
            // 
            // lbLadder
            // 
            this.lbLadder.AutoSize = true;
            this.lbLadder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLadder.Location = new System.Drawing.Point(121, 397);
            this.lbLadder.Name = "lbLadder";
            this.lbLadder.Size = new System.Drawing.Size(63, 20);
            this.lbLadder.TabIndex = 24;
            this.lbLadder.Text = "Ladder:";
            // 
            // cmdPrintInvoice
            // 
            this.cmdPrintInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPrintInvoice.Location = new System.Drawing.Point(346, 471);
            this.cmdPrintInvoice.Name = "cmdPrintInvoice";
            this.cmdPrintInvoice.Size = new System.Drawing.Size(80, 30);
            this.cmdPrintInvoice.TabIndex = 116;
            this.cmdPrintInvoice.Text = "&Print";
            this.cmdPrintInvoice.UseVisualStyleBackColor = true;
            this.cmdPrintInvoice.Click += new System.EventHandler(this.cmdPrintInvoice_Click);
            // 
            // txbLadder
            // 
            this.txbLadder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLadder.Location = new System.Drawing.Point(200, 394);
            this.txbLadder.Name = "txbLadder";
            this.txbLadder.ReadOnly = true;
            this.txbLadder.Size = new System.Drawing.Size(98, 26);
            this.txbLadder.TabIndex = 45;
            this.txbLadder.TabStop = false;
            this.txbLadder.Text = "0";
            this.txbLadder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbLadder.WordWrap = false;
            // 
            // lbHandrail
            // 
            this.lbHandrail.AutoSize = true;
            this.lbHandrail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHandrail.Location = new System.Drawing.Point(112, 367);
            this.lbHandrail.Name = "lbHandrail";
            this.lbHandrail.Size = new System.Drawing.Size(72, 20);
            this.lbHandrail.TabIndex = 22;
            this.lbHandrail.Text = "Handrail:";
            // 
            // txbHandrail
            // 
            this.txbHandrail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHandrail.Location = new System.Drawing.Point(200, 364);
            this.txbHandrail.Name = "txbHandrail";
            this.txbHandrail.ReadOnly = true;
            this.txbHandrail.Size = new System.Drawing.Size(98, 26);
            this.txbHandrail.TabIndex = 44;
            this.txbHandrail.TabStop = false;
            this.txbHandrail.Text = "0";
            this.txbHandrail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbHandrail.WordWrap = false;
            // 
            // lbStairRail
            // 
            this.lbStairRail.AutoSize = true;
            this.lbStairRail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStairRail.Location = new System.Drawing.Point(107, 337);
            this.lbStairRail.Name = "lbStairRail";
            this.lbStairRail.Size = new System.Drawing.Size(77, 20);
            this.lbStairRail.TabIndex = 20;
            this.lbStairRail.Text = "Stair Rail:";
            // 
            // txbStairRail
            // 
            this.txbStairRail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStairRail.Location = new System.Drawing.Point(200, 334);
            this.txbStairRail.Name = "txbStairRail";
            this.txbStairRail.ReadOnly = true;
            this.txbStairRail.Size = new System.Drawing.Size(98, 26);
            this.txbStairRail.TabIndex = 43;
            this.txbStairRail.TabStop = false;
            this.txbStairRail.Text = "0";
            this.txbStairRail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbStairRail.WordWrap = false;
            // 
            // lbStairs
            // 
            this.lbStairs.AutoSize = true;
            this.lbStairs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStairs.Location = new System.Drawing.Point(138, 307);
            this.lbStairs.Name = "lbStairs";
            this.lbStairs.Size = new System.Drawing.Size(46, 20);
            this.lbStairs.TabIndex = 18;
            this.lbStairs.Text = "Stair:";
            // 
            // txbStairs
            // 
            this.txbStairs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStairs.Location = new System.Drawing.Point(200, 304);
            this.txbStairs.Name = "txbStairs";
            this.txbStairs.ReadOnly = true;
            this.txbStairs.Size = new System.Drawing.Size(98, 26);
            this.txbStairs.TabIndex = 42;
            this.txbStairs.TabStop = false;
            this.txbStairs.Text = "0";
            this.txbStairs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbStairs.WordWrap = false;
            // 
            // panWeights
            // 
            this.panWeights.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panWeights.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panWeights.Controls.Add(this.GroupBox1);
            this.panWeights.Controls.Add(this.lbXXXHeavy);
            this.panWeights.Controls.Add(this.txbXXXHeavy);
            this.panWeights.Controls.Add(this.lblGrating);
            this.panWeights.Controls.Add(this.tbxGrating);
            this.panWeights.Controls.Add(this.lbGrandTotal);
            this.panWeights.Controls.Add(this.txbGrandTotal);
            this.panWeights.Controls.Add(this.lbSafetyGate);
            this.panWeights.Controls.Add(this.txbSafetyGate);
            this.panWeights.Controls.Add(this.lbFloorPlate);
            this.panWeights.Controls.Add(this.txbFloorPlate);
            this.panWeights.Controls.Add(this.lbCagedLadder);
            this.panWeights.Controls.Add(this.txbCagedLadder);
            this.panWeights.Controls.Add(this.lbLadder);
            this.panWeights.Controls.Add(this.txbLadder);
            this.panWeights.Controls.Add(this.lbHandrail);
            this.panWeights.Controls.Add(this.txbHandrail);
            this.panWeights.Controls.Add(this.lbStairRail);
            this.panWeights.Controls.Add(this.txbStairRail);
            this.panWeights.Controls.Add(this.lbStairs);
            this.panWeights.Controls.Add(this.txbStairs);
            this.panWeights.Controls.Add(this.lbFames);
            this.panWeights.Controls.Add(this.txbFrames);
            this.panWeights.Controls.Add(this.lbXXHeavy);
            this.panWeights.Controls.Add(this.txbXXHeavy);
            this.panWeights.Controls.Add(this.lbXHeavy);
            this.panWeights.Controls.Add(this.txbXHeavy);
            this.panWeights.Controls.Add(this.lbHeavy);
            this.panWeights.Controls.Add(this.txbMedium);
            this.panWeights.Controls.Add(this.lbMedium);
            this.panWeights.Controls.Add(this.txbLight);
            this.panWeights.Controls.Add(this.lbLight);
            this.panWeights.Controls.Add(this.txbHeavy);
            this.panWeights.Controls.Add(this.lbXLight);
            this.panWeights.Controls.Add(this.txbXLight);
            this.panWeights.Location = new System.Drawing.Point(11, 12);
            this.panWeights.Name = "panWeights";
            this.panWeights.Padding = new System.Windows.Forms.Padding(12);
            this.panWeights.Size = new System.Drawing.Size(317, 592);
            this.panWeights.TabIndex = 115;
            // 
            // lbFames
            // 
            this.lbFames.AutoSize = true;
            this.lbFames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFames.Location = new System.Drawing.Point(59, 277);
            this.lbFames.Name = "lbFames";
            this.lbFames.Size = new System.Drawing.Size(125, 20);
            this.lbFames.TabIndex = 16;
            this.lbFames.Text = "Welded Frames:";
            // 
            // txbFrames
            // 
            this.txbFrames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFrames.Location = new System.Drawing.Point(200, 274);
            this.txbFrames.Name = "txbFrames";
            this.txbFrames.ReadOnly = true;
            this.txbFrames.Size = new System.Drawing.Size(98, 26);
            this.txbFrames.TabIndex = 41;
            this.txbFrames.TabStop = false;
            this.txbFrames.Text = "0";
            this.txbFrames.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbFrames.WordWrap = false;
            // 
            // lbXXHeavy
            // 
            this.lbXXHeavy.AutoSize = true;
            this.lbXXHeavy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXXHeavy.Location = new System.Drawing.Point(72, 217);
            this.lbXXHeavy.Name = "lbXXHeavy";
            this.lbXXHeavy.Size = new System.Drawing.Size(112, 20);
            this.lbXXHeavy.TabIndex = 14;
            this.lbXXHeavy.Text = "Double Heavy:";
            // 
            // txbXXHeavy
            // 
            this.txbXXHeavy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbXXHeavy.Location = new System.Drawing.Point(200, 214);
            this.txbXXHeavy.Name = "txbXXHeavy";
            this.txbXXHeavy.ReadOnly = true;
            this.txbXXHeavy.Size = new System.Drawing.Size(98, 26);
            this.txbXXHeavy.TabIndex = 40;
            this.txbXXHeavy.TabStop = false;
            this.txbXXHeavy.Text = "0";
            this.txbXXHeavy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbXXHeavy.WordWrap = false;
            // 
            // lbXHeavy
            // 
            this.lbXHeavy.AutoSize = true;
            this.lbXHeavy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXHeavy.Location = new System.Drawing.Point(86, 187);
            this.lbXHeavy.Name = "lbXHeavy";
            this.lbXHeavy.Size = new System.Drawing.Size(98, 20);
            this.lbXHeavy.TabIndex = 12;
            this.lbXHeavy.Text = "Extra Heavy:";
            // 
            // txbXHeavy
            // 
            this.txbXHeavy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbXHeavy.Location = new System.Drawing.Point(200, 184);
            this.txbXHeavy.Name = "txbXHeavy";
            this.txbXHeavy.ReadOnly = true;
            this.txbXHeavy.Size = new System.Drawing.Size(98, 26);
            this.txbXHeavy.TabIndex = 39;
            this.txbXHeavy.TabStop = false;
            this.txbXHeavy.Text = "0";
            this.txbXHeavy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbXHeavy.WordWrap = false;
            // 
            // lbHeavy
            // 
            this.lbHeavy.AutoSize = true;
            this.lbHeavy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeavy.Location = new System.Drawing.Point(127, 157);
            this.lbHeavy.Name = "lbHeavy";
            this.lbHeavy.Size = new System.Drawing.Size(57, 20);
            this.lbHeavy.TabIndex = 10;
            this.lbHeavy.Text = "Heavy:";
            // 
            // txbMedium
            // 
            this.txbMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMedium.Location = new System.Drawing.Point(200, 124);
            this.txbMedium.Name = "txbMedium";
            this.txbMedium.ReadOnly = true;
            this.txbMedium.Size = new System.Drawing.Size(98, 26);
            this.txbMedium.TabIndex = 37;
            this.txbMedium.TabStop = false;
            this.txbMedium.Text = "0";
            this.txbMedium.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbMedium.WordWrap = false;
            // 
            // lbMedium
            // 
            this.lbMedium.AutoSize = true;
            this.lbMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMedium.Location = new System.Drawing.Point(115, 127);
            this.lbMedium.Name = "lbMedium";
            this.lbMedium.Size = new System.Drawing.Size(69, 20);
            this.lbMedium.TabIndex = 8;
            this.lbMedium.Text = "Medium:";
            // 
            // txbLight
            // 
            this.txbLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLight.Location = new System.Drawing.Point(200, 94);
            this.txbLight.Name = "txbLight";
            this.txbLight.ReadOnly = true;
            this.txbLight.Size = new System.Drawing.Size(98, 26);
            this.txbLight.TabIndex = 36;
            this.txbLight.TabStop = false;
            this.txbLight.Text = "0";
            this.txbLight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbLight.WordWrap = false;
            // 
            // lbLight
            // 
            this.lbLight.AutoSize = true;
            this.lbLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLight.Location = new System.Drawing.Point(136, 97);
            this.lbLight.Name = "lbLight";
            this.lbLight.Size = new System.Drawing.Size(48, 20);
            this.lbLight.TabIndex = 6;
            this.lbLight.Text = "Light:";
            // 
            // txbHeavy
            // 
            this.txbHeavy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHeavy.Location = new System.Drawing.Point(200, 154);
            this.txbHeavy.Name = "txbHeavy";
            this.txbHeavy.ReadOnly = true;
            this.txbHeavy.Size = new System.Drawing.Size(98, 26);
            this.txbHeavy.TabIndex = 38;
            this.txbHeavy.TabStop = false;
            this.txbHeavy.Text = "0";
            this.txbHeavy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbHeavy.WordWrap = false;
            // 
            // lbXLight
            // 
            this.lbXLight.AutoSize = true;
            this.lbXLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXLight.Location = new System.Drawing.Point(95, 67);
            this.lbXLight.Name = "lbXLight";
            this.lbXLight.Size = new System.Drawing.Size(89, 20);
            this.lbXLight.TabIndex = 0;
            this.lbXLight.Text = "Extra Light:";
            // 
            // txbXLight
            // 
            this.txbXLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbXLight.Location = new System.Drawing.Point(200, 64);
            this.txbXLight.Name = "txbXLight";
            this.txbXLight.ReadOnly = true;
            this.txbXLight.Size = new System.Drawing.Size(98, 26);
            this.txbXLight.TabIndex = 35;
            this.txbXLight.TabStop = false;
            this.txbXLight.Text = "0";
            this.txbXLight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbXLight.WordWrap = false;
            // 
            // btnShowPiecemarks
            // 
            this.btnShowPiecemarks.Enabled = false;
            this.btnShowPiecemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPiecemarks.Location = new System.Drawing.Point(346, 288);
            this.btnShowPiecemarks.Name = "btnShowPiecemarks";
            this.btnShowPiecemarks.Size = new System.Drawing.Size(80, 30);
            this.btnShowPiecemarks.TabIndex = 120;
            this.btnShowPiecemarks.Text = "&Show";
            this.btnShowPiecemarks.UseVisualStyleBackColor = true;
            this.btnShowPiecemarks.Click += new System.EventHandler(this.btnShowPiecemarks_Click);
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 617);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cblPiecemarks);
            this.Controls.Add(this.cmdPrintInvoice);
            this.Controls.Add(this.panWeights);
            this.Controls.Add(this.btnShowPiecemarks);
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.panWeights.ResumeLayout(false);
            this.panWeights.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblJob;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lbXXXHeavy;
        internal System.Windows.Forms.TextBox txbXXXHeavy;
        internal System.Drawing.Printing.PrintDocument PrintDoc;
        internal System.Windows.Forms.Label lblGrating;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox tbxGrating;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Label lbGrandTotal;
        internal System.Windows.Forms.TextBox txbGrandTotal;
        internal System.Windows.Forms.PrintPreviewDialog PrintPreview;
        internal System.Windows.Forms.Label lbSafetyGate;
        internal System.Windows.Forms.TextBox txbSafetyGate;
        internal System.Windows.Forms.Label lbFloorPlate;
        internal System.Windows.Forms.CheckedListBox cblPiecemarks;
        internal System.Windows.Forms.TextBox txbFloorPlate;
        internal System.Windows.Forms.Label lbCagedLadder;
        internal System.Windows.Forms.TextBox txbCagedLadder;
        internal System.Windows.Forms.Label lbLadder;
        internal System.Windows.Forms.Button cmdPrintInvoice;
        internal System.Windows.Forms.TextBox txbLadder;
        internal System.Windows.Forms.Label lbHandrail;
        internal System.Windows.Forms.TextBox txbHandrail;
        internal System.Windows.Forms.Label lbStairRail;
        internal System.Windows.Forms.TextBox txbStairRail;
        internal System.Windows.Forms.Label lbStairs;
        internal System.Windows.Forms.TextBox txbStairs;
        internal System.Windows.Forms.Panel panWeights;
        internal System.Windows.Forms.Label lbFames;
        internal System.Windows.Forms.TextBox txbFrames;
        internal System.Windows.Forms.Label lbXXHeavy;
        internal System.Windows.Forms.TextBox txbXXHeavy;
        internal System.Windows.Forms.Label lbXHeavy;
        internal System.Windows.Forms.TextBox txbXHeavy;
        internal System.Windows.Forms.Label lbHeavy;
        internal System.Windows.Forms.TextBox txbMedium;
        internal System.Windows.Forms.Label lbMedium;
        internal System.Windows.Forms.TextBox txbLight;
        internal System.Windows.Forms.Label lbLight;
        internal System.Windows.Forms.TextBox txbHeavy;
        internal System.Windows.Forms.Label lbXLight;
        internal System.Windows.Forms.TextBox txbXLight;
        internal System.Windows.Forms.Button btnShowPiecemarks;
    }
}