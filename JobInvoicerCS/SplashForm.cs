using System.Windows.Forms;
using System.Threading;

namespace JobInvoicerCS
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        //Delegate for cross thread call to close
        private delegate void CloseDelegate();

        //The type of form to be displayed as the splash screen.
        private static SplashForm _splashForm;

        public static void ShowSplashScreen()
        {
            // Make sure it is only launched once.

            if (_splashForm != null)
                return;
            var thread = new Thread(ShowForm);
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private static void ShowForm()
        {
            _splashForm = new SplashForm();
            Application.Run(_splashForm);
        }

        public static void CloseForm()
        {
            _splashForm.Invoke(new CloseDelegate(CloseFormInternal));
        }

        private static void CloseFormInternal()
        {
            _splashForm.Close();
            _splashForm = null;
        }
    }
}