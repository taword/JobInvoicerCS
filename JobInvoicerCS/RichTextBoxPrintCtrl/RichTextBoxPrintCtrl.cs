using System;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace JobInvoicerCS.RichTextBoxPrintCtrl
{
    public class RichTextBoxPrintCtrl : RichTextBox
    {
        // Convert the unit that is used by the .NET framework (1/100 inch) 
        // and the unit that is used by Win32 API calls (twips 1/1440 inch)
        private const double AnInch = 14.4;

        [StructLayout(LayoutKind.Sequential)]
        private struct Rect
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct Charrange
        {
            public int cpMin; // First character of range (0 for start of doc)
            public int cpMax; // Last character of range (-1 for end of doc)
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct Formatrange
        {
            public IntPtr hdc; // Actual DC to draw on
            public IntPtr hdcTarget; // Target DC for determining text formatting
            public Rect rc; // Region of the DC to draw to (in twips)
            public Rect rcPage; // Region of the whole DC (page size) (in twips)
            public Charrange chrg; // Range of text to draw (see above declaration)
        }

        private const int WmUser = 0x400;
        private const int EmFormatrange = WmUser + 57;

        [DllImport("USER32", EntryPoint = "SendMessageA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        // Render the contents of the RichTextBox for printing
        //	Return the last character printed + 1 (printing start from this point for next page)
        public int Print(int charFrom, int charTo, PrintPageEventArgs e)
        {

            // Mark starting and ending character 
            var cRange = new Charrange
            {
                cpMin = charFrom,
                cpMax = charTo
            };

            // Calculate the area to render and print
            var rectToPrint = new Rect
            {
                Top = Convert.ToInt32(e.MarginBounds.Top * AnInch),
                Bottom = Convert.ToInt32(e.MarginBounds.Bottom * AnInch),
                Left = Convert.ToInt32(e.MarginBounds.Left * AnInch),
                Right = Convert.ToInt32(e.MarginBounds.Right * AnInch)
            };

            // Calculate the size of the page
            var rectPage = new Rect
            {
                Top = Convert.ToInt32(e.PageBounds.Top * AnInch),
                Bottom = Convert.ToInt32(e.PageBounds.Bottom * AnInch),
                Left = Convert.ToInt32(e.PageBounds.Left * AnInch),
                Right = Convert.ToInt32(e.PageBounds.Right * AnInch)
            };

            var hdc = e.Graphics.GetHdc();

            var fmtRange = new Formatrange
            {
                chrg = cRange,
                hdc = hdc,
                hdcTarget = hdc,
                rc = rectToPrint,
                rcPage = rectPage
            };
            // Indicate character from to character to
            // Use the same DC for measuring and rendering
            // Point at printer hDC
            // Indicate the area on page to print
            // Indicate whole size of page

            var wparam = new IntPtr(1);

            // Move the pointer to the FORMATRANGE structure in memory
            var lparam = Marshal.AllocCoTaskMem(Marshal.SizeOf(fmtRange));
            Marshal.StructureToPtr(fmtRange, lparam, false);

            // Send the rendered data for printing 
            var res = SendMessage(Handle, EmFormatrange, wparam, lparam);

            // Free the block of memory allocated
            Marshal.FreeCoTaskMem(lparam);

            // Release the device context handle obtained by a previous call
            e.Graphics.ReleaseHdc(hdc);

            // Return last + 1 character printer
            return res.ToInt32();
        }
    }
}
