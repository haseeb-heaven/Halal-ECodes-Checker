using System;
using System.Threading;
using System.Windows.Forms;

namespace Halal_ECodes_Checker
{
    static class MainClass
    {
        const string PROJECT_NAME = "$(ProjectName)";
        [STAThread]
        static void Main()
        {
            bool createdNew = false;
            Mutex mutex = null;

            try
            {
                mutex = new Mutex(true, PROJECT_NAME, out createdNew);
                if (createdNew)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new halal_ecode_form());
                    mutex.ReleaseMutex();
                }
                else
                {
                    MessageBox.Show("An instance of application is already running", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}