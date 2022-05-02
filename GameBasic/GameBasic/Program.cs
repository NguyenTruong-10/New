using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBasic
{
    static class Program
    {
        public static int money_credits;
        public static int money_push,first_money,tien_no ;
        //public static bool first_recharge;
        public static string check_data;
        public static bool check;
        public static void Save_file(int load)
        {
            StreamWriter File = new StreamWriter("D:\\GameBasic\\Data\\data.txt");
            File.Write(load);
            File.Close();

            File.Dispose();
        }
        public static string Read_file()
        {
            StreamReader read = new StreamReader("D:\\GameBasic\\Data\\data.txt");
            string reads = read.ReadLine();

            read.Close();
            return reads;        
        }


        //public static void Read_file(int load)
        //{
        //    StreamWriter File = new StreamWriter("D:\\GameBasic\\Data\\data.txt");
        //    File.Write(load);
        //    File.Close();
        //}
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread] 

        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           
        }
  
    }
}
