using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

//using System.Xml.Linq;
//using System.Xml.Serialization;

namespace JobInvoicerCS
{
    public sealed partial class MainForm : Form
    {
        //InchFraction inchfac = new InchFraction();
        private readonly Bill _bill = new Bill();


        //materials = StructuralMaterials.ToList();
        // foreach (Material material in StructuralMaterials.ToList.Where(m => m.Size == Beam.Material))
        //public Materials StructuralMaterials = new Materials();


        //private readonly Fractions _fractions = new Fractions();

        private decimal DFrames      { get; set; }
        private decimal DStairRail   { get; set; }
        private decimal DStair       { get; set; }
        private decimal DHandrail    { get; set; }
        private decimal DLadder      { get; set; }
        private decimal DCagedLadder { get; set; }
        private decimal DFloorPlate  { get; set; }
        private decimal DGrating     { get; set; }
        private decimal DSafetyGate  { get; set; }
        private decimal DxLight      { get; set; }
        private decimal DLight       { get; set; }
        private decimal DMedium      { get; set; }
        private decimal DHeavy       { get; set; }
        private decimal DxHeavy      { get; set; }
        private decimal DXxHeavy     { get; set; }
        private decimal DXxxHeavy    { get; set; }

        //private int _retries;
        private decimal _dMin;
        private decimal _dMax = -1;

        private readonly CheckBox[]      _checkBoxs;
        private readonly NumericUpDown[] _minimumsNumericUpDowns;
        private readonly NumericUpDown[] _maximumsNumericUpDowns;

        //private readonly ArrayList _xLightList = new ArrayList();
        //private readonly ArrayList _lightList = new ArrayList();
        //private readonly ArrayList _mediumList = new ArrayList();
        //private readonly ArrayList _heavyList = new ArrayList();
        //private readonly ArrayList _xHeavyList = new ArrayList();
        //private readonly ArrayList _xxHeavyList = new ArrayList();
        //private readonly ArrayList _xxxHeavyList = new ArrayList();
        //private readonly ArrayList _frameList = new ArrayList();
        private readonly List<string> _xLightList   = new List<string>();
        private readonly List<string> _lightList    = new List<string>();
        private readonly List<string> _mediumList   = new List<string>();
        private readonly List<string> _heavyList    = new List<string>();
        private readonly List<string> _xHeavyList   = new List<string>();
        private readonly List<string> _xxHeavyList  = new List<string>();
        private readonly List<string> _xxxHeavyList = new List<string>();
        private readonly List<string> _frameList    = new List<string>();

        private readonly string _structType = string.Empty;

        // Lists of Structure and Misc Sheets
        private const string S = "Struct";

        //Weight Type
        private const string XLight   = "XLight";
        private const string Light    = "Light";
        private const string Medium   = "Medium";
        private const string Heavy    = "Heavy";
        private const string XHeavy   = "XHeavy";
        private const string XxHeavy  = "XXHeavy";
        private const string XxxHeavy = "XXXHeavy";

        //Member Type
        private const string Beam        = "Beam";
        private const string Column      = "Column";
        private const string Brace       = "Brace";
        private const string Plate       = "Plate";
        private const string Girt        = "Girt";
        private const string Angle       = "Angle";
        private const string Misc        = "Misc";
        private const string SagRod      = "SagRod";
        private const string Frame       = "Frame";
        private const string CagedLadder = "CagedLadder";
        private const string Ladder      = "Ladder";
        private const string Handrail    = "Handrail";
        private const string FloorPlate  = "FloorPlate";
        private const string Truss       = "Truss";
        private const string StairRail   = "StairRail";
        private const string Stair       = "Stair";
        private const string SafetyGate  = "SafetyGate";

        private string _structCategoryType;

        private string _pcMk  = string.Empty;
        private string _sz    = string.Empty;
        private string _wght  = string.Empty;
        private string _mType = string.Empty;
        private string JName { get; set; }


        private void DisableNumericUpDowns()
        {
            // disable everything:
            foreach (var n in _minimumsNumericUpDowns)
            {
                if (n != null)
                    n.Enabled = false;
            }

            foreach (var n in _maximumsNumericUpDowns)
            {
                if (n != null)
                    n.Enabled = false;
            }
        }

        private static double WeightPerFoot(string materialSize)
        {
            var words = materialSize.Split('x');
            return Convert.ToDouble(words[1]);
        }


