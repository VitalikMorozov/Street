using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Микрорайон
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public static class help
    {
        public static string a;
        public static string a1;
        public static string a2;

        public static int IDKLASS;
        public static int id;
        public static int id2;
        public static int id3;
        public static int id4;
        public static int id5;
        public static int id6;
        public static int id7;
        public static int idREBOBSLED;

    }

}
