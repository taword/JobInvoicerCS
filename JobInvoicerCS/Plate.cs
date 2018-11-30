using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JobInvoicerCS
{
    public partial class Plate : Material
    {
        // To calculate weight per foot of steel plate,
        // we use a standard density of 0.2836 and
        // standard length of 12 inches
        const double LENGTHxDENSITY = 3.4032D;
        private double depthField;
        private double widthField;
        private double wt_ftField;

        public double Wt_Ft
        {
            get { return wt_ftField; }
            set { wt_ftField = Depth * Width * LENGTHxDENSITY; ; }
        }

        public double Depth
        {
            get { return depthField; }
            set { depthField = value; }
        }

        public double Width
        {
            get { return widthField; }
            set { widthField = value; }
        }

        public Plate(string Material)
        {
            // Remove PL, FL, FB from front of Material
            Material = Material.Remove(0, 2);

            // Split Depth and Width
            string[] dimensions = Material.Split('x');

            // WholeDepth and WholeWidth might contain inches and fractions
            string WholeDepth = dimensions[0];
            string WholeWidth = dimensions[1];
            string[] parts;

            if (WholeDepth.Contains(' ') || WholeWidth.Contains(' '))
            {
                parts = WholeDepth.Split(' ');
                depthField = Convert.ToDouble(parts[0]) + Fractions.FractionToDouble(parts[1]);
                parts = WholeWidth.Split(' ');
                widthField = Convert.ToDouble(parts[0]) + Fractions.FractionToDouble(parts[1]);
            }
            else
            {
                Depth = Fractions.FractionToDouble(dimensions[0]);
                Width = Fractions.FractionToDouble(dimensions[1]);
            }
        }

        //public FlatBar(double Depth, double Width, double Length)
        //{
        //    weightPerSqFt = Depth * Width * Length * DENSITY;
        //}
        //if (Material == "PL10") { Wt_Ft= 408; }
        //if (Material == "PL9") { Wt_Ft = 367.2; }
        //if (Material == "PL8") { Wt_Ft = 326.4; }
        //if (Material == "PL7 1/2") { Wt_Ft = 306; }
        //if (Material == "PL7") { Wt_Ft = 285.6; }
        //if (Material == "PL6 1/2") { Wt_Ft = 265.2; }
        //if (Material == "PL6") { Wt_Ft = 244.8; }
        //if (Material == "PL5 1/2") { Wt_Ft = 224.62; }
        //if (Material == "PL5") { Wt_Ft = 204.2; }
        //if (Material == "PL4 3/4") { Wt_Ft = 193.99; }
        //if (Material == "PL4 1/2") { Wt_Ft = 183.78; }
        //if (Material == "PL4 1/4") { Wt_Ft = 173.57; }
        //if (Material == "PL4") { Wt_Ft = 163.2; }
        //if (Material == "PL3 3/4") { Wt_Ft = 153; }
        //if (Material == "PL3 1/2") { Wt_Ft = 142.8; }
        //if (Material == "PL3 1/4") { Wt_Ft = 132.6; }
        //if (Material == "PL3") { Wt_Ft = 122.4; }
        //if (Material == "PL2 3/4") { Wt_Ft = 112.2; }
        //if (Material == "PL2 1/2") { Wt_Ft = 102; }
        //if (Material == "PL2 1/4") { Wt_Ft = 91.8; }
        //if (Material == "PL2") { Wt_Ft = 81.6; }
        //if (Material == "PL1 3/4") { Wt_Ft = 71.4; }
        //if (Material == "PL1 5/8") { Wt_Ft = 66.3; }
        //if (Material == "PL1 1/2") { Wt_Ft = 61.26; }
        //if (Material == "PL1 3/8") { Wt_Ft = 56.1; }
        //if (Material == "PL1 1/4") { Wt_Ft = 51; }
        //if (Material == "PL1 1/8") { Wt_Ft = 45.9; }
        //if (Material == "PL1") { Wt_Ft = 40.8; }
        //if (Material == "PL7/8") { Wt_Ft = 35.7; }
        //if (Material == "PL3/4") { Wt_Ft = 30.6; }
        ////if (Material == "PL11/16") { Wt_Ft =  28.05; }
        //if (Material == "PL5/8") { Wt_Ft = 25.5; }
        //if (Material == "PL9/16") { Wt_Ft = 22.95; }
        //if (Material == "PL1/2") { Wt_Ft = 20.4; }
        //if (Material == "PL7/16") { Wt_Ft = 17.85; }
        //if (Material == "PL3/8") { Wt_Ft = 15.3; }
        //if (Material == "PL5/16") { Wt_Ft = 12.75; }
        //if (Material == "PL1/4") { Wt_Ft = 10.2; }
        //if (Material == "PL3/16") { Wt_Ft = 7.65; }
        //if (Material == "PL1/8") { Wt_Ft = 5.1; }
        //if (Material == "PL1/16") { Wt_Ft = 2.55; }
        //if (Material == "FL1/8x3/4") { Wt_Ft = 0.32; }
        //if (Material == "FL1/8x2") { Wt_Ft = 0.852; }
        //if (Material == "FL1/8x4") { Wt_Ft = 1.704; }
        //if (Material == "FL1/8x8") { Wt_Ft = 3.408; }
        //if (Material == "FL1/8x12") { Wt_Ft = 5.112; }
        //if (Material == "FL3/16x3/4") { Wt_Ft = 0.479; }
        //if (Material == "FL3/16x2") { Wt_Ft = 1.278; }
        //if (Material == "FL3/16x4") { Wt_Ft = 2.556; }
        //if (Material == "FL3/16x8") { Wt_Ft = 5.112; }
        //if (Material == "FL3/16x12") { Wt_Ft = 7.668; }
        //if (Material == "FL1/4x3/8") { Wt_Ft = 0.319; }
        //if (Material == "FL1/4x1/2") { Wt_Ft = 0.425; }
        //if (Material == "FL1/4x5/8") { Wt_Ft = 0.531; }
        //if (Material == "FL1/4x3/4") { Wt_Ft = 0.638; }
        //if (Material == "FL1/4x7/8") { Wt_Ft = 0.744; }
        //if (Material == "FL1/4x1") { Wt_Ft = 0.85; }
        //if (Material == "FL1/4x1 1/8") { Wt_Ft = 0.956; }
        //if (Material == "FL1/4x1 1/4") { Wt_Ft = 1.06; }
        //if (Material == "FL1/4x1 3/8") { Wt_Ft = 1.17; }
        //if (Material == "FL1/4x1 1/2") { Wt_Ft = 1.28; }
        //if (Material == "FL1/4x1 5/8") { Wt_Ft = 1.38; }
        //if (Material == "FL1/4x1 3/4") { Wt_Ft = 1.49; }
        //if (Material == "FL1/4x2") { Wt_Ft = 1.7; }
        //if (Material == "FL1/4x2 1/4") { Wt_Ft = 1.91; }
        //if (Material == "FL1/4x2 1/2") { Wt_Ft = 2.13; }
        //if (Material == "FL1/4x2 3/4") { Wt_Ft = 2.34; }
        //if (Material == "FL1/4x3") { Wt_Ft = 2.55; }
        //if (Material == "FL1/4x3 1/4") { Wt_Ft = 2.76; }
        //if (Material == "FL1/4x3 1/2") { Wt_Ft = 2.98; }
        //if (Material == "FL1/4x3 3/4") { Wt_Ft = 3.19; }
        //if (Material == "FL1/4x4") { Wt_Ft = 3.4; }
        //if (Material == "FL1/4x4 1/4") { Wt_Ft = 3.61; }
        //if (Material == "FL1/4x4 1/2") { Wt_Ft = 3.83; }
        //if (Material == "FL1/4x5") { Wt_Ft = 4.25; }
        //if (Material == "FL1/4x5 1/2") { Wt_Ft = 4.68; }
        //if (Material == "FL1/4x6") { Wt_Ft = 5.1; }
        //if (Material == "FL1/4x7") { Wt_Ft = 5.95; }
        //if (Material == "FL1/4x8") { Wt_Ft = 6.8; }
        //if (Material == "FL5/16x1/2") { Wt_Ft = 0.531; }
        //if (Material == "FL5/16x5/8") { Wt_Ft = 0.664; }
        //if (Material == "FL5/16x3/4") { Wt_Ft = 0.797; }
        //if (Material == "FL5/16x7/8") { Wt_Ft = 0.93; }
        //if (Material == "FL5/16x1") { Wt_Ft = 1.06; }
        //if (Material == "FL5/16x1 1/8") { Wt_Ft = 1.2; }
        //if (Material == "FL5/16x1 1/4") { Wt_Ft = 1.33; }
        //if (Material == "FL5/16x1 3/8") { Wt_Ft = 1.46; }
        //if (Material == "FL5/16x1 1/2") { Wt_Ft = 1.59; }
        //if (Material == "FL5/16x1 3/4") { Wt_Ft = 1.86; }
        //if (Material == "FL5/16x2") { Wt_Ft = 2.13; }
        //if (Material == "FL5/16x2 1/4") { Wt_Ft = 2.39; }
        //if (Material == "FL5/16x2 1/2") { Wt_Ft = 2.66; }
        //if (Material == "FL5/16x2 3/4") { Wt_Ft = 2.92; }
        //if (Material == "FL5/16x3") { Wt_Ft = 3.19; }
        //if (Material == "FL5/16x3 1/4") { Wt_Ft = 3.45; }
        //if (Material == "FL5/16x3 1/2") { Wt_Ft = 3.72; }
        //if (Material == "FL5/16x4") { Wt_Ft = 4.25; }
        //if (Material == "FL5/16x4 1/2") { Wt_Ft = 4.78; }
        //if (Material == "FL5/16x5") { Wt_Ft = 5.31; }
        //if (Material == "FL5/16x5 1/2") { Wt_Ft = 5.84; }
        //if (Material == "FL5/16x6") { Wt_Ft = 6.38; }
        //if (Material == "FL5/16x7") { Wt_Ft = 7.44; }
        //if (Material == "FL5/16x8") { Wt_Ft = 8.5; }
        //if (Material == "FL3/8x1/2") { Wt_Ft = 0.638; }
        //if (Material == "FL3/8x5/8") { Wt_Ft = 0.797; }
        //if (Material == "FL3/8x3/4") { Wt_Ft = 0.956; }
        //if (Material == "FL3/8x7/8") { Wt_Ft = 1.12; }
        //if (Material == "FL3/8x1") { Wt_Ft = 1.28; }
        //if (Material == "FL3/8x1 1/8") { Wt_Ft = 1.43; }
        //if (Material == "FL3/8x1 1/4") { Wt_Ft = 1.59; }
        //if (Material == "FL3/8x1 3/8") { Wt_Ft = 1.75; }
        //if (Material == "FL3/8x1 1/2") { Wt_Ft = 1.91; }
        //if (Material == "FL3/8x1 5/8") { Wt_Ft = 2.07; }
        //if (Material == "FL3/8x1 3/4") { Wt_Ft = 2.23; }
        //if (Material == "FL3/8x2") { Wt_Ft = 2.55; }
        //if (Material == "FL3/8x2 1/4") { Wt_Ft = 2.87; }
        //if (Material == "FL3/8x2 1/2") { Wt_Ft = 3.19; }
        //if (Material == "FL3/8x2 3/4") { Wt_Ft = 3.51; }
        //if (Material == "FL3/8x3") { Wt_Ft = 3.83; }
        //if (Material == "FL3/8x3 1/4") { Wt_Ft = 4.14; }
        //if (Material == "FL3/8x3 1/2") { Wt_Ft = 4.46; }
        //if (Material == "FL3/8x4") { Wt_Ft = 5.1; }
        //if (Material == "FL3/8x4 1/2") { Wt_Ft = 5.74; }
        //if (Material == "FL3/8x5") { Wt_Ft = 6.38; }
        //if (Material == "FL3/8x5 1/2") { Wt_Ft = 7.01; }
        //if (Material == "FL3/8x6") { Wt_Ft = 7.65; }
        //if (Material == "FL3/8x7") { Wt_Ft = 8.93; }
        //if (Material == "FL3/8x8") { Wt_Ft = 10.2; }
        //if (Material == "FL1/2x5/8") { Wt_Ft = 1.06; }
        //if (Material == "FL1/2x3/4") { Wt_Ft = 1.28; }
        //if (Material == "FL1/2x7/8") { Wt_Ft = 1.49; }
        //if (Material == "FL1/2x1") { Wt_Ft = 1.7; }
        //if (Material == "FL1/2x1 1/8") { Wt_Ft = 1.91; }
        //if (Material == "FL1/2x1 1/4") { Wt_Ft = 2.13; }
        //if (Material == "FL1/2x1 3/8") { Wt_Ft = 2.34; }
        //if (Material == "FL1/2x1 1/2") { Wt_Ft = 2.55; }
        //if (Material == "FL1/2x1 5/8") { Wt_Ft = 2.76; }
        //if (Material == "FL1/2x1 3/4") { Wt_Ft = 2.98; }
        //if (Material == "FL1/2x2") { Wt_Ft = 3.4; }
        //if (Material == "FL1/2x2 1/4") { Wt_Ft = 3.83; }
        //if (Material == "FL1/2x2 1/2") { Wt_Ft = 4.25; }
        //if (Material == "FL1/2x2 3/4") { Wt_Ft = 4.68; }
        //if (Material == "FL1/2x3") { Wt_Ft = 5.1; }
        //if (Material == "FL1/2x3 1/4") { Wt_Ft = 5.53; }
        //if (Material == "FL1/2x3 1/2") { Wt_Ft = 5.95; }
        //if (Material == "FL1/2x3 3/4") { Wt_Ft = 6.375; }
        //if (Material == "FL1/2x4") { Wt_Ft = 6.8; }
        //if (Material == "FL1/2x4 1/2") { Wt_Ft = 7.65; }
        //if (Material == "FL1/2x5") { Wt_Ft = 8.5; }
        //if (Material == "FL1/2x5 1/2") { Wt_Ft = 7.01; }
        //if (Material == "FL1/2x6") { Wt_Ft = 10.2; }
        //if (Material == "FL1/2x7") { Wt_Ft = 11.9; }
        //if (Material == "FL1/2x8") { Wt_Ft = 13.6; }
        //if (Material == "FL5/8x3/4") { Wt_Ft = 1.59; }
        //if (Material == "FL5/8x7/8") { Wt_Ft = 1.86; }
        //if (Material == "FL5/8x1") { Wt_Ft = 2.13; }
        //if (Material == "FL5/8x1 1/8") { Wt_Ft = 2.39; }
        //if (Material == "FL5/8x1 1/4") { Wt_Ft = 2.66; }
        //if (Material == "FL5/8x1 3/8") { Wt_Ft = 2.92; }
        //if (Material == "FL5/8x1 1/2") { Wt_Ft = 3.19; }
        //if (Material == "FL5/8x1 5/8") { Wt_Ft = 3.45; }
        //if (Material == "FL5/8x1 3/4") { Wt_Ft = 3.72; }
        //if (Material == "FL5/8x2") { Wt_Ft = 4.25; }
        //if (Material == "FL5/8x2 1/4") { Wt_Ft = 4.78; }
        //if (Material == "FL5/8x2 1/2") { Wt_Ft = 5.31; }
        //if (Material == "FL5/8x2 3/4") { Wt_Ft = 5.84; }
        //if (Material == "FL5/8x3") { Wt_Ft = 6.38; }
        //if (Material == "FL5/8x3 1/4") { Wt_Ft = 6.91; }
        //if (Material == "FL5/8x3 1/2") { Wt_Ft = 7.44; }
        //if (Material == "FL5/8x4") { Wt_Ft = 8.5; }
        //if (Material == "FL5/8x4 1/2") { Wt_Ft = 9.56; }
        //if (Material == "FL5/8x5") { Wt_Ft = 10.63; }
        //if (Material == "FL5/8x5 1/2") { Wt_Ft = 11.69; }
        //if (Material == "FL5/8x6") { Wt_Ft = 12.75; }
        //if (Material == "FL5/8x7") { Wt_Ft = 14.88; }
        //if (Material == "FL5/8x8") { Wt_Ft = 17.0; }
        //if (Material == "FL3/4x7/8") { Wt_Ft = 2.23; }
        //if (Material == "FL3/4x1") { Wt_Ft = 2.55; }
        //if (Material == "FL3/4x1 1/8") { Wt_Ft = 2.87; }
        //if (Material == "FL3/4x1 1/4") { Wt_Ft = 3.19; }
        //if (Material == "FL3/4x1 3/8") { Wt_Ft = 3.51; }
        //if (Material == "FL3/4x1 1/2") { Wt_Ft = 3.83; }
        //if (Material == "FL3/4x1 5/8") { Wt_Ft = 4.14; }
        //if (Material == "FL3/4x1 3/4") { Wt_Ft = 4.46; }
        //if (Material == "FL3/4x2") { Wt_Ft = 5.1; }
        //if (Material == "FL3/4x2 1/4") { Wt_Ft = 5.74; }
        //if (Material == "FL3/4x2 1/2") { Wt_Ft = 6.38; }
        //if (Material == "FL3/4x2 3/4") { Wt_Ft = 7.01; }
        //if (Material == "FL3/4x3") { Wt_Ft = 7.65; }
        //if (Material == "FL3/4x3 1/4") { Wt_Ft = 8.29; }
        //if (Material == "FL3/4x3 1/2") { Wt_Ft = 8.93; }
        //if (Material == "FL3/4x4") { Wt_Ft = 10.2; }
        //if (Material == "FL3/4x4 1/2") { Wt_Ft = 11.48; }
        //if (Material == "FL3/4x5") { Wt_Ft = 12.75; }
        //if (Material == "FL3/4x5 1/2") { Wt_Ft = 14.03; }
        //if (Material == "FL3/4x6") { Wt_Ft = 15.3; }
        //if (Material == "FL3/4x7") { Wt_Ft = 17.85; }
        //if (Material == "FL3/4x8") { Wt_Ft = 20.4; }
        //if (Material == "FL1x1 1/4") { Wt_Ft = 4.25; }
        //if (Material == "FL1x1 1/2") { Wt_Ft = 5.1; }
        //if (Material == "FL1x1 3/4") { Wt_Ft = 5.95; }
        //if (Material == "FL1x2") { Wt_Ft = 6.8; }
        //if (Material == "FL1x2 1/4") { Wt_Ft = 7.65; }
        //if (Material == "FL1x2 1/2") { Wt_Ft = 8.5; }
        //if (Material == "FL1x2 3/4") { Wt_Ft = 9.35; }
        //if (Material == "FL1x3") { Wt_Ft = 10.2; }
        //if (Material == "FL1x3 1/4") { Wt_Ft = 11.05; }
        //if (Material == "FL1x3 1/2") { Wt_Ft = 11.9; }
        //if (Material == "FL1x4") { Wt_Ft = 13.6; }
        //if (Material == "FL1x4 1/2") { Wt_Ft = 15.3; }
        //if (Material == "FL1x5") { Wt_Ft = 17.0; }
        //if (Material == "FL1x5 1/2") { Wt_Ft = 18.7; }
        //if (Material == "FL1x6") { Wt_Ft = 20.4; }
        //if (Material == "FL1x7") { Wt_Ft = 23.8; }
        //if (Material == "FL1x8") { Wt_Ft = 27.2; }
        //if (Material == "FL1 1/4x1 1/2") { Wt_Ft = 6.38; }
        //if (Material == "FL1 1/4x1 3/4") { Wt_Ft = 7.44; }
        //if (Material == "FL1 1/4x2") { Wt_Ft = 8.5; }
        //if (Material == "FL1 1/4x2 1/4") { Wt_Ft = 9.56; }
        //if (Material == "FL1 1/4x2 1/2") { Wt_Ft = 10.63; }
        //if (Material == "FL1 1/4x2 3/4") { Wt_Ft = 11.69; }
        //if (Material == "FL1 1/4x3") { Wt_Ft = 12.75; }
        //if (Material == "FL1 1/4x3 1/4") { Wt_Ft = 13.81; }
        //if (Material == "FL1 1/4x3 1/2") { Wt_Ft = 14.88; }
        //if (Material == "FL1 1/4x4") { Wt_Ft = 17.0; }
        //if (Material == "FL1 1/4x4 1/2") { Wt_Ft = 19.13; }
        //if (Material == "FL1 1/4x5") { Wt_Ft = 21.25; }
        //if (Material == "FL1 1/4x5 1/2") { Wt_Ft = 23.38; }
        //if (Material == "FL1 1/4x6") { Wt_Ft = 25.6; }
        //if (Material == "FL1 1/4x8") { Wt_Ft = 34.0; }
        //if (Material == "FL1 1/2x1 3/8") { Wt_Ft = 8.93; }
        //if (Material == "FL1 1/2x2") { Wt_Ft = 10.2; }
        //if (Material == "FL1 1/2x2 1/4") { Wt_Ft = 11.48; }
        //if (Material == "FL1 1/2x2 1/2") { Wt_Ft = 12.75; }
        //if (Material == "FL1 1/2x2 3/4") { Wt_Ft = 14.03; }
        //if (Material == "FL1 1/2x3") { Wt_Ft = 15.3; }
        //if (Material == "FL1 1/2x3 1/4") { Wt_Ft = 16.57; }
        //if (Material == "FL1 1/2x3 1/2") { Wt_Ft = 17.85; }
        //if (Material == "FL1 1/2x4") { Wt_Ft = 20.4; }
        //if (Material == "FL1 1/2x4 1/2") { Wt_Ft = 22.95; }
        //if (Material == "FL1 1/2x5") { Wt_Ft = 25.5; }
        //if (Material == "FL1 1/2x5 1/2") { Wt_Ft = 28.05; }
        //if (Material == "FL1 1/2x6") { Wt_Ft = 30.6; }
        //if (Material == "FL1 1/2x8") { Wt_Ft = 40.8; }
        //if (Material == "FL2x2 1/4") { Wt_Ft = 15.3; }
        //if (Material == "FL2x2 1/2") { Wt_Ft = 17.0; }
        //if (Material == "FL2x2 3/4") { Wt_Ft = 18.7; }
        //if (Material == "FL2x3") { Wt_Ft = 20.4; }
        //if (Material == "FL2x3 1/2") { Wt_Ft = 23.8; }
        //if (Material == "FL2x4") { Wt_Ft = 27.2; }
        //if (Material == "FL2x4 1/2") { Wt_Ft = 30.6; }
        //if (Material == "FL2x5") { Wt_Ft = 34.0; }
        //if (Material == "FL2x5 1/2") { Wt_Ft = 37.4; }
        //if (Material == "FL2x6") { Wt_Ft = 40.8; }
        //if (Material == "FL2x8") { Wt_Ft = 54.4; }
    }
}