        public MainForm()
        {
            InitializeComponent();
            SubscribeToEvents();
            _checkBoxs = new[] {cbXLight, cbLight, cbMedium, cbHeavy, cbXHeavy, cbXXHeavy, cbXXXHeavy};
            _minimumsNumericUpDowns = new[]
                                      {null, nLightMin, nMediumMin, nHeavyMin, nXHeavyMin, nXXHeavyMin, nXXXHeavyMin};
            _maximumsNumericUpDowns = new[]
                                      {nXLightMax, nLightMax, nMediumMax, nHeavyMax, nXHeavyMax, nXXHeavyMax, null};
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //var material = XDocument.Load(@"XmlFiles\Materials.xml");

            //var path = @"XmlFiles\Materials.xml";
            //var serial = new XmlSerializer(typeof(Material));
            //var reader = new StreamReader(path);

            //StructuralMaterials = (Materials)serial.Deserialize(reader);
            //reader.Close();

            //Console.WriteLine("Complete list:");
            //foreach (Material material in StructuralMaterials.ToList)
            //{
            //    Console.WriteLine(material.ToString());
            //}

            //Console.WriteLine("\nFiltered list:");
            //foreach (Material material in StructuralMaterials.ToList.Where(m => m.Size == "W44x335"))
            //{
            //    Console.WriteLine(material.ToString());
            //}
        }

        private void CheckBox_NumericState(object sender, EventArgs e)
        {
            // disable everything
            DisableNumericUpDowns();

            // see if more than one checkbox is checked:
            var numChecked = _checkBoxs.Count((cb) => cb.Checked);

            // enable things if more than one item is checked:
            if (numChecked <= 1) return;

            // find the smallest and enable its max:
            var smallest = -1;
            for (var i = 0; i < _checkBoxs.Length; i++)
            {
                if (!_checkBoxs[i].Checked) continue;
                if (_maximumsNumericUpDowns[i] != null)
                {
                    _maximumsNumericUpDowns[i].Enabled = true;
                }

                smallest = i;
                break;
            }

            // find the largest and enable its min:
            var largest = -1;
            for (var i = _checkBoxs.Length - 1; i >= 0; i--)
            {
                if (!_checkBoxs[i].Checked) continue;
                if (_minimumsNumericUpDowns[i] != null)
                {
                    _minimumsNumericUpDowns[i].Enabled = true;
                }

                largest = i;
                break;
            }

            // enable both for everything between smallest and largest:
            var tempVar = largest - 1;
            for (var i = (smallest + 1); i <= tempVar; i++)
            {
                if (!_checkBoxs[i].Checked) continue;
                if (_minimumsNumericUpDowns[i] != null)
                {
                    _minimumsNumericUpDowns[i].Enabled = true;
                }

                if (_maximumsNumericUpDowns[i] != null)
                {
                    _maximumsNumericUpDowns[i].Enabled = true;
                }
            }
        }

        private bool _eventsSubscribed;

        private void SubscribeToEvents()
        {
            if (_eventsSubscribed)
                return;
            _eventsSubscribed = true;

            cbXXHeavy.CheckedChanged  += CheckBox_NumericState;
            cbXHeavy.CheckedChanged   += CheckBox_NumericState;
            cbXLight.CheckedChanged   += CheckBox_NumericState;
            cbHeavy.CheckedChanged    += CheckBox_NumericState;
            cbLight.CheckedChanged    += CheckBox_NumericState;
            cbMedium.CheckedChanged   += CheckBox_NumericState;
            cbXXXHeavy.CheckedChanged += CheckBox_NumericState;
        }


        private void cmdCalculate_Click(object sender, EventArgs e)
        {
        }

