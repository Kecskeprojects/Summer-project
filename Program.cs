using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
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
            Application.Run(new Menu_Form());
        }
        //Getter Setter for Currently logged in User's data
        private static string username = "";
        public static string Username
        {
            get { return username; }
            set { username = value; }
        }
        private static string password = "";
        public static string Password
        {
            get { return password; }
            set { password = value; }
        }
        private static int high_score = 0;
        public static int High_score
        {
            get { return high_score; }
            set { high_score = value; }
        }
    }
}
