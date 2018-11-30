using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace JobInvoicerCS
{
    public partial class Invoice : Form
    {
        public List<string> XLightList;
        public List<string> LightList;
        public List<string> MediumList;
        public List<string> HeavyList;
        public List<string> XHeavyList;
        public List<string> XxHeavyList;
        public List<string> XxxHeavyList;
        public List<string> FrameList;
        public List<string> StairsList;
        public List<string> StairRailsList;
        public List<string> FloorPlateList;
        public List<string> SafetyGateList;
        public List<string> CagedLadderList;
        public List<string> LadderList;
        public List<string> HandrailList;
        public List<string> GratingList;

        public Invoice()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Bitmap _bmpPanel;

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            var rect = new Rectangle(new Point(0, 0), _bmpPanel.Size); // get the size of the image
            e.Graphics.DrawImage(_bmpPanel, rect); //Draw Image
        }

        private const int Srccopy = 0xCC0020;

        [System.Runtime.InteropServices.DllImport("gdi32", EntryPoint = "BitBlt", ExactSpelling = true,
            CharSet = System.Runtime.InteropServices.CharSet.Ansi, SetLastError = true)]
        private static extern int BitBlt(IntPtr hDestDc, int x, int y, int nWidth, int nHeight, IntPtr hSrcDc, int xSrc,
            int ySrc, int dwRop);

        private static Bitmap CaptureControl(Control c)
        {
            var tempCaptureControl = new Bitmap(c.Width, c.Height);

            var gSource = c.CreateGraphics();
            try
            {
                var gDest = Graphics.FromImage(tempCaptureControl);
                try
                {
                    var hdcSource = gSource.GetHdc();
                    try
                    {
                        var hdcDest = gDest.GetHdc();
                        try
                        {
                            BitBlt(hdcDest, 0, 0, c.Width, c.Height, hdcSource, 0, 0, Srccopy);
                        }
                        finally
                        {
                            gDest.ReleaseHdc(hdcDest);
                        }
                    }
                    finally
                    {
                        gSource.ReleaseHdc(hdcSource);
                    }
                }
                finally
                {
                    gDest.Dispose();
                }
            }
            finally
            {
                gSource.Dispose();
            }

            return tempCaptureControl;
        }

        private void cmdPrintInvoice_Click(object sender, EventArgs e)
        {
            _bmpPanel = CaptureControl(panWeights);
            PrintPreview.Document = PrintDoc;

            PrintPreview.ShowDialog();
        }

        private void cblPiecemarks_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (var i = 0; i < cblPiecemarks.Items.Count; i++)
            {
                cblPiecemarks.SetItemCheckState(i, CheckState.Unchecked);
            }
            cblPiecemarks.SetItemCheckState(cblPiecemarks.SelectedIndex, CheckState.Checked);
            btnShowPiecemarks.Enabled = true;
        }

        private void btnShowPiecemarks_Click(object sender, EventArgs e)
        {
            var myPml = new PiecemarkList {Type = (string) cblPiecemarks.SelectedItem};
            switch (myPml.Type)
            {
                case "XLight":
                    myPml.XLightList = XLightList;
                    break;
                case "Light":
                    myPml.LightList = LightList;
                    break;
                case "Medium":
                    myPml.MediumList = MediumList;
                    break;
                case "Heavy":
                    myPml.HeavyList = HeavyList;
                    break;
                case "XHeavy":
                    myPml.XHeavyList = XHeavyList;
                    break;
                case "XXHeavy":
                    myPml.XxHeavyList = XxHeavyList;
                    break;
                case "XXXHeavy":
                    myPml.XxxHeavyList = XxxHeavyList;
                    break;
                case "Frames":
                    myPml.FrameList = FrameList;
                    break;
                case "Stairs":
                    myPml.StairsList = StairsList;
                    break;
                case "Stair Rails":
                    myPml.StairRailsList = StairRailsList;
                    break;
                case "Handrails":
                    myPml.HandrailList = HandrailList;
                    break;
                case "Ladders":
                    myPml.LadderList = LadderList;
                    break;
                case "Caged Ladders":
                    myPml.CagedLadderList = CagedLadderList;
                    break;
                case "Floor Plates":
                    myPml.FloorPlateList = FloorPlateList;
                    break;
                case "Safety Gates":
                    myPml.SafetyGateList = SafetyGateList;
                    break;
                case "Gratings":
                    myPml.GratingList = GratingList;
                    break;
                //default:
                //    MessageBox(@"List does not exist");
                //    break;
            }
            Hide();
            myPml.ShowDialog();
            Show();
        }
    }
}