        private void GetStructureWeight()
        {
            // Extra Light
            if (!cbXLight.Checked) return;
            if (nXLightMax.Enabled == false)
            {
                _structCategoryType = XLight;
                CheckStructureSheets();
            }
            else
            {
                if (nXLightMax.Value > 0)
                {
                    _dMax               = nXLightMax.Value;
                    _structCategoryType = XLight;
                    CheckStructureSheets();
                }
                else
                {
                    MessageBox.Show(@"Extra Light Max cannot be zero (0)");
                }
            }

            // Light
            if (cbLight.Checked)
            {
                if (nLightMin.Enabled == false && nLightMax.Enabled == false)
                {
                    _structCategoryType = Light;
                    CheckStructureSheets();
                }
                else
                {
                    if (nLightMin.Enabled && nLightMin.Value > 0)
                    {
                        if (nXLightMax.Enabled && nLightMin.Enabled && nLightMax.Enabled == false)
                        {
                            _dMin               = nLightMin.Value;
                            _structCategoryType = Light;
                            CheckStructureSheets();
                        }
                        else
                        {
                            if (nLightMax.Value > 0)
                            {
                                _dMin               = nLightMin.Value;
                                _dMax               = nLightMax.Value;
                                _structCategoryType = Light;
                                CheckStructureSheets();
                            }
                            else
                            {
                                MessageBox.Show(@"Light Max cannot be zero (0)");
                                return;
                            }
                        }
                    }
                    else if (nLightMin.Enabled == false && nLightMax.Enabled)
                    {
                        if (nLightMax.Value > 0)
                        {
                            _dMax               = nLightMax.Value;
                            _structCategoryType = Light;
                            CheckStructureSheets();
                        }
                        else
                        {
                            MessageBox.Show(@"Light Max cannot be zero (0)");
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Light Min cannot be zero (0)");
                        return;
                    }
                }
            }

            // Medium
            if (!cbMedium.Checked) return;
            if (nMediumMin.Enabled == false && nMediumMax.Enabled == false)
            {
                _structCategoryType = Medium;
                CheckStructureSheets();
            }
            else
            {
                if (nMediumMin.Enabled && nMediumMin.Value > 0)
                {
                    if ((nMediumMin.Enabled && nXLightMax.Enabled || nLightMax.Enabled) && nMediumMax.Enabled == false)
                    {
                        _dMin               = nMediumMin.Value;
                        _structCategoryType = Medium;
                        CheckStructureSheets();
                    }
                    else
                    {
                        if (nMediumMax.Value > 0)
                        {
                            _dMin               = nMediumMin.Value;
                            _dMax               = nMediumMax.Value;
                            _structCategoryType = Medium;
                            CheckStructureSheets();
                        }
                        else
                        {
                            MessageBox.Show(@"Medium Max cannot be zero (0)");
                        }
                    }
                }
                else if (nMediumMin.Enabled == false && nMediumMax.Enabled)
                {
                    if (nMediumMax.Value > 0)
                    {
                        _dMax               = nMediumMax.Value;
                        _structCategoryType = Medium;
                        CheckStructureSheets();
                    }
                    else
                    {
                        MessageBox.Show(@"Medium Max cannot be zero (0)");
                    }
                }
                else
                {
                    MessageBox.Show(@"Medium Min cannot be zero (0)");
                }
            }

            //Heavy
            if (cbHeavy.Checked)
            {
                if (nHeavyMin.Enabled == false && nHeavyMax.Enabled == false)
                {
                    _structCategoryType = Heavy;
                    CheckStructureSheets();
                }
                else
                {
                    if (nHeavyMin.Enabled && nHeavyMin.Value > 0)
                    {
                        if ((nHeavyMin.Enabled && nXLightMax.Enabled || nLightMax.Enabled || nMediumMax.Enabled) &&
                            nHeavyMax.Enabled == false)
                        {
                            _dMin               = nHeavyMin.Value;
                            _structCategoryType = Heavy;
                            CheckStructureSheets();
                        }
                        else
                        {
                            if (nHeavyMax.Value > 0)
                            {
                                _dMin               = nHeavyMin.Value;
                                _dMax               = nHeavyMax.Value;
                                _structCategoryType = Heavy;
                                CheckStructureSheets();
                            }
                            else
                            {
                                MessageBox.Show(@"Heavy Max cannot be zero (0)");
                                return;
                            }
                        }
                    }
                    else if (nHeavyMin.Enabled == false && nHeavyMax.Enabled)
                    {
                        if (nHeavyMax.Value > 0)
                        {
                            _dMax               = nHeavyMax.Value;
                            _structCategoryType = Heavy;
                            CheckStructureSheets();
                        }
                        else
                        {
                            MessageBox.Show(@"Heavy Max cannot be zero (0)");
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Heavy Min cannot be zero (0)");
                        return;
                    }
                }
            }

            // X Heavy
            if (cbXHeavy.Checked)
            {
                if (nXHeavyMin.Enabled == false && nXHeavyMax.Enabled == false)
                {
                    _structCategoryType = XHeavy;
                    CheckStructureSheets();
                }
                else
                {
                    if (nXHeavyMin.Enabled && nXHeavyMin.Value > 0)
                    {
                        if ((nXHeavyMin.Enabled && nXLightMax.Enabled || nLightMax.Enabled || nMediumMin.Enabled ||
                             nHeavyMin.Enabled) && !nXHeavyMax.Enabled)
                        {
                            _dMin               = nXHeavyMin.Value;
                            _structCategoryType = XHeavy;
                            CheckStructureSheets();
                        }
                        else
                        {
                            if (nXHeavyMax.Value > 0)
                            {
                                _dMin               = nXHeavyMin.Value;
                                _dMax               = nXHeavyMax.Value;
                                _structCategoryType = XHeavy;
                                CheckStructureSheets();
                            }
                            else
                            {
                                MessageBox.Show(@"Extra Heavy Max cannot be zero (0)");
                                return;
                            }
                        }
                    }
                    else if (nXHeavyMin.Enabled == false && nXHeavyMax.Enabled)
                    {
                        if (nXHeavyMax.Value > 0)
                        {
                            _dMax               = nXHeavyMax.Value;
                            _structCategoryType = XHeavy;
                            CheckStructureSheets();
                        }
                        else
                        {
                            MessageBox.Show(@"Extra Heavy Max cannot be zero (0)");
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Extra Heavy Min cannot be zero (0)");
                        return;
                    }
                }
            }

            // XX Heavy
            if (cbXXHeavy.Checked)
            {
                if (nXXHeavyMin.Enabled == false && nXXHeavyMax.Enabled == false)
                {
                    _structCategoryType = XxHeavy;
                    CheckStructureSheets();
                }
                else
                {
                    if (nXXHeavyMin.Enabled && nXXHeavyMin.Value > 0)
                    {
                        if ((nXXXHeavyMin.Enabled && nXLightMax.Enabled || nLightMax.Enabled || nMediumMin.Enabled ||
                             nHeavyMin.Enabled                          || nXHeavyMin.Enabled) && !nXXHeavyMax.Enabled)
                        {
                            _dMin               = nXXHeavyMin.Value;
                            _structCategoryType = XxHeavy;
                            CheckStructureSheets();
                        }
                        else
                        {
                            if (nXXHeavyMax.Value > 0)
                            {
                                _dMin               = nXXHeavyMin.Value;
                                _dMax               = nXXHeavyMax.Value;
                                _structCategoryType = XxHeavy;
                                CheckStructureSheets();
                            }
                            else
                            {
                                MessageBox.Show(@"Double Heavy Max cannot be zero (0)");
                                return;
                            }
                        }
                    }
                    else if (nXXHeavyMin.Enabled == false && nXXHeavyMax.Enabled)
                    {
                        if (nXXHeavyMax.Value > 0)
                        {
                            _dMax               = nXXHeavyMax.Value;
                            _structCategoryType = XxHeavy;
                            CheckStructureSheets();
                        }
                        else
                        {
                            MessageBox.Show(@"Double Heavy Max cannot be zero (0)");
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Double Heavy Min cannot be zero (0)");
                        return;
                    }
                }
            }

            // XXX Heavy
            if (cbXXXHeavy.Checked)
            {
                if (nXXXHeavyMin.Enabled == false)
                {
                    _structCategoryType = XxxHeavy;
                    CheckStructureSheets();
                }
                else
                {
                    if (nXXXHeavyMin.Enabled && nXXXHeavyMin.Value > 0)
                    {
                        _dMin               = nXXXHeavyMin.Value;
                        _structCategoryType = XxxHeavy;
                        CheckStructureSheets();
                    }
                    else
                    {
                        MessageBox.Show(@"Triple Heavy Min cannot be zero (0)");
                        return;
                    }
                }
            }

            // Frame
            if (cbFrame.Checked)
            {
                _structCategoryType = Frame;
                CheckStructureSheets();
            }

            // Handrail
            if (cbHandrail.Checked)
            {
                DHandrail = (decimal) MbrSheet.WeightByType(Handrail);
            }

            // Stair
            if (cbStair.Checked)
            {
                DStair = (decimal) MbrSheet.WeightByType(Stair);
            }

            // Stair Rail
            if (cbStairRail.Checked)
            {
                DStairRail = (decimal) MbrSheet.WeightByType(StairRail);
            }

            // Laddder
            if (cbLadder.Checked)
            {
                DLadder = (decimal) MbrSheet.WeightByType(Ladder);
            }

            // Caged Ladder
            if (cbCagedLadder.Checked)
            {
                DCagedLadder = (decimal) MbrSheet.WeightByType(CagedLadder);
            }

            // Floor Plate
            if (cbFloorPlate.Checked)
            {
                DFloorPlate = (decimal) MbrSheet.WeightByType(FloorPlate);
            }

            // Safety Gate
            if (cbSafetyGate.Checked)
            {
                DSafetyGate = (decimal) MbrSheet.WeightByType(SafetyGate);
            }
        }

        private static void CheckStructureSheets()
        {
            //foreach (var sht in _jobInvoicer.StructList)
            //foreach (var billSheet in _bill.Sheets)
            //{
            //    for (var mbrIndex = 0; mbrIndex < _bill.NumberOfSheets; mbrIndex++)
            //    {
            //        foreach (var billSheetDetail in billSheet.Details)
            //        {
            //            _pcMk = billSheetDetail.Piecemark;
            //            foreach (var line in billSheetDetail.Lines)
            //            {
            //                _sz=line.
            //            }
            //        }
            //    }
            //}
            //{
            //    //INSTANT C# NOTE: The ending condition of VB 'For' loops is tested only on entry to the loop. Instant C# has created a temporary variable in order to use the initial value of Sheet.Sheets.Item(sht).Members.Count for every iteration:
            //    //int tempVar = Sheet.Sheets.Item(sht).Members.Count;
            //    var tempVar = _bill.NumberOfSheets;
            //    for (var mbrIndex = 0; mbrIndex < tempVar; mbrIndex++)
            //    {

            //        //_pcMk = Sheet.Sheets.Item(sht).Members(MbrIndex).Piecemark;
            //        _pcMk=_bill.
            //        _sz = Sheet.Sheets.Item(sht).Members(mbrIndex).Size;
            //        _wght = Sheet.Sheets.Item(sht).Members(mbrIndex).TotalWeight;
            //        _mType = Sheet.Sheets.Item(sht).Members(mbrIndex).MemberType;
            //        _structType = Sheet.Sheets.Item(sht).Members(mbrIndex).StructType;
            //        CheckMemberByCategory();
            //    }
            //}
        }

        private void CheckMemberByCategory()
        {
            if (_structType != S) return;
            if (_structCategoryType != XLight   && _structCategoryType != Light  && _structCategoryType != Medium  &&
                _structCategoryType != Heavy    && _structCategoryType != XHeavy && _structCategoryType != XxHeavy &&
                _structCategoryType != XxxHeavy && _structCategoryType != Misc   && _structCategoryType != SagRod)
            {
                if (_structCategoryType != Frame) return;
                if (_mType == Frame)
                {
                    AddMemberToStruct_List_N_Weight(_pcMk, Convert.ToDecimal(_wght, CultureInfo.InvariantCulture));
                }
            }
            else
            {
                if (_mType != Beam  && _mType != Column && _mType != Angle && _mType != Plate && _mType != Girt &&
                    _mType != Brace && _mType != Misc   && _mType != SagRod)
                {
                    if (_mType              != Truss) return;
                    if (_structCategoryType == Frame) return;
                    if (Convert.ToDecimal(_wght, CultureInfo.InvariantCulture) >= _dMin && _dMax == -1)
                    {
                        AddMemberToStruct_List_N_Weight(_pcMk,
                                                        Convert.ToDecimal(_wght, CultureInfo.InvariantCulture));
                    }
                    else if (Convert.ToDecimal(_wght, CultureInfo.InvariantCulture) >= _dMin &&
                             Convert.ToDecimal(_wght, CultureInfo.InvariantCulture) <= _dMax)
                    {
                        AddMemberToStruct_List_N_Weight(_pcMk,
                                                        Convert.ToDecimal(_wght, CultureInfo.InvariantCulture));
                    }
                }
                else
                {
                    if (Convert.ToDecimal(_sz, CultureInfo.InvariantCulture) >= _dMin && _dMax == -1)
                    {
                        AddMemberToStruct_List_N_Weight(_pcMk, Convert.ToDecimal(_wght, CultureInfo.InvariantCulture));
                    }
                    else if (Convert.ToDecimal(_sz, CultureInfo.InvariantCulture) >= _dMin &&
                             Convert.ToDecimal(_sz, CultureInfo.InvariantCulture) <= _dMax)
                    {
                        AddMemberToStruct_List_N_Weight(_pcMk, Convert.ToDecimal(_wght, CultureInfo.InvariantCulture));
                    }
                }
            }
        }

        private void AddMemberToStruct_List_N_Weight(string pcMk, decimal thisWeight)
        {
            switch (_structCategoryType)
            {
                case XLight:
                    _xLightList.Add(pcMk);
                    DxLight += thisWeight;
                    break;
                case Light:
                    _lightList.Add(pcMk);
                    DLight += thisWeight;
                    break;
                case Medium:
                    _mediumList.Add(pcMk);
                    DMedium += thisWeight;
                    break;
                case Heavy:
                    _heavyList.Add(pcMk);
                    DHeavy += thisWeight;
                    break;
                case XHeavy:
                    _xHeavyList.Add(pcMk);
                    DxHeavy += thisWeight;
                    break;
                case XxHeavy:
                    _xxHeavyList.Add(pcMk);
                    DXxHeavy += thisWeight;
                    break;
                case XxxHeavy:
                    _xxxHeavyList.Add(pcMk);
                    DXxxHeavy += thisWeight;
                    break;
                case Frame:
                    _frameList.Add(pcMk);
                    DFrames += thisWeight;
                    break;
                default:
                    MessageBox.Show(@"Structure Category not found");
                    break;
            }
        }

        private void cmdReset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Help_Click(object sender, EventArgs e)
        {
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            var pathFile = string.Empty;
            var result   = OpenFileDiag.ShowDialog();
            if (result == DialogResult.OK)
            {
                pathFile = OpenFileDiag.FileName;
            }

            //var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var billOutput = new FileInfo(pathFile);
            _bill.Parse(billOutput);
            var dump = ObjectDumper.Dump(_bill);
            SeperateMembers();
            //decimal LadTotalWeight = Ladders.Sum(s => s.Weight);
            //decimal BeamsTotalWeight = Beams.Sum(s => s.Weight);
            //decimal ColumsTotalWeight = Columns.Sum(s => s.Weight);
            //decimal BracesTotalWeight = Braces.Sum(s => s.Weight);
            //decimal FramesTotalWeight = Frames.Sum(s => s.Weight);
            //decimal PlatesTotalWeight = Plates.Sum(s => s.Weight);
            //decimal CagedLaddersTotalWeight = CagedLadders.Sum(s => s.Weight);
            //decimal FloorPlatesTotalWeight = FloorPlates.Sum(s => s.Weight);
            //decimal StairsTotalWeight = Stairs.Sum(s => s.Weight);
            //decimal StairRailsTotalWeight = StairRails.Sum(s => s.Weight);
            //decimal HandrailsTotalWeight = Handrails.Sum(s => s.Weight);
            //decimal ToePlatesTotalWeight = ToePlates.Sum(s => s.Weight);
            //decimal AnglesTotalWeight = Angles.Sum(s => s.Weight);
            //decimal MiscsTotalWeight = Miscs.Sum(s => s.Weight);
            //bill.GenerateXml("Job.xml");
        }

        private void SeperateMembers()
        {
            // var materials = new List<Material>();

            //var sht = _bill.NumberOfSheets;
            lblJobName.Text = _bill.Job;

            foreach (var sheet in _bill.Sheets)
            {
                foreach (var detail in sheet.Details)
                {
                    var memberType = detail.Lines[0].Material;

                    if (memberType == "BEAM")
                    {


                    }
                    else if (memberType == "COLUMN")
                    {
                    }
                    else if (memberType == "VERTICAL BRACE")
                    {
                    }
                    else if (memberType == "HORIZONTAL BRACE")
                    {
                    }
                    else if (memberType == "PLATE")
                    {
                    }
                    else if (memberType == "ANGLE")
                    {
                    }
                    else if (memberType == "FRAME")
                    {
                    }
                    else if (memberType == "LADDER")
                    {
                    }
                    else if (memberType == "CAGED LADDER")
                    {
                    }
                    else if (memberType == "FLOOR PLATE")
                    {
                    }
                    else if (memberType == "STAIR")
                    {
                    }
                    else if (memberType == "STAIR STRINGER")
                    {
                    }
                    else if (memberType == "STAIR RAIL")
                    {
                    }
                    else if (memberType == "HANDRAIL")
                    {
                    }
                    else if (memberType == "Toeplate")
                    {
                    }
                    else if (memberType == "MISC")
                    {
                    }
                    else if (memberType == "PIPE")
                    {
                    }
                    else if (memberType == "ANCHOR BOLT")
                    {
                    }
                }
            }
        }

    }
}