using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * Author : Meer Zaheen Nazmul
 * Student # : 300522487
 * Date : August, 12th, 2016
 * Description : Movie Bonanza!
 * Version : 0.0.5 
 */
namespace Movie_Bonanza
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
            Application.Run(new SelectionForm());
        }
    }
}
