using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace JobInvoicerCS
{
    public partial class PiecemarkList : Form
    {
        //internal ArrayList XLightList = new ArrayList();
        //internal ArrayList LightList = new ArrayList();
        //internal ArrayList MediumList = new ArrayList();
        //internal ArrayList HeavyList = new ArrayList();
        //internal ArrayList XHeavyList = new ArrayList();
        //internal ArrayList XxHeavyList = new ArrayList();
        //internal ArrayList XxxHeavyList = new ArrayList();
        //internal ArrayList FrameList = new ArrayList();
        internal List<string> XLightList;
        internal List<string> LightList;
        internal List<string> MediumList;
        internal List<string> HeavyList;
        internal List<string> XHeavyList;
        internal List<string> XxHeavyList;
        internal List<string> XxxHeavyList;
        internal List<string> FrameList;
        internal List<string> StairsList;
        internal List<string> StairRailsList;
        internal List<string> FloorPlateList;
        internal List<string> SafetyGateList;
        internal List<string> CagedLadderList;
        internal List<string> LadderList;
        internal List<string> HandrailList;
        internal List<string> GratingList;
        internal string Type;

        private readonly PrintDocument _documentToPrint = new PrintDocument();
        private int _checkPrint;
        private readonly PrintDialog _print = new PrintDialog();
        private readonly PageSetupDialog _pageSetup = new PageSetupDialog();
        private readonly PrintPreviewDialog _printPreview = new PrintPreviewDialog();

        private readonly RichTextBoxPrintCtrl.RichTextBoxPrintCtrl _rtbPrintCtrl =
            new RichTextBoxPrintCtrl.RichTextBoxPrintCtrl();

        private bool _eventsSubscribed;

        private void SubscribeToEvents()
        {
            if (_eventsSubscribed)
                return;
            _eventsSubscribed = true;

            _documentToPrint.BeginPrint += docToPrint_BeginPrint;
            _documentToPrint.PrintPage += docToPrint_PrintPage;
        }

        private void docToPrint_BeginPrint(object sender, PrintEventArgs e)
        {
            _checkPrint = 0;
        }

        private void docToPrint_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Print the content of the RichTextBox. Store the last chracter printed
            _checkPrint = _rtbPrintCtrl.Print(_checkPrint, _rtbPrintCtrl.TextLength, e);

            // Look for more pages
            e.HasMorePages = _checkPrint < _rtbPrintCtrl.TextLength;
        }

        private void cmdPageSetup_Click(object sender, EventArgs e)
        {
            _pageSetup.ShowDialog();
        }

        private void cmdPagePreview_Click(object sender, EventArgs e)
        {
            _printPreview.ShowDialog();
        }

        private void cmdPrintList_Click(object sender, EventArgs e)
        {
            if (_print.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            _documentToPrint.Print();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PiecemarkList_Load(object sender, EventArgs e)
        {
            SubscribeToEvents();
            _print.Document = _documentToPrint;
            _printPreview.Document = _documentToPrint;
            _pageSetup.Document = _documentToPrint;
            int count;
            lblMaterialType.Text = Type;
            switch (Type)
            {
                case "XLight":
                    _rtbPrintCtrl.AppendText("Piecemarks for Extra Light:     ");
                    count = XLightList.Count - 1;
                    foreach (var mbr in XLightList)
                    {
                        rtbPiecemarks.AppendText(mbr);
                        _rtbPrintCtrl.AppendText(mbr);
                        if (count > 0)
                        {
                            rtbPiecemarks.AppendText(", ");
                            _rtbPrintCtrl.AppendText(", ");
                        }
                        count = count - 1;
                    }
                    break;
                case "Light":
                    _rtbPrintCtrl.AppendText("Piecemarks for Light:     ");

                    count = LightList.Count - 1;
                    foreach (var mbr in LightList)
                    {
                        rtbPiecemarks.AppendText(mbr);
                        _rtbPrintCtrl.AppendText(mbr);
                        if (count > 0)
                        {
                            rtbPiecemarks.AppendText(", ");
                            _rtbPrintCtrl.AppendText(", ");
                        }
                        count = count - 1;
                    }
                    break;
                case "Medium":
                    _rtbPrintCtrl.AppendText("Piecemarks for Medium:     ");

                    count = MediumList.Count - 1;
                    foreach (var mbr in MediumList)
                    {
                        rtbPiecemarks.AppendText(mbr);
                        _rtbPrintCtrl.AppendText(mbr);
                        if (count > 0)
                        {
                            rtbPiecemarks.AppendText(", ");
                            _rtbPrintCtrl.AppendText(", ");
                        }
                        count = count - 1;
                    }
                    break;
                case "Heavy":
                    _rtbPrintCtrl.AppendText("Piecemarks for Heavy:     ");

                    count = HeavyList.Count - 1;
                    foreach (var mbr in HeavyList)
                    {
                        rtbPiecemarks.AppendText(mbr);
                        _rtbPrintCtrl.AppendText(mbr);
                        if (count > 0)
                        {
                            rtbPiecemarks.AppendText(", ");
                            _rtbPrintCtrl.AppendText(", ");
                        }
                        count = count - 1;
                    }
                    break;
                case "XHeavy":
                    _rtbPrintCtrl.AppendText("Piecemarks for Extra Heavy:     ");

                    count = XHeavyList.Count - 1;
                    foreach (var mbr in XHeavyList)
                    {
                        rtbPiecemarks.AppendText(mbr);
                        _rtbPrintCtrl.AppendText(mbr);
                        if (count > 0)
                        {
                            rtbPiecemarks.AppendText(", ");
                            _rtbPrintCtrl.AppendText(", ");
                        }
                        count = count - 1;
                    }
                    break;
                case "XXHeavy":
                    _rtbPrintCtrl.AppendText("Piecemarks for Double Heavy:     ");

                    count = XxHeavyList.Count - 1;
                    foreach (var mbr in XxHeavyList)
                    {
                        rtbPiecemarks.AppendText(mbr);
                        _rtbPrintCtrl.AppendText(mbr);
                        if (count > 0)
                        {
                            rtbPiecemarks.AppendText(", ");
                            _rtbPrintCtrl.AppendText(", ");
                        }
                        count = count - 1;
                    }
                    break;
                case "XXXHeavy":
                    _rtbPrintCtrl.AppendText("Piecemarks for Triple Heavy:     ");

                    count = XxxHeavyList.Count - 1;
                    foreach (var mbr in XxxHeavyList)
                    {
                        rtbPiecemarks.AppendText(mbr);
                        _rtbPrintCtrl.AppendText(mbr);
                        if (count > 0)
                        {
                            rtbPiecemarks.AppendText(", ");
                            _rtbPrintCtrl.AppendText(", ");
                        }
                        count = count - 1;
                    }
                    break;
                case "Frames":
                    _rtbPrintCtrl.AppendText("Piecemarks for Frames:     ");

                    count = FrameList.Count - 1;
                    foreach (var mbr in FrameList)
                    {
                        rtbPiecemarks.AppendText(mbr);
                        _rtbPrintCtrl.AppendText(mbr);
                        if (count > 0)
                        {
                            rtbPiecemarks.AppendText(", ");
                            _rtbPrintCtrl.AppendText(", ");
                        }
                        count = count - 1;
                    }
                    break;
                case "Stairs":
                    _rtbPrintCtrl.AppendText("Piecemarks for Stairs:     ");

                    count = StairsList.Count - 1;
                    foreach (var mbr in StairsList)
                    {
                        rtbPiecemarks.AppendText(mbr);
                        _rtbPrintCtrl.AppendText(mbr);
                        if (count > 0)
                        {
                            rtbPiecemarks.AppendText(", ");
                            _rtbPrintCtrl.AppendText(", ");
                        }
                        count = count - 1;
                    }
                    break;
                case "Stair Rails":
                    _rtbPrintCtrl.AppendText("Piecemarks for Stair Rails:     ");

                    count = StairRailsList.Count - 1;
                    foreach (var mbr in StairRailsList)
                    {
                        rtbPiecemarks.AppendText(mbr);
                        _rtbPrintCtrl.AppendText(mbr);
                        if (count > 0)
                        {
                            rtbPiecemarks.AppendText(", ");
                            _rtbPrintCtrl.AppendText(", ");
                        }
                        count = count - 1;
                    }
                    break;
                case "Handrails":
                    _rtbPrintCtrl.AppendText("Piecemarks for Handrails:     ");

                    count = HandrailList.Count - 1;
                    foreach (var mbr in HandrailList)
                    {
                        rtbPiecemarks.AppendText(mbr);
                        _rtbPrintCtrl.AppendText(mbr);
                        if (count > 0)
                        {
                            rtbPiecemarks.AppendText(", ");
                            _rtbPrintCtrl.AppendText(", ");
                        }
                        count = count - 1;
                    }
                    break;
                case "Ladders":
                    _rtbPrintCtrl.AppendText("Piecemarks for Ladders:     ");

                    count = LadderList.Count - 1;
                    foreach (var mbr in LadderList)
                    {
                        rtbPiecemarks.AppendText(mbr);
                        _rtbPrintCtrl.AppendText(mbr);
                        if (count > 0)
                        {
                            rtbPiecemarks.AppendText(", ");
                            _rtbPrintCtrl.AppendText(", ");
                        }
                        count = count - 1;
                    }
                    break;
                case "Caged Ladders":
                    _rtbPrintCtrl.AppendText("Piecemarks for Caged Ladders:     ");

                    count = CagedLadderList.Count - 1;
                    foreach (var mbr in CagedLadderList)
                    {
                        rtbPiecemarks.AppendText(mbr);
                        _rtbPrintCtrl.AppendText(mbr);
                        if (count > 0)
                        {
                            rtbPiecemarks.AppendText(", ");
                            _rtbPrintCtrl.AppendText(", ");
                        }
                        count = count - 1;
                    }
                    break;
                case "Floor Plates":
                    _rtbPrintCtrl.AppendText("Piecemarks for Floor Plates:     ");

                    count = FloorPlateList.Count - 1;
                    foreach (var mbr in FloorPlateList)
                    {
                        rtbPiecemarks.AppendText(mbr);
                        _rtbPrintCtrl.AppendText(mbr);
                        if (count > 0)
                        {
                            rtbPiecemarks.AppendText(", ");
                            _rtbPrintCtrl.AppendText(", ");
                        }
                        count = count - 1;
                    }
                    break;
                case "Safety Gates":
                    _rtbPrintCtrl.AppendText("Piecemarks for Safety Gates:     ");

                    count = SafetyGateList.Count - 1;
                    foreach (var mbr in SafetyGateList)
                    {
                        rtbPiecemarks.AppendText(mbr);
                        _rtbPrintCtrl.AppendText(mbr);
                        if (count > 0)
                        {
                            rtbPiecemarks.AppendText(", ");
                            _rtbPrintCtrl.AppendText(", ");
                        }
                        count = count - 1;
                    }
                    break;
                case "Gratings":
                    _rtbPrintCtrl.AppendText("Piecemarks for Gratings:     ");

                    count = GratingList.Count - 1;
                    foreach (var mbr in GratingList)
                    {
                        rtbPiecemarks.AppendText(mbr);
                        _rtbPrintCtrl.AppendText(mbr);
                        if (count > 0)
                        {
                            rtbPiecemarks.AppendText(", ");
                            _rtbPrintCtrl.AppendText(", ");
                        }
                        count = count - 1;
                    }
                    break;
            }
        }
    }
}