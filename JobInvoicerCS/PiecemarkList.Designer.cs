namespace JobInvoicerCS
{
    partial class PiecemarkList
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
            this.lblMaterialType = new System.Windows.Forms.Label();
            this.cmdPagePreview = new System.Windows.Forms.Button();
            this.cmdPageSetup = new System.Windows.Forms.Button();
            this.rtbPiecemarks = new System.Windows.Forms.RichTextBox();
            this.cmdPrintList = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaterialType
            // 
            this.lblMaterialType.AutoSize = true;
            this.lblMaterialType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialType.Location = new System.Drawing.Point(23, 12);
            this.lblMaterialType.Name = "lblMaterialType";
            this.lblMaterialType.Size = new System.Drawing.Size(57, 20);
            this.lblMaterialType.TabIndex = 12;
            this.lblMaterialType.Text = "Label1";
            // 
            // cmdPagePreview
            // 
            this.cmdPagePreview.Location = new System.Drawing.Point(155, 486);
            this.cmdPagePreview.Name = "cmdPagePreview";
            this.cmdPagePreview.Size = new System.Drawing.Size(90, 23);
            this.cmdPagePreview.TabIndex = 11;
            this.cmdPagePreview.Text = "Page &Preview";
            this.cmdPagePreview.UseVisualStyleBackColor = true;
            this.cmdPagePreview.Click += new System.EventHandler(this.cmdPagePreview_Click);
            // 
            // cmdPageSetup
            // 
            this.cmdPageSetup.Location = new System.Drawing.Point(58, 486);
            this.cmdPageSetup.Name = "cmdPageSetup";
            this.cmdPageSetup.Size = new System.Drawing.Size(75, 23);
            this.cmdPageSetup.TabIndex = 10;
            this.cmdPageSetup.Text = "Page &Setup";
            this.cmdPageSetup.UseVisualStyleBackColor = true;
            this.cmdPageSetup.Click += new System.EventHandler(this.cmdPageSetup_Click);
            // 
            // rtbPiecemarks
            // 
            this.rtbPiecemarks.Location = new System.Drawing.Point(12, 41);
            this.rtbPiecemarks.Name = "rtbPiecemarks";
            this.rtbPiecemarks.Size = new System.Drawing.Size(635, 426);
            this.rtbPiecemarks.TabIndex = 9;
            this.rtbPiecemarks.Text = "";
            // 
            // cmdPrintList
            // 
            this.cmdPrintList.Location = new System.Drawing.Point(265, 486);
            this.cmdPrintList.Name = "cmdPrintList";
            this.cmdPrintList.Size = new System.Drawing.Size(75, 23);
            this.cmdPrintList.TabIndex = 8;
            this.cmdPrintList.Text = "Print &List";
            this.cmdPrintList.UseVisualStyleBackColor = true;
            this.cmdPrintList.Click += new System.EventHandler(this.cmdPrintList_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(542, 486);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 7;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PiecemarkList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 516);
            this.Controls.Add(this.lblMaterialType);
            this.Controls.Add(this.cmdPagePreview);
            this.Controls.Add(this.cmdPageSetup);
            this.Controls.Add(this.rtbPiecemarks);
            this.Controls.Add(this.cmdPrintList);
            this.Controls.Add(this.cmdCancel);
            this.Name = "PiecemarkList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Piecemark List";
            this.Load += new System.EventHandler(this.PiecemarkList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblMaterialType;
        internal System.Windows.Forms.Button cmdPagePreview;
        internal System.Windows.Forms.Button cmdPageSetup;
        internal System.Windows.Forms.RichTextBox rtbPiecemarks;
        internal System.Windows.Forms.Button cmdPrintList;
        internal System.Windows.Forms.Button cmdCancel;
    }
}