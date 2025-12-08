using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mee_Hotel.GUI;
namespace Mee_Hotel
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /**/
            while (true)
            {
                using (frmLogin lg = new frmLogin())
                {
                    DialogResult result = lg.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        using (frmMain mf = new frmMain())
                        {
                            if (mf.ShowDialog() == DialogResult.Cancel)
                            {
                                continue;
                            }
                        }
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        break;
                    }
                }

            }
            //  Application.Run(new frmXemLichDat());
        }
    }
}
