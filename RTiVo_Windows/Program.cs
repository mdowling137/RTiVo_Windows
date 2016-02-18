using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTiVo_Windows
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            StationList testList = new StationList();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainWindow mainWindow = new MainWindow();
            //mainWindow.Location = new System.Drawing.Point(MainWindow.mainWindowX, MainWindow.mainWindowY);
            mainWindow.addButtons(testList);
            Application.Run(mainWindow);
            
        }
    }
}
