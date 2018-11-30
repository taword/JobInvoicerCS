using System.Collections.Generic;

namespace JobInvoicerCS
{
    public class Structure
    {
        private readonly Bill _bill = new Bill();
        public List<Beam> Beams { get; } = new List<Beam>();

        private void GetMembers()
        {
            // var materials = new List<Material>();


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